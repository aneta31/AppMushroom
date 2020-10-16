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
    public partial class FormVid : Form
    {
        public FormVid()
        {
            InitializeComponent();
            LoadTable();
        }

        void LoadTable()
        {
            using (SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=AplikacijaPecurki;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter sqa = new SqlDataAdapter("Select * From PecurkiVid", con);
                DataTable dt = new DataTable();
                sqa.Fill(dt);
                
                dataGridView1.DataSource = dt;
                con.Close();

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Име";
                comboBox1.ValueMember = "Име";
            }
        }

        private void FormVid_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = comboBox1.Text;
            using (SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=AplikacijaPecurki;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter sqa = new SqlDataAdapter("Select * From PecurkiVid Where Име Like N'" + selectedName + "' ORDER BY БројИД ASC", con);
                DataTable dt = new DataTable();
                sqa.Fill(dt);
                DataSet ds = new DataSet();
                //BindingSource bSource = new BindingSource();
                dataGridView1.DataSource = dt;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
