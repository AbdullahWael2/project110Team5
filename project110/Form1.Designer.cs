namespace project110
{
    partial class Form1
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
            this.BtnMrs = new System.Windows.Forms.Button();
            this.BtnPhoto = new System.Windows.Forms.Button();
            this.BtnTxt = new System.Windows.Forms.Button();
            this.LblChoose1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMrs
            // 
            this.BtnMrs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnMrs.Location = new System.Drawing.Point(562, 258);
            this.BtnMrs.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMrs.Name = "BtnMrs";
            this.BtnMrs.Size = new System.Drawing.Size(171, 47);
            this.BtnMrs.TabIndex = 0;
            this.BtnMrs.Text = "For Morse Code";
            this.BtnMrs.UseVisualStyleBackColor = false;
            this.BtnMrs.Click += new System.EventHandler(this.BtnMrs_Click);
            // 
            // BtnPhoto
            // 
            this.BtnPhoto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnPhoto.Location = new System.Drawing.Point(307, 258);
            this.BtnPhoto.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPhoto.Name = "BtnPhoto";
            this.BtnPhoto.Size = new System.Drawing.Size(172, 47);
            this.BtnPhoto.TabIndex = 2;
            this.BtnPhoto.Text = "For Photos";
            this.BtnPhoto.UseVisualStyleBackColor = false;
            this.BtnPhoto.Click += new System.EventHandler(this.BtnPhoto_Click);
            // 
            // BtnTxt
            // 
            this.BtnTxt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnTxt.Location = new System.Drawing.Point(77, 258);
            this.BtnTxt.Margin = new System.Windows.Forms.Padding(0);
            this.BtnTxt.Name = "BtnTxt";
            this.BtnTxt.Size = new System.Drawing.Size(172, 47);
            this.BtnTxt.TabIndex = 3;
            this.BtnTxt.Text = "For Text";
            this.BtnTxt.UseVisualStyleBackColor = false;
            this.BtnTxt.Click += new System.EventHandler(this.BtnTxt_Click);
            // 
            // LblChoose1
            // 
            this.LblChoose1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LblChoose1.Location = new System.Drawing.Point(243, 82);
            this.LblChoose1.Name = "LblChoose1";
            this.LblChoose1.Size = new System.Drawing.Size(353, 128);
            this.LblChoose1.TabIndex = 4;
            this.LblChoose1.Text = " Choose Your interpretation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblChoose1);
            this.Controls.Add(this.BtnTxt);
            this.Controls.Add(this.BtnPhoto);
            this.Controls.Add(this.BtnMrs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMrs;
        private System.Windows.Forms.Button BtnPhoto;
        private System.Windows.Forms.Button BtnTxt;
        private System.Windows.Forms.Label LblChoose1;
    }
}

