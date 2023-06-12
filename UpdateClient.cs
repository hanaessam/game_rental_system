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
    public partial class UpdateClient : Form
    {
        public UpdateClient()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void EditDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameRentalDatabaseDataSet.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.gameRentalDatabaseDataSet.CLIENT);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sqlCommand.CommandText = "INSERT INTO CLIENT Values (,,,,,);";

            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-006HCOG\\SQLEXPRESS;Initial Catalog=GameRentalDatabase;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "update CLIENT SET CLIENTPASSWORD ='" + textBox5.Text + "', CLEINTADDRESS = '" + textBox3.Text + "',  CLIENTFNAME = '" + textBox7.Text + "', CLIENTLNAME ='" + textBox4.Text + "',CLIENTPHONE =" + textBox2.Text + " where CLIENTEMAIL = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            this.Hide();
            Home f3 = new Home();
            f3.ShowDialog();
            this.Close();
        }
    }
}
