namespace project110
{
    partial class PicPreview
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
            this.OutputPicEnc = new System.Windows.Forms.PictureBox();
            this.OutputPicDec = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPicEnc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPicDec)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputPicEnc
            // 
            this.OutputPicEnc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputPicEnc.Location = new System.Drawing.Point(12, 33);
            this.OutputPicEnc.Name = "OutputPicEnc";
            this.OutputPicEnc.Size = new System.Drawing.Size(364, 405);
            this.OutputPicEnc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OutputPicEnc.TabIndex = 0;
            this.OutputPicEnc.TabStop = false;
            this.OutputPicEnc.Click += new System.EventHandler(this.OutputPicEnc_Click);
            // 
            // OutputPicDec
            // 
            this.OutputPicDec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputPicDec.Location = new System.Drawing.Point(424, 33);
            this.OutputPicDec.Name = "OutputPicDec";
            this.OutputPicDec.Size = new System.Drawing.Size(364, 405);
            this.OutputPicDec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OutputPicDec.TabIndex = 1;
            this.OutputPicDec.TabStop = false;
            this.OutputPicDec.Click += new System.EventHandler(this.OutputPicDec_Click);
            // 
            // PicPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputPicDec);
            this.Controls.Add(this.OutputPicEnc);
            this.Name = "PicPreview";
            this.Text = "PicPreview";
            ((System.ComponentModel.ISupportInitialize)(this.OutputPicEnc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPicDec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox OutputPicEnc;
        private System.Windows.Forms.PictureBox OutputPicDec;
    }
}