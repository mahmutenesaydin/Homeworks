using IO___CodeFirst_EntFram.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO___CodeFirst_EntFram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindContext nortContext = new NorthwindContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nortContext.Products.ToList();

            cmbCategory.DataSource = nortContext.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName"; ;
            cmbCategory.ValueMember = "CategoryID";

            cmbSupplier.DataSource = nortContext.Suppliers.ToList();
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "SupplierID";
        }

        //void UrunListele()
        //{
        //    var kategoriListele = nortContext.Products.Join(
        //                    nortContext.Categories,
        //                    u=>u.CategoryID,
        //                    k=>k.CategoryID,
                            
        //        );
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product urun = new Product();
            urun.ProductName = txtProductName.Text;
            urun.UnitPrice = nupPrice.Value;
            urun.UnitsInStock= Convert.ToInt16(nupStock.Value);
            urun.CategoryID = (int)cmbCategory.SelectedValue;
            urun.SupplierID = (int)cmbSupplier.SelectedValue;
            nortContext.Products.Add(urun);
            nortContext.SaveChanges();

            dataGridView1.DataSource = nortContext.Products.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ara = txtSearch.Text;
            dataGridView1.DataSource = nortContext.Products.Where(x => x.ProductName.Contains(ara)).ToList();
        }

        private void radioArtan_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
