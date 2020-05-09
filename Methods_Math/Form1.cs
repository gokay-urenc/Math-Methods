using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods_Math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deger = Math.PI.ToString();
            MessageBox.Show(deger);
            // MessageBox.Show(Math.PI.ToString()); // Değişken atamadan tek seferde olur.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mutlak_deger = Math.Abs(-45);
            MessageBox.Show(mutlak_deger.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double deger = Math.Floor(12.98);
            MessageBox.Show(deger.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double deger = Math.Ceiling(12.98);
            MessageBox.Show(deger.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double deger = Math.Round(12.45);
            MessageBox.Show(deger.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double deger = Math.Truncate(14.23);
            MessageBox.Show(deger.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int deger = Math.Max(545, 647);
            MessageBox.Show(deger.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int deger = Math.Min(545, 647);
            MessageBox.Show(deger.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double deger = Math.Pow(3, 4);
            MessageBox.Show(deger.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double deger = Math.Sqrt(15);
            MessageBox.Show(deger.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int deger = Math.Sign(-25);
            switch (deger)
            {
                case -1:
                    MessageBox.Show("Sayı negatiftir.");
                    break;
                case 1:
                    MessageBox.Show("Sayı pozitiftir.");
                    break;
                case 0:
                    MessageBox.Show("Sayı 0'a eşittir.");
                    break;
            }
        }
    }
}
// Math Class'ı hazır matematiksel fonksiyonları sunan sınıftır. Yuvarlama, pi bilgisi,    karekök, kuvvet, vs.

// Math.PI: Pi sayısı bilgisini gösterir.

// Math.Abs: Mutlak değer alır.

// Math.Floor: Verilen ondalıklı değeri bir alt tam sayıya tamamlar.

// Math.Ceiling: Verilen ondalıklı değeri bir üst tam sayıya tamamlar.

// Math.Round: Sayının yarısından fazlasını bir üste, yarısından azını bir alttaki tam     sayıya yuvarlar. Noktadan önceki sayı çift ise bir alt değere, tek ise bir üst değere   tamamlar.(Bu olay noktadan sonraki değer 50 ise olur).

// Math.Truncate: Sayının ondalıklı kısmına bakmaz, yalnızca tam kısmını teslim eder.

// Math.Max: İki sayı karşılaştırmasında en büyük olanı teslim eder.

// Math.Min: İki sayı karşılaştırmasında en küçük olanı teslim eder.

// Math.Pow: Kuvvet alma işlemini gerçekleştirir. İlk parametrede hangi sayının kuvveti    alınacak, ikinci parametrede ise o sayının kaçıncı kuvveti alınacak diye sorar.

// Math.Sqrt: Karekök alma işlemini gerçekleştirir.

// Math.Sign: Bir sayının negatif, pozitif ya da 0'a eşit olup olmdığıyla ilgili bildirim  döner. Eğer sayı negatifse -1, pozitifse 1, 0 ise 0 değerini döner.