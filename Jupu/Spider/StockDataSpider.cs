using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupu.Spider
{
    class StockDataSpider
    {
        public string baseURL = "http://quotes.money.163.com/service/chddata.html?code={###}&end={$$$}&fields=TCLOSE;HIGH;LOW;TOPEN;LCLOSE;CHG;PCHG;TURNOVER;VOTURNOVER;VATURNOVER;TCAP;MCAP";
        public string formatURL(string baseURL, string stockId)
        {
            string url = baseURL;

            return url;
        }
        public bool downloadStockData(string stockId)
        {
            return true;
        }
    }
}
