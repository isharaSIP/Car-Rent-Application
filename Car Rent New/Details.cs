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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void siButton9_Click(object sender, EventArgs e)
        {
            
            DialogResult Information;
            Information = MessageBox.Show("Information about vehicles registered in AYUBO DRIVE is displayed in this table!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Information == DialogResult.OK)
            {
                Vehicle_D vehicle = new Vehicle_D();
                vehicle.Show();
                this.Hide();
            }
        }

        private void siButton7_Click(object sender, EventArgs e)
        {
            HomePgNw home = new HomePgNw();
            home.Show();
            this.Close();
        }

        private void siButton4_Click(object sender, EventArgs e)
        {
            
            DialogResult Information;
            Information = MessageBox.Show("Information About Packages Registered in AYUBO DRIVE is Displayed in this Table!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Information == DialogResult.OK)
            {
                Packages_D packagedetails = new Packages_D();
                packagedetails.Show();
                this.Hide();
            }
        }

        private void siButton2_Click(object sender, EventArgs e)
        {
            DialogResult Information;
            Information = MessageBox.Show("Information About Drivers Registered in AYUBO DRIVE is Displayed in this Table!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Information == DialogResult.OK)
            {
                Drivers_D driverdetails = new Drivers_D();
                driverdetails.Show();
                this.Hide();
            }
        }

        private void siButton3_Click(object sender, EventArgs e)
        {
            DialogResult Information;
            Information = MessageBox.Show("Information About Customers Registered in AYUBO DRIVE is Displayed in this Table!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Information == DialogResult.OK)
            {
                Customers_D customerdetails = new Customers_D();
                customerdetails.Show();
                this.Hide();
            }
        }
    }
}
