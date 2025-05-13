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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTxt_Click(object sender, EventArgs e)
        {
            Page1ForText textForm = new Page1ForText();
            textForm.Show();
        }

        private void BtnPhoto_Click(object sender, EventArgs e)
        {
            Form3 photoForm = new Form3();
            photoForm.Show();              
            this.Hide();
        }

        private void BtnMrs_Click(object sender, EventArgs e)
        {
            Form5 photoForm = new Form5();
            photoForm.Show();
            this.Hide();

        }
    }
    
}
