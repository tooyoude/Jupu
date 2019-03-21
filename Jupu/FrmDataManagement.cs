using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jupu
{
    public partial class FrmDataManagement : Form
    {
        private List<String> stockList = new List<string>();
        private string baseURL = "http://quotes.money.163.com/service/chddata.html?code={###}&end={$$$}&fields=TCLOSE;HIGH;LOW;TOPEN;LCLOSE;CHG;PCHG;TURNOVER;VOTURNOVER;VATURNOVER;TCAP;MCAP";
        public FrmDataManagement()
        {
            InitializeComponent();
            this.init();
        }
        private void init()
        {
            this.stockList.Add("600016");
            this.stockList.Add("000032");
        }
        private void BtnDataUpdate_Click(object sender, EventArgs e)
        {
            string url = "";
            string code = "";
            string datestr = DateTime.Now.Date.ToString("yyyyMMdd");
            
            HttpFileManager hfm = new HttpFileManager();
            foreach (string element in this.stockList)
            {
                switch (element.Substring(0,1))
                {
                    case "0":
                        code = "1" + element;
                        break;
                    case "6":
                        code = "0" + element;
                        break;
                }
                url = this.baseURL;
                url = url.Replace("{###}", code);
                url = url.Replace("{$$$}", datestr);
                
                this.LbStockKLineDayUpdate.Text += "\n" + url ;
                hfm.Download(url, element+".csv");
                
            }
        }
        
    }
}
