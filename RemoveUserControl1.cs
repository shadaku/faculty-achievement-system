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
    public partial class RemoveUserControl1 : UserControl
    {
        private static RemoveUserControl1 _instance;
        public static RemoveUserControl1 Instnce
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RemoveUserControl1();
                }
                return _instance;
            }
        }

        public RemoveUserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ConnectString = "datasource = localhost; username= root; password= ;database=faculty_achievement_system";
            MySqlConnection conn = new MySqlConnection(ConnectString);
            conn.Open();
            String email_id = textBox1.Text;
            MySqlCommand cmd;
            MySqlDataReader dr;
           //DELETE FROM `table_name` [WHERE condition];
            String syntax = "delete FROM faculty WHERE email_id='";  //delete FROM faculty WHERE email_id='kiran@rvce.edu.in';
            syntax = syntax + email_id;           
            syntax = syntax + "'";
            cmd = new MySqlCommand(syntax, conn);
            dr = cmd.ExecuteReader();
            MessageBox.Show("value deleted successfully successfullty");
            conn.Close();
        }
    }
}
