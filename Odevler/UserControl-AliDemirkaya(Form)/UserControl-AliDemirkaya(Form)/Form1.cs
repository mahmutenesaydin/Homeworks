using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl_AliDemirkaya_Form_
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
    //    TurkeyProvincesEntities1 db = new TurkeyProvincesEntities1();
        DataClasses1DataContext dc = new DataClasses1DataContext();
        List<UserDetails> listele = new List<UserDetails>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Satir = 0;
            Sutun = 0;

            //foreach (var tr in dc.Villages)
            //{
            //  Yerlestir(resims.ResimGetirme(tr.Images.ToArray()), tr.VillageName + " " + tr.PopulationID, tr.VillageID);
            //}


            foreach (var tr in dc.Villages)
            {
                Yerlestir(resims.ResimGetirme(tr.Images.ToArray()), tr.VillageName,/* tr.PopulationID.ToString(), */tr.VillageID);
            }
        }

        public void Yerlestir(Image resim, string isim, /*string nufus,*/ int id)
        {
            UserDetails user = new UserDetails();
            user.pictureBox1.Image = resim;
            user.label1.Text = isim;
        /*    user.label2.Text = nufus;*/
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
    }
}
