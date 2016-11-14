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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("You must enter your Last Name", "Entry Error");
                textBox2.Focus();

            }
        }

        private void comTravelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTravelType.SelectedIndex == -1)
            {
                MessageBox.Show("You must select Travel Type", "Entry Error");
                comTravelType.Focus();

            }
        }

        private void txtfName_TextChanged(object sender, EventArgs e)
        {
            if (txtfName.Text == "")
            {
                MessageBox.Show("You must enter your First Name", "Entry Error");
                txtfName.Focus();

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
                MessageBox.Show("You must enter your BIC", "Entry Error");
                txtBic.Focus();

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
                SqlCommand cmd = new SqlCommand("Insert into Reservation" +
                    "(TravelType,FirstName,LastName,Email,Number,Day,Month,Year,AccountNumber,Bic)" +
                    "Values('" + comTravelType.Text + "','" + txtfName.Text + "','" + textBox2.Text + "','" + txtEmail.Text + "','" + txtNumber.Text + "','" + comDay.Text + "','" + comMonth.Text + "', '" + comYear.Text + "','" + txtAccountNumber.Text + "','" + txtBic.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Booking Successful");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
