namespace MUSCLEMAN_MUSCQLER
{
    partial class QR_READER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR_READER));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toCreator = new System.Windows.Forms.Button();
            this.MUSCLEMANLOGO = new System.Windows.Forms.PictureBox();
            this.dragdrop = new System.Windows.Forms.PictureBox();
            this.Reader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MUSCLEMANLOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragdrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reader)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(380, 389);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // toCreator
            // 
            this.toCreator.BackgroundImage = global::MUSCLEMAN_MUSCQLER.Properties.Resources.CREATORBUTTON;
            this.toCreator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toCreator.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toCreator.Location = new System.Drawing.Point(35, 33);
            this.toCreator.Name = "toCreator";
            this.toCreator.Size = new System.Drawing.Size(93, 82);
            this.toCreator.TabIndex = 1;
            this.toCreator.UseVisualStyleBackColor = true;
            this.toCreator.Click += new System.EventHandler(this.toCreator_Click);
            // 
            // MUSCLEMANLOGO
            // 
            this.MUSCLEMANLOGO.Image = global::MUSCLEMAN_MUSCQLER.Properties.Resources.MUSCLEMAN;
            this.MUSCLEMANLOGO.Location = new System.Drawing.Point(35, 121);
            this.MUSCLEMANLOGO.Name = "MUSCLEMANLOGO";
            this.MUSCLEMANLOGO.Size = new System.Drawing.Size(234, 228);
            this.MUSCLEMANLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MUSCLEMANLOGO.TabIndex = 2;
            this.MUSCLEMANLOGO.TabStop = false;
            // 
            // dragdrop
            // 
            this.dragdrop.Image = global::MUSCLEMAN_MUSCQLER.Properties.Resources.dragdrop;
            this.dragdrop.Location = new System.Drawing.Point(323, 161);
            this.dragdrop.Name = "dragdrop";
            this.dragdrop.Size = new System.Drawing.Size(156, 151);
            this.dragdrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dragdrop.TabIndex = 0;
            this.dragdrop.TabStop = false;
            // 
            // Reader
            // 
            this.Reader.Image = global::MUSCLEMAN_MUSCQLER.Properties.Resources.qrcodereader;
            this.Reader.Location = new System.Drawing.Point(445, 52);
            this.Reader.Name = "Reader";
            this.Reader.Size = new System.Drawing.Size(395, 365);
            this.Reader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Reader.TabIndex = 3;
            this.Reader.TabStop = false;
            // 
            // QR_READER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dragdrop);
            this.Controls.Add(this.toCreator);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.MUSCLEMANLOGO);
            this.Controls.Add(this.Reader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QR_READER";
            this.Text = "QR_READER";
            this.Load += new System.EventHandler(this.QR_READER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MUSCLEMANLOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragdrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button toCreator;
        private System.Windows.Forms.PictureBox MUSCLEMANLOGO;
        private System.Windows.Forms.PictureBox dragdrop;
        private System.Windows.Forms.PictureBox Reader;
    }
}