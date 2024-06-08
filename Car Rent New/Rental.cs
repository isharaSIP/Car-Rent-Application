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
    public partial class Rental : Form
    {
        SqlConnection con = null; //2nd step
        public Rental()
        {
            con = new SqlConnection("Data Source=DESKTOP-U6T96L7;Initial Catalog=CarRental;Integrated Security=True"); //3rd step
            InitializeComponent();
        }

        //Declare Variables

        TimeSpan totalDays;
        decimal dailyRent;
        decimal weeklyRent;
        decimal monthlyRent;
        int driverCharge;
        decimal total;
        decimal withDriver;


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

        private void timecalculation()
        {
            //Time Calculation

            DateTime RentDate = DateTime.Parse(dateTimePicker1.Text);
            DateTime ReturnDate = DateTime.Parse(dateTimePicker2.Text);

            totalDays = ReturnDate - RentDate;
            txtTotalDays.Text = totalDays.Days.ToString();
        }

        private void RentCalculation()
        {
            // Rent Calculation
            try
            {
                con.Open();
                
                string vehicletype = comboBoxVehicleType.Text;
                string query = "SELECT Daily_Price,Weekly_Price,Monthly_Price FROM Vehicle_tblnw WHERE Type = '" + vehicletype + "';SELECT Driver_Charge FROM Package_tbl WHERE Package_ID=1 ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        dailyRent = rdr.GetDecimal(0);
                        weeklyRent = rdr.GetDecimal(1);
                        monthlyRent = rdr.GetDecimal(2);
                    }
                }
                if (rdr.NextResult())
                {
                    while (rdr.Read())
                    {
                        driverCharge = rdr.GetInt32(0);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            int totalDays = int.Parse(txtTotalDays.Text);
            withDriver = (driverCharge * totalDays);

            //Rent Calculation With Driver

            if (checkBoxDriver.Checked == true)
            {
                if (totalDays / 7 == 1)
                {
                    total = (weeklyRent + withDriver);
                    txtTotalCharge.Text = ("Rs." + total.ToString());
                }
                if (totalDays / 7 == 2)
                {
                    total = (weeklyRent * 2) + withDriver;
                    txtTotalCharge.Text = ("Rs." + total.ToString());
                }
                if (totalDays / 7 == 3)
                {
                    total = (weeklyRent * 3) + withDriver;
                    txtTotalCharge.Text = ("Rs." + total.ToString());
                }
                if (totalDays / 7 == 4)
                {
                    total = (weeklyRent * 4) + withDriver;
                    txtTotalCharge.Text = ("Rs." + total.ToString());
                }
                if (totalDays < 7)
                {
                    total = (dailyRent * totalDays) + withDriver;
                    txtTotalCharge.Text = ("Rs." + total.ToString());
                }
                if (totalDays > 7)
                {
                    total = (dailyRent * totalDays) + withDriver;
                    txtTotalCharge.Text = ("Rs." + total.ToString());
                }
                if (totalDays % 30 == 0)
                {
                    total = (monthlyRent + withDriver);
                    txtTotalCharge.Text = ("Rs." + total.ToString());
                }
            }

            // Rent Calculation Without Driver

            if (checkBoxDriver.Checked == false)
            {
                if (totalDays / 7 == 1)
                {
                    total = (weeklyRent);
                    txtTotalCharge.Text = ("Rs." + total.ToString());
                }
                if (totalDays / 7 == 2)
                {
                    total = (weeklyRent * 2);
                    txtTotalCharge.Text = ("Rs." + total.ToString());
                }
                if (totalDays / 7 == 3)
                {
                    total = (weeklyRent * 3);
                    txtTotalCharge.Text = ("Rs." + total.ToString());
                }
                if (totalDays / 7 == 4)
                {
                    total = (weeklyRent * 4);
                    txtTotalCharge.Text = ("Rs." + total.ToString());
                }
                if (totalDays < 7)
                {
                    total = (dailyRent * totalDays);
                    txtTotalCharge.Text = ("Rs." + total.ToString());
                }
                if (totalDays > 7)
                {
                    total = (dailyRent * totalDays);
                    txtTotalCharge.Text = ("Rs." + total.ToString());
                }
                if (totalDays % 30 == 0)
                {
                    total = (monthlyRent);
                    txtTotalCharge.Text = ("Rs." + total.ToString());
                }
            }

        }

        private void siButton7_Click(object sender, EventArgs e)
        {
            

        }

        private void Rental_Load(object sender, EventArgs e)
        {
            loadvehiclecombo();
        }

        private void siButton1_Click(object sender, EventArgs e)
        {
            timecalculation();
            RentCalculation();
            
        }

        private void siButton4_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert Payment Record 
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string id = txtRentID.Text;
                string driverID = txtDriverID.Text;
                string vehicletype = comboBoxVehicleType.SelectedItem.ToString();
                string rentdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string returndate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string totaldays = txtTotalDays.Text;
                string totalcharge = txtTotalCharge.Text;

                DialogResult Payment;
                Payment = MessageBox.Show("Confirm the payment", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Payment == DialogResult.Yes)

                {
                    cmd.CommandText = "INSERT INTO Rent_tbl (Driver_ID,Vehicle_Type,Rent_Date,Return_Date,Total_Days,Total_Charge) VALUES ('" + driverID + "','" + vehicletype + "','" + rentdate + "','" + returndate + "','" + totaldays + "','" + totalcharge + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Payment Successfully!");
                }

                txtRentID.Clear();
                txtDriverID.Clear();
                txtTotalCharge.Clear();
                txtTotalDays.Clear();             
                comboBoxVehicleType.ResetText();
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg" + ex);
            }
        }

        private void siButton2_Click(object sender, EventArgs e)
        {
            HomePgNw Home = new HomePgNw();
            Home.Show();
            this.Close();
        }

        private void siButton5_Click(object sender, EventArgs e)
        {
            Rent_Records rentrecords = new Rent_Records();
            rentrecords.Show();
            this.Hide();
        }

        private void siButton3_Click(object sender, EventArgs e)
        {
            txtRentID.Clear();
            txtDriverID.Clear();
            txtTotalCharge.Clear();
            txtTotalDays.Clear();
            checkBoxDriver.Checked = false;
            comboBoxVehicleType.ResetText();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}
