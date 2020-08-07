
using System;
using System.Windows.Forms;
using CefSharp;
using PoETradeHelper.Controls;
using PoETradeHelper.Classes;
using Gma.UserActivityMonitor;
using System.Runtime.InteropServices;
using IniParser;
using IniParser.Model;

namespace PoETradeHelper
{


    public partial class frmWebHost : Form
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("kernel32.dll")]
        public static extern int FreeLibrary(IntPtr lib);


        WebSearchController SniperController;

        int tabIndexKey = 0;
        private frmItemLists ItemListsWindow = new frmItemLists();
        bool bSettingLiveKey = false;
        bool bSettingBulkKey = false;
        bool bSettingClearListsKey = false;
        IniData iniConfigData;
        FileIniDataParser iniParser = new FileIniDataParser();

        public frmWebHost()
        {
            InitializeComponent();
            SniperController = new WebSearchController(this, ItemListsWindow);

            iniConfigData = iniParser.ReadFile("PoETradeHelperConfig.ini");
            SniperController.LiveSearchMsgKey = (Keys)int.Parse(iniConfigData["Keys"]["LiveSearchMsgKey"]);
            SniperController.BulkSearchMsgKey = (Keys)int.Parse(iniConfigData["Keys"]["BulkSearchMsgKey"]);
            SniperController.ClearListsKey= (Keys)int.Parse(iniConfigData["Keys"]["ClearMsgLists"]);
            btnSetBulkSearchMsgKey.Text = SniperController.BulkSearchMsgKey.ToString();
            btnSetLiveSearchMsgKey.Text = SniperController.LiveSearchMsgKey.ToString();
            btnSetClearListKey.Text = SniperController.ClearListsKey.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HookManager.MarshalLib = LoadLibrary("user32.dll");
            ItemListsWindow.Show();
            
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            iniConfigData["Keys"]["LiveSearchMsgKey"] = ((int)SniperController.LiveSearchMsgKey).ToString();
            iniConfigData["Keys"]["BulkSearchMsgKey"] = ((int)SniperController.BulkSearchMsgKey).ToString();
            iniConfigData["Keys"]["ClearMsgLists"] = ((int)SniperController.ClearListsKey).ToString();
            iniParser.WriteFile("PoETradeHelperConfig.ini", iniConfigData);
            FreeLibrary(HookManager.MarshalLib);
            Cef.Shutdown();
        }

        private void btnAddSniper_Click(object sender, EventArgs e)
        {
            WebClientControl webControl = SniperController.AddNewSniper();
            tabWebSnipers.TabPages.Add(tabIndexKey.ToString(), tabIndexKey.ToString());
            tabWebSnipers.TabPages[tabIndexKey.ToString()].Controls.Add(webControl);
            
            webControl.Dock = DockStyle.Fill;
            webControl.WebBind();

            tabIndexKey++;
        }

        private void chkAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkAlwaysOnTop.Checked;
        }

        private void btnSetLiveSearchMsgKey_Click(object sender, EventArgs e)
        {
            bSettingLiveKey = !bSettingLiveKey;
            if (bSettingLiveKey)
            {
                btnSetLiveSearchMsgKey.Text = "Press any key";
            }
            else
            {
                btnSetLiveSearchMsgKey.Text = SniperController.LiveSearchMsgKey.ToString();
            }
        }

        private void FrmWebHost_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (bSettingLiveKey)
            {
                bSettingLiveKey = false;
                btnSetLiveSearchMsgKey.Text = e.KeyCode.ToString();
                SniperController.LiveSearchMsgKey = e.KeyCode;
            }
            else
            {
                if (bSettingBulkKey)
                {
                    bSettingBulkKey = false;
                    btnSetBulkSearchMsgKey.Text = e.KeyCode.ToString();
                    SniperController.BulkSearchMsgKey = e.KeyCode; 
                }
                else if (bSettingClearListsKey)
                {
                    bSettingClearListsKey = false;
                    btnSetClearListKey.Text = e.KeyCode.ToString();
                    SniperController.ClearListsKey = e.KeyCode;
                }
            }
        }

        private void btnSetBulkSearchMsgKey_Click(object sender, EventArgs e)
        {
            bSettingBulkKey = !bSettingBulkKey;
            if (bSettingBulkKey)
            {
                btnSetBulkSearchMsgKey.Text = "Press any key";
            }
            else
            {
                btnSetBulkSearchMsgKey.Text = SniperController.BulkSearchMsgKey.ToString();
            }
        }

        private void btnSetClearListKey_Click(object sender, EventArgs e)
        {
            bSettingClearListsKey = !bSettingClearListsKey;
            if (bSettingClearListsKey)
            {
                btnSetClearListKey.Text = "Press any key";
            }
            else
            {
                btnSetClearListKey.Text = SniperController.ClearListsKey.ToString();
            }
        }

        private void chkShowListForm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowListForm.Checked)
                ItemListsWindow.Visible = true;
            else
                ItemListsWindow.Visible = false; 
        }

        private void numOpacity_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = Decimal.ToDouble(numOpacity.Value / 100);
            ItemListsWindow.Opacity = Decimal.ToDouble(numOpacity.Value / 100);
        }

        private void btnRemoveWeb_Click(object sender, EventArgs e)
        {
            if (this.tabWebSnipers.SelectedIndex >= 0)
            {
                this.tabWebSnipers.TabPages.RemoveAt(this.tabWebSnipers.SelectedIndex);
            }
        }
    }
}
