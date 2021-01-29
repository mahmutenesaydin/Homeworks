using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenemeUserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();
        Resimler resims = new Resimler();
        List<UserControl1> EmpUC = new List<UserControl1>();
        public int SeciliID { get; set; }
        public int Satir { get; set; }
        public int Sutun { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            Satir = 0;
            Sutun = 0;

            foreach (var emp in db.Employees)
            {
                Yerlestir(emp.EmployeeID, emp.FirstName + emp.LastName, resims.ResimGetirme(emp.Photo.ToArray()), emp.Title);
            }
        }

        public void Yerlestir(int empId, string name, Image resim, string etiket)
        {
            UserControl1 empUC = new UserControl1();
            empUC.bunifuThinButton21.Tag = empId;
            empUC.lblName.Text = name;
            empUC.pictureBox1.Image = resim;
            empUC.lblTitle.Text = etiket;
            EmpUC.Add(empUC);
            empUC.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(empUC, Sutun, Satir);
            Sutun += 1;
            if (Sutun == 3)
            {
                Satir += 1;
                Sutun = 0;
            }

        }
    }
}
