using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoETradeHelper.Classes;

namespace PoETradeHelper
{
    public partial class frmItemLists : Form
    {
        public frmItemLists()
        {
            InitializeComponent(); 
            foreach (DataGridViewColumn item in dgvLiveSearchItem.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn item in dgvBulkSearchItems.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void AddBulkSearchItem(BulkTradeInfo[] newTrades)
        {
            if (newTrades.Length > 0)
            {

                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    dgvBulkSearchItems.AddTradeItems(newTrades);
                });
            }
        }
        public void AddSnipedItem(TradeInfo[] newTrades)
        {
            if (newTrades.Length > 0)
            {
 
                this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        dgvLiveSearchItem.AddTradeItems(newTrades);
                    });
            }

        }

        public void RemoveItemFromGrid(Guid itemID, bool bBulkItem)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                if (bBulkItem)
                {
                    dgvBulkSearchItems.RemoveItemFromGrid(itemID);
                }
                else
                {
                    dgvLiveSearchItem.RemoveItemFromGrid(itemID);
                }
            });
        }

        public void ClearLists()
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                dgvBulkSearchItems.Rows.Clear();
                dgvLiveSearchItem.Rows.Clear();
            });
        }

        private void chkAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkAlwaysOnTop.Checked;
        }
    }
}
