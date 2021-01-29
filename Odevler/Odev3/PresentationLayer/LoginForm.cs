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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        ServiceReference1.ServiceContractClient client = new ServiceReference1.ServiceContractClient();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (client.Login(txtUserName.Text, txtPassword.Text) == true)
            {
                MessageBox.Show("Giriş Başarılı");
                menuStrip1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Giriş Başarısız !!!!");
            }
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

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierForm sup = new SupplierForm();
            sup.Show();
        }
    }
}
