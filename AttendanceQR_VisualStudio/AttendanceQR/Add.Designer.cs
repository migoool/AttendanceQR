namespace AttendanceQR
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
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
            this.registerButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.personalinformationGroup.SuspendLayout();
            this.courseinformationGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // personalinformationGroup
            // 
            this.personalinformationGroup.Controls.Add(this.label2);
            this.personalinformationGroup.Controls.Add(this.lastnameText);
            this.personalinformationGroup.Controls.Add(this.label1);
            this.personalinformationGroup.Controls.Add(this.middlenameText);
            this.personalinformationGroup.Controls.Add(this.firstnameLabel);
            this.personalinformationGroup.Controls.Add(this.firstnameText);
            this.personalinformationGroup.Location = new System.Drawing.Point(12, 12);
            this.personalinformationGroup.Name = "personalinformationGroup";
            this.personalinformationGroup.Size = new System.Drawing.Size(253, 129);
            this.personalinformationGroup.TabIndex = 0;
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
            this.courseinformationGroup.Location = new System.Drawing.Point(12, 158);
            this.courseinformationGroup.Name = "courseinformationGroup";
            this.courseinformationGroup.Size = new System.Drawing.Size(253, 129);
            this.courseinformationGroup.TabIndex = 6;
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
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.registerButton.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.registerButton.Location = new System.Drawing.Point(12, 301);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(260, 40);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "REGISTER USER";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Silver;
            this.resetButton.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(12, 352);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(125, 40);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelButton.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Maroon;
            this.cancelButton.Location = new System.Drawing.Point(142, 352);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 40);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 411);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.courseinformationGroup);
            this.Controls.Add(this.personalinformationGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRATION";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_FormClosed);
            this.Load += new System.EventHandler(this.Add_Load);
            this.personalinformationGroup.ResumeLayout(false);
            this.personalinformationGroup.PerformLayout();
            this.courseinformationGroup.ResumeLayout(false);
            this.courseinformationGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox personalinformationGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastnameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox middlenameText;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.TextBox firstnameText;
        private System.Windows.Forms.GroupBox courseinformationGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label textlabel;
        private System.Windows.Forms.TextBox sectionText;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox courseText;
        private System.Windows.Forms.ComboBox yearText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}