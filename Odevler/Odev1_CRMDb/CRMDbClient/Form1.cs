using CRMDbClient.ProductServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMDbClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDataServiceSoapClient client = new ProductDataServiceSoapClient("ProductDataServiceSoap");

        private void Listele()
        {
            string key = client.Login("admin", "1");
            dataGridView1.DataSource = client.List(key);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            client.Insert(new AutoHeader { UserName = "admin", Password = "1" },
                txtName.Text,
                Convert.ToDouble(txtPrice.Text),
                Convert.ToInt32(txtStock.Text));
            Listele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            client.Update(new AutoHeader { UserName = "admin", Password = "1" },
                Convert.ToInt32(txtId.Text),
                txtName.Text,
                Convert.ToDouble(txtPrice.Text),
                Convert.ToInt32(txtStock.Text));
            Listele();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            client.Delete(new AutoHeader { UserName = "admin", Password = "1" },
                Convert.ToInt32(txtId.Text));
            Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
        }
    }
}
