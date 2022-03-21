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
            cbxCustomer.ValueMember = "id";
            cbxCustomer.DisplayMember = "companyName";
            cbxCustomer.DataSource = _customers;

            cbxEmployee.ValueMember = "id";
            cbxEmployee.DisplayMember = "firstName";
            cbxEmployee.DataSource = _employees;

            cbxShipper.ValueMember = "id";
            cbxShipper.DisplayMember = "companyName";
            cbxShipper.DataSource = _shippers;
            
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
            else
            {
                _order = new Order();
            }

            if(_openType == OpenType.Examine)
            {
                cbxCustomer.Enabled = false;
                cbxEmployee.Enabled = false;
                cbxShipper.Enabled = false;
                dtpOrder.Enabled = false;
                dtpRequired.Enabled = false;
                dtpShip.Enabled = false;
                txtCity.Enabled = false;
                txtCode.Enabled=false;
                txtCountry.Enabled=false;
                mtxtFreight.Enabled=false;
                txtRegion.Enabled=false;
                txtShipName.Enabled=false;
                txtStreet.Enabled=false;
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
                    case OpenType.Examine:
                        this.Close();
                        break;
                    case OpenType.Create:
                        using (OrderService service = new OrderService())
                        {
                            Order order = new Order()
                            {
                                id = _order.id == null ? 0:_order.id,
                                customerId = ((Customer)cbxCustomer.SelectedItem).id,
                                employeeId = (int)((Employee)cbxEmployee.SelectedItem).id,
                                shipVia = (int)((Shipper)cbxShipper.SelectedItem).id,
                                orderDate = dtpOrder.Value,
                                requiredDate = dtpRequired.Value,
                                shippedDate = dtpShip.Value,
                                freight = Convert.ToDouble(mtxtFreight.Text),
                                shipName = txtShipName.Text,
                                details = (List<Detail>)dgwOrfLine.DataSource
                            };
                            Address address = new Address
                            {
                                country = txtCountry.Text,
                                city = txtCity.Text,
                                street = txtStreet.Text,
                                postalCode = txtCode.Text,
                                region = txtRegion.Text
                            };
                            order.shipAddress = address;
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
                                freight=Convert.ToDouble(mtxtFreight.Text),
                                shipName = txtShipName.Text,
                                details = (List<Detail>)dgwOrfLine.DataSource
                            };
                            Address address = new Address
                            {
                                country=txtCountry.Text,
                                city=txtCity.Text,
                                street=txtStreet.Text,
                                postalCode=txtCode.Text,
                                region=txtRegion.Text
                            };
                            order.shipAddress = address;

                            service.Update(order);
                        }
                        break;
                }
                this.Close();
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

        private void dgwOrfLine_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && _openType != OpenType.Examine)
                cmsItem.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detail newItem = new Detail();
            using(Form frm = new AddOrderProduct((d) => { newItem = d; }))
            {
                frm.ShowDialog();

                _order.details.Add(newItem);
                dgwOrfLine.DataSource = _order.details;
                dgwOrfLine.Refresh();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _order.details.Remove((Detail)dgwOrfLine.CurrentRow.DataBoundItem);
            dgwOrfLine.DataSource = _order.details;
            dgwOrfLine.Refresh();
        }
    }
}
