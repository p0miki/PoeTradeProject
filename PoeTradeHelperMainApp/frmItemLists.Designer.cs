using webTest.Controls;

namespace webTest
{
    partial class frmItemLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemLists));
            this.chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.tabLiveSearch = new System.Windows.Forms.TabPage();
            this.dgvLiveSearchItem = new webTest.Controls.ItemGridView();

            this.tabGrids = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBulkSearchItems = new webTest.Controls.ItemGridView();
            this.tabLiveSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveSearchItem)).BeginInit();
            this.tabGrids.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBulkSearchItems)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAlwaysOnTop
            // 
            this.chkAlwaysOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAlwaysOnTop.AutoSize = true;
            this.chkAlwaysOnTop.Location = new System.Drawing.Point(2280, 9);
            this.chkAlwaysOnTop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            this.chkAlwaysOnTop.Size = new System.Drawing.Size(132, 28);
            this.chkAlwaysOnTop.TabIndex = 1;
            this.chkAlwaysOnTop.Text = "Keep on top";
            this.chkAlwaysOnTop.UseVisualStyleBackColor = true;
            this.chkAlwaysOnTop.CheckedChanged += new System.EventHandler(this.chkAlwaysOnTop_CheckedChanged);
            // 
            // tabLiveSearch
            // 
            this.tabLiveSearch.Controls.Add(this.dgvLiveSearchItem);
            this.tabLiveSearch.Location = new System.Drawing.Point(4, 27);
            this.tabLiveSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabLiveSearch.Name = "tabLiveSearch";
            this.tabLiveSearch.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabLiveSearch.Size = new System.Drawing.Size(2389, 879);
            this.tabLiveSearch.TabIndex = 0;
            this.tabLiveSearch.Text = "Live Search Items";
            this.tabLiveSearch.UseVisualStyleBackColor = true;
            // 
            // dgvLiveSearchItem
            // 
            this.dgvLiveSearchItem.AllowUserToAddRows = false;
            this.dgvLiveSearchItem.AllowUserToDeleteRows = false;
            this.dgvLiveSearchItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiveSearchItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLiveSearchItem.Location = new System.Drawing.Point(6, 6);
            this.dgvLiveSearchItem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvLiveSearchItem.Name = "dgvLiveSearchItem";
            this.dgvLiveSearchItem.ReadOnly = true;
            this.dgvLiveSearchItem.Size = new System.Drawing.Size(2377, 867);
            this.dgvLiveSearchItem.TabIndex = 1;

            // 
            // tabGrids
            // 
            this.tabGrids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabGrids.Controls.Add(this.tabLiveSearch);
            this.tabGrids.Controls.Add(this.tabPage1);
            this.tabGrids.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGrids.Location = new System.Drawing.Point(22, 22);
            this.tabGrids.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabGrids.Name = "tabGrids";
            this.tabGrids.SelectedIndex = 0;
            this.tabGrids.Size = new System.Drawing.Size(2397, 910);
            this.tabGrids.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.dgvBulkSearchItems);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(2389, 879);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Bulk Search Items";
            // 
            // dgvBulkSearchItems
            // 
            this.dgvBulkSearchItems.AllowUserToAddRows = false;
            this.dgvBulkSearchItems.AllowUserToDeleteRows = false;
            this.dgvBulkSearchItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBulkSearchItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBulkSearchItems.Location = new System.Drawing.Point(0, 0);
            this.dgvBulkSearchItems.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvBulkSearchItems.Name = "dgvBulkSearchItems";
            this.dgvBulkSearchItems.ReadOnly = true;
            this.dgvBulkSearchItems.Size = new System.Drawing.Size(2389, 879);
            this.dgvBulkSearchItems.TabIndex = 2;

            // 
            // frmSnipeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2441, 939);
            this.ControlBox = false;
            this.Controls.Add(this.chkAlwaysOnTop);
            this.Controls.Add(this.tabGrids);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "frmSnipeList";
            this.Text = "Item List";
            this.tabLiveSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveSearchItem)).EndInit();
            this.tabGrids.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBulkSearchItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkAlwaysOnTop;
        private System.Windows.Forms.TabPage tabLiveSearch;
        private ItemGridView dgvLiveSearchItem;
        private System.Windows.Forms.TabControl tabGrids;
        private System.Windows.Forms.TabPage tabPage1;
        private ItemGridView dgvBulkSearchItems;
    }
}