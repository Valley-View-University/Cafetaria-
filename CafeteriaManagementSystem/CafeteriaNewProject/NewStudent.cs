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
    public partial class NewStudent : Form
    {
        public NewStudent()
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
                MessageBox.Show("You must select Department", "Entry Error");
                comDepartment.Focus();
            }
        }

        private void comHall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comHall.SelectedIndex == -1)
            {
                MessageBox.Show("You must select Hall", "Entry Error");
                comHall.Focus();
            }
        }

        private void comFull_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comFull.SelectedIndex == -1)
            {
                MessageBox.Show("You must select Feeding", "Entry Error");
                comFull.Focus();
            }
        }


        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentId.Text == "")
            {
                MessageBox.Show("You must enter your Student ID", "Entry Error");
                txtStudentId.Focus();
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

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
            {
                MessageBox.Show("You must enter your Number", "Entry Error");
                txtNumber.Focus();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("You must enter your Student Email", "Entry Error");
                txtEmail.Focus();
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
            this.Hide();
            Form1 Get = new Form1();
            Get.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=cafeteria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
             
             try
             {
                 conn.Open();
                 if (txtFname.Text == "" & txtMname.Text == "" & txtLname.Text == "" & txtStudentId.Text == "" & txtPassword.Text == "" & txtNumber.Text == "" & txtEmail.Text == "")
                 {


                     MessageBox.Show("Please all forms required");

                 }
                 else
                 {


                     SqlCommand com = new SqlCommand("Insert into Registration(FirstName,MiddleName,LastName,Department,Hall,FeedingType,StudentID,Password,Number,Email,Gender) Values('" + txtFname.Text + "','" + txtMname.Text + "','" + txtLname.Text + "','" + comDepartment.Text + "','" + comHall.Text + "','" + comFull.Text + "','" + txtStudentId.Text + "','" + txtPassword.Text + "', '" + txtNumber.Text + "', '" + txtEmail.Text + "', '" + comGender.Text + "')", conn);
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