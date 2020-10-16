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
    public partial class FormCena : Form
    {
        public FormCena()
        {
           
        InitializeComponent();
        
    }

        private void btnPresmetka_Click(object sender, EventArgs e)
        {
            txtIsplata.Text = (float.Parse(txtCena.Text) * float.Parse(txtKolicina.Text)).ToString();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            txtIsplata.Text = String.Empty;
            txtKolicina.Text = String.Empty;
            txtVid.Text = String.Empty;
            txtCena.Text = String.Empty;
        }

        private void FormCena_Load(object sender, EventArgs e)
        {

        }

        private void txtIsplata_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
