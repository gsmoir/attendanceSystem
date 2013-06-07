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
    public partial class UpdateStudentDetails : Form
    {

        int i=0;

        public UpdateStudentDetails()
        {
            InitializeComponent();
        }

        private void UpdateStudentDetails_Load(object sender, EventArgs e)
        {
            //string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\myprojects\c#attendance\Database\attendance.accdb;Jet OLEDB:Database Password=password";
            //OleDbConnection MyConn = new OleDbConnection(ConnStr);
            //DataSet ds = new DataSet();
            //MyConn.Open();
            //string strAttn = string.Format("Select * from Student");
            //OleDbCommand cmdAttn = new OleDbCommand(strAttn, MyConn);
            //OleDbDataReader attnDataReader = cmdAttn.ExecuteReader();
            //attnDataReader.Read();

           
            //int id = int.Parse(textBoxId.Text);

            
            //----------------

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
            sql = "select * from Student";
            try
            {
                connection.Open();  // your code must have like this
                oledbAdapter = new OleDbDataAdapter(sql, connection);
                oledbCmdBuilder = new OleDbCommandBuilder(oledbAdapter);
                oledbAdapter.Fill(ds);

                textBoxId.Text= (ds.Tables[0].Rows[i][0].ToString());
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //------------------


            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
                sql = "select * from Student";

                connection.Open();  // your code must have like this
                oledbAdapter = new OleDbDataAdapter(sql, connection);
                oledbCmdBuilder = new OleDbCommandBuilder(oledbAdapter);
                oledbAdapter.Fill(ds);


                if (i < ds.Tables[0].Rows.Count-1)
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxDept.Text = "";
            textBoxSem.Text = "";
            textBoxSec.Text = "";
            textBoxCurrAttn.Text = "";
            textBoxAttnPerc.Text = "";
            textBoxPhone.Text = "";
            textBoxParName.Text = "";
            textBoxParNo.Text = "";
            textBoxAddr.Text = "";
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to Update?","Update",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {


                try
                {
                    string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Attendance Application\Database\attendance.accdb;Jet OLEDB:Database Password=password";
                    OleDbConnection MyConn = new OleDbConnection(ConnStr);
                    DataSet ds = new DataSet();
                    MyConn.Open();

                    string updStr = String.Format("");
                    //OleDbCommand updCmd = new OleDbCommand(updStr,MyConn);
                    ////OleDbDataAdapter da=new OleDbDataAdapter(updStr,MyConn);
                    //OleDbDataReader ObjReader = updCmd.ExecuteReader();
                    ////da.Fill(ds);


                    //using (OleDbDataReader myDataReader = updCmd.ExecuteReader())
                    //{
                    //    textBoxName.Text = ObjReader["stdName"].ToString();
                    //}

                    int id = int.Parse(textBoxId.Text);
                    string name = textBoxName.Text;
                    string dept = textBoxDept.Text;
                    int sem = int.Parse(textBoxSem.Text);
                    string sec = textBoxSec.Text;
                    int attn = int.Parse(textBoxCurrAttn.Text);
                    float perc = float.Parse(textBoxAttnPerc.Text);
                    string ph = textBoxPhone.Text;
                    string pName = textBoxParName.Text;
                    string pPhone = textBoxParNo.Text;
                    string addr = textBoxAddr.Text;


                    string strAttnUpdate = string.Format("Update Student Set stdId='{0}',stdName='{1}',stdDept='{2}',stdSem='{3}',sec='{4}',currAttn='{5}',attnPerc='{6}',stdPhone ='{7}',parName='{8}',parPhone='{9}',address='{10}' where stdId= '{0}' ", id, name, dept, sem, sec, attn, perc, ph, pName, pPhone, addr);
                    using (OleDbCommand cmd = new OleDbCommand(strAttnUpdate, MyConn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Details Successfully Updated!");

                    MyConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else if(dr==DialogResult.No)
            {


            }
                
           
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = MessageBox.Show("Are you sure to DELETE?","Delete",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Attendance Application\Database\attendance.accdb;Jet OLEDB:Database Password=password";
                    OleDbConnection MyConn = new OleDbConnection(ConnStr);
                    DataSet ds = new DataSet();
                    MyConn.Open();

                    int id = int.Parse(textBoxId.Text);
                    string strAttnUpdate = string.Format("DELETE FROM Student where stdId='{0}'", id);
                    using (OleDbCommand cmd = new OleDbCommand(strAttnUpdate, MyConn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    textBoxId.Text = "";
                    textBoxName.Text = "";
                    textBoxDept.Text = "";
                    textBoxSem.Text = "";
                    textBoxSec.Text = "";
                    textBoxCurrAttn.Text = "";
                    textBoxAttnPerc.Text = "";
                    textBoxPhone.Text = "";
                    textBoxParName.Text = "";
                    textBoxParNo.Text = "";
                    textBoxAddr.Text = "";

                    MessageBox.Show("Details DELETED Successfully!");

                    MyConn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }

            }
            else { }
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = MessageBox.Show("Are you sure to INSERT this detail?","Insert",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {

                    string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Attendance Application\Database\attendance.accdb;Jet OLEDB:Database Password=password";
                    OleDbConnection MyConn = new OleDbConnection(ConnStr);
                    DataSet ds = new DataSet();
                    MyConn.Open();

                    string updStr = String.Format("");

                    int id = int.Parse(textBoxId.Text);
                    string name = textBoxName.Text;
                    string dept = textBoxDept.Text;
                    int sem = int.Parse(textBoxSem.Text);
                    string sec = textBoxSec.Text;
                    int attn = int.Parse(textBoxCurrAttn.Text);
                    float perc = float.Parse(textBoxAttnPerc.Text);
                    string ph = textBoxPhone.Text;
                    string pName = textBoxParName.Text;
                    string pPhone = textBoxParNo.Text;
                    string addr = textBoxAddr.Text;


                    string strAttnUpdate = string.Format("INSERT INTO Student VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}') ", id, name, dept, sem, sec, attn, perc, ph, pName, pPhone, addr);
                    using (OleDbCommand cmd = new OleDbCommand(strAttnUpdate, MyConn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Details Successfully Updated!");

                    MyConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
            else { }
            
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
    }
}
