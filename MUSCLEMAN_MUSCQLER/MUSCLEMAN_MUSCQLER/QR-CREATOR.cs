using QRCoder;
using System.Drawing;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace MUSCLEMAN_MUSCQLER
{
    public partial class QRCODECREATOR : Form
    {
        private Bitmap qrCodeImage;

        public QRCODECREATOR()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.pictureBox1.Click += PictureBox1_Click; 
            this.textBox1.TextChanged += TextBox1_TextChanged; 
        }

        private void QRCODECREATOR_Load(object sender, EventArgs e)
        {
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            GenerateQRCode(); 
        }

        private void GenerateQRCode()
        {
            string data = textBox1.Text;

            if (string.IsNullOrEmpty(data))
            {
                pictureBox1.Image = null; 
                return;
            }


            if (!data.StartsWith("http://") && !data.StartsWith("https://"))
            {

            }


            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData); 


            qrCodeImage = qrCode.GetGraphic(20);


            pictureBox1.Image = qrCodeImage;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (qrCodeImage == null)
            {
                MessageBox.Show("Please generate a QR code first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPath = Path.Combine(desktopPath, "QR Codes");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileName = textBox1.Text;

            foreach (char c in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(c.ToString(), "");
            }

            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Invalid file name. Cannot save QR code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filePath = Path.Combine(folderPath, fileName + ".png");

            try
            {
                qrCodeImage.Save(filePath, ImageFormat.Png);
                MessageBox.Show($"QR code saved successfully: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toReader_Click(object sender, EventArgs e)
        {
            QR_READER secondForm = new QR_READER();
            secondForm.Location = this.Location; 
            secondForm.Show();
            this.Hide(); 
        }
    }
}
