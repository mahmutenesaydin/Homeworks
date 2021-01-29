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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        ServiceReference1.ServiceContractClient client = new ServiceReference1.ServiceContractClient();

        private void List()
        {
            dgvCategory.DataSource = client.ListCategory();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            client.AddCategory(new ServiceReference1.Category
            {
                CategoryName = txtCategoryName.Text,
                Description = txtCategoryDiscr.Text
            });
            List();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            client.UpdateCategory(new ServiceReference1.Category
            {
                CategoryID = Convert.ToInt32(txtCategoryID.Text),
                CategoryName=txtCategoryName.Text,
                Description=txtCategoryDiscr.Text               
            });
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            client.DeleteCategory(Convert.ToInt32(txtCategoryID.Text));
            List();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsForm prod = new ProductsForm();
            prod.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierForm sup = new SupplierForm();
            sup.Show();
        }
    }
}
