namespace MUSCLEMAN_MUSCQLER
{
    partial class QRCODECREATOR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCODECREATOR));
            this.toReader = new System.Windows.Forms.Button();
            this.Reader = new System.Windows.Forms.PictureBox();
            this.MUSCLEMANLOGO = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.download = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Reader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUSCLEMANLOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toReader
            // 
            this.toReader.BackgroundImage = global::MUSCLEMAN_MUSCQLER.Properties.Resources.READERBUTTON;
            this.toReader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toReader.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toReader.Location = new System.Drawing.Point(35, 33);
            this.toReader.Name = "toReader";
            this.toReader.Size = new System.Drawing.Size(93, 82);
            this.toReader.TabIndex = 5;
            this.toReader.UseVisualStyleBackColor = true;
            this.toReader.Click += new System.EventHandler(this.toReader_Click);
            // 
            // Reader
            // 
            this.Reader.Image = global::MUSCLEMAN_MUSCQLER.Properties.Resources.a_black_background_with_the_anime_style_logo_qr_co_wf5s2M8ZROWpAHh3NpQirQ_bwBqDAk_RUaYzkIa4fYcmg;
            this.Reader.Location = new System.Drawing.Point(485, 135);
            this.Reader.Name = "Reader";
            this.Reader.Size = new System.Drawing.Size(312, 199);
            this.Reader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Reader.TabIndex = 4;
            this.Reader.TabStop = false;
            // 
            // MUSCLEMANLOGO
            // 
            this.MUSCLEMANLOGO.Image = global::MUSCLEMAN_MUSCQLER.Properties.Resources.MUSCLEMAN;
            this.MUSCLEMANLOGO.Location = new System.Drawing.Point(35, 121);
            this.MUSCLEMANLOGO.Name = "MUSCLEMANLOGO";
            this.MUSCLEMANLOGO.Size = new System.Drawing.Size(234, 228);
            this.MUSCLEMANLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MUSCLEMANLOGO.TabIndex = 3;
            this.MUSCLEMANLOGO.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(436, 20);
            this.textBox1.TabIndex = 6;
            // 
            // download
            // 
            this.download.AutoSize = true;
            this.download.BackColor = System.Drawing.Color.Black;
            this.download.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download.ForeColor = System.Drawing.Color.White;
            this.download.Location = new System.Drawing.Point(295, 389);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(223, 16);
            this.download.TabIndex = 8;
            this.download.Text = "Click on the QR Code for download";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(323, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Type some text or link in the box to create a QR code";
            // 
            // QRCODECREATOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.download);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toReader);
            this.Controls.Add(this.Reader);
            this.Controls.Add(this.MUSCLEMANLOGO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QRCODECREATOR";
            this.Text = "QR-CREATOR";
            ((System.ComponentModel.ISupportInitialize)(this.Reader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUSCLEMANLOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MUSCLEMANLOGO;
        private System.Windows.Forms.PictureBox Reader;
        private System.Windows.Forms.Button toReader;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label download;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

