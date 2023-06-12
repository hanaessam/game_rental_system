using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace game_rental_final
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-006HCOGSQLEXPRESS;Initial Catalog=game_rental_sys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateAdmin f3 = new UpdateAdmin();
            f3.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Client f3 = new Add_Client();
            f3.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddGame f3 = new AddGame();
            f3.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateGame f3 = new UpdateGame();
            f3.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f3 = new Home();
            f3.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inquiries f3 = new Inquiries();
            f3.ShowDialog();
            this.Close();
        }
    }
}
