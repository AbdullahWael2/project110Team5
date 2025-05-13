using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project110
{
    public partial class PicPreview : Form
    {
        public PicPreview(Image encryptedImage, Image decryptedImage)
        {
            InitializeComponent();

            if (encryptedImage != null)
            {
                Form testForm = new Form();
                PictureBox testPic = new PictureBox();
                testPic.Dock = DockStyle.Fill;
                testPic.Image = encryptedImage;
                testPic.SizeMode = PictureBoxSizeMode.Zoom;
                testForm.Controls.Add(testPic);
                testForm.Show();
            }

            if (decryptedImage != null)
            {
                OutputPicDec.Image = decryptedImage;
                MessageBox.Show("✅ Decrypted image loaded into OutputPicDec");
            }
        }

        private void OutputPicEnc_Click(object sender, EventArgs e)
        {

        }

        private void OutputPicDec_Click(object sender, EventArgs e)
        {

        }
    }
}
