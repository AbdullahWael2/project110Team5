namespace project110
{
    partial class Form5
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
            this.toMorseButton = new System.Windows.Forms.Button();
            this.toTextButton = new System.Windows.Forms.Button();
            this.textInputTextBox = new System.Windows.Forms.TextBox();
            this.morseInputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toMorseButton
            // 
            this.toMorseButton.Location = new System.Drawing.Point(28, 364);
            this.toMorseButton.Name = "toMorseButton";
            this.toMorseButton.Size = new System.Drawing.Size(293, 40);
            this.toMorseButton.TabIndex = 0;
            this.toMorseButton.Text = "Convert Text to Morse Code";
            this.toMorseButton.UseVisualStyleBackColor = true;
            this.toMorseButton.Click += new System.EventHandler(this.toMorseButton_Click);
            // 
            // toTextButton
            // 
            this.toTextButton.Location = new System.Drawing.Point(473, 364);
            this.toTextButton.Name = "toTextButton";
            this.toTextButton.Size = new System.Drawing.Size(293, 40);
            this.toTextButton.TabIndex = 1;
            this.toTextButton.Text = "Convert Morse Code to Text";
            this.toTextButton.UseVisualStyleBackColor = true;
            this.toTextButton.Click += new System.EventHandler(this.toTextButton_Click);
            // 
            // textInputTextBox
            // 
            this.textInputTextBox.Location = new System.Drawing.Point(28, 72);
            this.textInputTextBox.Multiline = true;
            this.textInputTextBox.Name = "textInputTextBox";
            this.textInputTextBox.Size = new System.Drawing.Size(293, 208);
            this.textInputTextBox.TabIndex = 2;
            // 
            // morseInputTextBox
            // 
            this.morseInputTextBox.Location = new System.Drawing.Point(473, 72);
            this.morseInputTextBox.Multiline = true;
            this.morseInputTextBox.Name = "morseInputTextBox";
            this.morseInputTextBox.Size = new System.Drawing.Size(293, 208);
            this.morseInputTextBox.TabIndex = 3;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.morseInputTextBox);
            this.Controls.Add(this.textInputTextBox);
            this.Controls.Add(this.toTextButton);
            this.Controls.Add(this.toMorseButton);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toMorseButton;
        private System.Windows.Forms.Button toTextButton;
        private System.Windows.Forms.TextBox textInputTextBox;
        private System.Windows.Forms.TextBox morseInputTextBox;
    }
}