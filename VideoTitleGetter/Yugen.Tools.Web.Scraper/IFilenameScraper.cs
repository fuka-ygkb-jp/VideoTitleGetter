using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yugen.Tools.Web.Scraper
{
    interface IScraper
    {
        List<string> GetFilenames(string condition);
    }
}
