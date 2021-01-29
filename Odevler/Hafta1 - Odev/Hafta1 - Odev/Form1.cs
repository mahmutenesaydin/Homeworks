using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta1___Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DatabaseBusiness db = new DatabaseBusiness();

        private void ProductsList()
        {
            dgvProducts.DataSource = db.ExecuteAdapter("SP_Select");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductsList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrand.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtStock.Text))
            {
                MessageBox.Show("Lütfen bilgileri doldurun!", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r = MessageBox.Show("Bilgiler kaydedilecek. Emin misiniz?", "KAYIT ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (r)
                {
                    case DialogResult.Yes:
                        db.ExecuteCommand("SP_Insert", new SqlParameter[]
                        {   new SqlParameter("@Brand",txtBrand.Text),
                            new SqlParameter("@Name", txtName.Text),
                            new SqlParameter("@Price", txtPrice.Text),
                            new SqlParameter("@Stock",txtStock.Text)
                        });
                        ProductsList();
                        break;
                }
            }
        }
    }
}
