namespace SteganographicEncryption_WinForms_SSTU
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_OpenSourceImg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_SourceImg = new System.Windows.Forms.PictureBox();
            this.pictureBox_UnsteganImg = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_OpenUnsteganImg = new System.Windows.Forms.Button();
            this.richTextBox_SourceTxt = new System.Windows.Forms.RichTextBox();
            this.richTextBox_EncTxt = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_PassForEncTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_StartEnc = new System.Windows.Forms.Button();
            this.button_StartDec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PassForDecTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox_DecTxt = new System.Windows.Forms.RichTextBox();
            this.richTextBox_ReadTxt = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SourceImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UnsteganImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Steganographic with encryption";
            // 
            // button_OpenSourceImg
            // 
            this.button_OpenSourceImg.Location = new System.Drawing.Point(10, 468);
            this.button_OpenSourceImg.Name = "button_OpenSourceImg";
            this.button_OpenSourceImg.Size = new System.Drawing.Size(350, 23);
            this.button_OpenSourceImg.TabIndex = 1;
            this.button_OpenSourceImg.Text = "Open image";
            this.button_OpenSourceImg.UseVisualStyleBackColor = true;
            this.button_OpenSourceImg.Click += new System.EventHandler(this.button_OpenSourceImg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(60, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Source text:";
            // 
            // pictureBox_SourceImg
            // 
            this.pictureBox_SourceImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_SourceImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_SourceImg.Location = new System.Drawing.Point(10, 62);
            this.pictureBox_SourceImg.Name = "pictureBox_SourceImg";
            this.pictureBox_SourceImg.Size = new System.Drawing.Size(350, 400);
            this.pictureBox_SourceImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_SourceImg.TabIndex = 3;
            this.pictureBox_SourceImg.TabStop = false;
            // 
            // pictureBox_UnsteganImg
            // 
            this.pictureBox_UnsteganImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_UnsteganImg.Location = new System.Drawing.Point(366, 62);
            this.pictureBox_UnsteganImg.Name = "pictureBox_UnsteganImg";
            this.pictureBox_UnsteganImg.Size = new System.Drawing.Size(350, 400);
            this.pictureBox_UnsteganImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_UnsteganImg.TabIndex = 5;
            this.pictureBox_UnsteganImg.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(140, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Source image:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(460, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Image with hidden data:";
            // 
            // button_OpenUnsteganImg
            // 
            this.button_OpenUnsteganImg.Location = new System.Drawing.Point(366, 468);
            this.button_OpenUnsteganImg.Name = "button_OpenUnsteganImg";
            this.button_OpenUnsteganImg.Size = new System.Drawing.Size(350, 23);
            this.button_OpenUnsteganImg.TabIndex = 9;
            this.button_OpenUnsteganImg.Text = "Open image";
            this.button_OpenUnsteganImg.UseVisualStyleBackColor = true;
            this.button_OpenUnsteganImg.Click += new System.EventHandler(this.button_OpenUnsteganImg_Click);
            // 
            // richTextBox_SourceTxt
            // 
            this.richTextBox_SourceTxt.Location = new System.Drawing.Point(10, 516);
            this.richTextBox_SourceTxt.Name = "richTextBox_SourceTxt";
            this.richTextBox_SourceTxt.Size = new System.Drawing.Size(172, 136);
            this.richTextBox_SourceTxt.TabIndex = 10;
            this.richTextBox_SourceTxt.Text = "";
            // 
            // richTextBox_EncTxt
            // 
            this.richTextBox_EncTxt.BackColor = System.Drawing.Color.White;
            this.richTextBox_EncTxt.Location = new System.Drawing.Point(188, 516);
            this.richTextBox_EncTxt.Name = "richTextBox_EncTxt";
            this.richTextBox_EncTxt.ReadOnly = true;
            this.richTextBox_EncTxt.Size = new System.Drawing.Size(172, 136);
            this.richTextBox_EncTxt.TabIndex = 11;
            this.richTextBox_EncTxt.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(200, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Encrypted and hidden text:";
            // 
            // textBox_PassForEncTxt
            // 
            this.textBox_PassForEncTxt.Location = new System.Drawing.Point(82, 658);
            this.textBox_PassForEncTxt.Name = "textBox_PassForEncTxt";
            this.textBox_PassForEncTxt.Size = new System.Drawing.Size(100, 20);
            this.textBox_PassForEncTxt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 659);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password:";
            // 
            // button_StartEnc
            // 
            this.button_StartEnc.Location = new System.Drawing.Point(188, 657);
            this.button_StartEnc.Name = "button_StartEnc";
            this.button_StartEnc.Size = new System.Drawing.Size(172, 23);
            this.button_StartEnc.TabIndex = 15;
            this.button_StartEnc.Text = "Encrypt and Hide";
            this.button_StartEnc.UseVisualStyleBackColor = true;
            this.button_StartEnc.Click += new System.EventHandler(this.button_StartEnc_Click);
            // 
            // button_StartDec
            // 
            this.button_StartDec.Location = new System.Drawing.Point(544, 657);
            this.button_StartDec.Name = "button_StartDec";
            this.button_StartDec.Size = new System.Drawing.Size(172, 23);
            this.button_StartDec.TabIndex = 22;
            this.button_StartDec.Text = "Read and decrypt";
            this.button_StartDec.UseVisualStyleBackColor = true;
            this.button_StartDec.Click += new System.EventHandler(this.button_StartDec_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(368, 659);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password:";
            // 
            // textBox_PassForDecTxt
            // 
            this.textBox_PassForDecTxt.Location = new System.Drawing.Point(438, 658);
            this.textBox_PassForDecTxt.Name = "textBox_PassForDecTxt";
            this.textBox_PassForDecTxt.Size = new System.Drawing.Size(100, 20);
            this.textBox_PassForDecTxt.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(591, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Decrypted text:";
            // 
            // richTextBox_DecTxt
            // 
            this.richTextBox_DecTxt.BackColor = System.Drawing.Color.White;
            this.richTextBox_DecTxt.Location = new System.Drawing.Point(544, 516);
            this.richTextBox_DecTxt.Name = "richTextBox_DecTxt";
            this.richTextBox_DecTxt.ReadOnly = true;
            this.richTextBox_DecTxt.Size = new System.Drawing.Size(172, 136);
            this.richTextBox_DecTxt.TabIndex = 18;
            this.richTextBox_DecTxt.Text = "";
            // 
            // richTextBox_ReadTxt
            // 
            this.richTextBox_ReadTxt.Location = new System.Drawing.Point(366, 516);
            this.richTextBox_ReadTxt.Name = "richTextBox_ReadTxt";
            this.richTextBox_ReadTxt.Size = new System.Drawing.Size(172, 136);
            this.richTextBox_ReadTxt.TabIndex = 17;
            this.richTextBox_ReadTxt.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(403, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Read hidden data:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 687);
            this.Controls.Add(this.button_StartDec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_PassForDecTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBox_DecTxt);
            this.Controls.Add(this.richTextBox_ReadTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_StartEnc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_PassForEncTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox_EncTxt);
            this.Controls.Add(this.richTextBox_SourceTxt);
            this.Controls.Add(this.button_OpenUnsteganImg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox_UnsteganImg);
            this.Controls.Add(this.pictureBox_SourceImg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_OpenSourceImg);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Steganographic encryption tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SourceImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UnsteganImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_OpenSourceImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_SourceImg;
        private System.Windows.Forms.PictureBox pictureBox_UnsteganImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_OpenUnsteganImg;
        private System.Windows.Forms.RichTextBox richTextBox_SourceTxt;
        private System.Windows.Forms.RichTextBox richTextBox_EncTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_PassForEncTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_StartEnc;
        private System.Windows.Forms.Button button_StartDec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_PassForDecTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox_DecTxt;
        private System.Windows.Forms.RichTextBox richTextBox_ReadTxt;
        private System.Windows.Forms.Label label9;
    }
}

