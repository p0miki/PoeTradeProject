
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using webTest.Controls;
using webTest.Classes;
using Gma.UserActivityMonitor;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace webTest
{


    public partial class frmWebHost : Form
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("kernel32.dll")]
        public static extern int FreeLibrary(IntPtr lib);

        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("User32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);


        const uint WM_KEYDOWN = 0x100;
        const uint WM_KEYUP = 0x0101;

        WebSearchController SniperController;
        Timer tmrTest = new Timer();

        int tabIndexKey = 0;
        private frmItemLists frmItemLists = new frmItemLists();


        public frmWebHost()
        {
            InitializeComponent();
            SniperController = new WebSearchController(this, frmItemLists);
            tmrTest.Tick += tmrTest_Tick;
        }

        private void tmrTest_Tick(object sender, EventArgs e)
        {
            tmrTest.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HookManager.MarshalLib = LoadLibrary("user32.dll");
            frmItemLists.Show();
            

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        private void cmdSendKeyTest_Click(object sender, EventArgs e)
        {

            tmrTest.Interval = 2000;
            tmrTest.Enabled = true; 


        }

        private void chkAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkAlwaysOnTop.Checked;
        }
    }
}
