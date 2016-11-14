using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace windows_Form_Application
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StateUse Heg = new StateUse();
            Heg.Show();
        }

        private void btnInternational_Click(object sender, EventArgs e)
        {
            this.Hide();
            International Heg = new International();
            Heg.Show();
        }

        private void btnDomestic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Domestic Heg = new Domestic();
            Heg.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation Heg = new Reservation();
            Heg.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 df = new Form1();
            df.Show();
            this.Hide();
        }
    }
}
