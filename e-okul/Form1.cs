using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace murathocaudemy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
          skisisel kisisel = new skisisel();
            kisisel.isim = textBox1.Text;
            kisisel.SOYAD = textBox2.Text;
            kisisel.bolum = textBox3.Text;
            snot not = new snot();
            not.vize1 = Convert.ToInt32(textBox4.Text)  ;
            not.vize2 = Convert.ToInt32(textBox5.Text);
            not.final = Convert.ToInt32(textBox6.Text);

            int vize1hsp =(not.vize1+not.vize2)*40/100;
            int finalhsp = not.final * 60 / 100;
            int ort=finalhsp+vize1hsp;
            if (ort < 50)
            {
                hesap.Items.Add(kisisel.isim+" "+kisisel.SOYAD+" "+kisisel.bolum+" KALDINIZ NOT ORTALAMANIZ: "+ort);

            }
            else
            {
                hesap.Items.Add(kisisel.isim + " " + kisisel.SOYAD + " " + kisisel.bolum + " GEÇTİNİZ NOT ORTALAMANIZ: " + ort);
            }




        }

      
    }
}
