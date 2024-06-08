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
    public partial class DayTour : Form
    {
        SqlConnection con = null; //2nd step
        public DayTour()
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

        TimeSpan totaltime;

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
                comboBoxVType.ValueMember = "Type";
                comboBoxVType.DataSource = dt;

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
                comboBoxpackage.ValueMember = "Package_Name";
                comboBoxpackage.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void timecalculation()
        {
            //Time_Calculation

            DateTime datetime1 = dateTimePicker1.Value.Date + dateTimePicker3.Value.TimeOfDay;
            DateTime datetime2 = dateTimePicker2.Value.Date + dateTimePicker4.Value.TimeOfDay;

            totaltime = datetime2 - datetime1;

        }

        private void hire()
        {
            try
            {
                con.Open();

                string packagetype = comboBoxpackage.Text;
                string vehicletype = comboBoxVType.Text;

                string query = "SELECT Driver_Charge, Waiting_Charge, Extra_Km_Chrage, Parking_Charge, Maximum_Km, Maximum_Hours FROM Package_tbl WHERE Package_Name = '" + packagetype + "'; SELECT Base_Charge FROM Vehicle_tblnw WHERE Type = '" + vehicletype +"' ";
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
                        maximumhours = rdr.GetInt32(5);
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

            //Call timecal method

            timecalculation();

            int totalTime = (int)totaltime.TotalHours;

            int startkm = int.Parse(txtStartKm.Text);
            int endkm = int.Parse(txtEndKm.Text);
            int totalkm = (endkm - startkm);

            txtDistance.Text = totalkm.ToString();

            total += (decimal)basecharge;

            int distance = int.Parse(txtDistance.Text);

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
             
                txtExtraKmChrage.Text = ("Rs.0" + extrakm.ToString());

            }

            if (totalkm >= maximumkm)
            {
                int extra = (extrakmcharge * (totalkm - maximumkm));
                total += extra;
                txtExtraKmChrage.Text = ("Rs." + extra.ToString());
                txtTotal.Text = ("Rs." + total.ToString());

            }
            if (totalTime >= maximumhours)
            {
                int extrahour = waitingcharge * (totalTime - maximumhours);
                total += extrahour;
                txtWaitingCharge.Text = ("Rs." + extrahour.ToString());
                txtTotal.Text = ("Rs." + total.ToString());


            }
            else if (totalTime < maximumhours)
            {
                string extrahour = txtWaitingCharge.Text;
                
                txtWaitingCharge.Text = ("Rs.0" + extrahour.ToString());
                
            }

        }

        private void siButton7_Click(object sender, EventArgs e)
        {
            HomePgNw Home = new HomePgNw();
            Home.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
            label6.Text = DateTime.Now.ToShortDateString();
        }

        private void DayTour_Load(object sender, EventArgs e)
        {
            loadpackagecombo();
            loadvehiclecombo();
        }

        private void siButton3_Click(object sender, EventArgs e)
        {
            hire();
        }

        private void siButton2_Click(object sender, EventArgs e)
        {
            txtTourID.Clear();
            txtDriverID.Clear();
            txtStartKm.Clear();
            txtEndKm.Clear();
            txtBaseCharge.Clear();
            txtWaitingCharge.Clear();
            txtTotal.Clear();
            txtDistance.Clear();
            txtExtraKmChrage.Clear();
            txtExtraKm.Clear();
            comboBoxpackage.ResetText();
            comboBoxVType.ResetText();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker4.Value = DateTime.Now;


        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

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
                string packagetype = comboBoxpackage.SelectedItem.ToString();
                string vehicletype = comboBoxVType.SelectedItem.ToString();

                string startDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string endDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                string startTime = dateTimePicker3.Value.ToString("t");
                string endTime = dateTimePicker4.Value.ToString("t");

                string startkm = txtStartKm.Text;
                string endkm = txtEndKm.Text;
                string distance = txtDistance.Text;
                string basecharge = txtBaseCharge.Text;
                string extrakmcharge = txtExtraKmChrage.Text;
                string waitingcharge = txtWaitingCharge.Text;
                string total = txtTotal.Text;

                DialogResult Payment;
                Payment = MessageBox.Show("Confirm the payment", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Payment == DialogResult.Yes)

                {
                    cmd.CommandText = "INSERT INTO Day_Tour_tbl (Driver_ID,P_Type,V_Type,Start_Time,End_Time,Start_Date,End_Date,Start_Km,End_Km,Distance,B_Charge,E_Km_Charge,W_Charge,Total) VALUES ('" + driverid + "','" + packagetype + "','" + vehicletype + "','" + startTime + "','" + endTime + "','" + startDate + "','" + endDate + "','" + startkm + "','" + endkm + "','" + distance + "','" + basecharge + "','" + extrakmcharge + "','" + waitingcharge + "','" + total + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Payment Successfully!");
                }
                          
                txtTourID.Clear();
                txtStartKm.Clear();
                txtDriverID.Clear();
                txtEndKm.Clear();
                comboBoxpackage.ResetText();
                comboBoxVType.ResetText();
                txtDistance.Clear();
                txtExtraKm.Clear();
                txtBaseCharge.Clear();
                txtExtraKmChrage.Clear();
                txtWaitingCharge.Clear();
                txtTotal.Clear();
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
                dateTimePicker3.Value = DateTime.Now;
                dateTimePicker4.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void siButton4_Click(object sender, EventArgs e)
        {
            Day_Tour_Records daytourrecords = new Day_Tour_Records();
            daytourrecords.Show();
            this.Hide();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
