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
    public partial class UpdateStaffDetails : Form
    {

        int i = 0;
        public UpdateStaffDetails()
        {
            InitializeComponent();
        }

        private void UpdateStaffDetails_Load(object sender, EventArgs e)
        {


           

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

            //------------------


            connection.Close();
        }

        private void buttonPre_Click(object sender, EventArgs e)
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

        private void buttonNext_Click(object sender, EventArgs e)
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

        private void buttonUpd_Click(object sender, EventArgs e)
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

                    int id = int.Parse(textBoxId.Text);
                    string name = textBoxName.Text;
                    string pw = textBoxPw.Text;



                    string strAttnUpdate = string.Format("Update Staff Set staffId='{0}',staffName='{1}',staffPassword='{2}' ", id, name, pw);
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

        private void buttonDel_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = MessageBox.Show("Are you sure to Delete?","Delete",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {

                    string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Attendance Application\Database\attendance.accdb;Jet OLEDB:Database Password=password";
                    OleDbConnection MyConn = new OleDbConnection(ConnStr);

                    MyConn.Open();

                    int id = int.Parse(textBoxId.Text);
                    MessageBox.Show(id.ToString());
                    string strAttnUpdate = string.Format("DELETE FROM Staff WHERE staffId={0} ", id);
                    MessageBox.Show(strAttnUpdate);
                    using (OleDbCommand cmd = new OleDbCommand(strAttnUpdate, MyConn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    textBoxId.Text = "";
                    textBoxName.Text = "";
                    textBoxPw.Text = "";

                    MessageBox.Show("Staff Entry for id:" + id + "  DELETED Successfully!");

                    MyConn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
            else { }

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxPw.Text = "";
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = MessageBox.Show("Are you sure to INSERT?","Insert",MessageBoxButtons.YesNo);
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
                    string pw = textBoxPw.Text;


                    string strAttnUpdate = string.Format("INSERT INTO Staff VALUES('{0}','{1}','{2}') ", id, name, pw);
                    using (OleDbCommand cmd = new OleDbCommand(strAttnUpdate, MyConn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Details Successfully ADDED to STAFF database!");

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
