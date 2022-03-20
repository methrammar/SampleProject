using SampleServices.Model;
using SampleServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SampleWinForms.Controller.MainController;

namespace SampleWinForms.View
{
    public partial class OrderDetails : Form
    {
        #region Class Variables
        Order? _order;
        List<Product> _products;
        List<Employee> _employees;
        List<Shipper> _shippers;
        List<Customer> _customers;
        OpenType _openType;
        #endregion

        #region cTor
        public OrderDetails(Order? order, List<Product> products, List<Employee> employees, List<Shipper> shippers, List<Customer> customers, OpenType type)
        {
            InitializeComponent();
            _order = order;
            _products = products;
            _employees = employees;
            _shippers = shippers;
            _customers = customers;
            _openType = type;
            LoadComponents();
        }
        #endregion

        #region Functions

        private void LoadComponents()
        {
            cbxCustomer.DataSource = _customers;
            cbxCustomer.ValueMember = "id";
            cbxCustomer.DisplayMember = "companyName";

            cbxEmployee.DataSource = _employees;
            cbxEmployee.ValueMember = "id";
            cbxEmployee.DisplayMember = "firstName";

            cbxShipper.DataSource = _shippers;
            cbxShipper.ValueMember = "id";
            cbxShipper.DisplayMember = "companyName";
            
            if (_order != null) 
            { 
                dgwOrfLine.DataSource = _order.details;
                dgwOrfLine.ReadOnly = true;
                cbxCustomer.SelectedItem = _customers.FirstOrDefault(p => p.id == _order.customerId);
                cbxEmployee.SelectedItem = _employees.FirstOrDefault(p => p.id == _order.employeeId);
                cbxShipper.SelectedItem = _shippers.FirstOrDefault(p => p.id == _order.shipVia);

                dtpOrder.Value = _order.orderDate== null ? DateTime.Today : (DateTime)_order.orderDate;
                dtpRequired.Value = _order.requiredDate == null ? DateTime.Today : (DateTime)_order.requiredDate;
                dtpShip.Value = _order.shippedDate == null ? DateTime.Today : (DateTime)_order.shippedDate;
            }

            if(_openType == OpenType.Analyze)
            {
                cbxCustomer.Enabled = false;
                cbxEmployee.Enabled = false;
                cbxShipper.Enabled = false;
                dtpOrder.Enabled = false;
                dtpRequired.Enabled = false;
                dtpShip.Enabled = false;

            }
        }

        #endregion

        #region Form Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_openType)
                {
                    case OpenType.Analyze:
                        this.Close();
                        break;
                    case OpenType.Create:
                        using (OrderService service = new OrderService())
                        {
                            Order order = new Order()
                            {
                                customerId = cbxCustomer.ValueMember,
                                employeeId = Convert.ToInt32(cbxEmployee.ValueMember),
                                shipVia = Convert.ToInt32(cbxShipper.ValueMember),
                                orderDate = dtpOrder.Value,
                                requiredDate = dtpRequired.Value,
                                shippedDate = dtpShip.Value,
                                details = (List<Detail>)dgwOrfLine.DataSource
                            };
                            service.Add(order);
                        }
                        break;
                    case OpenType.Alter:
                        using (OrderService service = new OrderService())
                        {
                            Order order = new Order()
                            {
                                id = _order.id,
                                customerId = cbxCustomer.ValueMember,
                                employeeId = Convert.ToInt32(cbxEmployee.ValueMember),
                                shipVia = Convert.ToInt32(cbxShipper.ValueMember),
                                orderDate = dtpOrder.Value,
                                requiredDate = dtpRequired.Value,
                                shippedDate = dtpShip.Value,
                                details = (List<Detail>)dgwOrfLine.DataSource
                            };
                            service.Update(order);
                        }
                        break;
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
        #endregion

    }
}
