using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace String_Metodları_1
{
    public partial class Form1 : Form
    {
        string kelime;

        string kelime2 = "Industryolog Akademi"; // Tanımlama yapılırken çift tırnak kullanıldığı unutulmamalıdır.


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ToString Metodu

            int s1 = 10;

            label2.Text = s1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text; // textboxtan gelen değeri a değişkenine atadık.

            string b = string.Copy(a); // a değişkenindeki değeri b değişkenine kopyaladık.

            label3.Text = b; // türümüz zaten string olduğu için ekstra dönüşüme ihtiyaç duymadık.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string c = textBox2.Text; // c değeri
            string d = textBox3.Text; // d değeri
             
            label6.Text = string.Concat(c,d); // c ve d değerlerini birleştirip label a yazdırdık.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string f = textBox4.Text; // f değeri
            string g = textBox5.Text; // g değeri

            g = string.Empty; // g nin içini boşalttık.

            label7.Text = string.Concat(f, g); // c ve d değerlerini birleştirip label a yazdırdık.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string h = textBox6.Text;
            string j = textBox7.Text;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); /* bu kodları kullanabilmek için system.Globalization
                                                                             * ve system.Threading uzayları projeye eklenmelidir.
                                                                             * Kodumuzun yaptığı işlem ise program için kullanabileceği kültür 
                                                                             * ayarlarını tanımladı.
                                                                             
                                                                             */
                                                                          

            int v = string.Compare(h,j,StringComparison.InvariantCultureIgnoreCase);

            if (v<0)
            {
                label10.Text = "1. ifade 2. ifadeden kısadır.";
            }

            else if (v == 0)
            {
                label10.Text = "Kelimelerin uzunlukları eşittir.";
            }

            else
            {
                label10.Text = "1. ifade 2. ifadeden uzundur.";
            }
        }

        
    }
}
