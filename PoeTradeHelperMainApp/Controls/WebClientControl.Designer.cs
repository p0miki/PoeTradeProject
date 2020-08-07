namespace PoETradeHelper.Controls
{
    partial class WebClientControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlWeb = new System.Windows.Forms.Panel();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnMakeBulkList = new System.Windows.Forms.Button();
            this.lblMaxUnitPrice = new System.Windows.Forms.Label();
            this.lblMaxAmount2Buy = new System.Windows.Forms.Label();
            this.numMaxAmount2Buy = new System.Windows.Forms.NumericUpDown();
            this.numMaxUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.numPriority = new System.Windows.Forms.NumericUpDown();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblPriorityInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAmount2Buy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWeb
            // 
            this.pnlWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWeb.Location = new System.Drawing.Point(0, 162);
            this.pnlWeb.Margin = new System.Windows.Forms.Padding(6);
            this.pnlWeb.Name = "pnlWeb";
            this.pnlWeb.Size = new System.Drawing.Size(1075, 1087);
            this.pnlWeb.TabIndex = 0;
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(829, 36);
            this.btnMonitor.Margin = new System.Windows.Forms.Padding(6);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(132, 39);
            this.btnMonitor.TabIndex = 8;
            this.btnMonitor.Text = "Snipe";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnMakeBulkList
            // 
            this.btnMakeBulkList.Location = new System.Drawing.Point(829, 106);
            this.btnMakeBulkList.Margin = new System.Windows.Forms.Padding(6);
            this.btnMakeBulkList.Name = "btnMakeBulkList";
            this.btnMakeBulkList.Size = new System.Drawing.Size(132, 37);
            this.btnMakeBulkList.TabIndex = 10;
            this.btnMakeBulkList.Text = "MakeList";
            this.btnMakeBulkList.UseVisualStyleBackColor = true;
            this.btnMakeBulkList.Click += new System.EventHandler(this.btnMakeBulkList_Click);
            // 
            // lblMaxUnitPrice
            // 
            this.lblMaxUnitPrice.AutoSize = true;
            this.lblMaxUnitPrice.Location = new System.Drawing.Point(6, 119);
            this.lblMaxUnitPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaxUnitPrice.Name = "lblMaxUnitPrice";
            this.lblMaxUnitPrice.Size = new System.Drawing.Size(136, 24);
            this.lblMaxUnitPrice.TabIndex = 11;
            this.lblMaxUnitPrice.Text = "Max Unit Price:";
            // 
            // lblMaxAmount2Buy
            // 
            this.lblMaxAmount2Buy.AutoSize = true;
            this.lblMaxAmount2Buy.Location = new System.Drawing.Point(6, 44);
            this.lblMaxAmount2Buy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaxAmount2Buy.Name = "lblMaxAmount2Buy";
            this.lblMaxAmount2Buy.Size = new System.Drawing.Size(221, 24);
            this.lblMaxAmount2Buy.TabIndex = 13;
            this.lblMaxAmount2Buy.Text = "Maximum Amount 2 Buy:";
            // 
            // numMaxAmount2Buy
            // 
            this.numMaxAmount2Buy.Location = new System.Drawing.Point(242, 41);
            this.numMaxAmount2Buy.Margin = new System.Windows.Forms.Padding(6);
            this.numMaxAmount2Buy.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numMaxAmount2Buy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxAmount2Buy.Name = "numMaxAmount2Buy";
            this.numMaxAmount2Buy.Size = new System.Drawing.Size(156, 29);
            this.numMaxAmount2Buy.TabIndex = 15;
            this.numMaxAmount2Buy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxAmount2Buy.ValueChanged += new System.EventHandler(this.numMaxAmount2Buy_ValueChanged);
            // 
            // numMaxUnitPrice
            // 
            this.numMaxUnitPrice.DecimalPlaces = 2;
            this.numMaxUnitPrice.Location = new System.Drawing.Point(242, 114);
            this.numMaxUnitPrice.Margin = new System.Windows.Forms.Padding(6);
            this.numMaxUnitPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numMaxUnitPrice.Name = "numMaxUnitPrice";
            this.numMaxUnitPrice.Size = new System.Drawing.Size(156, 29);
            this.numMaxUnitPrice.TabIndex = 16;
            // 
            // numPriority
            // 
            this.numPriority.Location = new System.Drawing.Point(575, 42);
            this.numPriority.Margin = new System.Windows.Forms.Padding(6);
            this.numPriority.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPriority.Name = "numPriority";
            this.numPriority.Size = new System.Drawing.Size(156, 29);
            this.numPriority.TabIndex = 17;
            this.numPriority.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numPriority.ValueChanged += new System.EventHandler(this.numPriority_ValueChanged);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(429, 44);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(134, 24);
            this.lblPriority.TabIndex = 18;
            this.lblPriority.Text = "Priority (1-100):";
            // 
            // lblPriorityInfo
            // 
            this.lblPriorityInfo.AutoSize = true;
            this.lblPriorityInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityInfo.Location = new System.Drawing.Point(429, 84);
            this.lblPriorityInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPriorityInfo.Name = "lblPriorityInfo";
            this.lblPriorityInfo.Size = new System.Drawing.Size(382, 24);
            this.lblPriorityInfo.TabIndex = 19;
            this.lblPriorityInfo.Text = "Higher priority value items get messaged first";
            // 
            // WebClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPriorityInfo);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.numPriority);
            this.Controls.Add(this.numMaxUnitPrice);
            this.Controls.Add(this.numMaxAmount2Buy);
            this.Controls.Add(this.lblMaxAmount2Buy);
            this.Controls.Add(this.lblMaxUnitPrice);
            this.Controls.Add(this.btnMakeBulkList);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.pnlWeb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WebClientControl";
            this.Size = new System.Drawing.Size(1075, 1250);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAmount2Buy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWeb;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnMakeBulkList;
        private System.Windows.Forms.Label lblMaxUnitPrice;
        private System.Windows.Forms.Label lblMaxAmount2Buy;
        private System.Windows.Forms.NumericUpDown numMaxAmount2Buy;
        private System.Windows.Forms.NumericUpDown numMaxUnitPrice;
        private System.Windows.Forms.NumericUpDown numPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblPriorityInfo;
    }
}
