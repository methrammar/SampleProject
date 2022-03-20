namespace SampleWinForms.View
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtOrderSearch = new System.Windows.Forms.TextBox();
            this.dgwOrders = new System.Windows.Forms.DataGridView();
            this.tpProducts = new System.Windows.Forms.TabPage();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.lblItemSearch = new System.Windows.Forms.Label();
            this.lblCatergories = new System.Windows.Forms.Label();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.tpSuppliers = new System.Windows.Forms.TabPage();
            this.tpEmployees = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExamine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain.SuspendLayout();
            this.tpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).BeginInit();
            this.tpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpOrders);
            this.tcMain.Controls.Add(this.tpProducts);
            this.tcMain.Controls.Add(this.tpSuppliers);
            this.tcMain.Controls.Add(this.tpEmployees);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1262, 781);
            this.tcMain.TabIndex = 0;
            // 
            // tpOrders
            // 
            this.tpOrders.Controls.Add(this.lblSearch);
            this.tpOrders.Controls.Add(this.txtOrderSearch);
            this.tpOrders.Controls.Add(this.dgwOrders);
            this.tpOrders.Location = new System.Drawing.Point(4, 29);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrders.Size = new System.Drawing.Size(1254, 748);
            this.tpOrders.TabIndex = 0;
            this.tpOrders.Text = "Orders";
            this.tpOrders.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(3, 3);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(92, 28);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // txtOrderSearch
            // 
            this.txtOrderSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtOrderSearch.Location = new System.Drawing.Point(101, 3);
            this.txtOrderSearch.Name = "txtOrderSearch";
            this.txtOrderSearch.Size = new System.Drawing.Size(1150, 27);
            this.txtOrderSearch.TabIndex = 1;
            this.txtOrderSearch.TextChanged += new System.EventHandler(this.txtOrderSearch_TextChanged);
            // 
            // dgwOrders
            // 
            this.dgwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwOrders.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwOrders.Location = new System.Drawing.Point(3, 34);
            this.dgwOrders.Name = "dgwOrders";
            this.dgwOrders.RowHeadersWidth = 51;
            this.dgwOrders.RowTemplate.Height = 29;
            this.dgwOrders.Size = new System.Drawing.Size(1248, 711);
            this.dgwOrders.TabIndex = 0;
            this.dgwOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOrders_CellContentClick);
            this.dgwOrders.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgwOrders_MouseClick);
            // 
            // tpProducts
            // 
            this.tpProducts.Controls.Add(this.dgwProducts);
            this.tpProducts.Controls.Add(this.txtItemSearch);
            this.tpProducts.Controls.Add(this.lblItemSearch);
            this.tpProducts.Controls.Add(this.lblCatergories);
            this.tpProducts.Controls.Add(this.cbxCategories);
            this.tpProducts.Location = new System.Drawing.Point(4, 29);
            this.tpProducts.Name = "tpProducts";
            this.tpProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tpProducts.Size = new System.Drawing.Size(1254, 748);
            this.tpProducts.TabIndex = 1;
            this.tpProducts.Text = "Products";
            this.tpProducts.UseVisualStyleBackColor = true;
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwProducts.Location = new System.Drawing.Point(3, 55);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 29;
            this.dgwProducts.Size = new System.Drawing.Size(1248, 690);
            this.dgwProducts.TabIndex = 4;
            this.dgwProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgwProducts_MouseClick);
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.Location = new System.Drawing.Point(388, 10);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(319, 27);
            this.txtItemSearch.TabIndex = 3;
            // 
            // lblItemSearch
            // 
            this.lblItemSearch.AutoSize = true;
            this.lblItemSearch.Location = new System.Drawing.Point(317, 14);
            this.lblItemSearch.Name = "lblItemSearch";
            this.lblItemSearch.Size = new System.Drawing.Size(53, 20);
            this.lblItemSearch.TabIndex = 2;
            this.lblItemSearch.Text = "Search";
            // 
            // lblCatergories
            // 
            this.lblCatergories.AutoSize = true;
            this.lblCatergories.Location = new System.Drawing.Point(8, 14);
            this.lblCatergories.Name = "lblCatergories";
            this.lblCatergories.Size = new System.Drawing.Size(80, 20);
            this.lblCatergories.TabIndex = 1;
            this.lblCatergories.Text = "Categories";
            // 
            // cbxCategories
            // 
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(94, 10);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(207, 28);
            this.cbxCategories.TabIndex = 0;
            this.cbxCategories.SelectedValueChanged += new System.EventHandler(this.cbxCategories_SelectedValueChanged);
            // 
            // tpSuppliers
            // 
            this.tpSuppliers.Location = new System.Drawing.Point(4, 29);
            this.tpSuppliers.Name = "tpSuppliers";
            this.tpSuppliers.Size = new System.Drawing.Size(1254, 748);
            this.tpSuppliers.TabIndex = 2;
            this.tpSuppliers.Text = "Suppliers";
            this.tpSuppliers.UseVisualStyleBackColor = true;
            // 
            // tpEmployees
            // 
            this.tpEmployees.Location = new System.Drawing.Point(4, 29);
            this.tpEmployees.Name = "tpEmployees";
            this.tpEmployees.Size = new System.Drawing.Size(1254, 748);
            this.tpEmployees.TabIndex = 3;
            this.tpEmployees.Text = "Employees";
            this.tpEmployees.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Location = new System.Drawing.Point(1118, 795);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 47);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmsMain
            // 
            this.cmsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdd,
            this.toolStripSeparator1,
            this.tsmUpdate,
            this.tsmExamine,
            this.tsmDelete});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(135, 106);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(134, 24);
            this.tsmAdd.Text = "Add";
            this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // tsmUpdate
            // 
            this.tsmUpdate.Name = "tsmUpdate";
            this.tsmUpdate.Size = new System.Drawing.Size(134, 24);
            this.tsmUpdate.Text = "Update";
            this.tsmUpdate.Click += new System.EventHandler(this.tsmUpdate_Click);
            // 
            // tsmExamine
            // 
            this.tsmExamine.Name = "tsmExamine";
            this.tsmExamine.Size = new System.Drawing.Size(134, 24);
            this.tsmExamine.Text = "Examine";
            this.tsmExamine.Click += new System.EventHandler(this.tsmExamine_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(134, 24);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 858);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMain.ResumeLayout(false);
            this.tpOrders.ResumeLayout(false);
            this.tpOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).EndInit();
            this.tpProducts.ResumeLayout(false);
            this.tpProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.TabPage tpProducts;
        private System.Windows.Forms.TabPage tpSuppliers;
        private System.Windows.Forms.TabPage tpEmployees;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgwOrders;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtOrderSearch;
        private System.Windows.Forms.Label lblItemSearch;
        private System.Windows.Forms.Label lblCatergories;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.TextBox txtItemSearch;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmExamine;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
    }
}