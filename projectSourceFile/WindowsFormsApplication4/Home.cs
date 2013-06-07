using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Please Take only for when a new class starts. AN HOUR WILL BE AUTOMATICALLY INCREASED!", "CAUTION", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                TakeAttendance take = new TakeAttendance();
                take.Show();
                this.Hide();
            }
            else { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Please Take only when a new class starts. AN HOUR WILL BE AUTOMATICALLY INCREASED!","CAUTION",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                TakeAttendance take = new TakeAttendance();
                take.Show();
                this.Hide();
            }
            else { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            stdGroupView vStd = new stdGroupView();
            vStd.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stdGroupView vStd = new stdGroupView();
            vStd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
