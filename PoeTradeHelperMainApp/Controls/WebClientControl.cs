using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using webTest.Classes; 
namespace webTest.Controls
{
    public partial class WebClientControl : UserControl
    {
        public ChromiumWebBrowser webClient;
        JSBinder jsListener;
        WebSearchController Controller = null;
        private bool bInit = true;
        private bool bSniping = false;

        public WebClientControl()
        {
            InitializeComponent();
        }

        public void Initilize(WebSearchController controller)
        {
            this.Controller = controller;
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            TimeSpan t = new TimeSpan(0, 0, 5);
            System.IO.StreamReader jsFile = new System.IO.StreamReader("1.txt");
            string script = jsFile.ReadToEnd();
            jsFile.Close();

            var task1 = webClient.EvaluateScriptAsync(script, t);

            task1.Wait();

        }

        public void WebBind()
        {
            jsListener = new JSBinder(this.Controller);
            jsListener.MaxAmountToBuy = decimal.ToInt32(numMaxAmount2Buy.Value);
            jsListener.ItemPriority = decimal.ToSingle( numPriority.Value);
            webClient = new ChromiumWebBrowser("https://www.pathofexile.com/trade");
            webClient.JavascriptObjectRepository.Register("netListner", jsListener, isAsync: true, options: BindingOptions.DefaultBinder);

            webClient.Dock = DockStyle.Fill;
            this.pnlWeb.Controls.Add(webClient);
            webClient.Dock = DockStyle.Fill;
        }

        private void btnMakeBulkList_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader jsFile = new System.IO.StreamReader("jsInjectionScript.txt");
            string script = jsFile.ReadToEnd();
            jsFile.Close();
            TimeSpan t = new TimeSpan(0, 0, 5);
            var task1 = webClient.EvaluateScriptAsync(script, t);
            //task1.Wait();
            string sc1 = "processBulkList();";
            BulkTradeInfo[] tradeInfos;
            webClient.EvaluateScriptAsync(sc1).ContinueWith(x =>
            {
                var response = x.Result;
                if (response.Success && response.Result != null)
                {
                    string s = response.Result.ToString();
                    System.Web.Script.Serialization.JavaScriptSerializer jsSer = new System.Web.Script.Serialization.JavaScriptSerializer();
                    tradeInfos = jsSer.Deserialize<BulkTradeInfo[]>(s);
                    Controller.AddBulkTradeQueue(tradeInfos, decimal.ToDouble(numMaxUnitPrice.Value), decimal.ToDouble(numMaxAmount2Buy.Value));

                }
            });
        }

        private void numMaxAmount2Buy_ValueChanged(object sender, EventArgs e)
        {
            jsListener.MaxAmountToBuy = decimal.ToInt32(numMaxAmount2Buy.Value);
        }

        private void numPriority_ValueChanged(object sender, EventArgs e)
        {
            jsListener.ItemPriority = decimal.ToSingle(numPriority.Value);
        }
    }
}
