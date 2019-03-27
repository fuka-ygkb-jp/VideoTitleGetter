using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Yugen.Tools.Web.Scraper
{
    /// <summary>NyaaTorrentをスクレイプする</summary>
    /// <remarks>閉鎖されたので基本的には使わない</remarks>
    [Obsolete("NyaaTorrentは閉鎖されています")]
    class NyaaTorrentScraper : IScraper
    {
        #region "定数"
        /// <summary>UserAgent名</summary>
        const string cUaName = "Mozilla/5.0 (Windows NT 6.3; Trident/7.0; rv:11.0) like Gecko";

        /// <summary>NTのURL</summary>
        const string cBaseURL = "http://sukebei.nyaa.se/?page=search";

        /// <summary>ファイル名一覧のXPath</summary>
        const string cFileNameListXPath =
            @"//table[@class=""tlist""]" +
            @"/tr[contains(@class,""tlistrow"")]" +
            @"/td[@class=""tlistname""]" +
            @"/a";
        #endregion

        /// <summary>
        /// 検索条件に合うファイル名一覧を返す
        /// 不一致の場合は０件のListを返す
        /// </summary>
        /// <param name="condition">検索条件</param>
        public List<string> GetFilenames(string condition)
        {
            var retVal = new List<string>();

            // 条件なし
            if (condition == "") return retVal;

            // GetWebPageAsyncメソッドを呼び出す
            var url = cBaseURL + "&term=" + condition;
            var htmlText = getFromWeb(new Uri((url)));

            // 取得失敗
            if (htmlText == null) return retVal;

            // HtmlDocumentオブジェクトを構築する
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(htmlText);

            try
            {
                // 目的の<a>要素を全て取り出して（XPath）、
                // そのhref属性とInnerTextを持つ匿名型オブジェクトのコレクションを作る（LINQ）
                // ※冒頭に「using System.Linq;」の追加が必要
                var articles
                  = htmlDoc.DocumentNode
                    .SelectNodes(cFileNameListXPath)
                    .Select(a => new
                    {
                        Url = a.Attributes["href"].Value.Trim(),
                        Title = a.InnerText.Trim(),
                    });

                foreach (var a in articles)
                {
                    retVal.Add(HttpUtility.HtmlDecode(a.Title));
                }
            }
            catch (ArgumentNullException)
            {
                // 結果なしの場合は何もしない
            }

            return retVal;
        }

        /// <summary>HTML取得</summary>
        private string getFromWeb(Uri uri)
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            wc.Headers.Add("User-Agent", cUaName);

            try
            {
                return wc.DownloadString(uri);
            }
            catch
            {
                return "";
            }
        }
    }
}
