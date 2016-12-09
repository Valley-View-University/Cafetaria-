using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaNewProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("You must enter your User ID", "Entry Error");
                textBox1.Focus();

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

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & txtPassword.Text != "")
            {
                Authenticate obj = new Authenticate();
                string msg = null;
                msg += "USER ID: " + textBox1.Text;
                msg += "\n" + "PASSWORD:" + txtPassword.Text + "\n";

                obj.Show();
                this.Hide();
            }

            else if (textBox1.Text == "Admin" & txtPassword.Text == "admin")
            {
                Authenticate k = new Authenticate();
                k.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Check YOUR Username and Password");
            }
           
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewStudent Heg = new NewStudent();
            Heg.Show();
        }
    }
}
