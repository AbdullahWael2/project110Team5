using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project110
{
    public partial class Form3 : Form
    {
        string originalImagePath = "";
        string encryptedImagePath = "";
        string decryptedImagePath = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnChooseToEnc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                originalImagePath = ofd.FileName;
                PhotoInputToEnc.Image = Image.FromFile(originalImagePath); 
            }
        }

        private void EncPhotoBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(originalImagePath))
            {
                byte[] bytes = File.ReadAllBytes(originalImagePath);

                int headerLength = 100;
                for (int i = headerLength; i < bytes.Length; i++)
                {
                    bytes[i] = (byte)(bytes[i] + 1);
                }

                string outputPath = Path.Combine(Path.GetDirectoryName(originalImagePath), "encrypted_" + Path.GetFileName(originalImagePath));
                File.WriteAllBytes(outputPath, bytes);
                encryptedImagePath = outputPath;

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JPEG Image|*.jpg|PNG Image|*.png|BMP Image|*.bmp";
                sfd.Title = "Save Encrypted Image As";
                sfd.FileName = "Encrypted_Image";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(outputPath, sfd.FileName, true);
                    MessageBox.Show("✅ Encrypted image saved successfully!");
                }
            }
            else
            {
                MessageBox.Show("❌ Please select an image to encrypt.");
            }
        }


        private void BtnChooseToDec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                decryptedImagePath = ofd.FileName;
                PhotoInputToDec.Image = Image.FromFile(decryptedImagePath);  
            }
        }

        private void DecPhotoBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(decryptedImagePath))
            {
                byte[] bytes = File.ReadAllBytes(decryptedImagePath);

                int headerLength = 100;
                for (int i = headerLength; i < bytes.Length; i++)
                {
                    bytes[i] = (byte)(bytes[i] - 1);
                }

                Image decryptedImage;
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    decryptedImage = Image.FromStream(ms);
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JPEG Image|*.jpg|PNG Image|*.png|BMP Image|*.bmp";
                sfd.Title = "Save Decrypted Image As";
                sfd.FileName = "Decrypted_Image";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    decryptedImage.Save(sfd.FileName);
                    MessageBox.Show("✅ Decrypted image saved successfully!");
                }
            }
            else
            {
                MessageBox.Show("❌ Please select an encrypted image to decrypt.");
            }
        }

        private void PhotoInputToEnc_Click(object sender, EventArgs e)
        {

        }

        private void PhotoInputToDec_Click(object sender, EventArgs e)
        {

        }
    }
}