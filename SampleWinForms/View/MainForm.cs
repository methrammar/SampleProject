﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleServices.Model;
using SampleServices.Services;
using static SampleWinForms.Controller.MainController;

namespace SampleWinForms.View
{
    internal partial class MainForm : Form
    {
        #region class variables

        List<Product> products;
        List<Order> orders;
        List<Category> categories;
        List<Customer> customers;
        List<Shipper> shippers;
        List<Supplier> suppliers;
        List<Employee> employees;

        #endregion

        #region cTor
        public MainForm()
        {
            InitializeComponent();
            RefreshForm();

        }

        #endregion

        #region Form Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            dgwOrders.DataSource = orders;
            dgwOrders.ReadOnly = true;
            dgwProducts.DataSource = products;
            dgwProducts.ReadOnly = true;
            cbxCategories.DataSource = categories;
            cbxCategories.DisplayMember = "name";
            cbxCategories.ValueMember = "id";
        }

        private void txtOrderSearch_TextChanged(object sender, EventArgs e)
        {
            dgwOrders.DataSource = orders.Where(p => p.customerId.ToUpper().Trim().Contains(txtOrderSearch.Text.ToUpper().Trim())).ToList();
            dgwOrders.Refresh();
        }

        private void dgwOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                Order selected = (Order)dgwOrders.CurrentRow.DataBoundItem;
                if (selected != null)
                    using (Form form = new OrderDetails(selected, products, employees, shippers, customers, OpenType.Alter))
                    {
                        form.ShowDialog();
                        RefreshForm();
                    }
                else
                {
                    using (Form form = new OrderDetails(null, products, employees, shippers, customers, OpenType.Create))
                    {
                        form.ShowDialog();
                        RefreshForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            dgwProducts.DataSource= products.Where(p=>p.categoryId == cbxCategories.SelectedIndex).ToList();
        }

        private void tsmAdd_Click(object sender, EventArgs e)
        {
            switch (tcMain.SelectedIndex)
            {
                case 0:
                    using (Form form = new OrderDetails(null, products, employees, shippers, customers, OpenType.Create))
                    {
                        form.ShowDialog();
                        RefreshForm();
                    }
                    break;
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
        private void tsmUpdate_Click(object sender, EventArgs e)
        {
            switch (tcMain.SelectedIndex)
            {
                case 0:
                    Order selected = (Order)dgwOrders.CurrentRow.DataBoundItem;
                    using (Form form = new OrderDetails(selected, products, employees, shippers, customers, OpenType.Alter))
                    {
                        form.ShowDialog();
                        RefreshForm();
                    }
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

        private void tsmExamine_Click(object sender, EventArgs e)
        {
            switch (tcMain.SelectedIndex)
            {
                case 0:
                    Order selected = (Order)dgwOrders.CurrentRow.DataBoundItem;
                    using (Form form = new OrderDetails(selected, products, employees, shippers, customers, OpenType.Analyze))
                    {
                        form.ShowDialog();
                        RefreshForm();
                    }
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            switch (tcMain.SelectedIndex)
            {
                case 0:
                    Order selected = (Order)dgwOrders.CurrentRow.DataBoundItem;
                    using (OrderService orderService = new OrderService())
                    {
                        orderService.Delete(selected);
                        RefreshForm();
                    }
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
        private void dgwOrders_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                cmsMain.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void dgwProducts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                cmsMain.Show(Cursor.Position.X, Cursor.Position.Y);
        }
        #endregion

        #region Functions

        public void RefreshForm()
        {
            try 
            {                
                using(ProductService productService = new ProductService()) 
                    products = productService.GetList();
                using (OrderService orderService = new OrderService())
                    orders = orderService.GetList();
                using (CategoryService categoryService = new CategoryService())
                    categories = categoryService.GetList();
                using (CustomerService CustomerService = new CustomerService())
                    customers = CustomerService.GetList();
                using (ShipperService shipperService = new ShipperService())
                    shippers = shipperService.GetList();
                using(SupplierService supplierService = new SupplierService())
                     suppliers = supplierService.GetList();
                using (EmployeeService employeeService = new EmployeeService())
                    employees = employeeService.GetList();

                foreach(var item in orders)
                {
                    item.customer= customers.Find(p=>p.id == item.customerId).companyName;
                    item.employee = employees.Find(p => p.id == item.employeeId).firstName;
                    item.shippingCompany = shippers.Find(p => p.id == item.shipVia).CompanyName;
                    foreach (Detail detail in item.details)
                    {
                        detail.productName = products.Find(p => p.id == detail.productId).name;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        #endregion


    }
}