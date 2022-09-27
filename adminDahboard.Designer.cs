namespace accountlogin
{
    partial class adminDahboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SlidingPannel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SlidingPannel_ToggleButton = new System.Windows.Forms.Button();
            this.SliddingPannel_Timer = new System.Windows.Forms.Timer(this.components);
            this.contentPannel = new System.Windows.Forms.Panel();
            this.SlidingPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlidingPannel
            // 
            this.SlidingPannel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SlidingPannel.Controls.Add(this.button4);
            this.SlidingPannel.Controls.Add(this.button3);
            this.SlidingPannel.Controls.Add(this.button2);
            this.SlidingPannel.Controls.Add(this.SlidingPannel_ToggleButton);
            this.SlidingPannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPannel.Location = new System.Drawing.Point(0, 0);
            this.SlidingPannel.Name = "SlidingPannel";
            this.SlidingPannel.Size = new System.Drawing.Size(177, 747);
            this.SlidingPannel.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 87);
            this.button4.TabIndex = 3;
            this.button4.Text = "achievements";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.achievementsClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 87);
            this.button3.TabIndex = 2;
            this.button3.Text = "removeUser";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.RemoveUserClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 87);
            this.button2.TabIndex = 1;
            this.button2.Text = "addUser";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.addUserClicked);
            // 
            // SlidingPannel_ToggleButton
            // 
            this.SlidingPannel_ToggleButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SlidingPannel_ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingPannel_ToggleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlidingPannel_ToggleButton.Location = new System.Drawing.Point(0, 3);
            this.SlidingPannel_ToggleButton.Name = "SlidingPannel_ToggleButton";
            this.SlidingPannel_ToggleButton.Size = new System.Drawing.Size(175, 87);
            this.SlidingPannel_ToggleButton.TabIndex = 0;
            this.SlidingPannel_ToggleButton.Text = "shrinking and expanding";
            this.SlidingPannel_ToggleButton.UseVisualStyleBackColor = false;
            this.SlidingPannel_ToggleButton.Click += new System.EventHandler(this.SlidingPannel_ToggleButton_Click);
            // 
            // SliddingPannel_Timer
            // 
            this.SliddingPannel_Timer.Tick += new System.EventHandler(this.SliddingPannel_Timer_Tick);
            // 
            // contentPannel
            // 
            this.contentPannel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.contentPannel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentPannel.Location = new System.Drawing.Point(180, 0);
            this.contentPannel.Name = "contentPannel";
            this.contentPannel.Size = new System.Drawing.Size(1154, 747);
            this.contentPannel.TabIndex = 1;
            // 
            // adminDahboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1334, 747);
            this.Controls.Add(this.contentPannel);
            this.Controls.Add(this.SlidingPannel);
            this.Name = "adminDahboard";
            this.Text = "adminDahboard";
            this.SlidingPannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SlidingPannel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SlidingPannel_ToggleButton;
        private System.Windows.Forms.Timer SliddingPannel_Timer;
        private System.Windows.Forms.Panel contentPannel;
    }
}