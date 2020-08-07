using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoETradeHelper.Classes;

namespace PoETradeHelper.Controls
{
    public partial class ItemGridView : DataGridView
    {
        public ItemGridView()
        {
            InitializeComponent();
        }

        public void AddTradeItems(BulkTradeInfo[] newTrades)
        {
            if (newTrades.Length > 0)
            {
                int rowCount = this.Rows.Count;

                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    for (int i = 0; i < newTrades.Length; i++)
                    {
                        BulkTradeInfo tradeInfo = newTrades[i];
                        this.Rows.Add();

                        this.Rows[rowCount].Cells["colItemName"].Value = tradeInfo.ItemYouGet;
                        this.Rows[rowCount].Cells["colAmount"].Value = tradeInfo.dblStock.ToString();
                        this.Rows[rowCount].Cells["colItemPrice"].Value = tradeInfo.PricePerSingleUnit.ToString();
                        this.Rows[rowCount].Cells["colAmount2Buy"].Value = tradeInfo.TotalAmountYouCanBuy.ToString();
                        this.Rows[rowCount].Cells["colTotalPrice"].Value = tradeInfo.BuyAllPrice.ToString();
                        this.Rows[rowCount].Cells["colTotalCurrencyType"].Value = tradeInfo.ItemYouPay;
                        this.Rows[rowCount].Tag = tradeInfo.Id;
                        rowCount++;
                    }
                });
            }

        }
        public void AddTradeItems(TradeInfo[] newTrades)
        {
            if (newTrades.Length > 0)
            {
                int rowCount = this.Rows.Count;

                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    for (int i = 0; i < newTrades.Length; i++)
                    {
                        TradeInfo tradeInfo = newTrades[i];
                        this.Rows.Add();

                        this.Rows[rowCount].Cells["colItemName"].Value = tradeInfo.ItemName;
                        this.Rows[rowCount].Cells["colAmount"].Value = tradeInfo.StackSize.ToString();
                        this.Rows[rowCount].Cells["colItemPrice"].Value = tradeInfo.Price.ToString();
                        this.Rows[rowCount].Cells["colAmount2Buy"].Value = tradeInfo.ActualAmountToBuy.ToString();
                        this.Rows[rowCount].Cells["colTotalPrice"].Value = tradeInfo.TotalPrice.ToString();
                        this.Rows[rowCount].Cells["colTotalCurrencyType"].Value = tradeInfo.CurrencyName;
                        this.Rows[rowCount].Tag = tradeInfo.Id;
                        rowCount++;
                    }
                });
            }

        }

        public void RemoveItemFromGrid(Guid itemID)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                int rowIdx = FindItemRowIndex(itemID);
                if (rowIdx >= 0)
                {
                    this.Rows.RemoveAt(rowIdx);
                }
            });
        }

        public int FindItemRowIndex(Guid itemID)
        {
            int rowCount = this.Rows.Count;
            int retVal = -1;
            bool bFound = false;
            int i = 0;

            while ((i < rowCount) && (!bFound))
            {
                if ((Guid)this.Rows[i].Tag == itemID)
                {
                    retVal = i;
                    bFound = true;
                }
                else
                {
                    i++;
                }
            }
            return retVal;
        }
    }
}
