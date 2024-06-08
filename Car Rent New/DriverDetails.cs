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
    public partial class DriverDetails : Form
    {
        SqlConnection con = null;
        public DriverDetails()
        {
            con = new SqlConnection("Data Source=DESKTOP-U6T96L7;Initial Catalog=CarRental;Integrated Security=True");
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update code
            try
            {
                if (MessageBox.Show("Are you sure to Update?", "Update Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    int id = Convert.ToInt32(txtID.Text);
                    int lnum = Convert.ToInt32(txtLNum.Text);
                    int age = Convert.ToInt32(txtAge.Text);
                    int pnum = Convert.ToInt32(txtPNum.Text);
                    string name = txtDName.Text;
                    string add = txtAdd.Text;
                    string email = txtEmail.Text; ;

                    cmd.CommandText = "UPDATE Drivertbl SET Name='" + name + "', Email='" + email + "', Licence_Number='" + lnum + "', Address='" + add + "', Mobile_Number='" + pnum + "', Age='" + age + "'  WHERE ID = '" + id + "'";

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record has been Updated!");

                    txtID.Clear();
                    txtDName.Clear();
                    txtPNum.Clear();
                    txtLNum.Clear();
                    txtEmail.Clear();
                    txtAdd.Clear();
                    txtAge.Clear();

                    loadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //insert
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;


                string id = txtID.Text;
                string name = txtDName.Text;
                string pnum = txtPNum.Text;
                string lnum = txtLNum.Text;
                string email = txtEmail.Text;
                string add = txtAdd.Text;
                string age = txtAge.Text;



                cmd.CommandText = "INSERT INTO Drivertbl (ID,Name,Email,Licence_Number,Age,Address,Mobile_Number) VALUES ('" + id + "','" + name + "','" + email + "','" + lnum + "','" + age + "','" + add + "','" + pnum + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has been inserted");
                


                txtID.Clear();
                txtDName.Clear();
                txtPNum.Clear();
                txtLNum.Clear();
                txtEmail.Clear();
                txtAdd.Clear();
                txtAge.Clear();


                loadTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void DriverDetails_Load(object sender, EventArgs e)
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

                cmd.CommandText = "SELECT * FROM Drivertbl";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView2.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Delete
            try
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    int id = Convert.ToInt32(txtID.Text);

                    cmd.CommandText = "DELETE FROM Drivertbl WHERE Driver_Id = '" + id + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Data has been deleted!");

                    txtID.Clear();
                    txtDName.Clear();
                    txtPNum.Clear();
                    txtLNum.Clear();
                    txtEmail.Clear();
                    txtAdd.Clear();
                    txtAge.Clear();


                    loadTable();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;
                txtID.Text = dataGridView2.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                txtAdd.Text = dataGridView2.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                txtDName.Text = dataGridView2.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtAge.Text = dataGridView2.Rows[e.RowIndex].Cells["Age"].FormattedValue.ToString();
                txtPNum.Text = dataGridView2.Rows[e.RowIndex].Cells["Mobile_Number"].FormattedValue.ToString();
                txtEmail.Text = dataGridView2.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                txtLNum.Text = dataGridView2.Rows[e.RowIndex].Cells["Licence_Number"].FormattedValue.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePgNw Home = new HomePgNw();
            Home.Show();
            this.Close();
        }
    }
}
