using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace windows_Form_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("You must enter your User Name", "Entry Error");
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" & txtPassword.Text != "")
            {
                Home obj = new Home();
                string msg = null;
                msg += "USER NAME: " + txtUserName.Text;
                msg += "\n" + "PASSWORD:" + txtPassword.Text + "\n";

                obj.Show();
                this.Hide();
            }

            else if (txtUserName.Text == "Admin" & txtPassword.Text == "admin")
            {
                Home F = new Home();
                F.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Check YOUR Username and Password");
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            this.Hide();
            Info Heg = new Info();
            Heg.Show();
        }
    }
}
