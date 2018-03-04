namespace AttendanceQR
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.addUser = new System.Windows.Forms.Button();
            this.viewUsers = new System.Windows.Forms.Button();
            this.viewAttendance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 146);
            this.panel1.TabIndex = 1;
            // 
            // addUser
            // 
            this.addUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addUser.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.addUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addUser.Image = ((System.Drawing.Image)(resources.GetObject("addUser.Image")));
            this.addUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addUser.Location = new System.Drawing.Point(12, 160);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(260, 75);
            this.addUser.TabIndex = 0;
            this.addUser.Text = "ADD USER       ";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // viewUsers
            // 
            this.viewUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.viewUsers.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.viewUsers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewUsers.Image = ((System.Drawing.Image)(resources.GetObject("viewUsers.Image")));
            this.viewUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewUsers.Location = new System.Drawing.Point(12, 241);
            this.viewUsers.Name = "viewUsers";
            this.viewUsers.Size = new System.Drawing.Size(260, 75);
            this.viewUsers.TabIndex = 2;
            this.viewUsers.Text = "VIEW USERS        ";
            this.viewUsers.UseVisualStyleBackColor = true;
            this.viewUsers.Click += new System.EventHandler(this.viewUsers_Click);
            // 
            // viewAttendance
            // 
            this.viewAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.viewAttendance.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.viewAttendance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewAttendance.Image = ((System.Drawing.Image)(resources.GetObject("viewAttendance.Image")));
            this.viewAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewAttendance.Location = new System.Drawing.Point(12, 324);
            this.viewAttendance.Name = "viewAttendance";
            this.viewAttendance.Size = new System.Drawing.Size(260, 75);
            this.viewAttendance.TabIndex = 3;
            this.viewAttendance.Text = "ATTENDANCE        ";
            this.viewAttendance.UseVisualStyleBackColor = true;
            this.viewAttendance.Click += new System.EventHandler(this.viewAttendance_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.viewAttendance);
            this.Controls.Add(this.viewUsers);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATTENDANCE SYSTEM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button viewUsers;
        private System.Windows.Forms.Button viewAttendance;
    }
}