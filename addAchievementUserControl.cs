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
using System.IO;// include this library 

namespace accountlogin
{
    public partial class addAchievementUserControl : UserControl
    {
        String field = "";
        string filename = "";
        private static addAchievementUserControl _instance;
        public static addAchievementUserControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new addAchievementUserControl();
                }
                return _instance;
            }
        }
        public addAchievementUserControl()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Uploadefile(filename);
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            field = "paper publication in journal";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            field = "paper publication in conference";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            field = "delivering a talk";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            field = "organisiing a  talk";
        }

        public void Uploadefile(string file)
        {
            string ConnectString = "datasource = localhost; username= root; password= ;database=faculty_achievement_system";
            MySqlConnection conn = new MySqlConnection(ConnectString);

            try
            {
                conn.Open();
                MessageBox.Show("ok connected succefully");

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);

            }
            FileStream fstream = File.OpenRead(file);
            byte[] contents = new byte[fstream.Length];
            fstream.Read(contents, 0, (int)fstream.Length);
            fstream.Close();

            String faculty_id = textBox1.Text;
            String discription = richTextBox1.Text;


            MySqlCommand cmd;
            MySqlDataReader dr;


                                         //insert into achievements(fac,field,discription) values
            using (cmd = new MySqlCommand("insert into achievements(fac,field,discription,proff) values(@fac,@field,@discription,@file)",conn))
            {
                cmd.Parameters.AddWithValue("@fac", faculty_id);
                cmd.Parameters.AddWithValue("@field", field);
                cmd.Parameters.AddWithValue("@discription", discription);
                cmd.Parameters.AddWithValue("@file", contents);
                cmd.ExecuteNonQuery();

            }
           
            MessageBox.Show("document inserted successfullty");
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "Text Documents (*.pdf) |*.pdf", ValidateNames = true })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("are you want to uploade file");
                    filename = dlg.FileName;
                    
                }
            }
        }
    }
}
