namespace PoETradeHelper
{
    partial class frmWebHost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebHost));
            this.tabWebSnipers = new System.Windows.Forms.TabControl();
            this.btnAddSniper = new System.Windows.Forms.Button();
            this.chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.lblLiveSearchHotKey = new System.Windows.Forms.Label();
            this.btnSetLiveSearchMsgKey = new System.Windows.Forms.Button();
            this.btnSetBulkSearchMsgKey = new System.Windows.Forms.Button();
            this.lblBulkSearchHotKey = new System.Windows.Forms.Label();
            this.btnSetClearListKey = new System.Windows.Forms.Button();
            this.lblClearListsHotKey = new System.Windows.Forms.Label();
            this.chkShowListForm = new System.Windows.Forms.CheckBox();
            this.numOpacity = new System.Windows.Forms.NumericUpDown();
            this.lblWindowOpacity = new System.Windows.Forms.Label();
            this.btnRemoveWeb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // tabWebSnipers
            // 
            this.tabWebSnipers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabWebSnipers.Location = new System.Drawing.Point(-2, 152);
            this.tabWebSnipers.Margin = new System.Windows.Forms.Padding(6);
            this.tabWebSnipers.Name = "tabWebSnipers";
            this.tabWebSnipers.SelectedIndex = 0;
            this.tabWebSnipers.Size = new System.Drawing.Size(1131, 423);
            this.tabWebSnipers.TabIndex = 0;
            // 
            // btnAddSniper
            // 
            this.btnAddSniper.Location = new System.Drawing.Point(22, 22);
            this.btnAddSniper.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddSniper.Name = "btnAddSniper";
            this.btnAddSniper.Size = new System.Drawing.Size(138, 42);
            this.btnAddSniper.TabIndex = 1;
            this.btnAddSniper.Text = "Add web";
            this.btnAddSniper.UseVisualStyleBackColor = true;
            this.btnAddSniper.Click += new System.EventHandler(this.btnAddSniper_Click);
            // 
            // chkAlwaysOnTop
            // 
            this.chkAlwaysOnTop.AutoSize = true;
            this.chkAlwaysOnTop.Location = new System.Drawing.Point(22, 77);
            this.chkAlwaysOnTop.Margin = new System.Windows.Forms.Padding(6);
            this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            this.chkAlwaysOnTop.Size = new System.Drawing.Size(132, 28);
            this.chkAlwaysOnTop.TabIndex = 3;
            this.chkAlwaysOnTop.Text = "Keep on top";
            this.chkAlwaysOnTop.UseVisualStyleBackColor = true;
            this.chkAlwaysOnTop.CheckedChanged += new System.EventHandler(this.chkAlwaysOnTop_CheckedChanged);
            // 
            // lblLiveSearchHotKey
            // 
            this.lblLiveSearchHotKey.AutoSize = true;
            this.lblLiveSearchHotKey.Location = new System.Drawing.Point(742, 17);
            this.lblLiveSearchHotKey.Name = "lblLiveSearchHotKey";
            this.lblLiveSearchHotKey.Size = new System.Drawing.Size(176, 24);
            this.lblLiveSearchHotKey.TabIndex = 4;
            this.lblLiveSearchHotKey.Text = "Live search hot key:";
            // 
            // btnSetLiveSearchMsgKey
            // 
            this.btnSetLiveSearchMsgKey.Location = new System.Drawing.Point(940, 12);
            this.btnSetLiveSearchMsgKey.Name = "btnSetLiveSearchMsgKey";
            this.btnSetLiveSearchMsgKey.Size = new System.Drawing.Size(179, 35);
            this.btnSetLiveSearchMsgKey.TabIndex = 5;
            this.btnSetLiveSearchMsgKey.Text = "Next";
            this.btnSetLiveSearchMsgKey.UseVisualStyleBackColor = true;
            this.btnSetLiveSearchMsgKey.Click += new System.EventHandler(this.btnSetLiveSearchMsgKey_Click);
            // 
            // btnSetBulkSearchMsgKey
            // 
            this.btnSetBulkSearchMsgKey.Location = new System.Drawing.Point(940, 53);
            this.btnSetBulkSearchMsgKey.Name = "btnSetBulkSearchMsgKey";
            this.btnSetBulkSearchMsgKey.Size = new System.Drawing.Size(179, 35);
            this.btnSetBulkSearchMsgKey.TabIndex = 7;
            this.btnSetBulkSearchMsgKey.Text = "F3";
            this.btnSetBulkSearchMsgKey.UseVisualStyleBackColor = true;
            this.btnSetBulkSearchMsgKey.Click += new System.EventHandler(this.btnSetBulkSearchMsgKey_Click);
            // 
            // lblBulkSearchHotKey
            // 
            this.lblBulkSearchHotKey.AutoSize = true;
            this.lblBulkSearchHotKey.Location = new System.Drawing.Point(742, 58);
            this.lblBulkSearchHotKey.Name = "lblBulkSearchHotKey";
            this.lblBulkSearchHotKey.Size = new System.Drawing.Size(178, 24);
            this.lblBulkSearchHotKey.TabIndex = 6;
            this.lblBulkSearchHotKey.Text = "Bulk search hot key:";
            // 
            // btnSetClearListKey
            // 
            this.btnSetClearListKey.Location = new System.Drawing.Point(940, 95);
            this.btnSetClearListKey.Name = "btnSetClearListKey";
            this.btnSetClearListKey.Size = new System.Drawing.Size(179, 35);
            this.btnSetClearListKey.TabIndex = 9;
            this.btnSetClearListKey.Text = "F4";
            this.btnSetClearListKey.UseVisualStyleBackColor = true;
            this.btnSetClearListKey.Click += new System.EventHandler(this.btnSetClearListKey_Click);
            // 
            // lblClearListsHotKey
            // 
            this.lblClearListsHotKey.AutoSize = true;
            this.lblClearListsHotKey.Location = new System.Drawing.Point(742, 100);
            this.lblClearListsHotKey.Name = "lblClearListsHotKey";
            this.lblClearListsHotKey.Size = new System.Drawing.Size(159, 24);
            this.lblClearListsHotKey.TabIndex = 8;
            this.lblClearListsHotKey.Text = "Clear lists hot key:";
            // 
            // chkShowListForm
            // 
            this.chkShowListForm.AutoSize = true;
            this.chkShowListForm.Checked = true;
            this.chkShowListForm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowListForm.Location = new System.Drawing.Point(166, 77);
            this.chkShowListForm.Margin = new System.Windows.Forms.Padding(6);
            this.chkShowListForm.Name = "chkShowListForm";
            this.chkShowListForm.Size = new System.Drawing.Size(182, 28);
            this.chkShowListForm.TabIndex = 10;
            this.chkShowListForm.Text = "Show lists window";
            this.chkShowListForm.UseVisualStyleBackColor = true;
            this.chkShowListForm.CheckedChanged += new System.EventHandler(this.chkShowListForm_CheckedChanged);
            // 
            // numOpacity
            // 
            this.numOpacity.Location = new System.Drawing.Point(182, 114);
            this.numOpacity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOpacity.Name = "numOpacity";
            this.numOpacity.Size = new System.Drawing.Size(54, 29);
            this.numOpacity.TabIndex = 11;
            this.numOpacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numOpacity.ValueChanged += new System.EventHandler(this.numOpacity_ValueChanged);
            // 
            // lblWindowOpacity
            // 
            this.lblWindowOpacity.AutoSize = true;
            this.lblWindowOpacity.Location = new System.Drawing.Point(18, 116);
            this.lblWindowOpacity.Name = "lblWindowOpacity";
            this.lblWindowOpacity.Size = new System.Drawing.Size(157, 24);
            this.lblWindowOpacity.TabIndex = 12;
            this.lblWindowOpacity.Text = "Windows opacity:";
            // 
            // btnRemoveWeb
            // 
            this.btnRemoveWeb.Location = new System.Drawing.Point(172, 23);
            this.btnRemoveWeb.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemoveWeb.Name = "btnRemoveWeb";
            this.btnRemoveWeb.Size = new System.Drawing.Size(138, 42);
            this.btnRemoveWeb.TabIndex = 13;
            this.btnRemoveWeb.Text = "Remove web";
            this.btnRemoveWeb.UseVisualStyleBackColor = true;
            this.btnRemoveWeb.Click += new System.EventHandler(this.btnRemoveWeb_Click);
            // 
            // frmWebHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 575);
            this.Controls.Add(this.btnRemoveWeb);
            this.Controls.Add(this.lblWindowOpacity);
            this.Controls.Add(this.numOpacity);
            this.Controls.Add(this.chkShowListForm);
            this.Controls.Add(this.btnSetClearListKey);
            this.Controls.Add(this.lblClearListsHotKey);
            this.Controls.Add(this.btnSetBulkSearchMsgKey);
            this.Controls.Add(this.lblBulkSearchHotKey);
            this.Controls.Add(this.btnSetLiveSearchMsgKey);
            this.Controls.Add(this.lblLiveSearchHotKey);
            this.Controls.Add(this.chkAlwaysOnTop);
            this.Controls.Add(this.btnAddSniper);
            this.Controls.Add(this.tabWebSnipers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmWebHost";
            this.Text = "PoE Trade Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmWebHost_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabWebSnipers;
        private System.Windows.Forms.Button btnAddSniper;
        private System.Windows.Forms.CheckBox chkAlwaysOnTop;
        private System.Windows.Forms.Label lblLiveSearchHotKey;
        private System.Windows.Forms.Button btnSetLiveSearchMsgKey;
        private System.Windows.Forms.Button btnSetBulkSearchMsgKey;
        private System.Windows.Forms.Label lblBulkSearchHotKey;
        private System.Windows.Forms.Button btnSetClearListKey;
        private System.Windows.Forms.Label lblClearListsHotKey;
        private System.Windows.Forms.CheckBox chkShowListForm;
        private System.Windows.Forms.NumericUpDown numOpacity;
        private System.Windows.Forms.Label lblWindowOpacity;
        private System.Windows.Forms.Button btnRemoveWeb;
    }
}

