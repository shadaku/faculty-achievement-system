using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accountlogin
{
    public partial class FacultyDashboard : Form
    {
       
        public FacultyDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!controlpanel.Controls.Contains(addAchievementUserControl.Instance)){
                controlpanel.Controls.Add(addAchievementUserControl.Instance);
                addAchievementUserControl.Instance.Dock = DockStyle.Fill;
               addAchievementUserControl.Instance.BringToFront();
            }
            else
            {
                addAchievementUserControl.Instance.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!controlpanel.Controls.Contains(resetPassword.Instance))
            {
                controlpanel.Controls.Add(resetPassword.Instance);
                resetPassword.Instance.Dock = DockStyle.Fill;
                resetPassword.Instance.BringToFront();
            }
            else {
                resetPassword.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!controlpanel.Controls.Contains(updateProfile.Instance))
            {
                controlpanel.Controls.Add(updateProfile.Instance);
                updateProfile.Instance.Dock = DockStyle.Fill;
                updateProfile.Instance.BringToFront();
            }
            else
            {
                updateProfile.Instance.BringToFront();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!controlpanel.Controls.Contains(addExperience.Instance))
            {
                controlpanel.Controls.Add(addExperience.Instance);
                addExperience.Instance.Dock = DockStyle.Fill;
                addExperience.Instance.BringToFront();
            }
            else
            {
                addExperience.Instance.BringToFront();
            }
        }
    }
}
