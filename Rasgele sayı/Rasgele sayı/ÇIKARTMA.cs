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
    public partial class ÇIKARTMA : Form
    {
        public ÇIKARTMA()
        {
            InitializeComponent();
        }
        int s1, s2, cıkartma, tahmin, sayac = 20, puan, hak = 3;


        private void ÇIKARTMA_Load(object sender, EventArgs e)
        {
            
        }
      
        private void btnodul_Click(object sender, EventArgs e)
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
                MessageBox.Show("SÜRE DOLDU");
                button1.Enabled = false;
                button2.Enabled = false;
                MessageBox.Show("ELENDİN!");
                sayac = 20;
                label4.Text = "20";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Focus();
            button2.Enabled = true;
            button1.Enabled = false;
            maskedTextBox1.Enabled = false;
           
            timer1.Stop();
            tahmin = Convert.ToInt32(maskedTextBox1.Text);
            lbltahmin.Text = tahmin.ToString();
            if (lblsonuc.Text == lbltahmin.Text)
            {
                puan += 10;
                lblPuan.Text = puan.ToString();

                this.BackColor = Color.Green;
                MessageBox.Show("TEBRİKLER! 10 PUAN KAZANDINIZ.");
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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random sayi1 = new Random();
            Random sayi2 = new Random();
            s1 = sayi1.Next(50);
            s2 = sayi2.Next(25);
            timer1.Start();
            cıkartma = s1 - s2;
            button2.Enabled = false;
            button1.Enabled = true;
            lbls1.Text = s1.ToString();
            lbls2.Text = s2.ToString();
            lblsonuc.Text = cıkartma.ToString();

            button1.Visible = true;
          
            maskedTextBox1.Enabled = true;
            maskedTextBox1.Focus();

            this.BackColor = Color.White;
            label4.Text = "20";
            sayac = 20;
        }
    }
}
