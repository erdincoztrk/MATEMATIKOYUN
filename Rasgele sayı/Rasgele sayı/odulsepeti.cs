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
    public partial class odulsepeti : Form
    {
        public odulsepeti()
        {
            InitializeComponent();



            
       
        }
        
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int puan = Convert.ToInt32(lblpuan.Text);

            if (puan >= 40)
            {
                puan = Convert.ToInt32(lblpuan.Text);
                puan -= 20;
                lblpuan.Text = puan.ToString();

                MessageBox.Show("20 PUANA KÖREBE ALDIN!");
                korebe++;
                lblkorebe.Text = korebe.ToString();
            }

            else
            {
                MessageBox.Show("YETERSİZ PUAN!");
            }
        }
        
        private void btncikolata_Click(object sender, EventArgs e)
        {
            

        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int puan = Convert.ToInt32(lblpuan.Text);

            if (puan >= 50)
            {
                puan = Convert.ToInt32(lblpuan.Text);
                puan -= 50;
                lblpuan.Text = puan.ToString();

                MessageBox.Show("50 PUANA ÇİKOLATA ALDIN!");
                cikolata++;
                lblcikolata.Text = cikolata.ToString();
            }

            else
            {
                MessageBox.Show("YETERSİZ PUAN!");
            }
        }

        private void odulsepeti_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int puan = Convert.ToInt32(lblpuan.Text);

            if (puan >= 10)
            {
                puan = Convert.ToInt32(lblpuan.Text);
                puan -= 10;
                lblpuan.Text = puan.ToString();

                MessageBox.Show("10 PUANA FUTBOL OYNAMA HAKKI ALDIN!");
                top++;
                lbltop.Text = top.ToString();
            }

            else
            {
                MessageBox.Show("YETERSİZ PUAN!");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int puan = Convert.ToInt32(lblpuan.Text);

            if (puan >= 40)
            {
                puan = Convert.ToInt32(lblpuan.Text);
                puan -= 40;
                lblpuan.Text = puan.ToString();

                MessageBox.Show("40 PUANA SAKIZ ALDIN");
                sakiz++;
                lblsakiz.Text = sakiz.ToString();
            }

            else
            {
                MessageBox.Show("YETERSİZ PUAN!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int puan = Convert.ToInt32(lblpuan.Text);

            if (puan >= 10)
            {
                puan = Convert.ToInt32(lblpuan.Text);
                puan -= 10;
                lblpuan.Text = puan.ToString();

                MessageBox.Show("10 PUANA ETS2 OYNAMA ALDIN!");
                ets++;
                lblets.Text = ets.ToString();
            }

            else
            {
                MessageBox.Show("YETERSİZ PUAN!");
            }
        }
        int top = 0, cikolata = 0, sakiz = 0, counter = 0, ets = 0, korebe = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TOP = 10 PUAN " + "\n" + "COUNTER = 10 PUAN" + "\n" + "ETS2 = 10 PUAN" + "\n" + "KÖREBE = 20 PUAN" + "\n" + "SAKIZ = 40 PUAN" + "\n" + "ÇİKOLATA = 50 PUAN");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int puan = Convert.ToInt32(lblpuan.Text);

            if (puan >= 10)
            {
                puan = Convert.ToInt32(lblpuan.Text);
                puan -= 10;
                lblpuan.Text = puan.ToString();

                MessageBox.Show("10 PUANA COUNTER STRİKE ALDIN!");
                counter++;
                lblcs.Text = counter.ToString();
            }

            else
            {
                MessageBox.Show("YETERSİZ PUAN!");
            }
        }
    }
}
