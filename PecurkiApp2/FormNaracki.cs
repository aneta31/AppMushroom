using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PecurkiApp2
{
    public partial class FormNaracki : Form
    {
        public FormNaracki()
        {
            InitializeComponent();
            LoadTable();
        }
        void LoadTable()
        {
            using (SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=AplikacijaPecurki;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter sqa = new SqlDataAdapter("Select * From Naracki", con);
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                SqlCommandBuilder smb = new SqlCommandBuilder();
                sqa.Fill(dt);
                //BindingSource bSource = new BindingSource();
                dataGridView2.DataSource = ds.Tables["Narcki"] ;
                con.Close();
            }
        }
        public bool ExecuteSqlcommBool(string sqlComm)
        {
            try
            {

                using (SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=AplikacijaPecurki;Integrated Security=True"))
                {
                    SqlCommand sqlcomm = new SqlCommand(sqlComm, con);
                    con.Open();
                    sqlcomm.ExecuteNonQuery();
                    sqlcomm.Dispose();
                    con.Close();
                    con.Dispose();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        private void FormNaracki_Load(object sender, EventArgs e)
        {

        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                string Column1 = dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString();
                string Column2 = dataGridView2[1, dataGridView2.CurrentCell.RowIndex].Value.ToString();
                string Column3 = dataGridView2[2, dataGridView2.CurrentCell.RowIndex].Value.ToString();
                string Column4 = dataGridView2[3, dataGridView2.CurrentCell.RowIndex].Value.ToString();
                string Column5 = dataGridView2[4, dataGridView2.CurrentCell.RowIndex].Value.ToString();

                string insert_sql = "INSERT INTO Naracki(ЛозинкаИД,Име,Презиме,Адреса,БројИД)VALUES('" + Column1 + "','" + Column2 + "','" + Column3 + "','" + Column4 + "','" + Column5 + "')";

               
                if (this.ExecuteSqlcommBool(insert_sql))
                { MessageBox.Show("Успешно внесена нарачка во база"); }
                else
                { MessageBox.Show("Направена е грeшка"); }
            }
            catch
            { }
            finally
            {
                
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(item.Index);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

