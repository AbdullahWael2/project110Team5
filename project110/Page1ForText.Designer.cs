namespace project110
{
    partial class Page1ForText
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
            this.label1PT = new System.Windows.Forms.Label();
            this.label2PT = new System.Windows.Forms.Label();
            this.TxtInputEnc = new System.Windows.Forms.TextBox();
            this.TxtInputDec = new System.Windows.Forms.TextBox();
            this.BtnTxtEnc = new System.Windows.Forms.Button();
            this.BtnTxtDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1PT
            // 
            this.label1PT.AutoSize = true;
            this.label1PT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1PT.Location = new System.Drawing.Point(24, 66);
            this.label1PT.Name = "label1PT";
            this.label1PT.Size = new System.Drawing.Size(336, 20);
            this.label1PT.TabIndex = 0;
            this.label1PT.Text = "Type your text message here for encryption.";
            // 
            // label2PT
            // 
            this.label2PT.AutoSize = true;
            this.label2PT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2PT.Location = new System.Drawing.Point(450, 66);
            this.label2PT.Name = "label2PT";
            this.label2PT.Size = new System.Drawing.Size(308, 20);
            this.label2PT.TabIndex = 1;
            this.label2PT.Text = "Type your text message here to decrypt.";
            this.label2PT.Click += new System.EventHandler(this.label2PT_Click);
            // 
            // TxtInputEnc
            // 
            this.TxtInputEnc.Location = new System.Drawing.Point(65, 107);
            this.TxtInputEnc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtInputEnc.Multiline = true;
            this.TxtInputEnc.Name = "TxtInputEnc";
            this.TxtInputEnc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtInputEnc.Size = new System.Drawing.Size(275, 221);
            this.TxtInputEnc.TabIndex = 2;
            // 
            // TxtInputDec
            // 
            this.TxtInputDec.Location = new System.Drawing.Point(466, 107);
            this.TxtInputDec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtInputDec.Multiline = true;
            this.TxtInputDec.Name = "TxtInputDec";
            this.TxtInputDec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtInputDec.Size = new System.Drawing.Size(273, 221);
            this.TxtInputDec.TabIndex = 3;
            // 
            // BtnTxtEnc
            // 
            this.BtnTxtEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnTxtEnc.Location = new System.Drawing.Point(123, 361);
            this.BtnTxtEnc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTxtEnc.Name = "BtnTxtEnc";
            this.BtnTxtEnc.Size = new System.Drawing.Size(157, 32);
            this.BtnTxtEnc.TabIndex = 4;
            this.BtnTxtEnc.Text = "Encrypt";
            this.BtnTxtEnc.UseVisualStyleBackColor = true;
            this.BtnTxtEnc.Click += new System.EventHandler(this.BtnTxtEnc_Click);
            // 
            // BtnTxtDec
            // 
            this.BtnTxtDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnTxtDec.Location = new System.Drawing.Point(527, 361);
            this.BtnTxtDec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTxtDec.Name = "BtnTxtDec";
            this.BtnTxtDec.Size = new System.Drawing.Size(173, 32);
            this.BtnTxtDec.TabIndex = 5;
            this.BtnTxtDec.Text = "Decrypt";
            this.BtnTxtDec.UseVisualStyleBackColor = true;
            this.BtnTxtDec.Click += new System.EventHandler(this.BtnTxtDec_Click);
            // 
            // Page1ForText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnTxtDec);
            this.Controls.Add(this.BtnTxtEnc);
            this.Controls.Add(this.TxtInputDec);
            this.Controls.Add(this.TxtInputEnc);
            this.Controls.Add(this.label2PT);
            this.Controls.Add(this.label1PT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Page1ForText";
            this.Text = "Page1ForText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1PT;
        private System.Windows.Forms.Label label2PT;
        private System.Windows.Forms.TextBox TxtInputEnc;
        private System.Windows.Forms.TextBox TxtInputDec;
        private System.Windows.Forms.Button BtnTxtEnc;
        private System.Windows.Forms.Button BtnTxtDec;
    }
}