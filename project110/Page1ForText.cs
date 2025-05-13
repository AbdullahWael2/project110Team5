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
    public partial class Page1ForText : Form
    {
        
            public Page1ForText()
            {
                InitializeComponent();
            }

            private void BtnHome_Click(object sender, EventArgs e)
            {
                Form1 main = new Form1();
                main.Show();
            }

            private void BtnTxtEnc_Click(object sender, EventArgs e)
            {
                string input = TxtInputEnc.Text;
                TxtInputDec.Clear(); 

                if (string.IsNullOrWhiteSpace(input)) return;

                char[] chars = input.ToCharArray();

                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] = (char)(chars[i] + 1); 
                }

                string encrypted = new string(chars);
                TxtInputDec.Text = encrypted;
            }

            private void BtnTxtDec_Click(object sender, EventArgs e)
            {
                string input = TxtInputDec.Text;
                TxtInputEnc.Clear(); 

                if (string.IsNullOrWhiteSpace(input)) return;

                char[] chars = input.ToCharArray();

                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] = (char)(chars[i] - 1);
                }

                string decrypted = new string(chars);
                TxtInputEnc.Text = decrypted;
            }

            private void label2PT_Click(object sender, EventArgs e)
            {
               
            }
        }

    }
