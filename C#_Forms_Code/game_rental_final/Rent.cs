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
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rent_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-006HCOGSQLEXPRESS;Initial Catalog=game_rental_sys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-006HCOG\\SQLEXPRESS;Initial Catalog=GameRentalDatabase;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO RENT Values('" + this.textBox1.Text + "','" + this.textBox2.Text + "', " + this.textBox3.Text + ",'" + dateTimePicker1.Value.Date + "' );";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            this.Hide();
            Home f3 = new Home();
            f3.ShowDialog();
            this.Close();
        }
    }
}
