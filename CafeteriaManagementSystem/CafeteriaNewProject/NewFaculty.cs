using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeteriaNewProject
{
    public partial class NewFaculty : Form
    {
        public NewFaculty()
        {
            InitializeComponent();
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            if (txtFname.Text == "")
            {
                MessageBox.Show("You must enter your First Name", "Entry Error");
                txtFname.Focus();
            }
        }

        private void txtMname_TextChanged(object sender, EventArgs e)
        {
            if (txtMname.Text == "")
            {
                MessageBox.Show("You must enter your Middle Name", "Entry Error");
                txtMname.Focus();
            }
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {
            if (txtLname.Text == "")
            {
                MessageBox.Show("You must enter your Last Name", "Entry Error");
                txtLname.Focus();
            }
        }

        private void comDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Department Name", "Entry Error");
                comDepartment.Focus();
            }
        }

        private void comGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comGender.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Gender", "Entry Error");
                comGender.Focus();
            }
        }

        private void txtFacultyId_TextChanged(object sender, EventArgs e)
        {
            if (txtFacultyId.Text == "")
            {
                MessageBox.Show("You must enter your Faculty ID", "Entry Error");
                txtFacultyId.Focus();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Try = new Form1();
            Try.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=cafeteria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");

                try
                {
                    conn.Open();

                    if (txtFname.Text == "" & txtMname.Text == "" & txtLname.Text == ""  & txtFacultyId.Text == "" & txtPassword.Text == "")
                    {


                        MessageBox.Show("Please all forms required");

                    }
                    else
                    {


                    

                    SqlCommand com = new SqlCommand("Insert into Registration(FirstName,MiddleName,LastName,Department,Gender,FacultyID,Password) Values('" + txtFname.Text + "','" + txtMname.Text + "','" + txtLname.Text + "','" + comDepartment.Text + "','" + comGender.Text + "','" + txtFacultyId.Text + "','" + txtPassword.Text + "')", conn);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Registration Successful");
                    conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
