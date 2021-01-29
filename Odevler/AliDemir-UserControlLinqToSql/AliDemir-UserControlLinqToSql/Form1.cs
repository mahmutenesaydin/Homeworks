using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliDemir_UserControlLinqToSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Satir { get; set; }
        public int Sutun { get; set; }
        Resimler resims = new Resimler();
        DataClasses1DataContext db = new DataClasses1DataContext();
        List<UserDetails> listele = new List<UserDetails>();

        public void Yerlestir(Image resim, string isim, string nufus, int id)
        {
            UserDetails user = new UserDetails();
            user.pictureBox1.Image = resim;
            user.lblName.Text = isim;
            user.lblTitle.Text = nufus;
            user.bunifuThinButton21.Tag = id;
            listele.Add(user);
            user.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(user, Satir, Sutun);
            Sutun += 1;
            if (Sutun == 3)
            {
                Satir += 1;
                Sutun = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Satir = 0;
            Sutun = 0;

            foreach (var tr in db.Provinces)
            {
                Yerlestir(resims.ResimGetirme(tr.Images.ToArray()), tr.ProvinceName + " " + tr.PopulationID, tr.ProvinceID);
            }
        }
    }
}
