using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace windows_Form_Application
{
    public partial class International : Form
    {


        public International()
        {
            InitializeComponent();
        }

        private void txtDeparture_TextChanged(object sender, EventArgs e)
        {
            if (txtDeparture.Text == "")
            {
                MessageBox.Show("You must enter your Depature Place", "Entry Error");
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

        private void comChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comChildren.SelectedIndex == -1)
            {
                MessageBox.Show("You must select Children", "Entry Error");
                comChildren.Focus();

            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("You must enter your Email", "Entry Error");
                txtEmail.Focus();

            }
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
            {
                MessageBox.Show("You must enter your Number", "Entry Error");
                txtNumber.Focus();

            }
        }

        private void comTicketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTicketType.SelectedIndex == -1)
            {
                MessageBox.Show("You must select Ticket Type", "Entry Error");
                comTicketType.Focus();

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

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtAccountNumber.Text == "")
            {
                MessageBox.Show("You must enter your Account Number", "Entry Error");
                txtAccountNumber.Focus();

            }
        }

        private void txtBic_TextChanged(object sender, EventArgs e)
        {
            if (txtBic.Text == "")
            {
                MessageBox.Show("You must enter your Bic", "Entry Error");
                txtBic.Focus();

            }
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Home df = new Home();
            df.Show();
            this.Hide();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=NANAQWAJO\NANAQWAJO;Initial Catalog=StarBowAirline;Integrated Security=True");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into Inter" +
                    "(Departure,Destination,Children,Email,Number,TicketType,Day,Month,Year,AccountNumber,Bic)" +
                    "Values('" + txtDeparture.Text + "','" + txtDestination.Text + "','" + comChildren.Text + "','" + txtEmail.Text + "','" + txtNumber.Text + "','" + comTicketType.Text + "','" + comDay.Text + "','" + comMonth.Text + "', '" + comYear.Text + "','" + txtAccountNumber.Text + "','" + txtBic.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("International Booking Successful");
                conn.Close();
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
