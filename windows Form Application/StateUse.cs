using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace windows_Form_Application
{
    public partial class StateUse : Form
    {
        public StateUse()
        {
            InitializeComponent();
        }

        private void comTravelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTravelType.SelectedIndex == -1)
            {
                MessageBox.Show("You must select Travel Type", "Entry Error");
                comTravelType.Focus();

            }
        }

        private void txtDeparture_TextChanged(object sender, EventArgs e)
        {
            if (txtDeparture.Text == "")
            {
                MessageBox.Show("You must enter your Departure", "Entry Error");
                txtDeparture.Focus();

            }
        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {
            if (txtDestination.Text == "")
            {
                MessageBox.Show("You must enter your Destination", "Entry Error");
                txtDestination.Focus();

            }
        }

        private void txtOffice_TextChanged(object sender, EventArgs e)
        {
            if (txtOffice.Text == "")
            {
                MessageBox.Show("You must enter your Office", "Entry Error");
                txtOffice.Focus();

            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("You must enter your Code", "Entry Error");
                txtCode.Focus();

            }
        }

        private void comDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comDay.SelectedIndex == -1)
            {
                MessageBox.Show("You must select day", "Entry Error");
                comDay.Focus();

            }
        }

        private void comMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comMonth.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a Month", "Entry Error");
                comMonth.Focus();

            }
        }

        private void comYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comYear.SelectedIndex == -1)
            {
                MessageBox.Show("You must select Year", "Entry Error");
                comYear.Focus();

            }
        }

        private void txtIdNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtIdNumber.Text == "")
            {
                MessageBox.Show("You must enter your ID Number", "Entry Error");
                txtIdNumber.Focus();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Home df = new Home();
            df.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=NANAQWAJO\NANAQWAJO;Initial Catalog=StarBowAirline;Integrated Security=True");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into StateUse" +
                    "(TravelType,Departure,Destination,Office,Code,Day,Month,Year,IdNumber)" +
                    "Values('" + comTravelType.Text + "','" + txtDeparture.Text + "','" + txtDestination.Text + "','" + txtOffice.Text + "','" + txtCode.Text + "','" + comDay.Text + "','" + comMonth.Text + "', '" + comYear.Text + "','" + txtIdNumber.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("State Use Booking Successful");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
