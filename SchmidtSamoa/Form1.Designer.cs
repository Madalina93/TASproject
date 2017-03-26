namespace SchmidtSamoa
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
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChipertextBox = new System.Windows.Forms.TextBox();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSsKeyGenTime = new System.Windows.Forms.Label();
            this.lblSsEncTime = new System.Windows.Forms.Label();
            this.lblSsDecryptTime = new System.Windows.Forms.Label();
            this.lblRSAKeyGenTime = new System.Windows.Forms.Label();
            this.lblRSAencTime = new System.Windows.Forms.Label();
            this.lblRSAdecTime = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "The message:";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(231, 19);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(284, 53);
            this.textBoxMessage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chiphertext:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Plaintext recovered:";
            // 
            // ChipertextBox
            // 
            this.ChipertextBox.Location = new System.Drawing.Point(231, 78);
            this.ChipertextBox.Multiline = true;
            this.ChipertextBox.Name = "ChipertextBox";
            this.ChipertextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChipertextBox.Size = new System.Drawing.Size(284, 53);
            this.ChipertextBox.TabIndex = 4;
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(231, 137);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlainText.Size = new System.Drawing.Size(284, 52);
            this.txtPlainText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Schmidt Samoa key generation time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Schmidt Samoa encryption time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Schmidt Samoa decryption time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "RSA decryption time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(499, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "RSA encryption time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(499, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "RSA key generation time:";
            // 
            // lblSsKeyGenTime
            // 
            this.lblSsKeyGenTime.AutoSize = true;
            this.lblSsKeyGenTime.Location = new System.Drawing.Point(317, 222);
            this.lblSsKeyGenTime.Name = "lblSsKeyGenTime";
            this.lblSsKeyGenTime.Size = new System.Drawing.Size(0, 17);
            this.lblSsKeyGenTime.TabIndex = 12;
            // 
            // lblSsEncTime
            // 
            this.lblSsEncTime.AutoSize = true;
            this.lblSsEncTime.Location = new System.Drawing.Point(317, 277);
            this.lblSsEncTime.Name = "lblSsEncTime";
            this.lblSsEncTime.Size = new System.Drawing.Size(0, 17);
            this.lblSsEncTime.TabIndex = 13;
            // 
            // lblSsDecryptTime
            // 
            this.lblSsDecryptTime.AutoSize = true;
            this.lblSsDecryptTime.Location = new System.Drawing.Point(317, 336);
            this.lblSsDecryptTime.Name = "lblSsDecryptTime";
            this.lblSsDecryptTime.Size = new System.Drawing.Size(0, 17);
            this.lblSsDecryptTime.TabIndex = 14;
            // 
            // lblRSAKeyGenTime
            // 
            this.lblRSAKeyGenTime.AutoSize = true;
            this.lblRSAKeyGenTime.Location = new System.Drawing.Point(695, 222);
            this.lblRSAKeyGenTime.Name = "lblRSAKeyGenTime";
            this.lblRSAKeyGenTime.Size = new System.Drawing.Size(0, 17);
            this.lblRSAKeyGenTime.TabIndex = 15;
            // 
            // lblRSAencTime
            // 
            this.lblRSAencTime.AutoSize = true;
            this.lblRSAencTime.Location = new System.Drawing.Point(695, 277);
            this.lblRSAencTime.Name = "lblRSAencTime";
            this.lblRSAencTime.Size = new System.Drawing.Size(0, 17);
            this.lblRSAencTime.TabIndex = 16;
            // 
            // lblRSAdecTime
            // 
            this.lblRSAdecTime.AutoSize = true;
            this.lblRSAdecTime.Location = new System.Drawing.Point(695, 336);
            this.lblRSAdecTime.Name = "lblRSAdecTime";
            this.lblRSAdecTime.Size = new System.Drawing.Size(0, 17);
            this.lblRSAdecTime.TabIndex = 17;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(550, 39);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(89, 33);
            this.buttonEncrypt.TabIndex = 18;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(550, 130);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(89, 37);
            this.buttonDecrypt.TabIndex = 19;
            this.buttonDecrypt.Text = "Dencrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 464);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.lblRSAdecTime);
            this.Controls.Add(this.lblRSAencTime);
            this.Controls.Add(this.lblRSAKeyGenTime);
            this.Controls.Add(this.lblSsDecryptTime);
            this.Controls.Add(this.lblSsEncTime);
            this.Controls.Add(this.lblSsKeyGenTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.ChipertextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ChipertextBox;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSsKeyGenTime;
        private System.Windows.Forms.Label lblSsEncTime;
        private System.Windows.Forms.Label lblSsDecryptTime;
        private System.Windows.Forms.Label lblRSAKeyGenTime;
        private System.Windows.Forms.Label lblRSAencTime;
        private System.Windows.Forms.Label lblRSAdecTime;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
    }
}

