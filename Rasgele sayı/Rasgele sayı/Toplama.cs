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
    public partial class Toplama : Form
    {
        public Toplama()
        {
            InitializeComponent();
        }
        int sayi1, sayi2, toplam, tahmin, puan, sayac = 20, hak = 3;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            odulsepeti odul_ = new odulsepeti();
            
            odul_.lblpuan.Text = lblPuan.Text;
            odul_.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label4.Text = sayac.ToString();

            if (sayac == 0)
            {
                timer1.Stop();
                button1.Enabled = false;
                button2.Enabled = true;
                maskedTextBox1.Enabled = false;
                MessageBox.Show("SÜRE DOLDU!");
                button1.Enabled = false;
                button2.Enabled = false;
                MessageBox.Show("ELENDİN!");
                sayac = 20;
                label4.Text = "20";
            }
                
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            tahmin = Convert.ToInt32(maskedTextBox1.Text);
            lbltahmin.Text = tahmin.ToString();
            timer1.Stop();
            lbltahmin.Visible = true;
            button1.Enabled = false;
            maskedTextBox1.Enabled = false;
            button2.Enabled = true;
            button2.Focus();
            if (lblsonuc.Text == lbltahmin.Text)
            {
                this.BackColor = Color.Green;
                MessageBox.Show("Tebrikler! 10 PUAN KAZANDIN!");
                puan += 10;
                lblPuan.Text = puan.ToString();              
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

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Random s1 = new Random();
            Random s2 = new Random();

            sayi1 = s1.Next(50);
            sayi2 = s2.Next(25);
            toplam = sayi1 + sayi2;

            lbls1.Text = sayi1.ToString();
            lbls2.Text = sayi2.ToString();

            lblsonuc.Text = toplam.ToString();
            lbltahmin.Visible = false;
            button2.Enabled = false;
            button1.Visible = true;
            button1.Enabled = true;
            maskedTextBox1.Enabled = true;

            this.BackColor = Color.White;
            maskedTextBox1.Focus();

            label4.Text = "20";
            sayac = 20;
        }
    }
}
