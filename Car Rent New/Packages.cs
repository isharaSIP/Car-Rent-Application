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
    public partial class Packages : Form
    {
        SqlConnection con = null;
        public Packages()
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

                string PId = txtPID.Text;
                string PName = comboBoxPName.SelectedItem.ToString();
                string DCharge = txtDcharge.Text;
                string WCharge = txtWaitingcharge.Text;
                string ExKmCharge = txtExtraKmChrge.Text;
                string OverNCharge = txtOverNChrge.Text;
                string ParkCharge = txtParkingChrge.Text;
                string MaxKm = txtMaxKm.Text;
                string MaxHour = txtMaxHours.Text;


                cmd.CommandText = "INSERT INTO Package_tbl (Package_ID,Package_Name,Driver_Charge,Waiting_Charge,Extra_Km_Chrage,Over_Night_Charge,Parking_Charge,Maximum_Km,Maximum_Hours) VALUES ('" + PId + "','" + PName + "','" + DCharge + "','" + WCharge + "','" + ExKmCharge + "','" + OverNCharge + "','" + ParkCharge + "','" + MaxKm + "','" + MaxHour + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has been inserted");

                txtPID.Clear();
                comboBoxPName.ResetText();
                txtDcharge.Clear();
                txtWaitingcharge.Clear();
                txtExtraKmChrge.Clear();
                txtOverNChrge.Clear();
                txtParkingChrge.Clear();
                txtMaxKm.Clear();
                txtMaxHours.Clear();

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

                cmd.CommandText = "SELECT * FROM Package_tbl";
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
                txtPID.Text = dataGridView1.Rows[e.RowIndex].Cells["Package_ID"].FormattedValue.ToString();
                comboBoxPName.Text = dataGridView1.Rows[e.RowIndex].Cells["Package_Name"].FormattedValue.ToString();
                txtDcharge.Text = dataGridView1.Rows[e.RowIndex].Cells["Driver_Charge"].FormattedValue.ToString();
                txtWaitingcharge.Text = dataGridView1.Rows[e.RowIndex].Cells["Waiting_Charge"].FormattedValue.ToString();
                txtExtraKmChrge.Text = dataGridView1.Rows[e.RowIndex].Cells["Extra_Km_Chrage"].FormattedValue.ToString();
                txtOverNChrge.Text = dataGridView1.Rows[e.RowIndex].Cells["Over_Night_Charge"].FormattedValue.ToString();
                txtParkingChrge.Text = dataGridView1.Rows[e.RowIndex].Cells["Parking_Charge"].FormattedValue.ToString();
                txtMaxKm.Text = dataGridView1.Rows[e.RowIndex].Cells["Maximum_Km"].FormattedValue.ToString();
                txtMaxHours.Text = dataGridView1.Rows[e.RowIndex].Cells["Maximum_Hours"].FormattedValue.ToString(); 

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

                    String PId = txtPID.Text;

                    //Delete Package

                    cmd.CommandText = "DELETE FROM Package_tbl WHERE Package_ID = '" + PId + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Data has been deleted!");


                    loadTable();

                    txtPID.Clear();
                    comboBoxPName.ResetText();
                    txtDcharge.Clear();
                    txtWaitingcharge.Clear();
                    txtExtraKmChrge.Clear();
                    txtOverNChrge.Clear();
                    txtParkingChrge.Clear();
                    txtMaxKm.Clear();
                    txtMaxHours.Clear();




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void Packages_Load(object sender, EventArgs e)
        {
            loadTable();
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

                    string PId = txtPID.Text;
                    string PName = comboBoxPName.SelectedItem.ToString();
                    string DCharge = txtDcharge.Text;
                    string WCharge = txtWaitingcharge.Text;
                    string ExKmCharge = txtExtraKmChrge.Text;
                    string OverNCharge = txtOverNChrge.Text;
                    string ParkCharge = txtParkingChrge.Text;
                    string MaxKm = txtMaxKm.Text;
                    string MaxHour = txtMaxHours.Text;

                    cmd.CommandText = "UPDATE Package_tbl SET Extra_Km_Chrage='" + ExKmCharge + "' , Package_Name = '" + PName + "', Driver_Charge='" + DCharge + "' ,Over_Night_Charge='" + OverNCharge + "',Parking_Charge='" + ParkCharge + "',Maximum_Km='" + MaxKm + "',Maximum_Hours='" + MaxHour + "', Waiting_Charge = '" + WCharge + "'WHERE Package_ID = '" + PId + "' ";

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record has been Updated!");

                    txtPID.Clear();
                    comboBoxPName.ResetText();
                    txtDcharge.Clear();
                    txtWaitingcharge.Clear();
                    txtExtraKmChrge.Clear();
                    txtOverNChrge.Clear();
                    txtParkingChrge.Clear();
                    txtMaxKm.Clear();
                    txtMaxHours.Clear();

                    loadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                //insert
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string PId = txtPID.Text;
                string PName = comboBoxPName.SelectedItem.ToString();
                string DCharge = txtDcharge.Text;
                string WCharge = txtWaitingcharge.Text;
                string ExKmCharge = txtExtraKmChrge.Text;
                string OverNCharge = txtOverNChrge.Text;
                string ParkCharge = txtParkingChrge.Text;
                string MaxKm = txtMaxKm.Text;
                string MaxHour = txtMaxHours.Text;


                cmd.CommandText = "INSERT INTO Package_tbl (Package_ID,Package_Name,Driver_Charge,Waiting_Charge,Extra_Km_Chrage,Over_Night_Charge,Parking_Charge,Maximum_Km,Maximum_Hours) VALUES ('" + PId + "','" + PName + "','" + DCharge + "','" + WCharge + "','" + ExKmCharge + "','" + OverNCharge + "','" + ParkCharge + "','" + MaxKm + "','" + MaxHour + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has been inserted");

                txtPID.Clear();
                comboBoxPName.ResetText();
                txtDcharge.Clear();
                txtWaitingcharge.Clear();
                txtExtraKmChrge.Clear();
                txtOverNChrge.Clear();
                txtParkingChrge.Clear();
                txtMaxKm.Clear();
                txtMaxHours.Clear();

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

                    string PId = txtPID.Text;
                    string PName = comboBoxPName.SelectedItem.ToString();
                    string DCharge = txtDcharge.Text;
                    string WCharge = txtWaitingcharge.Text;
                    string ExKmCharge = txtExtraKmChrge.Text;
                    string OverNCharge = txtOverNChrge.Text;
                    string ParkCharge = txtParkingChrge.Text;
                    string MaxKm = txtMaxKm.Text;
                    string MaxHour = txtMaxHours.Text;

                    cmd.CommandText = "UPDATE Package_tbl SET Extra_Km_Chrage='" + ExKmCharge + "' , Package_Name = '" + PName + "', Driver_Charge='" + DCharge + "' ,Over_Night_Charge='" + OverNCharge + "',Parking_Charge='" + ParkCharge + "',Maximum_Km='" + MaxKm + "',Maximum_Hours='" + MaxHour + "', Waiting_Charge = '" + WCharge + "'WHERE Package_ID = '" + PId + "' ";

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record has been Updated!");

                    txtPID.Clear();
                    comboBoxPName.ResetText();
                    txtDcharge.Clear();
                    txtWaitingcharge.Clear();
                    txtExtraKmChrge.Clear();
                    txtOverNChrge.Clear();
                    txtParkingChrge.Clear();
                    txtMaxKm.Clear();
                    txtMaxHours.Clear();

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

                    String PId = txtPID.Text;

                    //Delete Package

                    cmd.CommandText = "DELETE FROM Package_tbl WHERE Package_ID = '" + PId + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Data has been deleted!");


                    loadTable();

                    txtPID.Clear();
                    comboBoxPName.ResetText();
                    txtDcharge.Clear();
                    txtWaitingcharge.Clear();
                    txtExtraKmChrge.Clear();
                    txtOverNChrge.Clear();
                    txtParkingChrge.Clear();
                    txtMaxKm.Clear();
                    txtMaxHours.Clear();




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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtParkingChrge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOverNChrge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExtraKmChrge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWaitingcharge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDcharge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaxKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaxHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
