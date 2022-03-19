using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rasgele_sayı
{
    public partial class bolme : Form
    {
        public bolme()
        {
            InitializeComponent();
        }
        //sayac2 = timer2, sayac = timer1, button1 = cevapla, button2 = gönder gelsin, label4 = sayac2
        int  s1, s2, sonuc, tahmin,  sayac2 = 20, puan, hak = 3;

        private void btnodul_Click(object sender, EventArgs e)
        {
            this.Hide();
            odulsepeti odul_ = new odulsepeti();
            odul_.lblpuan.Text = lblPuan.Text;
            odul_.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Focus();
            
            timer2.Stop();
            tahmin = Convert.ToInt32(maskedTextBox1.Text);
            lbltahmin.Text = tahmin.ToString();
            
            button1.Enabled = false;
            button2.Enabled = true;
            maskedTextBox1.Enabled = false;
            if (lbltahmin.Text == lblsonuc.Text )
            {
                this.BackColor = Color.Green;
                puan += 10;
                lblPuan.Text = puan.ToString();
                MessageBox.Show("DOĞRU CEVAP! 10 PUAN KAZANDIN.");
            }
            else
            {
                hak--;
                lblhak.Text = hak.ToString();
                if (hak > 0)
                {
                    this.BackColor = Color.Red;
                    MessageBox.Show("YANLIŞ BİLDİN KRAL");                   
                    
                }

                else if (hak == 0)
                {
                    MessageBox.Show("HAKKIN DOLDU! ELENDİN.");
                    MessageBox.Show("KAZANDIĞIN PUAN: " + puan + "\n" + "ÖDÜL SEPETİNE GİDEBİLİRSİN!");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    btnodul.Enabled = true;
                    maskedTextBox1.Enabled = false;
                }
                
            }
            maskedTextBox1.Text = "";

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2--;
            label4.Text = sayac2.ToString();
            if(sayac2 == 0)
            {
                timer2.Stop();
                sayac2 = 20;               
                button1.Enabled = false;
                button2.Enabled = true;
                MessageBox.Show("süreniz dolmuştur");
                button1.Enabled = false;
                button2.Enabled = false;
                MessageBox.Show("ELENDİN!");
                label4.Text = "20";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Random sayi1 = new Random();
            Random sayi2 = new Random();
            s1 = sayi1.Next(1, 50);
            s2 = sayi2.Next(1, 8);         
             sonuc = s1 / s2;
            lblsonuc.Text = sonuc.ToString();

            if (s1 % s2 == 0)
            {
                lbls1.Text = s1.ToString();
                lbls2.Text = s2.ToString();
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Visible = true;
            button1.Enabled = true;
            timer2.Start();
            timer1.Start();
            this.BackColor = Color.White;
            maskedTextBox1.Enabled = true;
            maskedTextBox1.Focus();
            sayac2 = 20;
            label4.Text = "20";
        }
    }
}
