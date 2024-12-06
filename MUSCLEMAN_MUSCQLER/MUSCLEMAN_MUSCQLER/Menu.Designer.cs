namespace MUSCLEMAN_MUSCQLER
{
    partial class MUSCQLER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MUSCQLER));
            this.toReader = new System.Windows.Forms.Button();
            this.toCreator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toReader
            // 
            this.toReader.BackgroundImage = global::MUSCLEMAN_MUSCQLER.Properties.Resources.READERBUTTON;
            this.toReader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toReader.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toReader.Location = new System.Drawing.Point(132, 168);
            this.toReader.Name = "toReader";
            this.toReader.Size = new System.Drawing.Size(179, 151);
            this.toReader.TabIndex = 8;
            this.toReader.UseVisualStyleBackColor = true;
            this.toReader.Click += new System.EventHandler(this.toReader_Click);
            // 
            // toCreator
            // 
            this.toCreator.BackgroundImage = global::MUSCLEMAN_MUSCQLER.Properties.Resources.CREATORBUTTON;
            this.toCreator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toCreator.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toCreator.Location = new System.Drawing.Point(480, 168);
            this.toCreator.Name = "toCreator";
            this.toCreator.Size = new System.Drawing.Size(179, 151);
            this.toCreator.TabIndex = 7;
            this.toCreator.UseVisualStyleBackColor = true;
            this.toCreator.Click += new System.EventHandler(this.toCreator_Click);
            // 
            // MUSCQLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toReader);
            this.Controls.Add(this.toCreator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "MUSCQLER";
            this.Text = "MUSCQLER";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button toCreator;
        private System.Windows.Forms.Button toReader;
    }
}