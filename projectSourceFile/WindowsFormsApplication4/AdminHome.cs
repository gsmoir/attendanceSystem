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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            stdGroupView vStd = new stdGroupView();
            vStd.Show();
            
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            stdGroupView vStd = new stdGroupView();
            vStd.Show();
            
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ViewStaffDetails vStaffd = new ViewStaffDetails();
            vStaffd.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ViewStaffDetails vStaffd = new ViewStaffDetails();
            vStaffd.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CAUTION: Records once modified/Deleted can't be retrieved. Do it carefully!");            
            
            UpdateStudentDetails us = new UpdateStudentDetails();
            us.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CAUTION: Records once modified/Deleted can't be retrieved. Do it carefully!");
            
            UpdateStaffDetails ust = new UpdateStaffDetails();
            ust.Show();
            this.Hide();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateStudentDetails us = new UpdateStudentDetails();
            us.Show();
            this.Hide();
        }

        private void staffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateStaffDetails us = new UpdateStaffDetails();
            us.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
