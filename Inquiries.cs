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
    public partial class Inquiries : Form
    {

        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public Inquiries()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-006HCOG\\SQLEXPRESS;Initial Catalog=GameRentalDatabase;Integrated Security=True");
            sda = new SqlDataAdapter(@"SELECT TOP 1 GNAME FROM GAME JOIN RENT ON GAME.GID = RENT.GID GROUP BY GNAME ORDER BY COUNT(*) DESC", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


            /*SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "SELECT TOP 1 GNAME FROM GAME JOIN RENT ON GAME.GID = RENT.GID GROUP BY GNAME ORDER BY COUNT(*) DESC";
     
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();*/
        }

        private void Inquiries_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-006HCOG\\SQLEXPRESS;Initial Catalog=GameRentalDatabase;Integrated Security=True");
            sda = new SqlDataAdapter(@"SELECT TOP 1 CLIENTFNAME
                                        FROM CLIENT
                                        JOIN RENT
                                        ON CLIENT.CLIENTEMAIL = RENT.CLIENTEMAIL
                                        WHERE MONTH(RENTDATE) BETWEEN MONTH(GETDATE())-1 AND MONTH(GETDATE())
                                        GROUP BY CLIENTFNAME
                                        ORDER BY COUNT (*) DESC"  , con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-006HCOG\\SQLEXPRESS;Initial Catalog=GameRentalDatabase;Integrated Security=True");
            sda = new SqlDataAdapter(@"SELECT GNAME 
                                        FROM GAME
                                        WHERE GAME.GID NOT IN (SELECT GID FROM RENT) 
                                        AND MONTH(YEAR) BETWEEN MONTH(GETDATE())-1 AND MONTH(GETDATE());", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-006HCOG\\SQLEXPRESS;Initial Catalog=GameRentalDatabase;Integrated Security=True");
            sda = new SqlDataAdapter(@"SELECT TOP 1 VNAME
                                        FROM GAME
                                        JOIN RENT
                                        ON GAME.GID = RENT.GID
                                        WHERE MONTH(RENTDATE) BETWEEN MONTH(GETDATE())-1 AND MONTH(GETDATE())
                                        GROUP BY VNAME
                                        ORDER BY COUNT (*) DESC", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-006HCOG\\SQLEXPRESS;Initial Catalog=GameRentalDatabase;Integrated Security=True");
            sda = new SqlDataAdapter(@"SELECT VNAME 
                                        FROM GAME
                                        WHERE GAME.GID NOT IN (SELECT GID FROM RENT) 
                                        AND MONTH(YEAR) BETWEEN MONTH(GETDATE())-1 AND MONTH(GETDATE());", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-006HCOG\\SQLEXPRESS;Initial Catalog=GameRentalDatabase;Integrated Security=True");
            sda = new SqlDataAdapter(@"SELECT VNAME 
                                        FROM GAME
                                        WHERE YEAR(YEAR) NOT LIKE YEAR(GETDATE())-1;", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
