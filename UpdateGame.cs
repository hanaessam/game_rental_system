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
    public partial class UpdateGame : Form
    {
        /*SqlConnection con = new SqlConnection("Data Source=DESKTOP-006HCOG\\SQLEXPRESS;Initial Catalog=GameRentalDatabase;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int GID = 0;

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from GAME", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }*/
        public UpdateGame()
        {
            InitializeComponent();
           // DisplayData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //dataGridView1 RowHeaderMouseClick Event  
       /* private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
           // textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker1.Value = DateTime.ParseExact(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        }*/



        private void button1_Click(object sender, EventArgs e)
        {

            /*if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != ""  && textBox6.Text != "")
            {
                cmd = new SqlCommand("update GAME set EMAIL=@EMAIL,CLIENTEMAIL='hanaessam@gmail.com', GNAME=@GNAME, CATEGORY=@CATEGORY, YEAR=@YEAR,VNAME = @VNAME ,PRICE=@PRICE where GID=@GID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@GID", GID);
                cmd.Parameters.AddWithValue("@EMAIL", textBox6.Text);
                cmd.Parameters.AddWithValue("@GNAME", textBox1.Text);
                cmd.Parameters.AddWithValue("@CATEGORY", textBox2.Text);
                cmd.Parameters.AddWithValue("@YEAR", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@VNAME", textBox3.Text);
                cmd.Parameters.AddWithValue("@PRICE", textBox4.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }*/
        }

        private void UpdateGame_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-006HCOG\\SQLEXPRESS;Initial Catalog=GameRentalDatabase;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            
            sqlCommand.CommandText = "update GAME SET EMAIL ='" + this.textBox6.Text + "', CLIENTEMAIL = '" + this.textBox7.Text + "',  GNAME = '" + this.textBox1.Text + "',CATEGORY ='" + textBox2.Text + "',YEAR ='" + dateTimePicker1.Value.Date + "', VNAME='" + textBox3.Text + "' , PRICE=" + textBox4.Text + "  where GID = " + this.textBox5.Text + "";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            this.Hide();
            Home f3 = new Home();
            f3.ShowDialog();
            this.Close();
        }
    }
}
