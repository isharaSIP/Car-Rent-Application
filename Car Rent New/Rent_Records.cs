using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //1st step

namespace Car_Rent_New
{
    public partial class Rent_Records : Form
    {
        SqlConnection con = null; //2nd step
        public Rent_Records()
        {
            con = new SqlConnection("Data Source=DESKTOP-U6T96L7;Initial Catalog=CarRental;Integrated Security=True");   //3rd step
            InitializeComponent();
        }

        private void siButton1_Click(object sender, EventArgs e)
        {
            Rental rent = new Rental();
            rent.Show();
            this.Hide();
        }

        private void Rent_Records_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void loadTable()
        {
            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM Rent_tbl";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }
    }
}
