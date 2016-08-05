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
    /// <summary>Googleをスクレイプする</summary>
    /// <remarks>だめ。色々試したが403エラーで内容取得不能</remarks>
    class hEraScraper : IScraper
    {
        #region "定数"
        /// <summary>UserAgent名</summary>
        const string cUaName = @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";

        /// <summary>NTのURL</summary>
        const string cBaseURL = @"http://jav.h-era.org/?";

        /// <summary>ファイル名一覧のXPath</summary>
        const string cFileNameListXPath = @"//*/div[@class=""post-headline""]/h2/a";
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
            var url = cBaseURL + "s=" + condition;
            var htmlText = getFromWeb(new Uri((url)));
            //var htmlText = getFromWeb(new Uri("http://jav.h-era.org/"));

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
            //wc.Headers.Add("Accept-Encoding", @"gzip, deflate, sdch");
            //wc.Headers.Add("Accept-Language", @"ja,en-US;q=0.8,en;q=0.6");

            try
            {
                return wc.DownloadString(uri);
            }
            //catch (Exception ex)
            catch 
            {
                return "";
            }
        }
    }
}
