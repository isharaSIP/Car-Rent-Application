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

namespace Car_Rent_New
{
    public partial class Login : Form
    {
        
        public Login()
        {
            
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U6T96L7;Initial Catalog=CarRental;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult HomeExit;
            HomeExit = MessageBox.Show("Confirm if you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (HomeExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void siButton2_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtUsername.Text;
            password = txtPassword.Text;

            try
            {
                string querry = "SELECT * FROM login_tblnw WHERE user_name = '" + txtUsername.Text + "'AND password = '" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;

                    {
                        MessageBox.Show("Login Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }

                    //next load page >> Home
                    HomePgNw Home = new HomePgNw();
                    Home.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid login details, Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();

                    //to focus username
                    txtUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
