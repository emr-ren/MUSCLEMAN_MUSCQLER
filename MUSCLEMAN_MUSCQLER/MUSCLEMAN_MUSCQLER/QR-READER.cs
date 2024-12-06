using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace MUSCLEMAN_MUSCQLER
{
    public partial class QR_READER : Form
    {
        private bool isContentCopied = false;

        public QR_READER()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.dragdrop.AllowDrop = true;
            this.dragdrop.DragEnter += new DragEventHandler(PictureBox1_DragEnter);
            this.dragdrop.DragDrop += new DragEventHandler(PictureBox1_DragDrop);
            this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
            linkLabel1.Visible = false; 
        }

        private void QR_READER_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string filePath = files[0];
                try
                {
                    Bitmap bitmap = new Bitmap(filePath);
                    if (bitmap != null)
                    {
                        var reader = new BarcodeReader();
                        var result = reader.Decode(bitmap);

                        if (result != null)
                        {
                            dragdrop.Image = bitmap; 
                            SetLinkLabelText(result.Text);
                            linkLabel1.Visible = true; 
                            isContentCopied = false;
                        }
                        else
                        {
                            MessageBox.Show("This is not a QR code. Please upload a valid QR code image.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to load image.");
                    }
                }
                catch (ArgumentException argEx)
                {
                    MessageBox.Show($"Argument Error: {argEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void SetLinkLabelText(string text)
        {
            linkLabel1.Text = text;
            linkLabel1.Size = TextRenderer.MeasureText(text, linkLabel1.Font);
            linkLabel1.Location = new Point((this.ClientSize.Width - linkLabel1.Width) / 2, linkLabel1.Location.Y);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!isContentCopied && !string.IsNullOrEmpty(linkLabel1.Text))
            {
                Clipboard.SetText(linkLabel1.Text);
                MessageBox.Show("Link copied!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isContentCopied = true;
            }
        }

        private void toCreator_Click(object sender, EventArgs e)
        {
            QRCODECREATOR secondForm = new QRCODECREATOR();
            secondForm.Location = this.Location; 
            secondForm.Show();
            this.Hide();
        }
    }
}
