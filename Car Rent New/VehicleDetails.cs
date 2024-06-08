using System;
using System.Data;
using System.Data.SqlClient; //1st step
using System.Windows.Forms;

namespace Car_Rent_New
{
    public partial class VehicleDetails : Form
    {
        SqlConnection con = null; //2nd step
        public VehicleDetails()
        {
            con = new SqlConnection("Data Source=DESKTOP-U6T96L7;Initial Catalog=CarRental;Integrated Security=True"); //3rd step
            InitializeComponent();
            
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
                string regnum = txtRegNum.Text;
                string brand = txtBrand.Text;
                double DPrice = Convert.ToDouble(txtDPrice.Text);
                double WPrice = Convert.ToDouble(txtWPrice.Text);
                double MPrice = Convert.ToDouble(txtMPrice.Text);
                string type = comboBoxType.SelectedItem.ToString();
                string BCharge = txtBCharge.Text;
               

                cmd.CommandText = "INSERT INTO Vehicle_tblnw (ID,Reg_Num,Brand,Type,Base_Charge,Daily_Price,Weekly_Price,Monthly_Price) VALUES ('" + id + "','" + regnum + "','" + brand + "','" + type + "','" + BCharge + "','" + DPrice + "','" + WPrice + "','" + MPrice + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has been inserted");

                txtID.Clear();
                txtRegNum.Clear();
                txtBrand.Clear();
                txtDPrice.Clear();
                txtWPrice.Clear();
                txtMPrice.Clear();
                comboBoxType.ResetText();
                txtBCharge.Clear();


                loadTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                txtRegNum.Text = dataGridView1.Rows[e.RowIndex].Cells["Reg_Num"].FormattedValue.ToString();
                txtBrand.Text = dataGridView1.Rows[e.RowIndex].Cells["Brand"].FormattedValue.ToString();
                txtDPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["Daily_Price"].FormattedValue.ToString();
                txtWPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["Weekly_Price"].FormattedValue.ToString();
                txtMPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["Monthly_Price"].FormattedValue.ToString();
                comboBoxType.Text = dataGridView1.Rows[e.RowIndex].Cells["Type"].FormattedValue.ToString();
                txtBCharge.Text = dataGridView1.Rows[e.RowIndex].Cells["Base_Charge"].FormattedValue.ToString();


            }
        }

        private void VehicleDetails_Load(object sender, EventArgs e)
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

                cmd.CommandText = "SELECT * FROM Vehicle_tblnw";
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

        private void button3_Click(object sender, EventArgs e)
        {
            //Delete code
            try
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    String id = txtID.Text;

                    //Delete Customer

                    cmd.CommandText = "DELETE FROM Vehicle_tblnw WHERE ID = '" + id + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Data has been deleted!");
                    

                    loadTable();

                    txtID.Clear();
                    txtRegNum.Clear();
                    txtBrand.Clear();
                    txtDPrice.Clear();
                    txtWPrice.Clear();
                    txtMPrice.Clear();
                    comboBoxType.ResetText();
                    txtBCharge.Clear();




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
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

                    string id = txtID.Text;
                    string regnum = txtRegNum.Text;
                    string brand = txtBrand.Text;
                    double DPrice = Convert.ToDouble(txtDPrice.Text);
                    double WPrice = Convert.ToDouble(txtWPrice.Text);
                    double MPrice = Convert.ToDouble(txtMPrice.Text);
                    string type = comboBoxType.SelectedItem.ToString();
                    string BCharge = txtBCharge.Text;

                    cmd.CommandText = "UPDATE Vehicle_tblnw SET Reg_Num='" + regnum + "' , Brand = '" + brand + "', Type='" + type + "' , Daily_Price='" + DPrice + "', Weekly_Price='" + WPrice + "', Monthly_Price='" + MPrice + "', Base_Charge= '" + BCharge + "'WHERE ID = '" + id + "' ";

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record has been Updated!");

                    txtID.Clear();
                    txtRegNum.Clear();
                    txtBrand.Clear();
                    txtDPrice.Clear();
                    txtWPrice.Clear();
                    txtMPrice.Clear();
                    comboBoxType.ResetText();
                    txtBCharge.Clear();

                    loadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePgNw Home = new HomePgNw();
            Home.Show();
            this.Close();

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
                string regnum = txtRegNum.Text;
                string brand = txtBrand.Text;
                double DPrice = Convert.ToDouble(txtDPrice.Text);
                double WPrice = Convert.ToDouble(txtWPrice.Text);
                double MPrice = Convert.ToDouble(txtMPrice.Text);
                string type = comboBoxType.SelectedItem.ToString();
                string BCharge = txtBCharge.Text;


                cmd.CommandText = "INSERT INTO Vehicle_tblnw (ID,Reg_Num,Brand,Type,Base_Charge,Daily_Price,Weekly_Price,Monthly_Price) VALUES ('" + id + "','" + regnum + "','" + brand + "','" + type + "','" + BCharge + "','" + DPrice + "','" + WPrice + "','" + MPrice + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has been inserted");

                txtID.Clear();
                txtRegNum.Clear();
                txtBrand.Clear();
                txtDPrice.Clear();
                txtWPrice.Clear();
                txtMPrice.Clear();
                comboBoxType.ResetText();
                txtBCharge.Clear();


                loadTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //update code
            try
            {
                if (MessageBox.Show("Are you sure to Update?", "Update Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    string id = txtID.Text;
                    string regnum = txtRegNum.Text;
                    string brand = txtBrand.Text;
                    double DPrice = Convert.ToDouble(txtDPrice.Text);
                    double WPrice = Convert.ToDouble(txtWPrice.Text);
                    double MPrice = Convert.ToDouble(txtMPrice.Text);
                    string type = comboBoxType.SelectedItem.ToString();
                    string BCharge = txtBCharge.Text;

                    cmd.CommandText = "UPDATE Vehicle_tblnw SET Reg_Num='" + regnum + "' , Brand = '" + brand + "', Type='" + type + "' , Daily_Price='" + DPrice + "', Weekly_Price='" + WPrice + "', Monthly_Price='" + MPrice + "', Base_Charge= '" + BCharge + "'WHERE ID = '" + id + "' ";

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record has been Updated!");

                    txtID.Clear();
                    txtRegNum.Clear();
                    txtBrand.Clear();
                    txtDPrice.Clear();
                    txtWPrice.Clear();
                    txtMPrice.Clear();
                    comboBoxType.ResetText();
                    txtBCharge.Clear();

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
            //Delete code
            try
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    String id = txtID.Text;

                    //Delete Customer

                    cmd.CommandText = "DELETE FROM Vehicle_tblnw WHERE ID = '" + id + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Data has been deleted!");


                    loadTable();

                    txtID.Clear();
                    txtRegNum.Clear();
                    txtBrand.Clear();
                    txtDPrice.Clear();
                    txtWPrice.Clear();
                    txtMPrice.Clear();
                    comboBoxType.ResetText();
                    txtBCharge.Clear();

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
    }
}
