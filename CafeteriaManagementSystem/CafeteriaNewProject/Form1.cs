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
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=cafeteria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            SqlDataAdapter adapta = new SqlDataAdapter("SELECT COUNT (*) FROM Registration WHERE StudentID= '" + textBox1.Text + "' AND Password= '" + txtPassword.Text + "' ", conn);
            SqlDataAdapter help = new SqlDataAdapter("SELECT COUNT (*) FROM Registration WHERE FacultyID= '" + textBox1.Text + "' AND Password= '" + txtPassword.Text + "' ", conn);
            
            DataTable table = new DataTable();
            adapta.Fill(table);

                if (table.Rows[0][0].ToString()=="1"){
                    Hide();
                    Authenticate open = new Authenticate();
                    open.Show();
                }

                else
                {
                    MessageBox.Show("You are not registered");

                }
           
        
        
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewStudent Heg = new NewStudent();
            Heg.Show();
        }

        private void btnNewFaculty_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewFaculty Pen = new NewFaculty();
            Pen.Show();

            
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admi rr = new Admi();
            rr.Show();

                
        }
    }
}
