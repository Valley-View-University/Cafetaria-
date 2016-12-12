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
    public partial class Authenticate : Form
    {
        public Authenticate()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 df = new Form1();
            df.Show();
            this.Hide();
        }

        private void comThuBreakFast_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comThuBreakFast.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your BreakFast", "Entry Error");
                comThuBreakFast.Focus();
            }
        }

        private void comThuLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comThuLunch.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Lunch", "Entry Error");
                comThuLunch.Focus();
            }
        }

        private void comThuSuper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comThuSuper.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Supper", "Entry Error");
                comThuSuper.Focus();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comFriBreakFast_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comFriBreakFast.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your BreakFast", "Entry Error");
                comFriBreakFast.Focus();
            }
        }

        private void comFriLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comFriLunch.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Lunch", "Entry Error");
                comFriLunch.Focus();
            }
        }

        private void comFriSuper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comFriSuper.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Supper", "Entry Error");
                comFriSuper.Focus();
            }
        }

        private void comSatBreakFast_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comSatBreakFast.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your BreakFast", "Entry Error");
                comSatBreakFast.Focus();
            }
        }

        private void comSatLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comSatLunch.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Lunch", "Entry Error");
                comSatLunch.Focus();
            }
        }

        private void comSatSuper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comSatSuper.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Supper", "Entry Error");
                comSatSuper.Focus();
            }
        }

        private void comSunBreakFast_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comSunBreakFast.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your BreakFast", "Entry Error");
                comSunBreakFast.Focus();
            }
        }

        private void comSunLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comSunLunch.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Lunch", "Entry Error");
                comSunLunch.Focus();
            }
        }

        private void comSunSuper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comSunSuper.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Supper", "Entry Error");
                comSunSuper.Focus();
            }
        }

        private void comMonBreakFast_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comMonBreakFast.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your BreakFast", "Entry Error");
                comMonBreakFast.Focus();
            }
        }

        private void comMonLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comMonLunch.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Lunch", "Entry Error");
                comMonLunch.Focus();
            }
        }

        private void comMonSuper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comMonSuper.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Supper", "Entry Error");
                comMonSuper.Focus();
            }
        }

        private void comTueBreakFast_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTueBreakFast.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your BreakFast", "Entry Error");
                comTueBreakFast.Focus();
            }
        }

        private void comTueLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTueLunch.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your LunchBreakFast", "Entry Error");
                comTueLunch.Focus();
            }
        }

        private void comTueSuper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTueSuper.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Supper", "Entry Error");
                comTueSuper.Focus();
            }
        }

        private void comWedBreakFast_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comWedBreakFast.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your BreakFast", "Entry Error");
                comWedBreakFast.Focus();
            }
        }

        private void comWedLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comWedLunch.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Lunch", "Entry Error");
                comWedLunch.Focus();
            }
        }

        private void comWedSuper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comWedSuper.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Supper", "Entry Error");
                comWedSuper.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Delivery Type", "Entry Error");
                comboBox1.Focus();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your BreakFast Time", "Entry Error");
                comboBox2.Focus();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Lunch Time", "Entry Error");
                comboBox3.Focus();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter your Supper Time", "Entry Error");
                comboBox4.Focus();
            }
        }

        private void comSpecialDiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comSpecialDiet.SelectedIndex == -1)
            {
                MessageBox.Show("Select if You on a special diet", "Entry Error");
                comSpecialDiet.Focus();
            }
        }
    }
}
