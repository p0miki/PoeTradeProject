using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoETradeHelper.Controls;
using System.Collections.Concurrent;
using Gma.UserActivityMonitor;
using CefSharp;
using CefSharp.WinForms;
using System.Xml.Schema;
using Priority_Queue;
using System.Windows.Forms;
using System.IO;

namespace PoETradeHelper.Classes
{
    public class WebSearchController
    {
        SimplePriorityQueue<TradeInfo> TradesQueue = new SimplePriorityQueue<TradeInfo>();
        SimplePriorityQueue<BulkTradeInfo> BulkTradeQueue = new SimplePriorityQueue<BulkTradeInfo>();
        frmWebHost MainForm = null;
        frmItemLists frmItemLists = null;
        ConcurrentDictionary<int, int> KeyFlags = new ConcurrentDictionary<int, int>(2, 2);
        WindowsInput.InputSimulator inputSim = new WindowsInput.InputSimulator();
        public Keys LiveSearchMsgKey { get; set; }
        public Keys BulkSearchMsgKey { get; set; }
        public Keys ClearListsKey { get; set; }


        double BulkTradeMaxUnitPrice { get; set; }

        public WebSearchController(frmWebHost mainForm, frmItemLists itemListsForm)
        {
            CefSettings setting = new CefSettings();
            this.MainForm = mainForm;
            this.frmItemLists = itemListsForm;
            LiveSearchMsgKey = Keys.PageDown;
            BulkSearchMsgKey = Keys.F3;
            ClearListsKey = Keys.F4;

            HookManager.KeyUp += HookManager_KeyUp;

            setting.RemoteDebuggingPort = 8088;
            setting.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF";
            CefSharpSettings.LegacyJavascriptBindingEnabled = true;
            Cef.Initialize(setting);
        }

        private void HookManager_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == ClearListsKey)
            {
                BulkTradeQueue.Clear();
                TradesQueue.Clear();
                frmItemLists.ClearLists();
            }
            if (e.KeyCode == this.LiveSearchMsgKey)
            {
                Task t = this.SendMessage();

            }
            if (e.KeyCode == this.BulkSearchMsgKey) 
            {
                if (BulkTradeQueue.Count > 0)
                {
                    BulkTradeInfo item;
                    bool ok = BulkTradeQueue.TryDequeue(out item);
                    if (ok)
                    {
                        frmItemLists.RemoveItemFromGrid(item.Id, true);
                        if (item.dblStock >= item.AmountYouGetD)
                        {
                            string msgFormat = "@{0} Hi, I'd like to buy your {1} {2} for my {3} {4} in {5}.";
                            string msg1 = string.Format(msgFormat, item.IGN, item.TotalAmountYouCanBuy, item.ItemYouGet, item.BuyAllPrice, item.ItemYouPay, item.LeagueName);
                            bool clipSet = false;
                            int i = 0;
                            while (clipSet != true)
                            {
                                i++;
                                try
                                {
                                    if (i < 3)
                                    {
                                        System.Windows.Forms.Clipboard.SetText(msg1);
                                        clipSet = true;
                                    }
                                    else
                                    {
                                        clipSet = true;
                                    }
                                }
                                catch
                                { }
                            }

                            inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.RETURN);
                            inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.RETURN);
                            inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.CONTROL);
                            inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_V);
                            inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_V);
                            inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.CONTROL);
                            inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.RETURN);
                            inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.RETURN);
                        }

                    }
                }
            }
        }


        public WebClientControl AddNewSniper()
        {
            WebClientControl sniper = new WebClientControl();
            sniper.Initilize(this);
            return sniper;
        }

        public void AddBulkTradeQueue(BulkTradeInfo[] newTrades, double maxUnitPrice, double maxaAmountToBuy)
        {
            List<BulkTradeInfo> actualTrades = new List<BulkTradeInfo>();
            foreach (BulkTradeInfo item in newTrades)
            {
                if (item.PricePerSingleUnit <= maxUnitPrice)
                {
                    item.MaxAmountToBuy = maxaAmountToBuy;
                    if ((item.BuyAllPrice > 0) && (item.AmountYouGetD > 0))
                    {
                        BulkTradeQueue.Enqueue(item, 0);
                        actualTrades.Add(item);
                    }
                }
            }
            frmItemLists.AddBulkSearchItem(actualTrades.ToArray());
        }

        public void AddTradesToQueue(TradeInfoRawData[] newTrades, int maxAmountToBuy, float priority)
        {
            TradeInfo newItem;
            TradeInfo[] newTradeItems = new TradeInfo[newTrades.Length];
            int i = 0;
            foreach (TradeInfoRawData item in newTrades)
            {
                newItem = new TradeInfo(maxAmountToBuy, item);
                TradesQueue.Enqueue(newItem, priority);
                newTradeItems[i] = newItem;
                i++;
            }
            frmItemLists.AddSnipedItem(newTradeItems);
        }
        

       async Task SendMessage()
        {
            TradeInfo tradeInfo;
            bool ok;

            string msgFormat = "@{0} Hi, I'd like to buy your {1} {2} for {3} {4} in {5}.";
            if (TradesQueue.Count > 0)
            {
                ok = TradesQueue.TryDequeue(out tradeInfo);
                if (ok)
                {
                    string msg1 = string.Format(msgFormat, tradeInfo.IGN, tradeInfo.ActualAmountToBuy,  tradeInfo.ItemName, tradeInfo.TotalPrice, tradeInfo.CurrencyName, tradeInfo.LeagueName);

                    System.Windows.Forms.Clipboard.SetText(msg1);
                    inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.RETURN);
                    inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.RETURN);
                    inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.CONTROL);
                    inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_V);
                    inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_V);
                    inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.CONTROL);
                    inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.RETURN);
                    inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.RETURN);

                    frmItemLists.RemoveItemFromGrid(tradeInfo.Id, false);
                }
            }
        }
    }
}
