using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rent_New
{
    public partial class HomePgNw : Form
    {
        public HomePgNw()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToShortDateString();
        }

        private void siButton7_Click(object sender, EventArgs e)
        {
            DialogResult HomeExit;
            HomeExit = MessageBox.Show("Confirm if you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(HomeExit == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void siButton2_Click(object sender, EventArgs e)
        {
            DriverDetails driver = new DriverDetails();
            driver.Show();
            this.Hide();
        }

        private void siButton3_Click(object sender, EventArgs e)
        {
            CustomerDetails customer = new CustomerDetails();
            customer.Show();
            this.Hide();
        }

        private void siButton1_Click(object sender, EventArgs e)
        {

        }

        private void siButton9_Click(object sender, EventArgs e)
        {
            VehicleDetails vehicle = new VehicleDetails();
            vehicle.Show();
            this.Hide();

        }

        private void siButton4_Click(object sender, EventArgs e)
        {
            Packages package = new Packages();
            package.Show();
            this.Hide();
        }

        private void siButton1_Click_1(object sender, EventArgs e)
        {
            DayTour Dtour = new DayTour();
            Dtour.Show();
            this.Hide();
        }

        private void siButton8_Click(object sender, EventArgs e)
        {
            LongTour Ltour = new LongTour();
            Ltour.Show();
            this.Hide();
        }

        private void siButton5_Click(object sender, EventArgs e)
        {
            Rental Rent = new Rental();
            Rent.Show();
            this.Hide();
        }

        private void siButton6_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siButton10_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void siButton11_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siButton11_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siButton12_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }
    }
}
