using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace PecurkiApp2
{
    public partial class FormSport : Form
    {
        private SoundPlayer _soundPlayer;

        
        public FormSport()
        {
            
                InitializeComponent();
         _soundPlayer = new SoundPlayer("Nordic Style Folk Music - Mountain Melody.wav");
            
        }
      
        private void FormSport_Load(object sender, EventArgs e)
        {
            
        }

        private void btnZacuvaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вашиот одговор е успешно зачуван");
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ви благодариме на пополнувањето");
        }

        private void btnMuzika_CheckedChanged(object sender, EventArgs e)
        {
            if (btnMuzika.Checked)
            {
                btnMuzika.Text = "Стоп";
                _soundPlayer.Play();
             }
            else
            {
                btnMuzika.Text = "Музика";
                _soundPlayer.Stop();
            }
        }
    }
}
        