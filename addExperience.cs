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
    
    public partial class addExperience : UserControl
    {
        private static addExperience _instance;
        public static addExperience Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new addExperience();
                }
                return _instance;
            }
        }
        string type = "";
        public addExperience()
        {
            InitializeComponent();
        }
        private MySqlConnection connect(EventArgs a)
        {
            string ConnectString = "datasource = localhost; username= root; password= ;database=faculty_achievement_system";
            MySqlConnection DBCOnnect = new MySqlConnection(ConnectString);

            try
            {
                DBCOnnect.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            return DBCOnnect;

        }

        public string Getfac_id(MySqlConnection DBCOnnect, String name)
        {
            MySqlCommand cmd;
            MySqlDataReader dr;

            String syntax = "select faculty_id from faculty where email_id=";
            syntax = syntax + "'";
            syntax = syntax + name;
            syntax = syntax + "'";
            cmd = new MySqlCommand(syntax, DBCOnnect);
            dr = cmd.ExecuteReader();
            dr.Read();
            String ans = dr[0].ToString();
            dr.Close();
            return ans;

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection DBCOnnect = connect(e);
            string fac = Getfac_id(DBCOnnect, Form1.uname);

          


            string noOfYears1 = textBox1.Text;
            int noOfYears = Convert.ToInt32(noOfYears1);
            string ConnectString = "datasource = localhost; username= root; password= ;database=faculty_achievement_system";
            MySqlConnection conn = new MySqlConnection(ConnectString);
            conn.Open();
            MySqlCommand cmd;
            
            
            
            
            
            //INSERT INTO `experience`(`fac`, `type`, `noOfYears`) VALUES ('[value-1]','[value-2]','[value-3]')
            String syntax = "insert into experience(fac,type,noOFYears) values('" + fac;
            syntax = syntax + "','"+type+"',"+noOfYears+")";
            

            cmd = new MySqlCommand(syntax, conn);
            cmd.ExecuteReader();
            MessageBox.Show("value inserted successfullty");
            conn.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = "teaching";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type = "industry";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            type = "research";
        }
    }
}
