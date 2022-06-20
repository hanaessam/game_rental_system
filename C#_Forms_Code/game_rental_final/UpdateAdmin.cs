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
    public partial class UpdateAdmin : Form
    {
        public UpdateAdmin()
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
            // TODO: This line of code loads data into the 'gameRentalDatabaseDataSet.ADMIN' table. You can move, or remove it, as needed.
            this.aDMINTableAdapter.Fill(this.gameRentalDatabaseDataSet.ADMIN);
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
            sqlCommand.CommandText = "update ADMIN SET PASSWORD ='" + textBox5.Text + "', ADDRESS = '" + textBox3.Text + "',  FNAME = '" + textBox7.Text + "', LNAME ='" + textBox4.Text + "',PHONE =" + textBox2.Text + " where EMAIL = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            this.Hide();
            Home f3 = new Home();
            f3.ShowDialog();
            this.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
