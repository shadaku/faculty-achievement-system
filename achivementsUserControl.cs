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
using System.IO;

namespace accountlogin
{




    public partial class achivementsUserControl : UserControl
    {

        private static achivementsUserControl _instance;
        public static achivementsUserControl Instnce
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new achivementsUserControl();
                }
                return _instance;
            }
        }

        public achivementsUserControl()
        {
            InitializeComponent();
        }


        public void refresh_DataGridView()
        {
            string ConnectString = "datasource = localhost; username= root; password= ;database=faculty_achievement_system";
            MySqlConnection conn = new MySqlConnection(ConnectString);
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select achievement_id,field,discription,fac from achievements",conn); // show achivements details 
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("     <<<<iinvalid sql operation    >>>>>");

                }
                conn.Close();

                dataGridView1.DataSource = DS.Tables[0];

            }
            catch(Exception e)
            {
                MessageBox.Show("" + e);

            }
        }

        private void refreshClicked(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectString = "datasource = localhost; username= root; password= ;database=faculty_achievement_system";
            MySqlConnection conn = new MySqlConnection(ConnectString);
            String fac_id = textBox1.Text;
            conn.Open();
            try
            {
                String command = "select achievement_id,field,discription,fac from achievements where fac = '" + fac_id + "'";
                MySqlCommand cmd = new MySqlCommand(command, conn); // show achivements details 
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("     <<<<iinvalid sql operation    >>>>>");

                }
                conn.Close();

                dataGridView1.DataSource = DS.Tables[0];

            }
            catch (Exception a)
            {
                MessageBox.Show("" + a);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string ConnectString = "datasource = localhost; username= root; password= ;database=faculty_achievement_system";
            MySqlConnection conn = new MySqlConnection(ConnectString);
            conn.Open();
            String achievement_id = textBox2.Text;
            MySqlCommand cmd;
            MySqlDataReader dr;
            String syntax = "delete from achievements where achievement_id=' ";
            syntax = syntax + achievement_id+"'";
           
            cmd = new MySqlCommand(syntax, conn);
            dr = cmd.ExecuteReader();
            MessageBox.Show("value deleted successfully successfullty");
            conn.Close();
            refresh_DataGridView();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        MySqlDataReader reader;
        public void downloadeFile(string file)
        {
            string ConnectString = "datasource = localhost; username= root; password= ;database=test12";
            MySqlConnection conn = new MySqlConnection(ConnectString);
            bool em = false;
            conn.Open();

            using (MySqlCommand cmd = new MySqlCommand("select doc from document where document_id='" + textBox1.Text + "'", conn))
            {
                using (reader = cmd.ExecuteReader(CommandBehavior.Default))
                {

                    if (reader.Read())
                    {
                        em = true;
                        byte[] fileData = (byte[])reader.GetValue(0);
                        using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.ReadWrite))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(fileData);
                                bw.Close();
                            }
                        }
                        MessageBox.Show("downloaded successfully");
                    }
                    if (em == false)
                    {
                        MessageBox.Show("unable to downloade file ");
                    }
                    reader.Close();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Document(.pdf)|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("are you sure want to downloade this file");
                    if (dialog == DialogResult.OK)
                    {
                        string filename = sfd.FileName;
                        downloadeFile(filename);
                    }
                }
            }
        }
    }
}
