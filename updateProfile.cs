using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace accountlogin
{
    public partial class updateProfile : UserControl
    {
        private static updateProfile _instance;
        public static updateProfile Instance
        {
            get
            {
                if( _instance == null)
                {
                    _instance = new updateProfile();
                }
                return _instance;
            }
        }

        public updateProfile()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname =textBox1.Text;
            string mname =maskedTextBox1.Text;
            string lname =textBox2.Text;
            string dep_id =maskedTextBox2.Text;
            string email_id =textBox3.Text;
            string pass =textBox4.Text;
            if(email_id != null || pass != null)
            {
                string ConnectString = "datasource = localhost; username= root; password= ;database=faculty_achievement_system";
                MySqlConnection conn = new MySqlConnection(ConnectString);
                conn.Open();
                MySqlCommand cmd;
                MySqlDataReader dr;
                //UPDATE Customers
               /* SET ContactName = 'Alfred Schmidt', City = 'Frankfurt'
                WHERE CustomerID = 1;*/
                String syntax = "update faculty set fname='"+fname+"',";
                syntax = syntax + "mname='" + mname + "',lname='" + lname + "',dep_id='" + dep_id + "'";
                syntax=syntax+"where email_id='"+email_id+"'and pass='"+pass+"'";
                
                cmd = new MySqlCommand(syntax, conn);
                dr = cmd.ExecuteReader();
                MessageBox.Show("value inserted successfullty");
                conn.Close();
            }
        }
    }
}
