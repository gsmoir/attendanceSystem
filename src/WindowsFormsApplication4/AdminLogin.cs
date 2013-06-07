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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
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
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Admin where adminName ='" + textBoxId.Text + "' and adminPassword='" + textBoxPw.Text + "'", MyConn);
                da.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                if (count == 0)
                {
                    MessageBox.Show("Invalid UserID/Password");
                }
                else
                {


                    AdminHome ah = new AdminHome();
                    ah.Show();
                    this.Hide();

                }


                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
