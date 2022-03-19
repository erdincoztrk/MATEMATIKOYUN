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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toplama tpl = new Toplama();
            tpl.Show();
        }

        private void btncikartma_Click(object sender, EventArgs e)
        {
            ÇIKARTMA cıkartma = new ÇIKARTMA();
            cıkartma.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            çarpma carpma = new çarpma();
            carpma.Show();
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            bolme blme = new bolme();
            blme.Show();
        }
    }
}
