namespace SampleWinForms.View
{
    partial class OrderDetails
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cbxCustomer = new System.Windows.Forms.ComboBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblReqDate = new System.Windows.Forms.Label();
            this.lblShipDate = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this.cbxShipper = new System.Windows.Forms.ComboBox();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.dtpRequired = new System.Windows.Forms.DateTimePicker();
            this.dtpShip = new System.Windows.Forms.DateTimePicker();
            this.dgwOrfLine = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.lblShipName = new System.Windows.Forms.Label();
            this.lblFreight = new System.Windows.Forms.Label();
            this.mtxtFreight = new System.Windows.Forms.MaskedTextBox();
            this.cmsItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrfLine)).BeginInit();
            this.cmsItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(23, 27);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(72, 20);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer";
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(119, 19);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(151, 28);
            this.cbxCustomer.TabIndex = 1;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(291, 27);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(83, 20);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(23, 73);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(75, 20);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Employee";
            // 
            // lblReqDate
            // 
            this.lblReqDate.AutoSize = true;
            this.lblReqDate.Location = new System.Drawing.Point(291, 73);
            this.lblReqDate.Name = "lblReqDate";
            this.lblReqDate.Size = new System.Drawing.Size(105, 20);
            this.lblReqDate.TabIndex = 4;
            this.lblReqDate.Text = "Required Date";
            // 
            // lblShipDate
            // 
            this.lblShipDate.AutoSize = true;
            this.lblShipDate.Location = new System.Drawing.Point(300, 114);
            this.lblShipDate.Name = "lblShipDate";
            this.lblShipDate.Size = new System.Drawing.Size(74, 20);
            this.lblShipDate.TabIndex = 5;
            this.lblShipDate.Text = "Ship Date";
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(24, 114);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(89, 20);
            this.lblShipping.TabIndex = 6;
            this.lblShipping.Text = "Shipped Via";
            // 
            // cbxEmployee
            // 
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Location = new System.Drawing.Point(119, 65);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(151, 28);
            this.cbxEmployee.TabIndex = 7;
            // 
            // cbxShipper
            // 
            this.cbxShipper.FormattingEnabled = true;
            this.cbxShipper.Location = new System.Drawing.Point(119, 106);
            this.cbxShipper.Name = "cbxShipper";
            this.cbxShipper.Size = new System.Drawing.Size(151, 28);
            this.cbxShipper.TabIndex = 8;
            // 
            // dtpOrder
            // 
            this.dtpOrder.Location = new System.Drawing.Point(411, 22);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(273, 27);
            this.dtpOrder.TabIndex = 9;
            // 
            // dtpRequired
            // 
            this.dtpRequired.Location = new System.Drawing.Point(411, 63);
            this.dtpRequired.Name = "dtpRequired";
            this.dtpRequired.Size = new System.Drawing.Size(273, 27);
            this.dtpRequired.TabIndex = 10;
            // 
            // dtpShip
            // 
            this.dtpShip.Location = new System.Drawing.Point(411, 112);
            this.dtpShip.Name = "dtpShip";
            this.dtpShip.Size = new System.Drawing.Size(273, 27);
            this.dtpShip.TabIndex = 11;
            // 
            // dgwOrfLine
            // 
            this.dgwOrfLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrfLine.Location = new System.Drawing.Point(6, 408);
            this.dgwOrfLine.Name = "dgwOrfLine";
            this.dgwOrfLine.RowHeadersWidth = 51;
            this.dgwOrfLine.RowTemplate.Height = 29;
            this.dgwOrfLine.Size = new System.Drawing.Size(696, 221);
            this.dgwOrfLine.TabIndex = 12;
            this.dgwOrfLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgwOrfLine_MouseClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(608, 649);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 649);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(20, 374);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(45, 20);
            this.lblDetails.TabIndex = 15;
            this.lblDetails.Text = "Items";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(20, 249);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(99, 31);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(428, 338);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(87, 20);
            this.lblCode.TabIndex = 17;
            this.lblCode.Text = "Postal Code";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(222, 337);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(48, 20);
            this.lblStreet.TabIndex = 18;
            this.lblStreet.Text = "Street";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(222, 299);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 20);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = "City";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(20, 334);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(56, 20);
            this.lblRegion.TabIndex = 20;
            this.lblRegion.Text = "Region";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(20, 299);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(60, 20);
            this.lblCountry.TabIndex = 21;
            this.lblCountry.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(88, 292);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(125, 27);
            this.txtCountry.TabIndex = 22;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(287, 292);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(125, 27);
            this.txtCity.TabIndex = 23;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(287, 331);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(125, 27);
            this.txtStreet.TabIndex = 24;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(88, 331);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(125, 27);
            this.txtRegion.TabIndex = 25;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(521, 334);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(163, 27);
            this.txtCode.TabIndex = 26;
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(119, 206);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(151, 27);
            this.txtShipName.TabIndex = 27;
            // 
            // lblShipName
            // 
            this.lblShipName.AutoSize = true;
            this.lblShipName.Location = new System.Drawing.Point(24, 213);
            this.lblShipName.Name = "lblShipName";
            this.lblShipName.Size = new System.Drawing.Size(82, 20);
            this.lblShipName.TabIndex = 29;
            this.lblShipName.Text = "Ship Name";
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.Location = new System.Drawing.Point(24, 165);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(55, 20);
            this.lblFreight.TabIndex = 30;
            this.lblFreight.Text = "Freight";
            // 
            // mtxtFreight
            // 
            this.mtxtFreight.Location = new System.Drawing.Point(119, 165);
            this.mtxtFreight.Mask = "000,00";
            this.mtxtFreight.Name = "mtxtFreight";
            this.mtxtFreight.Size = new System.Drawing.Size(151, 27);
            this.mtxtFreight.TabIndex = 31;
            // 
            // cmsItem
            // 
            this.cmsItem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsItem.Name = "cmsItem";
            this.cmsItem.Size = new System.Drawing.Size(211, 80);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 690);
            this.Controls.Add(this.mtxtFreight);
            this.Controls.Add(this.lblFreight);
            this.Controls.Add(this.lblShipName);
            this.Controls.Add(this.txtShipName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgwOrfLine);
            this.Controls.Add(this.dtpShip);
            this.Controls.Add(this.dtpRequired);
            this.Controls.Add(this.dtpOrder);
            this.Controls.Add(this.cbxShipper);
            this.Controls.Add(this.cbxEmployee);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.lblShipDate);
            this.Controls.Add(this.lblReqDate);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.cbxCustomer);
            this.Controls.Add(this.lblCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrfLine)).EndInit();
            this.cmsItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbxCustomer;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblReqDate;
        private System.Windows.Forms.Label lblShipDate;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.ComboBox cbxShipper;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.DateTimePicker dtpRequired;
        private System.Windows.Forms.DateTimePicker dtpShip;
        private System.Windows.Forms.DataGridView dgwOrfLine;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.Label lblShipName;
        private System.Windows.Forms.Label lblFreight;
        private System.Windows.Forms.MaskedTextBox mtxtFreight;
        private System.Windows.Forms.ContextMenuStrip cmsItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}