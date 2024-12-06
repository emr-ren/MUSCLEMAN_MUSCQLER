using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSCLEMAN_MUSCQLER
{
    public partial class MUSCQLER : Form
    {
        public MUSCQLER()
        {
            InitializeComponent();
        }

        private void toCreator_Click(object sender, EventArgs e)
        {
            QRCODECREATOR secondForm = new QRCODECREATOR();
            secondForm.Location = this.Location; // İkinci formun konumunu ayarlıyoruz
            secondForm.Show();
            this.Hide(); // Eski formu gizle
        }

        private void toReader_Click(object sender, EventArgs e)
        {
            QR_READER secondForm = new QR_READER();
            secondForm.Location = this.Location; // İkinci formun konumunu ayarlıyoruz
            secondForm.Show();
            this.Hide(); // Eski formu gizle
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            CenterToScreen(); // Başlangıçta ekranın ortasına al
        }
    }
}
