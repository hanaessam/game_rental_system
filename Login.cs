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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-006HCOG\\SQLEXPRESS;Initial Catalog=GameRentalDatabase;Integrated Security=True";
            con.Open();
            /*string email = textBox3.Text;
            string password = textBox1.Text;*/
            SqlCommand cmd = new SqlCommand("Select EMAIL, PASSWORD from ADMIN where EMAIL='" + textBox3.Text + "'and PASSWORD='" + textBox1.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                this.Hide();
                Menu f3 = new Menu();
                f3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
           
        }
    }
}
