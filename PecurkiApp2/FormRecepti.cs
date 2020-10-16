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
    public partial class FormRecepti : Form
    {
        public FormRecepti()
        {
            InitializeComponent();
        }

        private void rbnDa(object sender, EventArgs e)
        {

        }

        private void rbtNe(object sender, EventArgs e)
        {

        }

        private void rbtIzmena(object sender, EventArgs e)
        {

        }

        private void FormRecepti_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;

        }

        private void btnZacuvaj_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Ви благодариме на одговорот");
            }
            else
                if(radioButton2.Checked==true)
            {
                MessageBox.Show("Ви благодариме на одговорот");
            }
            else
            {
                MessageBox.Show("Ви благодариме на одговорот");
            }
                
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
