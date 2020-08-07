using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoETradeHelper.Classes
{
    [Serializable]
    public class BulkTradeInfo
    {
        public Guid Id { get; protected set; }
        public double PricePerSingleUnit {
            get
            {
                double unitPrice = 0;
                if (AmountYouGet != null && AmountYouPay != null)
                {
                    unitPrice = AmountYouPayD / AmountYouGetD;
                }
                return unitPrice;
            }
        }
        public double BuyAllPrice
        {
            get
            {
                double unitCount = TotalAmountYouCanBuy / AmountYouGetD;
                return unitCount * AmountYouPayD;
            }
        }

        public double TotalAmountYouCanBuy
        {
            get
            {
                double maxPossibleAmount = Math.Floor(dblStock / AmountYouGetD) * AmountYouGetD;
                double maxNeededAmount = Math.Floor(MaxAmountToBuy / AmountYouGetD) * AmountYouGetD;
                return Math.Min(maxPossibleAmount, maxNeededAmount);

            }
        }


        public double MaxAmountToBuy { get; set; }
        public double AmountYouGetD { get; private set; }
        public double AmountYouPayD { get; private set; }
        public string IGN { get; set; }
        public double dblStock {get; set;}
        private string stock;
        public string Stock { get { return stock; }
            set
            {
                stock = value;
                double dTemp;
                dblStock = 0; 
                if (double.TryParse(value, out dTemp))
                {
                    dblStock = dTemp;
                }
                
            }
        }
        public string ItemYouGet { get; set; }
        private string amountYouGet;
        public string AmountYouGet
        {
            get { return amountYouGet;  }
            set
            {
                amountYouGet = value;
                AmountYouGetD = double.Parse(value);
            }
        }
        public string ItemYouPay { get; set; }
        private string amountYouPay;
        public string AmountYouPay
        {
            get
            {
                return amountYouPay;
            }
            set
            {
                amountYouPay = value;
                AmountYouPayD = double.Parse(value);
            }
        }
        public string LeagueName { get; set; }

        public BulkTradeInfo()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
