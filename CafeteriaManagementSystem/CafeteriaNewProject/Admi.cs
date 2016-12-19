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
    public partial class Admi : Form
    {
        public Admi()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=cafeteria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            SqlDataAdapter adapta = new SqlDataAdapter("SELECT COUNT (*) FROM Admin WHERE ID= '" + txtID.Text + "' AND Password= '" + txtPassword.Text + "' ", conn);
            

            DataTable table = new DataTable();
            adapta.Fill(table);

            if (table.Rows[0][0].ToString() == "1")
            {
                Hide();
                Details cut = new Details();
                cut.Show();
            }

            else
            {
                MessageBox.Show("You are not an Administrator");

            }
           
        }
    }
}
