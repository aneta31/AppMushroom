using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PecurkiApp2
{
    public partial class Meni : Form
    {
        public Meni()
        {
            InitializeComponent();
        }

        private void Meni_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Informacii_Click(object sender, EventArgs e)
        {
           
            new FormInf().Show();

        }

        private void Vid_Click(object sender, EventArgs e)
        {
           
            new FormVid().Show();
        }

        private void Naracki_Click(object sender, EventArgs e)
        {
            new FormNaracki().Show();
        }

        private void Cena_Click(object sender, EventArgs e)
        {
           
            new FormCena().Show();
        }

        private void Odjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormOdjava().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
