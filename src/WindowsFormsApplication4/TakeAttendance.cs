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
    public partial class TakeAttendance : Form
    {
        int i=0;
        public TakeAttendance()
        {
            InitializeComponent();
        }

        
        private void TakeAttendance_Load(object sender, EventArgs e)
        {

            

            //// TODO: This line of code loads data into the 'attendanceDataSet1.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.attendanceDataSet1.Student);
            //// TODO: This line of code loads data into the 'attendanceDataSet1.TotalHours' table. You can move, or remove it, as needed.
            //this.totalHoursTableAdapter.Fill(this.attendanceDataSet1.TotalHours);
            //// TODO: This line of code loads data into the 'attendanceDataSet1.AttSystem' table. You can move, or remove it, as needed.
            //this.attSystemTableAdapter.Fill(this.attendanceDataSet1.AttSystem);


            try
            {

                string Conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Attendance Application\Database\attendance.accdb;Jet OLEDB:Database Password=password";
                OleDbConnection MyConn = new OleDbConnection(Conn);
                DataSet ds = new DataSet();
                MyConn.Open();

                string strRetr = "Select totalHours from TotalHours";
                OleDbCommand cmdRetr = new OleDbCommand(strRetr, MyConn);

                OleDbDataReader myDataReader = cmdRetr.ExecuteReader();

                myDataReader.Read();
                int a = int.Parse(myDataReader["totalHours"].ToString());

                //a = int.Parse(labelTotalHours.Text);
                a += 1;
                textBoxTotal.Text = a.ToString();

                string str = string.Format("Update TotalHours Set totalHours = '{0}' ", a);
                using (OleDbCommand cmd = new OleDbCommand(str, MyConn))
                {
                    cmd.ExecuteNonQuery();
                }


                 OleDbDataAdapter oledbAdapter;
            OleDbCommandBuilder oledbCmdBuilder;
            
            
            string sql = null;

           
            sql = "select * from Student";
            
                  // your code must have like this
                oledbAdapter = new OleDbDataAdapter(sql, MyConn);
                oledbCmdBuilder = new OleDbCommandBuilder(oledbAdapter);
                oledbAdapter.Fill(ds);

                textBoxId.Text= (ds.Tables[0].Rows[i][0].ToString());
                textBoxName.Text = (ds.Tables[0].Rows[i][1].ToString());
               




                MyConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            
            }
        }

        

       
        //when clicking present button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
            //Gets total and present count of students is student datasource defined in data binding
            //this is prepared to avoid repeated update of last student attendance

        
            //float totalCnt = bindingSource1.Count;
            //float currCnt = bindingSource1.Position;
            string id = textBoxId.Text;

            string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Attendance Application\Database\attendance.accdb;Jet OLEDB:Database Password=password";
            OleDbConnection MyConn = new OleDbConnection(ConnStr);
            DataSet ds = new DataSet();
            MyConn.Open();
            //string id = textBoxId.Text;


            string strAttn = string.Format( "Select currAttn from Student where stdId='{0}' ",id);
            OleDbCommand cmdAttn = new OleDbCommand(strAttn, MyConn);
            OleDbDataReader attnDataReader = cmdAttn.ExecuteReader();
            attnDataReader.Read();
            float attn = float.Parse(attnDataReader["currAttn"].ToString());

            attn += 1;

            
            float total = float.Parse(textBoxTotal.Text.ToString());

            float perc;

            perc = (attn / total) * 100;
            
            string strAttnUpdate = string.Format("Update Student Set currAttn= '{0}',attnPerc ='{1}' where stdId= '{2}' ", attn, perc, id);
            using (OleDbCommand cmd = new OleDbCommand(strAttnUpdate, MyConn))
            {
                cmd.ExecuteNonQuery();
            }

            //---------

            string sql = null;
                sql = "select * from Student";

               OleDbDataAdapter oledbAdapter = new OleDbDataAdapter(sql, MyConn);
               OleDbCommandBuilder oledbCmdBuilder = new OleDbCommandBuilder(oledbAdapter);
                oledbAdapter.Fill(ds);


                if (i < ds.Tables[0].Rows.Count - 1)
                {
                    i += 1;
                    textBoxId.Text = (ds.Tables[0].Rows[i][0].ToString());
                    textBoxName.Text = (ds.Tables[0].Rows[i][1].ToString());

                }

                else
                {
                    MessageBox.Show("Its the Last Entry!  ATTENDANCE OVER! YOU CAN LOG OUT!");
                    Login lg = new Login();
                    lg.Show();
                    this.Close();
                }

                MyConn.Close();

                //connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }


            //----------



            //bindingSource1.MoveNext();
            //bindingSource1.EndEdit();


                 
            //if (currCnt == totalCnt-1)
            //{
            //    MessageBox.Show("ATTENDANCE OVER! YOU CAN LOG OUT!");
            //    bindingSource1.EndEdit();
            //}

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bindingSource1.MoveNext();
            //float totalCnt = bindingSource1.Count;
            //float currCnt = bindingSource1.Position;
            //string id = textBoxId.Text;
            //if (currCnt == totalCnt - 1)
            //{
            //    MessageBox.Show("ATTENDANCE OVER! YOU CAN LOG OUT!");
            //    bindingSource1.EndEdit();
            //}
            //-----------

            try
            {

                //Gets total and present count of students is student datasource defined in data binding
                //this is prepared to avoid repeated update of last student attendance


                //float totalCnt = bindingSource1.Count;
                //float currCnt = bindingSource1.Position;
                //string id = textBoxId.Text;

                string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Attendance Application\Database\attendance.accdb;Jet OLEDB:Database Password=password";
                OleDbConnection MyConn = new OleDbConnection(ConnStr);
                DataSet ds = new DataSet();
                MyConn.Open();




                //---------

                string sql = null;
                sql = "select * from Student";

                OleDbDataAdapter oledbAdapter = new OleDbDataAdapter(sql, MyConn);
                OleDbCommandBuilder oledbCmdBuilder = new OleDbCommandBuilder(oledbAdapter);
                oledbAdapter.Fill(ds);


                if (i < ds.Tables[0].Rows.Count - 1)
                {
                    i += 1;
                    textBoxId.Text = (ds.Tables[0].Rows[i][0].ToString());
                    textBoxName.Text = (ds.Tables[0].Rows[i][1].ToString());

                }

                else
                {
                    MessageBox.Show("Its the Last Entry!  ATTENDANCE OVER! YOU CAN LOG OUT!");
                    Login lg = new Login();
                    lg.Show();
                    this.Close();
                }

                MyConn.Close();
                //-----------
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            
            }


        }
    

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Home hm = new Home();
            hm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
