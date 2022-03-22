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

namespace SampleWinForms.View
{
    public partial class AddCustomer : Form
    {
        
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(CustomerService service = new CustomerService())
            {
                Customer customer = new Customer()
                {
                    companyName = txtCompName.Text,
                    contactName = txtContName.Text,
                    contactTitle = txtContTitle.Text,
                    address =
                    {
                        city= txtCity.Text,
                        region=txtRegion.Text,
                        country=txtCountry.Text,
                        phone=txtPhone.Text,
                        postalCode=txtPCode.Text,
                        street=txtStreet.Text
                    }
                };

                service.Add(customer);
            }
        }
    }
}
