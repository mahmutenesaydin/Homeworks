using BusinessLayer;
using DataLayer;
using PresentationLayer.Bridge;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Productss productModel = new Productss
        {
            ProductObject = new ProductsObjects()
        };

        ProductsDataBusiness pdb = new ProductsDataBusiness();

        private void Listele()
        {
            dgvproducts.DataSource = pdb.execadapter("SP_Select");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertProducts insertProduct = new InsertProducts();
            insertProduct.name = txtname.Text;
            insertProduct.price = txtprice.Text;
            insertProduct.stock = txtstock.Text;
            insertProduct.CRUD();
            Listele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProducts updatep = new UpdateProducts();
            updatep.ID = Convert.ToInt32(txtid.Text);
            updatep.name = txtname.Text;
            updatep.price = txtprice.Text;
            updatep.stock = txtstock.Text;
            updatep.CRUD();
            Listele();
        }

        private void Temizle()
        {
            foreach (Control c in grpcrud.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProducts deletep = new DeleteProducts();
            deletep.ID = Convert.ToInt32(txtid.Text);
            deletep.CRUD();
            Listele();
            Temizle();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in grpcrud.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private void btnonceki_Click(object sender, EventArgs e)
        {
            dgvproducts.DataSource = productModel.Show();
            Product prod = productModel.Onceki;
            txtid.Text = prod.Id.ToString();
            txtname.Text = prod.Name;
            txtprice.Text = prod.Price.ToString();
            txtstock.Text = prod.Stock.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {

            dgvproducts.DataSource = productModel.Show();
            Product prod = productModel.Sonraki;
            txtid.Text = prod.Id.ToString();
            txtname.Text = prod.Name;
            txtprice.Text = prod.Price.ToString();
            txtstock.Text = prod.Stock.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grpcrud_Enter(object sender, EventArgs e)
        {

        }
    }
}
