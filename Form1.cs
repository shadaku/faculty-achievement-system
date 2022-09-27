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
    public partial class Form1 : Form
    {
        public static string hello="hello shivu";
        public static String uname = "";
        public Form1()
        {
            
            InitializeComponent();
           
        }
        //below try catch block will try to connect code to my sql erver running on xaamp
        //password= ;database=database1";// in xaam server admin page we have database 1 named database we use this
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
        
        private string getUserName(MySqlConnection DBCOnnect,String name)
        {
           
            MySqlCommand cmd;
            MySqlDataReader dr;

            String syntax = "select email_id from faculty where email_id= ";
            syntax = syntax + "'";
            syntax = syntax + name;
            syntax = syntax + "'";
            cmd = new MySqlCommand(syntax, DBCOnnect);
            dr = cmd.ExecuteReader();
             dr.Read();
            string ans = dr[0].ToString();
            dr.Close();
            return ans;



        }
        private string getUserNameAdmin(MySqlConnection DBCOnnect, String name)
        {

            MySqlCommand cmd;
            MySqlDataReader dr;

            String syntax = "select email_id from admin where email_id= ";
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





        private string getPassword(MySqlConnection DBCOnnect, String name)
        {
            MySqlCommand cmd;
            MySqlDataReader dr;
            String syntax = "select pass from faculty where email_id= ";
            syntax = syntax + "'";
            syntax = syntax + name;
            syntax = syntax + "'";
            cmd = new MySqlCommand(syntax, DBCOnnect);
            dr = cmd.ExecuteReader();
            dr.Read();
            String ans = dr[0].ToString();
            dr.Close();
            DBCOnnect.Close();
            return ans;


        }

        private string getPasswordAdmin(MySqlConnection DBCOnnect, String name)
        {
            MySqlCommand cmd;
            MySqlDataReader dr;
            String syntax = "select pass from admin where email_id= ";
            syntax = syntax + "'";
            syntax = syntax + name;
            syntax = syntax + "'";
            cmd = new MySqlCommand(syntax, DBCOnnect);
            dr = cmd.ExecuteReader();
            dr.Read();
            String ans = dr[0].ToString();
            dr.Close();
            DBCOnnect.Close();
            return ans;


        }






        private void submit(object sender, EventArgs e)
        {
            
            MySqlConnection DBCOnnect = connect(e);
          
            String name = textBox2.Text;
            String pass = textBox1.Text;
            uname = getUserNameAdmin(DBCOnnect,name);
            MessageBox.Show(uname);
            String password = getPasswordAdmin(DBCOnnect,name);
            if (uname.Equals(name) && pass.Equals(password))
            {

                adminDahboard obj = new adminDahboard();  //creates a object of admindash board form 
               
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("invalid user name or password please try again");

            }
            DBCOnnect.Close();

            



        }
        private void FacultySubmit(object sender,EventArgs e)
        {
            MySqlConnection DBCOnnect = connect(e);

            String name = textBox3.Text;
            String pass = textBox4.Text;
            uname = getUserName(DBCOnnect, name);
            String password = getPassword(DBCOnnect, name);
            if (uname.Equals(name) && pass.Equals(password))
            {

                //adminDahboard obj = new adminDahboard();  //creates a object of admindash board form 
                FacultyDashboard obj = new FacultyDashboard();  //creates a object of admindash board form 
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("invalid user name or password please try again");

            }
            DBCOnnect.Close();


        }

      
    }
}
