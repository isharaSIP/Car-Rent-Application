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
    public partial class CustomerDetails : Form
    {
        SqlConnection con = null;
     
        public CustomerDetails()
        {
            con = new SqlConnection("Data Source=DESKTOP-U6T96L7;Initial Catalog=CarRental;Integrated Security=True");
            InitializeComponent();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePgNw Home = new HomePgNw();
            Home.Show();
            this.Close();
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
                string email = txtEmail.Text;
                string name = txtName.Text;
                string nic = txtNIC.Text;
                string add = txtAdd.Text;
                string pnum = txtPnum.Text;
                
                
               
              
                cmd.CommandText = "INSERT INTO Cus_tbl (Id,Email,Name,NIC,Address,[Mobile Num]) VALUES ('" + id + "','" + email + "','" + name + "','" + nic + "','" + add + "','" + pnum + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has been inserted");



                txtID.Clear();
                txtEmail.Clear();
                txtName.Clear();
                txtAdd.Clear();
                txtPnum.Clear();
                txtNIC.Clear();

                loadTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }

        }

        private void loadTable()
        {
            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM Cus_tbl";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                txtAdd.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                txtPnum.Text = dataGridView1.Rows[e.RowIndex].Cells["Mobile Num"].FormattedValue.ToString();
                txtNIC.Text = dataGridView1.Rows[e.RowIndex].Cells["NIC"].FormattedValue.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to Update?", "Update Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    string id = txtID.Text;
                    string email = txtEmail.Text;
                    string name = txtName.Text;
                    string nic = txtNIC.Text;
                    string add = txtAdd.Text;
                    string pnum = txtPnum.Text;

                    cmd.CommandText = "UPDATE Cus_tbl SET Email='" + email + "' , Name = '" + name + "', NIC = '" + nic + "', Address='" + add + "' , [Mobile Num] = '" + pnum + "'WHERE ID = '" + id + "' ";

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record has been Updated!");

                    txtID.Clear();
                    txtEmail.Clear();
                    txtName.Clear();
                    txtAdd.Clear();
                    txtPnum.Clear();
                    txtNIC.Clear();

                    loadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    String id = txtID.Text;

                    //Delete Customer

                    cmd.CommandText = "DELETE FROM Cus_tbl WHERE ID = '" + id + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Data has been deleted!");


                    loadTable();

                    txtID.Clear();
                    txtEmail.Clear();
                    txtName.Clear();
                    txtAdd.Clear();
                    txtPnum.Clear();
                    txtNIC.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            loadTable();
           

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                //insert
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;


                string id = txtID.Text;
                string email = txtEmail.Text;
                string name = txtName.Text;
                string nic = txtNIC.Text;
                string add = txtAdd.Text;
                string pnum = txtPnum.Text;

                cmd.CommandText = "INSERT INTO Cus_tbl (Id,Email,Name,NIC,Address,[Mobile Num]) VALUES ('" + id + "','" + email + "','" + name + "','" + nic + "','" + add + "','" + pnum + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has been inserted");

                txtID.Clear();
                txtEmail.Clear();
                txtName.Clear();
                txtAdd.Clear();
                txtPnum.Clear();
                txtNIC.Clear();

                loadTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to Update?", "Update Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    string id = txtID.Text;
                    string email = txtEmail.Text;
                    string name = txtName.Text;
                    string nic = txtNIC.Text;
                    string add = txtAdd.Text;
                    string pnum = txtPnum.Text;

                    cmd.CommandText = "UPDATE Cus_tbl SET Email='" + email + "' , Name = '" + name + "', NIC = '" + nic + "', Address='" + add + "' , [Mobile Num] = '" + pnum + "'WHERE ID = '" + id + "' ";

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record has been Updated!");

                    txtID.Clear();
                    txtEmail.Clear();
                    txtName.Clear();
                    txtAdd.Clear();
                    txtPnum.Clear();
                    txtNIC.Clear();

                    loadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    String id = txtID.Text;

                    //Delete Customer

                    cmd.CommandText = "DELETE FROM Cus_tbl WHERE ID = '" + id + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Data has been deleted!");


                    loadTable();

                    txtID.Clear();
                    txtEmail.Clear();
                    txtName.Clear();
                    txtAdd.Clear();
                    txtPnum.Clear();
                    txtNIC.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomePgNw Home = new HomePgNw();
            Home.Show();
            this.Close();
        }

        private void lblTotalRecords_Click(object sender, EventArgs e)
        {

        }
    }
}
