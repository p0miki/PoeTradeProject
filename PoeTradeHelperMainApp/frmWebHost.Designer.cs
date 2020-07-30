namespace webTest
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
            this.tabWebSnipers = new System.Windows.Forms.TabControl();
            this.btnAddSniper = new System.Windows.Forms.Button();
            this.cmdSendKeyTest = new System.Windows.Forms.Button();
            this.chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tabWebSnipers
            // 
            this.tabWebSnipers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabWebSnipers.Location = new System.Drawing.Point(0, 92);
            this.tabWebSnipers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabWebSnipers.Name = "tabWebSnipers";
            this.tabWebSnipers.SelectedIndex = 0;
            this.tabWebSnipers.Size = new System.Drawing.Size(2419, 962);
            this.tabWebSnipers.TabIndex = 0;
            // 
            // btnAddSniper
            // 
            this.btnAddSniper.Location = new System.Drawing.Point(22, 22);
            this.btnAddSniper.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddSniper.Name = "btnAddSniper";
            this.btnAddSniper.Size = new System.Drawing.Size(138, 42);
            this.btnAddSniper.TabIndex = 1;
            this.btnAddSniper.Text = "Add Web ";
            this.btnAddSniper.UseVisualStyleBackColor = true;
            this.btnAddSniper.Click += new System.EventHandler(this.btnAddSniper_Click);
            // 
            // cmdSendKeyTest
            // 
            this.cmdSendKeyTest.Location = new System.Drawing.Point(1173, 15);
            this.cmdSendKeyTest.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdSendKeyTest.Name = "cmdSendKeyTest";
            this.cmdSendKeyTest.Size = new System.Drawing.Size(138, 42);
            this.cmdSendKeyTest.TabIndex = 2;
            this.cmdSendKeyTest.Text = "Test Keys";
            this.cmdSendKeyTest.UseVisualStyleBackColor = true;
            this.cmdSendKeyTest.Visible = false;
            this.cmdSendKeyTest.Click += new System.EventHandler(this.cmdSendKeyTest_Click);
            // 
            // chkAlwaysOnTop
            // 
            this.chkAlwaysOnTop.AutoSize = true;
            this.chkAlwaysOnTop.Location = new System.Drawing.Point(182, 30);
            this.chkAlwaysOnTop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            this.chkAlwaysOnTop.Size = new System.Drawing.Size(132, 28);
            this.chkAlwaysOnTop.TabIndex = 3;
            this.chkAlwaysOnTop.Text = "Keep on top";
            this.chkAlwaysOnTop.UseVisualStyleBackColor = true;
            this.chkAlwaysOnTop.CheckedChanged += new System.EventHandler(this.chkAlwaysOnTop_CheckedChanged);
            // 
            // frmWebHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2419, 1054);
            this.Controls.Add(this.chkAlwaysOnTop);
            this.Controls.Add(this.cmdSendKeyTest);
            this.Controls.Add(this.btnAddSniper);
            this.Controls.Add(this.tabWebSnipers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmWebHost";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabWebSnipers;
        private System.Windows.Forms.Button btnAddSniper;
        private System.Windows.Forms.Button cmdSendKeyTest;
        private System.Windows.Forms.CheckBox chkAlwaysOnTop;
    }
}

