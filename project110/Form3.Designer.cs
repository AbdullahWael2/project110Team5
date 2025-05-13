namespace project110
{
    partial class Form3
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
            this.PhotoInputToEnc = new System.Windows.Forms.PictureBox();
            this.PhotoInputToDec = new System.Windows.Forms.PictureBox();
            this.EncPhotoBtn = new System.Windows.Forms.Button();
            this.DecPhotoBtn = new System.Windows.Forms.Button();
            this.BtnChooseToEnc = new System.Windows.Forms.Button();
            this.BtnChooseToDec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoInputToEnc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoInputToDec)).BeginInit();
            this.SuspendLayout();
            // 
            // PhotoInputToEnc
            // 
            this.PhotoInputToEnc.Location = new System.Drawing.Point(120, 129);
            this.PhotoInputToEnc.Name = "PhotoInputToEnc";
            this.PhotoInputToEnc.Size = new System.Drawing.Size(205, 106);
            this.PhotoInputToEnc.TabIndex = 0;
            this.PhotoInputToEnc.TabStop = false;
            this.PhotoInputToEnc.Click += new System.EventHandler(this.PhotoInputToEnc_Click);
            // 
            // PhotoInputToDec
            // 
            this.PhotoInputToDec.Location = new System.Drawing.Point(505, 129);
            this.PhotoInputToDec.Name = "PhotoInputToDec";
            this.PhotoInputToDec.Size = new System.Drawing.Size(205, 106);
            this.PhotoInputToDec.TabIndex = 1;
            this.PhotoInputToDec.TabStop = false;
            this.PhotoInputToDec.Click += new System.EventHandler(this.PhotoInputToDec_Click);
            // 
            // EncPhotoBtn
            // 
            this.EncPhotoBtn.Location = new System.Drawing.Point(140, 276);
            this.EncPhotoBtn.Name = "EncPhotoBtn";
            this.EncPhotoBtn.Size = new System.Drawing.Size(158, 33);
            this.EncPhotoBtn.TabIndex = 2;
            this.EncPhotoBtn.Text = "Encrypt";
            this.EncPhotoBtn.UseVisualStyleBackColor = true;
            this.EncPhotoBtn.Click += new System.EventHandler(this.EncPhotoBtn_Click);
            // 
            // DecPhotoBtn
            // 
            this.DecPhotoBtn.Location = new System.Drawing.Point(532, 276);
            this.DecPhotoBtn.Name = "DecPhotoBtn";
            this.DecPhotoBtn.Size = new System.Drawing.Size(158, 33);
            this.DecPhotoBtn.TabIndex = 3;
            this.DecPhotoBtn.Text = "Decrypt";
            this.DecPhotoBtn.UseVisualStyleBackColor = true;
            this.DecPhotoBtn.Click += new System.EventHandler(this.DecPhotoBtn_Click);
            // 
            // BtnChooseToEnc
            // 
            this.BtnChooseToEnc.Location = new System.Drawing.Point(120, 76);
            this.BtnChooseToEnc.Name = "BtnChooseToEnc";
            this.BtnChooseToEnc.Size = new System.Drawing.Size(205, 30);
            this.BtnChooseToEnc.TabIndex = 4;
            this.BtnChooseToEnc.Text = "Choose the Photo to encrypt";
            this.BtnChooseToEnc.UseVisualStyleBackColor = true;
            this.BtnChooseToEnc.Click += new System.EventHandler(this.BtnChooseToEnc_Click);
            // 
            // BtnChooseToDec
            // 
            this.BtnChooseToDec.Location = new System.Drawing.Point(505, 76);
            this.BtnChooseToDec.Name = "BtnChooseToDec";
            this.BtnChooseToDec.Size = new System.Drawing.Size(205, 30);
            this.BtnChooseToDec.TabIndex = 5;
            this.BtnChooseToDec.Text = "Choose the photo to Decrypt";
            this.BtnChooseToDec.UseVisualStyleBackColor = true;
            this.BtnChooseToDec.Click += new System.EventHandler(this.BtnChooseToDec_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnChooseToDec);
            this.Controls.Add(this.BtnChooseToEnc);
            this.Controls.Add(this.DecPhotoBtn);
            this.Controls.Add(this.EncPhotoBtn);
            this.Controls.Add(this.PhotoInputToDec);
            this.Controls.Add(this.PhotoInputToEnc);
            this.Name = "Form3";
            this.Text = "Photos";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoInputToEnc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoInputToDec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PhotoInputToEnc;
        private System.Windows.Forms.PictureBox PhotoInputToDec;
        private System.Windows.Forms.Button EncPhotoBtn;
        private System.Windows.Forms.Button DecPhotoBtn;
        private System.Windows.Forms.Button BtnChooseToEnc;
        private System.Windows.Forms.Button BtnChooseToDec;
    }
}