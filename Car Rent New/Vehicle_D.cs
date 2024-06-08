﻿using System;
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
    public partial class Vehicle_D : Form
    {
        SqlConnection con = null;
        public Vehicle_D()
        {
            con = new SqlConnection("Data Source=DESKTOP-U6T96L7;Initial Catalog=CarRental;Integrated Security=True");
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Vehicle_D_Load(object sender, EventArgs e)
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

        private void siButton7_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.Show();
            this.Close();
        }
    }
}
