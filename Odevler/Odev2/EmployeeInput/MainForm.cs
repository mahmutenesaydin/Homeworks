using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInput
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm p = new ProductForm();
            p.MdiParent = this;
            p.Show();
        }
        CategoryForm c = new CategoryForm();
        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CategoryForm c = new CategoryForm();
            //c.MdiParent = this;
            //c.Show();

            if (c.IsDisposed)
            {
                c = new CategoryForm();
            }
            c.MdiParent = this;
            c.Show();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm s = new SupplierForm();
            s.MdiParent = this;
            s.Show();
        }
    }
}
