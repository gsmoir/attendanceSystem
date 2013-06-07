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
    public partial class stdIndivView : Form
    {
        int i = 0;
        public stdIndivView()
        {
            InitializeComponent();
        }

        private void UpdateStudentDetail_Load(object sender, EventArgs e)
        {

            
            //// TODO: This line of code loads data into the 'attendanceDataSet1.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.attendanceDataSet1.Student);
            //string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\myprojects\c#attendance\Database\attendance.accdb;Jet OLEDB:Database Password=password";
            //OleDbConnection MyConn = new OleDbConnection(ConnStr);
            //DataSet ds = new DataSet();
            //MyConn.Open();

            //int id = int.Parse(textBoxId.Text);

            //string strAttn = string.Format("Select * from Student where stdId='{0}' ", id);
            //OleDbCommand cmdAttn = new OleDbCommand(strAttn, MyConn);
            //OleDbDataReader attnDataReader = cmdAttn.ExecuteReader();
            //attnDataReader.Read();

            //textBoxName.Text = attnDataReader["stdName"].ToString();
            //textBoxDept.Text = attnDataReader["stdDept"].ToString();
            //textBoxSem.Text = attnDataReader["stdSem"].ToString();
            //textBoxSec.Text = attnDataReader["sec"].ToString();
            //textBoxCurrAttn.Text = attnDataReader["currAttn"].ToString();
            //textBoxAttnPerc.Text = attnDataReader["attnPerc"].ToString();
            //textBoxPhone.Text = attnDataReader["stdPhone"].ToString();
            //textBoxParName.Text = attnDataReader["parName"].ToString();
            //textBoxParNo.Text = attnDataReader["parPhone"].ToString();
            //textBoxAddr.Text = attnDataReader["address"].ToString();


            //MyConn.Close();

            //--------

            string connetionString = null;
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter;
            OleDbCommandBuilder oledbCmdBuilder;
            DataSet ds = new DataSet();
            //int i = 0;
            string sql = null;

            connetionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Attendance Application\Database\attendance.accdb;Jet OLEDB:Database Password=password";

            connection = new OleDbConnection(connetionString);
            sql = "select * from Student";
            try
            {
                connection.Open();  // your code must have like this
                oledbAdapter = new OleDbDataAdapter(sql, connection);
                oledbCmdBuilder = new OleDbCommandBuilder(oledbAdapter);
                oledbAdapter.Fill(ds);

                textBoxId.Text = (ds.Tables[0].Rows[i][0].ToString());
                textBoxName.Text = (ds.Tables[0].Rows[i][1].ToString());
                textBoxDept.Text = (ds.Tables[0].Rows[i][2].ToString());
                textBoxSem.Text = (ds.Tables[0].Rows[i][3].ToString());
                textBoxSec.Text = (ds.Tables[0].Rows[i][4].ToString());
                textBoxCurrAttn.Text = (ds.Tables[0].Rows[i][5].ToString());
                textBoxAttnPerc.Text = (ds.Tables[0].Rows[i][6].ToString());
                textBoxPhone.Text = (ds.Tables[0].Rows[i][7].ToString());
                textBoxParName.Text = (ds.Tables[0].Rows[i][8].ToString());
                textBoxParNo.Text = (ds.Tables[0].Rows[i][9].ToString());
                textBoxAddr.Text = (ds.Tables[0].Rows[i][10].ToString());

                //for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                //{
                //    ds.Tables[0].Rows[i].ItemArray[2] = "neweamil@email.com";
                //}
                //oledbAdapter.Update(ds.Tables[0]);
                //connection.Close();
                //MessageBox.Show("Email address updates !");


                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //------------------



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bindingSource1.MoveNext();
            
            //string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\myprojects\c#attendance\Database\attendance.accdb;Jet OLEDB:Database Password=password";
            //OleDbConnection MyConn = new OleDbConnection(ConnStr);
            //DataSet ds = new DataSet();
            //MyConn.Open();

            //int id = int.Parse(textBoxId.Text);

            //string strAttn = string.Format("Select * from Student where stdId='{0}' ", id);
            //OleDbCommand cmdAttn = new OleDbCommand(strAttn, MyConn);
            //OleDbDataReader attnDataReader = cmdAttn.ExecuteReader();
            //attnDataReader.Read();

            //textBoxName.Text = attnDataReader["stdName"].ToString();
            //textBoxDept.Text = attnDataReader["stdDept"].ToString();
            //textBoxSem.Text = attnDataReader["stdSem"].ToString();
            //textBoxSec.Text = attnDataReader["sec"].ToString();
            //textBoxCurrAttn.Text = attnDataReader["currAttn"].ToString();
            //textBoxAttnPerc.Text = attnDataReader["attnPerc"].ToString();
            //textBoxPhone.Text = attnDataReader["stdPhone"].ToString();
            //textBoxParName.Text = attnDataReader["parName"].ToString();
            //textBoxParNo.Text = attnDataReader["parPhone"].ToString();
            //textBoxAddr.Text = attnDataReader["address"].ToString();

            //MyConn.Close();

            ////CHecks and informs end of record
            //float totalCnt = bindingSource1.Count;
            //float currCnt = bindingSource1.Position;

            //if (currCnt == totalCnt - 1)
            //{
            //    MessageBox.Show("Student entry Over!");
            //    bindingSource1.EndEdit();
            //}


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
                sql = "select * from Student";

                connection.Open();  // your code must have like this
                oledbAdapter = new OleDbDataAdapter(sql, connection);
                oledbCmdBuilder = new OleDbCommandBuilder(oledbAdapter);
                oledbAdapter.Fill(ds);


                if (i < ds.Tables[0].Rows.Count - 1)
                {
                    i += 1;


                    textBoxId.Text = (ds.Tables[0].Rows[i][0].ToString());
                    textBoxName.Text = (ds.Tables[0].Rows[i][1].ToString());
                    textBoxDept.Text = (ds.Tables[0].Rows[i][2].ToString());
                    textBoxSem.Text = (ds.Tables[0].Rows[i][3].ToString());
                    textBoxSec.Text = (ds.Tables[0].Rows[i][4].ToString());
                    textBoxCurrAttn.Text = (ds.Tables[0].Rows[i][5].ToString());
                    textBoxAttnPerc.Text = (ds.Tables[0].Rows[i][6].ToString());
                    textBoxPhone.Text = (ds.Tables[0].Rows[i][7].ToString());
                    textBoxParName.Text = (ds.Tables[0].Rows[i][8].ToString());
                    textBoxParNo.Text = (ds.Tables[0].Rows[i][9].ToString());
                    textBoxAddr.Text = (ds.Tables[0].Rows[i][10].ToString());


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
                    sql = "select * from Student";

                    connection.Open();  // your code must have like this
                    oledbAdapter = new OleDbDataAdapter(sql, connection);
                    oledbCmdBuilder = new OleDbCommandBuilder(oledbAdapter);
                    oledbAdapter.Fill(ds);

                    textBoxId.Text = (ds.Tables[0].Rows[i][0].ToString());
                    textBoxName.Text = (ds.Tables[0].Rows[i][1].ToString());
                    textBoxDept.Text = (ds.Tables[0].Rows[i][2].ToString());
                    textBoxSem.Text = (ds.Tables[0].Rows[i][3].ToString());
                    textBoxSec.Text = (ds.Tables[0].Rows[i][4].ToString());
                    textBoxCurrAttn.Text = (ds.Tables[0].Rows[i][5].ToString());
                    textBoxAttnPerc.Text = (ds.Tables[0].Rows[i][6].ToString());
                    textBoxPhone.Text = (ds.Tables[0].Rows[i][7].ToString());
                    textBoxParName.Text = (ds.Tables[0].Rows[i][8].ToString());
                    textBoxParNo.Text = (ds.Tables[0].Rows[i][9].ToString());
                    textBoxAddr.Text = (ds.Tables[0].Rows[i][10].ToString());


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

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Login lg = new Login();
            lg.Show();
            this.Close();
        }
    }
}
