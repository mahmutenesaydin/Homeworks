using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        ServiceReference1.ServiceContractClient client = new ServiceReference1.ServiceContractClient();

        private void List()
        {
            dgvProduct.DataSource = client.ListProduct();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            client.AddProduct(new ServiceReference1.Product
            {
                ProductName = txtProductName.Text,
                UnitPrice = Convert.ToDecimal(txtPrice.Text),
                UnıtsInStock = Convert.ToInt16(txtStock.Text)
            });
            List();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            client.UpdateProduct(new ServiceReference1.Product
            {
                ProductID = Convert.ToInt32(txtProductID.Text),
                ProductName = txtProductName.Text,
                UnitPrice = Convert.ToDecimal(txtPrice.Text),
                UnıtsInStock = Convert.ToInt16(txtStock.Text)
            });
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            client.DeleteProduct(Convert.ToInt32(txtProductID.Text));
            List();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoriesForm cat = new CategoriesForm();
            cat.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierForm sup = new SupplierForm();
            sup.Show();
        }
    }
}
