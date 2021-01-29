using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliDemirkaya_FormTasarımı1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     //   TurkeyProvincesEntities db = new TurkeyProvincesEntities();
        DataClasses1DataContext dc = new DataClasses1DataContext();
        Resimleme res = new Resimleme();

        public void KoyEkle()
        {
            Village koy = new Village();
            koy.VillageName = textBox1.Text; 
            koy.TownID = (int)comboBox1.SelectedValue;
            koy.PopulationID = Convert.ToInt32(textBox2.Text);
            koy.Images = res.ResimYukleme(pictureEdit1.Image);
            dc.Villages.InsertOnSubmit(koy);
            dc.SubmitChanges();
          //  MessageBox.Show("Köy Eklendi");


            Province il = new Province();
            il.ProvinceName = txtil.Text;
            il.PopulationID = Convert.ToInt32(textBox5.Text);
            il.PlateCode = Convert.ToInt32(textBox6.Text);
            il.Images = res.ResimYukleme(pictureEdit2.Image);
            dc.Provinces.InsertOnSubmit(il);
            dc.SubmitChanges();


            Town ilce = new Town();
            ilce.TownName = textBox7.Text;
            ilce.ProvinceID = (int)comboBox3.SelectedValue;
            ilce.PopulationID = Convert.ToInt32(textBox8.Text);
            ilce.Images = res.ResimYukleme(pictureEdit3.Image);
            dc.Towns.InsertOnSubmit(ilce);
            dc.SubmitChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KoyEkle(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = dc.Towns;
            comboBox1.ValueMember = "TownID";
            comboBox1.DisplayMember = "TownName";

            comboBox3.DataSource = dc.Provinces;
            comboBox3.ValueMember = "ProvinceID";
            comboBox3.DisplayMember = "ProvinceName";
        }
    }
}
