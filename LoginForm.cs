using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Movie_Recommender_Application
{
    public partial class LoginForm : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kashe\\Documents\\Movie_Recommender.mdf;Integrated Security = True; Connect Timeout = 30; Encrypt=True";
        SqlConnection conn;
        SqlCommand cmd;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration rf = new Registration();
            rf.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Username=@username AND Password=@password", conn);
            cmd.Parameters.AddWithValue("@username",username.Text);
            cmd.Parameters.AddWithValue("@password",password.Text);

            int result = Convert.ToInt32(cmd.ExecuteScalar());

            if (result > 0)
            {
                Dashboard df = new Dashboard();
                df.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }
    }
}
