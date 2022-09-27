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
    public partial class resetPassword : UserControl
    {
        private static resetPassword _instance;
        public static resetPassword Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new resetPassword();
                }
                return _instance;
            }
        }

        public resetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email_id = textBox3.Text;
            string pass = textBox4.Text;
            string newPass = textBox1.Text;
            string newpas1 = textBox2.Text;
            if (newpas1 == newPass)
            {
                string ConnectString = "datasource = localhost; username= root; password= ;database=faculty_achievement_system";
                MySqlConnection conn = new MySqlConnection(ConnectString);
                conn.Open();
                MySqlCommand cmd;
                MySqlDataReader dr;
               
                String syntax = "update faculty set pass='" + newPass + "'";
                syntax = syntax + "where email_id='" + email_id + "' and pass='" + pass + "'";

                cmd = new MySqlCommand(syntax, conn);
                dr = cmd.ExecuteReader();
                MessageBox.Show("value inserted successfullty");
                conn.Close();
            }
        }

        private void resetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
