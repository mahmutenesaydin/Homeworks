using BussinesLayer;
using DataLayer;
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

        CustomerDatabaseBusiness cdb = new CustomerDatabaseBusiness();

        BankaDBEntities bankdb = new BankaDBEntities();

        private void ListCustomer()
        {
         

            var customer = (from c in bankdb.Customers
                            select new
                            {
                                c.CustomerID,
                                c.FirstName,
                                c.LastName,
                                c.Email,
                                c.IdentityNumber,
                                c.PhoneNumber
                            }).ToList();
            dataGridView1.DataSource = customer;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Customer c = new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                IdentityNumber = mskIdentityNumber.Text.ToString(),
                PhoneNumber = mskPhoneNumber.Text.ToString()
            };
            cdb.Create(c);
            ListCustomer();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ListCustomer();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        { 
            Customer c = cdb.Read(Convert.ToInt32(txtID.Text));

            c.CustomerID = Convert.ToInt32(txtID.Text);
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;
            c.Email = txtEmail.Text;
            c.IdentityNumber = mskIdentityNumber.Text.ToString();
            c.PhoneNumber = mskPhoneNumber.Text.ToString();
            cdb.Update(c);
            ListCustomer();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {  
            cdb.Delete(Convert.ToInt32(txtID.Text));
            ListCustomer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCustomer();
        }
    }
}
