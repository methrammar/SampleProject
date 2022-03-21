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
    public partial class AddOrderProduct : Form
    {
        private Action<Detail> returnData;
        private Detail itemOut;
        List<Product> products = new List<Product>();
        public AddOrderProduct(Action<Detail> item)
        {
            InitializeComponent();
            itemOut = new Detail();
            returnData = item;
            using(ProductService service = new ProductService())
            {
                products = service.GetList();
            }

            cbxItem.DataSource = products;
            cbxItem.DisplayMember = "name";
            if(cbxItem.ValueMember ==null)
                cbxItem.ValueMember = "id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try 
            { 
                itemOut.productId = (int)((Product)cbxItem.SelectedItem).id;
                itemOut.quantity = Convert.ToDouble(txtQuantity.Text);
                itemOut.discount= Convert.ToDouble(txtDiscount.Text);
                itemOut.unitPrice = Convert.ToDouble(txtPrice.Text);
                returnData(itemOut);

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
