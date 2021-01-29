using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorsAlfabesiOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            string document = txtMetin.Text;
            char[] chars = document.ToCharArray();
            var factory = new CharacterFactory();
            foreach (char c in chars)
            {
               var character = factory[c];
                character.Display(txtMorse);
            }
        }
    }
}
