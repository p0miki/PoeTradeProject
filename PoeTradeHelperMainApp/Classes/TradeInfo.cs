using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PoETradeHelper.Classes
{
    public class TradeInfo
    {
        public Guid Id { get; private set; }
        public string IGN { get; set; }
        public double Price { get; set; }
        public int StackSize { get; set; }

        public int AmountYouGet { get; set; }
        public string ItemName { get; set; }
        public string CurrencyName { get; set; }
        public string LeagueName { get; set; }

        public int MaxAmountToBuy { get; protected set; }

        public double TotalPrice
        {
            get
            {
                return this.ActualAmountToBuy * this.Price;
            }
        }

        public int ActualAmountToBuy
        {
            get
            {
                return Math.Min(this.StackSize, this.MaxAmountToBuy);
            }
        }

        public TradeInfo(int maxAmountToBuy, TradeInfoRawData rawData)
        {
            this.MaxAmountToBuy = maxAmountToBuy;
            this.Id = Guid.NewGuid();
            this.IGN = rawData.IGN;

            double price;
            double.TryParse(rawData.Price, out price);
            this.Price = price;

            int stackSize;
            int.TryParse(rawData.StackSize, out stackSize);
            this.StackSize = stackSize;

            this.CurrencyName = rawData.CurrencyName;
            this.LeagueName = rawData.LeagueName;
            this.ItemName = rawData.ItemName;
        }
    }
}
