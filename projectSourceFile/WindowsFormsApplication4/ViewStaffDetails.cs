using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication4
{
    public partial class ViewStaffDetails : Form
    {
        int i=0;
        public ViewStaffDetails()
        {
            InitializeComponent();
        }

        private void UpdateStaffDetails_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'attendanceDataSet1.Staff' table. You can move, or remove it, as needed.
            //this.staffTableAdapter.Fill(this.attendanceDataSet1.Staff);


            //define vars
            string connetionString = null;
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter;
            OleDbCommandBuilder oledbCmdBuilder;
            DataSet ds = new DataSet();
            //int i = 0;
            string sql = null;

            connetionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Attendance Application\Database\attendance.accdb;Jet OLEDB:Database Password=password";

            connection = new OleDbConnection(connetionString);
            sql = "select * from Staff";
            try
            {
                connection.Open();  // your code must have like this
                oledbAdapter = new OleDbDataAdapter(sql, connection);
                oledbCmdBuilder = new OleDbCommandBuilder(oledbAdapter);
                oledbAdapter.Fill(ds);

                textBoxId.Text = (ds.Tables[0].Rows[i][0].ToString());
                textBoxName.Text = (ds.Tables[0].Rows[i][1].ToString());
                textBoxPw.Text = (ds.Tables[0].Rows[i][2].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            connection.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString = null;
                OleDbConnection connection;
                OleDbDataAdapter oledbAdapter;
                OleDbCommandBuilder oledbCmdBuilder;
                DataSet ds = new DataSet();
                //int i = 0;
                string sql = null;

                connetionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Attendance Application\Database\attendance.accdb;Jet OLEDB:Database Password=password";

                connection = new OleDbConnection(connetionString);
                sql = "select * from Staff";

                connection.Open();  // your code must have like this
                oledbAdapter = new OleDbDataAdapter(sql, connection);
                oledbCmdBuilder = new OleDbCommandBuilder(oledbAdapter);
                oledbAdapter.Fill(ds);


                if (i < ds.Tables[0].Rows.Count - 1)
                {
                    i += 1;


                    textBoxId.Text = (ds.Tables[0].Rows[i][0].ToString());
                    textBoxName.Text = (ds.Tables[0].Rows[i][1].ToString());
                    textBoxPw.Text = (ds.Tables[0].Rows[i][2].ToString());


                }

                else
                {
                    MessageBox.Show("Its the Last Entry!");

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (i > 0)
                {
                    i -= 1;
                    string connetionString = null;
                    OleDbConnection connection;
                    OleDbDataAdapter oledbAdapter;
                    OleDbCommandBuilder oledbCmdBuilder;
                    DataSet ds = new DataSet();
                    //int i = 0;
                    string sql = null;

                    connetionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Attendance Application\Database\attendance.accdb;Jet OLEDB:Database Password=password";

                    connection = new OleDbConnection(connetionString);
                    sql = "select * from Staff";

                    connection.Open();  // your code must have like this
                    oledbAdapter = new OleDbDataAdapter(sql, connection);
                    oledbCmdBuilder = new OleDbCommandBuilder(oledbAdapter);
                    oledbAdapter.Fill(ds);

                    textBoxId.Text = (ds.Tables[0].Rows[i][0].ToString());
                    textBoxName.Text = (ds.Tables[0].Rows[i][1].ToString());
                    textBoxPw.Text = (ds.Tables[0].Rows[i][2].ToString());
               

                }

                else
                {
                    MessageBox.Show("Its the first Entry!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            ah.Show();
            this.Close();

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminHome ah = new AdminHome();
            ah.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
