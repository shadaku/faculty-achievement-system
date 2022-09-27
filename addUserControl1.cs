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


    public partial class addUserControl1 : UserControl
    {
        private static addUserControl1 _instance;
        public static addUserControl1 Instnce
        {

            get
            {
                if(_instance == null)
                {
                    _instance = new addUserControl1();
                }
                return _instance;
            }
        }
        public addUserControl1()
        {
            InitializeComponent();
        }

        private void addMember_Clicked(object sender, EventArgs e)
        {
             
            string ConnectString = "datasource = localhost; username= root; password= ;database=faculty_achievement_system";
            MySqlConnection conn = new MySqlConnection(ConnectString);
            conn.Open();
            String faculty_id = textBox3.Text;
            String username = textBox1.Text;

            string password = textBox2.Text;
            MySqlCommand cmd;
            MySqlDataReader dr;
            String syntax = "insert into faculty(faculty_id,email_id,pass) values ('"+faculty_id+"','";
            syntax = syntax+username;
            syntax = syntax + "','";
            syntax = syntax + password;
            syntax = syntax + "')";
            cmd = new MySqlCommand(syntax, conn);
            dr = cmd.ExecuteReader();
            MessageBox.Show("value inserted successfullty");
            conn.Close();

        }  
    }
}
