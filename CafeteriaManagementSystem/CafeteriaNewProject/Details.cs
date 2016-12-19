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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeteriaDataSet13.Mondays' table. You can move, or remove it, as needed.
            this.mondaysTableAdapter1.Fill(this.cafeteriaDataSet13.Mondays);
            // TODO: This line of code loads data into the 'cafeteriaDataSet12.Sundays' table. You can move, or remove it, as needed.
            this.sundaysTableAdapter.Fill(this.cafeteriaDataSet12.Sundays);
            // TODO: This line of code loads data into the 'cafeteriaDataSet11.Saturdays' table. You can move, or remove it, as needed.
            this.saturdaysTableAdapter.Fill(this.cafeteriaDataSet11.Saturdays);
            // TODO: This line of code loads data into the 'cafeteriaDataSet10.Fridays' table. You can move, or remove it, as needed.
            this.fridaysTableAdapter.Fill(this.cafeteriaDataSet10.Fridays);
            // TODO: This line of code loads data into the 'cafeteriaDataSet9.Thursdays' table. You can move, or remove it, as needed.
            this.thursdaysTableAdapter.Fill(this.cafeteriaDataSet9.Thursdays);
            // TODO: This line of code loads data into the 'cafeteriaDataSet8.Wednesdays' table. You can move, or remove it, as needed.
            this.wednesdaysTableAdapter.Fill(this.cafeteriaDataSet8.Wednesdays);
            // TODO: This line of code loads data into the 'cafeteriaDataSet7.Tuesdays' table. You can move, or remove it, as needed.
            this.tuesdaysTableAdapter.Fill(this.cafeteriaDataSet7.Tuesdays);
            // TODO: This line of code loads data into the 'cafeteriaDataSet6.Mondays' table. You can move, or remove it, as needed.
            this.mondaysTableAdapter.Fill(this.cafeteriaDataSet6.Mondays);
            // TODO: This line of code loads data into the 'cafeteriaDataSet5.Deliverys' table. You can move, or remove it, as needed.
            this.deliverysTableAdapter.Fill(this.cafeteriaDataSet5.Deliverys);
            // TODO: This line of code loads data into the 'cafeteriaDataSet4.Registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter.Fill(this.cafeteriaDataSet4.Registration);
            // TODO: This line of code loads data into the 'cafeteriaDataSet2.Delivery' table. You can move, or remove it, as needed.
            this.deliveryTableAdapter.Fill(this.cafeteriaDataSet2.Delivery);

        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            dataGridView7.Visible = false;
            dataGridView8.Visible = false;
            dataGridView9.Visible = false;

        }

        private void btnViewDelivery_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            dataGridView7.Visible = false;
            dataGridView8.Visible = false;
            dataGridView9.Visible = false;

        }

        private void btnMondayOrder_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            dataGridView7.Visible = false;
            dataGridView8.Visible = false;
            dataGridView9.Visible = false;


        }

        private void btnTuesdayOrder_Click(object sender, EventArgs e)
        {
            dataGridView4.Visible = true;
            dataGridView3.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            dataGridView7.Visible = false;
            dataGridView8.Visible = false;
            dataGridView9.Visible = false;

        }

        private void btnWednsdayOrder_Click(object sender, EventArgs e)
        {
            dataGridView5.Visible = true;
            dataGridView4.Visible = false;
            dataGridView3.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView6.Visible = false;
            dataGridView7.Visible = false;
            dataGridView8.Visible = false;
            dataGridView9.Visible = false;

        }

        private void btnThusdayOrder_Click(object sender, EventArgs e)
        {
            dataGridView6.Visible = true;
            dataGridView5.Visible = false;
            dataGridView4.Visible = false;
            dataGridView3.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView7.Visible = false;
            dataGridView8.Visible = false;
            dataGridView9.Visible = false;

        }

        private void btnFridayOrder_Click(object sender, EventArgs e)
        {
            dataGridView7.Visible = true;
            dataGridView6.Visible = false;
            dataGridView5.Visible = false;
            dataGridView4.Visible = false;
            dataGridView3.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView8.Visible = false;
            dataGridView9.Visible = false;

        }

        private void btnSaturdayOrder_Click(object sender, EventArgs e)
        {
            dataGridView8.Visible = true;
            dataGridView7.Visible = false;
            dataGridView6.Visible = false;
            dataGridView5.Visible = false;
            dataGridView4.Visible = false;
            dataGridView3.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView9.Visible = false;

        }

        private void btnSundayOrder_Click(object sender, EventArgs e)
        {
            dataGridView9.Visible = true;
            dataGridView8.Visible = false;
            dataGridView7.Visible = false;
            dataGridView6.Visible = false;
            dataGridView5.Visible = false;
            dataGridView4.Visible = false;
            dataGridView3.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
        }
    }
}
