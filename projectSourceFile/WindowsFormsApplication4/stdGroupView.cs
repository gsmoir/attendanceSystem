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
    public partial class stdGroupView : Form
    {
        public stdGroupView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Attendance Application\Database\attendance.accdb;Jet OLEDB:Database Password=password";
            OleDbConnection MyConn = new OleDbConnection(ConnStr);
            DataSet ds = new DataSet();
            MyConn.Open();

            //---Part for total hours display
            string strRetr = "Select totalHours from TotalHours";
            OleDbCommand cmdRetr = new OleDbCommand(strRetr, MyConn);

            OleDbDataReader myDataReader = cmdRetr.ExecuteReader();

            myDataReader.Read();
            int a = int.Parse(myDataReader["totalHours"].ToString());
            textBoxTotal.Text = a.ToString();

            //-----

            //---part for grid view starts

            //OleDbDataAdapter sda = new OleDbDataAdapter("select * from Student", MyConn);
            
            //sda.Fill(ds);
            //dataGridView1.DataSource = ds;
            //dataGridView1.DataBind();

            OleDbCommand sCommand = new OleDbCommand("select * from Student", MyConn);
            OleDbDataAdapter sAdapter = new OleDbDataAdapter(sCommand);
            OleDbCommandBuilder sBuilder = new OleDbCommandBuilder(sAdapter);

            sAdapter.Fill(ds, "Student");
            DataTable sTable = ds.Tables["Student"];
            MyConn.Close();
            dataGridView1.DataSource = ds.Tables["Student"];
            dataGridView1.ReadOnly = true;
            //save_btn.Enabled = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                
            


        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stdIndivView vs = new stdIndivView();
            vs.Show();

            
        }

        private void vIEWINDIVIDUALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stdIndivView vs = new stdIndivView();
            vs.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Attendance Application\Database\attendance.accdb;Jet OLEDB:Database Password=password";
            OleDbConnection MyConn = new OleDbConnection(ConnStr);
            DataSet ds = new DataSet();
            MyConn.Open();


            OleDbCommand sCommand = new OleDbCommand("select * from Student where attnPerc < 75", MyConn);
            OleDbDataAdapter sAdapter = new OleDbDataAdapter(sCommand);
            OleDbCommandBuilder sBuilder = new OleDbCommandBuilder(sAdapter);

            sAdapter.Fill(ds, "Student");
            DataTable sTable = ds.Tables["Student"];
            MyConn.Close();
            dataGridView1.DataSource = ds.Tables["Student"];
            dataGridView1.ReadOnly = true;
            //save_btn.Enabled = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                
        }
    }
}
