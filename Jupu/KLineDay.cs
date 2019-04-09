using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupu
{
    class KLineDay
    {
        //TCLOSE;HIGH;LOW;TOPEN;LCLOSE;CHG;PCHG;TURNOVER;VOTURNOVER;VATURNOVER;TCAP;MCAP'
        public String stockname { set; get; }
        public DateTime date { set; get; }
        public Double open { set; get; }
        public Double close { set; get; }
        public Double low { set; get; }
        public Double high { set; get; }
        public long volume { set; get; }
        
        
    }
}
