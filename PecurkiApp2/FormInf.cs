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
    public partial class FormInf : Form
    {
        public FormInf()
        {
            InitializeComponent();
        }

        private void FormInf_Load(object sender, EventArgs e)
        {

        }

        private void Sliki_Click(object sender, EventArgs e)
        {
            new SlikiForma().Show();
        }

        private void Zdravje_Click(object sender, EventArgs e)
        {
            new FormZdravje().Show();
        }

        private void Sport_Click(object sender, EventArgs e)
        {
            new FormSport().Show();
        }

        private void Recepti_Click(object sender, EventArgs e)
        {
            new FormRecepti().Show();
        }
    }
}
