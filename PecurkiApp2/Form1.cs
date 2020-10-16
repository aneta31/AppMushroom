using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PecurkiApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblKorisnickoIme_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=AplikacijaPecurki;Integrated Security=True");
            SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) From Najava Where КорисничкоИме ='" + textKorisnickoIme.Text + "' and Лозинка ='" + txtLozinka.Text + "'", con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                new Meni().Show();
            } else
            {
                MessageBox.Show("Корисничкото име и/или лозинката е грешна. Ве молиме обидете се повторно.");
            }
            
        }
        private void btnCansel_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Откажи го најавувањето во апликацијата", "Порака", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }

      
    }
