using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceQR
{
    public partial class QR : Form
    {
        public QR()
        {
            InitializeComponent();
        }

        private void qrText_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateQR_Click(object sender, EventArgs e)
        {
            //Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            //QRpic.Image = qrcode.Draw(qrText.Text,0);
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            {   
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                    encoder.QRCodeScale = 10;
                    Bitmap bmp = encoder.Encode(qrText.Text);
                    QRpic.Image = bmp;
                    bmp.Save(sfd.FileName, ImageFormat.Jpeg);
                }

            }
        }
    }
}
