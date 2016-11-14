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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void txtfName_TextChanged(object sender, EventArgs e)
        {
            if (txtfName.Text == "")
            {
                MessageBox.Show("You must enter your First Name", "Entry Error");
                txtfName.Focus();
            }
        }

        private void txtmName_TextChanged(object sender, EventArgs e)
        {
            if (txtmName.Text == "")
            {
                MessageBox.Show("You must enter your Middle Name", "Entry Error");
                txtmName.Focus();
            }
        }

        private void txtlName_TextChanged(object sender, EventArgs e)
        {
            if (txtlName.Text == "")
            {
                MessageBox.Show("You must enter your Last Name", "Entry Error");
                txtlName.Focus();
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

        private void txthNumber_TextChanged(object sender, EventArgs e)
        {
            if (txthNumber.Text == "")
            {
                MessageBox.Show("You must enter your House Number", "Entry Error");
                txthNumber.Focus();
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("You must enter your User name", "Entry Error");
                txtUserName.Focus();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                MessageBox.Show("You must enter your Password", "Entry Error");
                txtPassword.Focus();
            }
        }

        private void comGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comGender.SelectedIndex == -1)
            {
                MessageBox.Show("You must select Gender", "Entry Error");
                comGender.Focus();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 df = new Form1();
            df.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
                SqlConnection conn = new SqlConnection(@"Data Source=NANAQWAJO\NANAQWAJO;Initial Catalog=StarBowAirline;Integrated Security=True");
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Info" +
                        "(FirstName,MiddleName,LastName,Gender,Email,Number,HouseNumber,UserName,Password)" +
                        "Values('" + txtfName.Text + "','" + txtmName.Text + "','" + txtlName.Text + "','" + comGender.Text+ "','" + txtEmail.Text + "','" + txtNumber.Text + "','" + txthNumber.Text + "','" + txtUserName.Text + "', '" + txtPassword.Text +"')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Successful");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
                }
        }
    }

