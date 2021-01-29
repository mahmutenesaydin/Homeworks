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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        ServiceReference1.ServiceContractClient client = new ServiceReference1.ServiceContractClient();

        private void List()
        {
            dgvSupplier.DataSource = client.ListSupplier();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            client.AddSupplier(new ServiceReference1.Supplier
            {
                CompanyName = txtCompanyName.Text,
                ContactTitle = txtContacTitle.Text,
                Address = txtAddress.Text,
                ContactName = txtContactName.Text
            });
            List();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            client.UpateSupplier(new ServiceReference1.Supplier
            {
                SupplierID=Convert.ToInt32(txtSupplierID.Text),
                CompanyName = txtCompanyName.Text,
                ContactTitle = txtContacTitle.Text,
                Address = txtAddress.Text,
                ContactName = txtContactName.Text
            });
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            client.DeleteSupplier(Convert.ToInt32(txtSupplierID.Text));
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoriesForm cat = new CategoriesForm();
            cat.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsForm prod = new ProductsForm();
            prod.Show();
        }
    }
}
