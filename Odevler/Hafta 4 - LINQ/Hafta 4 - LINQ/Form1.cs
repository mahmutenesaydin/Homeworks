using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta_4___LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] Ulkeler
        {
            get
            {
                return new string[]
                {

                    "Arnavutluk",
                    "Arjantin",
                    "Belarus",
                    "Bolivya",
                    "Belçika",
                    "Cezayir",
                    "Danimarka",
                    "Dominik",
                    "Etiyopya",
                    "Estonya",
                    "Endonezya",
                    "Fransa",
                    "Fas",
                    "Gamboçya",
                    "Gürcistan",
                    "Hırvatistan",
                    "Honduras",
                    "Irak",
                    "Japonya",
                    "Kamerun",
                    "Kenya",
                    "Litvanya",
                    "Lübnan",
                    "Malezya",
                    "Malta",
                    "Nijer",
                    "Nijerya",
                    "Polonya",
                    "Ruanda",
                    "Rusya",
                    "Sırbistan",
                    "Slovakya",
                    "Türkiye",
                    "Uganda",
                    "Ukrayna",
                    "Venezuella",
                    "Yeni Zelenda",
                    "Yunanistan",
                    "Zambia"
                };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //E Harfi ile başlayanları listeleyiniz.

          //  var result = Ulkeler.Where(ulke => ulke.StartsWith("e", true, CultureInfo.CurrentCulture));


            //2.sırada olan ülkeleri yazın
            IEnumerable<string> result = Ulkeler.Where((p, i) => (i & 0) == 0);

            foreach (var ulke in result)
            {
                listBox1.Items.Add(ulke);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ülkelerin kaç harf olduğunu gösterir

            //IEnumerable<int>result = Ulkeler.Select(ulke => ulke.Length);

            //var result = Ulkeler.Select((u, i) => new { u, i, u.Length });


            /* Ülke adını ve kaç harf olduğu */

            //var result = Ulkeler.Select(u => new
            //{
            //    Ulke=u,                             //Anonim bir tip bu yapı
            //    KarakterSayisi=u.Length
            //});

            //foreach (var ulke in result)
            //{
            //    listBox1.Items.Add(ulke.Ulke + " " + ulke.KarakterSayisi.ToString());
            //}

            /*Ülke isimleri ve isimleri tersten yazma*/

            var result = Ulkeler.Select((u, i) => new
            {
                Ulke = u,
                TUlke = u.TerstenYaz(),
                Index = i,
                KaraterSayisi = u.Length
            });


            foreach (var ulke in result)
            {
                listBox1.Items.Add(ulke.Ulke + " " + ulke.TUlke);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*5 Karakterli ülke isimlerinden 2 tanesini alınız*/

            var result = Ulkeler.Where(ulke => ulke.Length == 5).Take(2);

            foreach (var ulke in result)
            {
                listBox1.Items.Add(ulke);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*Karakter sayısı 3 e eşit olan ülke ismini bulana kadar tüm ülke isimlerini al.*/

            var result = Ulkeler.TakeWhile(ulke => ulke.Length > 3);
            foreach (var ulke in result)
            {
                listBox1.Items.Add(ulke);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = Ulkeler.Skip(3);
            foreach (var ulke in result)
            {
                listBox1.Items.Add(ulke);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /* A ile başlayanları atla*/

            var result = Ulkeler.SkipWhile(ulke => ulke.StartsWith("A"));
            foreach (var ulke in result)
            {
                listBox1.Items.Add(ulke);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*C harfi ile başlayan ülkeri alın K harfi ile başlayan ülkelerle birleştirin.*/

            var result = Ulkeler.Where(ulke => ulke.StartsWith("C") || ulke.StartsWith("K"));

            //var result = Ulkeler.Where(ulke => ulke.StartsWith("C")).Concat(Ulkeler.Where(ulke => ulke.StartsWith("K")));

            foreach (var ulke in result)
            {
                listBox1.Items.Add(ulke);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /* Karakter sayılarına göre sıralayın */

            //küçükten büyüğe
            Ulkeler.OrderBy(ulke => ulke.Length).ToList().ForEach(ulke => listBox1.Items.Add(ulke));

            //büyükten küçüğe
            Ulkeler.OrderByDescending(ulke => ulke.Length).ToList().ForEach(ulke => listBox1.Items.Add(ulke));
        }
    }
}
