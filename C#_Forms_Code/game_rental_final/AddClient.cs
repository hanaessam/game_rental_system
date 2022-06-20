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
    public partial class Add_Client : Form
    {
        public Add_Client()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-006HCOG\\SQLEXPRESS;Initial Catalog=GameRentalDatabase;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO CLIENT Values ('" + textBox1.Text + "','" + textBox5.Text + "','" + textBox3.Text + "','" + textBox7.Text + "','" + textBox4.Text + "'," + textBox2.Text + ");";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            this.Hide();
            Home f3 = new Home();
            f3.ShowDialog();
            this.Close();

            /*cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FNAME", textBox7.Text);
            cmd.Parameters.AddWithValue("@LNAME", textBox4.Text);
            cmd.Parameters.AddWithValue("@ADDRESS", textBox3.Text);
            cmd.Parameters.AddWithValue("@PHONE", textBox2.Text);
            cmd.Parameters.AddWithValue("@EMAIL", textBox1.Text);
            cmd.Parameters.AddWithValue("@PASSWORD_", textBox5.Text);
            cmd.Parameters.AddWithValue("@CID", textBox6.Text);
            cmd.Parameters.AddWithValue("@GENDER", radioButton2.Checked);*/


            //con.Open();
            //int i = cmd.ExecuteNonQuery();


            //con.Close();

            /* if (i != 0)
             {
                 MessageBox.Show(i + "Data Saved");
             }*/

        }

        private void Add_Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameRentalDatabaseDataSet.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.gameRentalDatabaseDataSet.CLIENT);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        
    }
}
