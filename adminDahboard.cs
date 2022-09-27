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
    public partial class adminDahboard : Form
    {
        public adminDahboard()
        {
            
            InitializeComponent();

           
        }

        bool isSlidingPannelExpanded;
        const int MaxSlidderWidth=175;
        const int MixSlidderWidth=63;
        private void SlidingPannel_ToggleButton_Click(object sender, EventArgs e)// sling of a pannel shrink and expand
        {
            if (isSlidingPannelExpanded)
            {
                //retract the pannel
            }
            SliddingPannel_Timer.Start();
        }

        private void SliddingPannel_Timer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPannelExpanded)
            {
                //retract the pannel
                SlidingPannel.Width -= 30;  //shrinking the sliding pannel
                if(SlidingPannel.Width <= MixSlidderWidth)
                {
                    // stop shrinking
                    isSlidingPannelExpanded = false;
                    SliddingPannel_Timer.Stop();

                    this.Refresh();
                }
            }
            else
            {
                //if already shrined we nee to expand
                SlidingPannel.Width += 30;  //shrinking the sliding pannel
                if (SlidingPannel.Width >= MaxSlidderWidth)
                {
                    // stop expanding
                    isSlidingPannelExpanded = true;
                    SliddingPannel_Timer.Stop();

                    this.Refresh();
                }

            }
           
        }

        private void addUserClicked(object sender, EventArgs e)  // this function helps us to add user control menus or options upon clicking addUser
        {
            
            if(!contentPannel.Controls.Contains(addUserControl1.Instnce))
            {
                contentPannel.Controls.Add(addUserControl1.Instnce);
                addUserControl1.Instnce.Dock = DockStyle.Fill;
                addUserControl1.Instnce.BringToFront();            
            }
            else
            {
                addUserControl1.Instnce.BringToFront();

            }

        }

        private void RemoveUserClicked(object sender, EventArgs e)
        {
            if (!contentPannel.Controls.Contains(RemoveUserControl1.Instnce))
            {
                contentPannel.Controls.Add(RemoveUserControl1.Instnce);
                RemoveUserControl1.Instnce.Dock = DockStyle.Fill;
                RemoveUserControl1.Instnce.BringToFront();
            }
            else
            {
                RemoveUserControl1.Instnce.BringToFront();

            }
        }

        private void achievementsClick(object sender, EventArgs e)
        {

            if (!contentPannel.Controls.Contains(achivementsUserControl.Instnce))
            {
                contentPannel.Controls.Add(achivementsUserControl.Instnce);
                achivementsUserControl.Instnce.Dock = DockStyle.Fill;
                achivementsUserControl.Instnce.BringToFront();
            }
            else
            {
                achivementsUserControl.Instnce.BringToFront();

            }

        }

        
    }
}
