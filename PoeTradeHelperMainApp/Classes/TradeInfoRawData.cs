using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webTest.Classes
{
    [Serializable]
    public class TradeInfoRawData
    {
        public string IGN { get; set; }
        public string Price { get; set; }
        public string StackSize { get; set; }
        public string ItemName { get; set; }
        public string CurrencyName { get; set; }
        public string LeagueName { get; set; }

    }
}
