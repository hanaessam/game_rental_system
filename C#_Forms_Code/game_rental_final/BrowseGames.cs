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

namespace game_rental_final
{
    public partial class Home : Form
    {
        string cs = "Data Source=DESKTOP-006HCOG\\SQLEXPRESS;Initial Catalog=GameRentalDatabase;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from GAME", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            /*// TODO: This line of code loads data into the 'gameRentalDatabaseDataSet.GAME' table. You can move, or remove it, as needed.
            this.gAMETableAdapter.Fill(this.gameRentalDatabaseDataSet.GAME);
            // TODO: This line of code loads data into the 'gameRentalDatabaseDataSet.GAME' table. You can move, or remove it, as needed.
            this.gAMETableAdapter.Fill(this.gameRentalDatabaseDataSet.GAME);*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            
            /*
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-006HCOG\\SQLEXPRESS;Initial Catalog=GameRentalDatabase;Integrated Security=True");
            
            sqlConnection.Open();
            string searchData = textBox1.Text;
            string query = */

            /*string cmdText = "SELECT GNAME From GAME WHERE " + textBox1.Text + " = @input";
       
            using (SqlCommand cmd = new SqlCommand(cmdText, sqlConnection))
            {
                
                cmd.Parameters.AddWithValue("@input", textBox1.Text);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from GAME where GNAME like '" + textBox1.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from GAME where CATEGORY like '" + textBox2.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from GAME where VNAME like '" + textBox3.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Rent f3 = new Rent();
            f3.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnGame f3 = new ReturnGame();
            f3.ShowDialog();
            this.Close();
        }
    }
}
