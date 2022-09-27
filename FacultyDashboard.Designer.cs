namespace accountlogin
{
    partial class FacultyDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyDashboard));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.controlpanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "add new achievement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(342, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "reset password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // controlpanel
            // 
            this.controlpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlpanel.BackgroundImage")));
            this.controlpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlpanel.Location = new System.Drawing.Point(349, 0);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(928, 523);
            this.controlpanel.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(342, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "update profile";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(342, 55);
            this.button4.TabIndex = 5;
            this.button4.Text = "add experience";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FacultyDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1277, 523);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.controlpanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FacultyDashboard";
            this.Text = "FacultyDashboard";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel controlpanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}