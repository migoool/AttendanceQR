namespace AttendanceQR
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.viewUsers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.getQR = new System.Windows.Forms.Button();
            this.userIDText = new System.Windows.Forms.Label();
            this.QRPic = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.personalinformationGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastnameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.middlenameText = new System.Windows.Forms.TextBox();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.firstnameText = new System.Windows.Forms.TextBox();
            this.courseinformationGroup = new System.Windows.Forms.GroupBox();
            this.yearText = new System.Windows.Forms.ComboBox();
            this.courseText = new System.Windows.Forms.ComboBox();
            this.sectionText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textlabel = new System.Windows.Forms.Label();
            this.saveQR = new System.Windows.Forms.Button();
            this.cancelQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QRPic)).BeginInit();
            this.personalinformationGroup.SuspendLayout();
            this.courseinformationGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewUsers
            // 
            this.viewUsers.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.viewUsers.AllowColumnReorder = true;
            this.viewUsers.AutoArrange = false;
            this.viewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.viewUsers.FullRowSelect = true;
            this.viewUsers.GridLines = true;
            this.viewUsers.Location = new System.Drawing.Point(12, 12);
            this.viewUsers.Name = "viewUsers";
            this.viewUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.viewUsers.Size = new System.Drawing.Size(500, 400);
            this.viewUsers.TabIndex = 9;
            this.viewUsers.UseCompatibleStateImageBehavior = false;
            this.viewUsers.View = System.Windows.Forms.View.Details;
            this.viewUsers.SelectedIndexChanged += new System.EventHandler(this.viewUsers_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Firstname";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Middlename";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lastname";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Course";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Year";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sec";
            this.columnHeader7.Width = 50;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.updateButton.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.updateButton.Location = new System.Drawing.Point(520, 282);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(255, 40);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "UPDATE USER";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancelButton.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Teal;
            this.cancelButton.Location = new System.Drawing.Point(520, 328);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 40);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteUser.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteUser.Location = new System.Drawing.Point(650, 328);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(125, 40);
            this.deleteUser.TabIndex = 16;
            this.deleteUser.Text = "DELETE";
            this.deleteUser.UseVisualStyleBackColor = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // getQR
            // 
            this.getQR.BackColor = System.Drawing.Color.MidnightBlue;
            this.getQR.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getQR.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.getQR.Location = new System.Drawing.Point(518, 372);
            this.getQR.Name = "getQR";
            this.getQR.Size = new System.Drawing.Size(257, 40);
            this.getQR.TabIndex = 17;
            this.getQR.Text = "QR CODE";
            this.getQR.UseVisualStyleBackColor = false;
            this.getQR.Click += new System.EventHandler(this.getQR_Click_1);
            // 
            // userIDText
            // 
            this.userIDText.AutoSize = true;
            this.userIDText.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDText.Location = new System.Drawing.Point(929, 283);
            this.userIDText.Name = "userIDText";
            this.userIDText.Size = new System.Drawing.Size(54, 16);
            this.userIDText.TabIndex = 15;
            this.userIDText.Text = "userID";
            // 
            // QRPic
            // 
            this.QRPic.Location = new System.Drawing.Point(797, 51);
            this.QRPic.Name = "QRPic";
            this.QRPic.Size = new System.Drawing.Size(226, 209);
            this.QRPic.TabIndex = 18;
            this.QRPic.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(797, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "STUDENT ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(791, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "GENERATED QR CODE";
            // 
            // personalinformationGroup
            // 
            this.personalinformationGroup.Controls.Add(this.label2);
            this.personalinformationGroup.Controls.Add(this.lastnameText);
            this.personalinformationGroup.Controls.Add(this.label1);
            this.personalinformationGroup.Controls.Add(this.middlenameText);
            this.personalinformationGroup.Controls.Add(this.firstnameLabel);
            this.personalinformationGroup.Controls.Add(this.firstnameText);
            this.personalinformationGroup.Location = new System.Drawing.Point(518, 12);
            this.personalinformationGroup.Name = "personalinformationGroup";
            this.personalinformationGroup.Size = new System.Drawing.Size(253, 129);
            this.personalinformationGroup.TabIndex = 11;
            this.personalinformationGroup.TabStop = false;
            this.personalinformationGroup.Text = "Personal Informations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lastname   :";
            // 
            // lastnameText
            // 
            this.lastnameText.Location = new System.Drawing.Point(79, 90);
            this.lastnameText.Name = "lastnameText";
            this.lastnameText.Size = new System.Drawing.Size(168, 20);
            this.lastnameText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Middlename:";
            // 
            // middlenameText
            // 
            this.middlenameText.Location = new System.Drawing.Point(79, 60);
            this.middlenameText.Name = "middlenameText";
            this.middlenameText.Size = new System.Drawing.Size(168, 20);
            this.middlenameText.TabIndex = 2;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(6, 31);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(64, 13);
            this.firstnameLabel.TabIndex = 1;
            this.firstnameLabel.Text = "Firstname   :";
            // 
            // firstnameText
            // 
            this.firstnameText.Location = new System.Drawing.Point(79, 29);
            this.firstnameText.Name = "firstnameText";
            this.firstnameText.Size = new System.Drawing.Size(168, 20);
            this.firstnameText.TabIndex = 0;
            // 
            // courseinformationGroup
            // 
            this.courseinformationGroup.Controls.Add(this.yearText);
            this.courseinformationGroup.Controls.Add(this.courseText);
            this.courseinformationGroup.Controls.Add(this.sectionText);
            this.courseinformationGroup.Controls.Add(this.label3);
            this.courseinformationGroup.Controls.Add(this.label4);
            this.courseinformationGroup.Controls.Add(this.textlabel);
            this.courseinformationGroup.Location = new System.Drawing.Point(518, 147);
            this.courseinformationGroup.Name = "courseinformationGroup";
            this.courseinformationGroup.Size = new System.Drawing.Size(253, 129);
            this.courseinformationGroup.TabIndex = 12;
            this.courseinformationGroup.TabStop = false;
            this.courseinformationGroup.Text = "Course Informations";
            // 
            // yearText
            // 
            this.yearText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearText.FormattingEnabled = true;
            this.yearText.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year",
            "5th Year"});
            this.yearText.Location = new System.Drawing.Point(79, 59);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(168, 21);
            this.yearText.TabIndex = 8;
            // 
            // courseText
            // 
            this.courseText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseText.FormattingEnabled = true;
            this.courseText.Items.AddRange(new object[] {
            "BS Civil Engineering",
            "BS Computer Engineering",
            "BS Electrical Engineering",
            "BS Electronics and Communications Engineering",
            "BS Industrial Engineering",
            "BS Mechanical Engineering",
            "Other Courses"});
            this.courseText.Location = new System.Drawing.Point(79, 28);
            this.courseText.Name = "courseText";
            this.courseText.Size = new System.Drawing.Size(168, 21);
            this.courseText.Sorted = true;
            this.courseText.TabIndex = 7;
            // 
            // sectionText
            // 
            this.sectionText.Location = new System.Drawing.Point(79, 89);
            this.sectionText.Name = "sectionText";
            this.sectionText.Size = new System.Drawing.Size(168, 20);
            this.sectionText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Section      :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year           :";
            // 
            // textlabel
            // 
            this.textlabel.AutoSize = true;
            this.textlabel.Location = new System.Drawing.Point(6, 31);
            this.textlabel.Name = "textlabel";
            this.textlabel.Size = new System.Drawing.Size(67, 13);
            this.textlabel.TabIndex = 1;
            this.textlabel.Text = "Course        :";
            // 
            // saveQR
            // 
            this.saveQR.BackColor = System.Drawing.Color.MidnightBlue;
            this.saveQR.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveQR.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.saveQR.Location = new System.Drawing.Point(812, 309);
            this.saveQR.Name = "saveQR";
            this.saveQR.Size = new System.Drawing.Size(191, 40);
            this.saveQR.TabIndex = 22;
            this.saveQR.Text = "SAVE QR CODE";
            this.saveQR.UseVisualStyleBackColor = false;
            this.saveQR.Click += new System.EventHandler(this.saveQR_Click);
            // 
            // cancelQR
            // 
            this.cancelQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancelQR.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelQR.ForeColor = System.Drawing.Color.Teal;
            this.cancelQR.Location = new System.Drawing.Point(812, 355);
            this.cancelQR.Name = "cancelQR";
            this.cancelQR.Size = new System.Drawing.Size(191, 40);
            this.cancelQR.TabIndex = 23;
            this.cancelQR.Text = "CANCEL";
            this.cancelQR.UseVisualStyleBackColor = false;
            this.cancelQR.Click += new System.EventHandler(this.cancelQR_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 421);
            this.Controls.Add(this.cancelQR);
            this.Controls.Add(this.saveQR);
            this.Controls.Add(this.personalinformationGroup);
            this.Controls.Add(this.courseinformationGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QRPic);
            this.Controls.Add(this.getQR);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.userIDText);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.viewUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(500, 100);
            this.MaximizeBox = false;
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Users";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.View_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.QRPic)).EndInit();
            this.personalinformationGroup.ResumeLayout(false);
            this.personalinformationGroup.PerformLayout();
            this.courseinformationGroup.ResumeLayout(false);
            this.courseinformationGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView viewUsers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button getQR;
        private System.Windows.Forms.Label userIDText;
        private System.Windows.Forms.PictureBox QRPic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox personalinformationGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastnameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox middlenameText;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.TextBox firstnameText;
        private System.Windows.Forms.GroupBox courseinformationGroup;
        private System.Windows.Forms.ComboBox yearText;
        private System.Windows.Forms.ComboBox courseText;
        private System.Windows.Forms.TextBox sectionText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label textlabel;
        private System.Windows.Forms.Button saveQR;
        private System.Windows.Forms.Button cancelQR;
    }
}