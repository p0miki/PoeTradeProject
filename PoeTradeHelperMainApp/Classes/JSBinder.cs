using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webTest.Classes
{
    public class JSBinder
    {
        private WebSearchController Controller = null;
        private float itemPriority = 50;
        public int MaxAmountToBuy { get; set; }
        public float ItemPriority { 
            get
            {
                return (100 - itemPriority);
            }
            set
            {
                itemPriority = value; 
            }
        }


        public JSBinder(WebSearchController controller)
        {
            this.Controller = controller;
        }

        public void jsCallback(string jsonInput)
        {
            System.Web.Script.Serialization.JavaScriptSerializer jsSer = new System.Web.Script.Serialization.JavaScriptSerializer();
            TradeInfoRawData[] tradeInfos = jsSer.Deserialize<TradeInfoRawData[]>(jsonInput);
            Controller.AddTradesToQueue(tradeInfos, MaxAmountToBuy, ItemPriority);
        }

    }

}
