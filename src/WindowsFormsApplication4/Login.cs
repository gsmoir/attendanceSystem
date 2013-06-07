using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace WindowsFormsApplication4
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //Ensure username and password entered
                if (textBoxId.Text.Length == 0)
                {
                    labelNotice.Text = "Please enter the User Name";
                    textBoxId.Focus();
                    return;
                }

                if (textBoxPw.Text.Length == 0)
                {
                    labelNotice.Text = "Please enter the Password";
                    textBoxPw.Focus();
                    return;
                }

                //ADO.NET connectivity using ACE adapter
                //access the Microsoft access database
                string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Attendance Application\Database\attendance.accdb;Jet OLEDB:Database Password=password";
                OleDbConnection MyConn = new OleDbConnection(ConnStr);
                MyConn.Open();

                //***TEST for Future reference***
                //string StrCmd =" Select staffPassword from Staff where staffName =( '" (textBoxId.Text) "') ";
                //string StrCmd = " Select * from Staff";            
                //OleDbCommand Cmd = new OleDbCommand(StrCmd, MyConn); 
                //OleDbDataReader ObjReader = Cmd.ExecuteReader();

                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Staff where staffName ='" + textBoxId.Text + "' and staffPassword='" + textBoxPw.Text + "'", MyConn);
                da.Fill(ds);



                int count = ds.Tables[0].Rows.Count;
                if (count == 0)
                {
                    MessageBox.Show("Invalid UserID/Password");
                }
                else
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();

                }


                MyConn.Close();

                //if (ObjReader != null)
                //{
                //    MessageBox.Show("Invalid username");
                //}
                //MessageBox.Show("test done");
                //ObjReader.Close();
                //MyConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            
            }
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            AdminLogin al = new AdminLogin();
            al.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewStaffDetails s = new ViewStaffDetails();
            s.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UpdateStaffDetails ust = new UpdateStaffDetails();
            ust.Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            stdGroupView f = new stdGroupView();
            f.Show();
        }

       
    }
}
