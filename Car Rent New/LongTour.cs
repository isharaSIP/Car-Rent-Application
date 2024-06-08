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
    public partial class LongTour : Form
    {
        SqlConnection con = null; //2nd step
        public LongTour()
        {
            con = new SqlConnection("Data Source=DESKTOP-U6T96L7;Initial Catalog=CarRental;Integrated Security=True"); //3rd step
            InitializeComponent();
        }

        //Declare Variables

        int drivercharge;
        int extrakmcharge;
        int waitingcharge;
        int parkingcharge;
        decimal basecharge;
        decimal total;
        int maximumkm;
        int maximumhours;
        int overnightcharge;

        TimeSpan totalDays;
       

        private void loadvehiclecombo()
        {
            try
            {
                con.Open();

                string query = "SELECT Type FROM Vehicle_tblnw";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Type", typeof(string));
                dt.Load(rdr);
                comboBoxVehicleType.ValueMember = "Type";
                comboBoxVehicleType.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void loadpackagecombo()

        {
            try
            {
                con.Open();

                string query = "SELECT Package_Name FROM Package_tbl";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Package_Name", typeof(string));
                dt.Load(rdr);
                comboBoxPackageType.ValueMember = "Package_Name";
                comboBoxPackageType.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void datecalculation()
        {
            //Date Calculation

            DateTime StartDate = DateTime.Parse(dateTimePicker1.Text);
            DateTime EndDate = DateTime.Parse(dateTimePicker2.Text);

            totalDays = EndDate - StartDate;
            txtTotalDays.Text = totalDays.Days.ToString();
        }

        private void hire()
        {
            try
            {
                con.Open();

                string packagetype = comboBoxPackageType.Text;
                string vehicletype = comboBoxVehicleType.Text;

                string query = "SELECT Driver_Charge, Waiting_Charge, Extra_Km_Chrage, Parking_Charge, Maximum_Km, Over_Night_Charge FROM Package_tbl WHERE Package_Name = '" + packagetype + "'; SELECT Base_Charge FROM Vehicle_tblnw WHERE Type = '" + vehicletype + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        drivercharge = rdr.GetInt32(0);
                        waitingcharge = rdr.GetInt32(1);
                        extrakmcharge = rdr.GetInt32(2);
                        parkingcharge = rdr.GetInt32(3);
                        maximumkm = rdr.GetInt32(4);
                        overnightcharge = rdr.GetInt32(5);
                    }
                }
                if (rdr.NextResult())
                {
                    while (rdr.Read())
                    {
                        basecharge = rdr.GetDecimal(0);
                        txtBaseCharge.Text = "Rs." + basecharge.ToString();
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            int startkm = int.Parse(txtStartKm.Text);
            int endkm = int.Parse(txtEndKm.Text);
            int totalkm = (endkm - startkm);

            txtDistance.Text = totalkm.ToString();

            total += (decimal)basecharge;

            int distance = int.Parse(txtDistance.Text);
     
            total += (overnightcharge + parkingcharge);
            int nightcharge = (overnightcharge + parkingcharge);
            txtOverNightCharge.Text = ("Rs." + nightcharge.ToString());


            if (totalkm >= maximumkm)
            {
                int extra = (extrakmcharge * (totalkm - maximumkm));
                total += extra;
                txtExtraKmCharge.Text = ("Rs." + extra.ToString());
                txtTotal.Text = ("Rs." + total.ToString());
            }

            if (totalkm >= maximumkm)
            {
                int extrakm = (totalkm - maximumkm);

                txtExtraKm.Text = ("" + extrakm.ToString());
            }

            if (totalkm <= maximumkm)
            {
                string extrakm = txtExtraKm.Text;

                txtExtraKm.Text = ("0" + extrakm.ToString());
                txtTotal.Text = ("Rs." + total.ToString());

                txtExtraKmCharge.Text = ("Rs.0" + extrakm.ToString());

            }

        }

        private void siButton7_Click(object sender, EventArgs e)
        {
            HomePgNw Home = new HomePgNw();
            Home.Show();
            this.Close();
        }

        private void siButton3_Click(object sender, EventArgs e)
        {
            HomePgNw home = new HomePgNw();
            home.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
            label6.Text = DateTime.Now.ToShortDateString();
        }

        private void LongTour_Load(object sender, EventArgs e)
        {
            loadpackagecombo();
            loadvehiclecombo();
        }

        private void siButton4_Click(object sender, EventArgs e)
        {
            datecalculation();
            hire();

        }

        private void siButton2_Click(object sender, EventArgs e)
        {
            txtDistance.Clear();
            txtBaseCharge.Clear();
            txtDriverID.Clear();
            txtEndKm.Clear();
            txtExtraKm.Clear();
            txtExtraKmCharge.Clear();
            txtOverNightCharge.Clear();
            txtStartKm.Clear();
            txtTotal.Clear();
            txtTourID.Clear();
            txtTotalDays.Clear();
            comboBoxPackageType.ResetText();
            comboBoxVehicleType.ResetText();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;


        }

        private void siButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //Payment Record Insert
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string tourid = txtTourID.Text;
                string driverid = txtDriverID.Text;
                string packagetype = comboBoxPackageType.SelectedItem.ToString();
                string vehicletype = comboBoxVehicleType.SelectedItem.ToString();

                string startDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string endDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                string totaldays = txtTotalDays.Text;
                string startkm = txtStartKm.Text;
                string endkm = txtEndKm.Text;
                string distance = txtDistance.Text;
                string basecharge = txtBaseCharge.Text;
                string extrakmcharge = txtExtraKmCharge.Text;
                string overnightcharge = txtOverNightCharge.Text;
                string total = txtTotal.Text;

                DialogResult Payment;
                Payment = MessageBox.Show("Confirm the payment", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Payment == DialogResult.Yes)

                {
                    cmd.CommandText = "INSERT INTO Long_Tour_tbl (Driver_ID,Package_Type,Vehicle_Type,Start_Date,End_Date,Start_Km,End_Km,Distance,Total_Days,Base_Charge,Extra_Km_Charge,Over_Night_Charge,Total) VALUES ('" + driverid + "','" + packagetype + "','" + vehicletype + "','" + startDate + "','" + endDate + "','" + startkm + "','" + endkm + "','" + distance + "','" + totaldays + "','" + basecharge + "','" + extrakmcharge + "','" + overnightcharge + "','" + total + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Payment Successfully!");
                }

                txtTourID.Clear();
                txtStartKm.Clear();
                txtDriverID.Clear();
                txtEndKm.Clear();
                comboBoxPackageType.ResetText();
                comboBoxVehicleType.ResetText();
                txtDistance.Clear();
                txtExtraKm.Clear();
                txtBaseCharge.Clear();
                txtExtraKmCharge.Clear();
                txtOverNightCharge.Clear();
                txtTotal.Clear();
                txtTotalDays.Clear();
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void siButton5_Click(object sender, EventArgs e)
        {
            Long_Tour_Records longtourRecords = new Long_Tour_Records();
            longtourRecords.Show();
            this.Hide();
        }
    }
}
