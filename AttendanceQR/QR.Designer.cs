namespace AttendanceQR
{
    partial class QR
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
            this.QRpic = new System.Windows.Forms.PictureBox();
            this.qrText = new System.Windows.Forms.TextBox();
            this.generateQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QRpic)).BeginInit();
            this.SuspendLayout();
            // 
            // QRpic
            // 
            this.QRpic.Location = new System.Drawing.Point(12, 25);
            this.QRpic.Name = "QRpic";
            this.QRpic.Size = new System.Drawing.Size(238, 224);
            this.QRpic.TabIndex = 0;
            this.QRpic.TabStop = false;
            // 
            // qrText
            // 
            this.qrText.Location = new System.Drawing.Point(288, 38);
            this.qrText.Name = "qrText";
            this.qrText.Size = new System.Drawing.Size(183, 20);
            this.qrText.TabIndex = 1;
            this.qrText.TextChanged += new System.EventHandler(this.qrText_TextChanged);
            // 
            // generateQR
            // 
            this.generateQR.Location = new System.Drawing.Point(288, 80);
            this.generateQR.Name = "generateQR";
            this.generateQR.Size = new System.Drawing.Size(183, 28);
            this.generateQR.TabIndex = 2;
            this.generateQR.Text = "QR";
            this.generateQR.UseVisualStyleBackColor = true;
            this.generateQR.Click += new System.EventHandler(this.generateQR_Click);
            // 
            // QR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 269);
            this.Controls.Add(this.generateQR);
            this.Controls.Add(this.qrText);
            this.Controls.Add(this.QRpic);
            this.Name = "QR";
            this.Text = "QR";
            ((System.ComponentModel.ISupportInitialize)(this.QRpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QRpic;
        private System.Windows.Forms.TextBox qrText;
        private System.Windows.Forms.Button generateQR;
    }
}