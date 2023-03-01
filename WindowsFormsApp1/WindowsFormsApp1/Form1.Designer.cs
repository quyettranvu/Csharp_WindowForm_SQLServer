namespace WindowsFormsApp1
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
            this.selectFileButton = new System.Windows.Forms.Button();
            this.textBoxEncryptKey = new System.Windows.Forms.TextBox();
            this.encryptFileButton = new System.Windows.Forms.Button();
            this.radioButtonDES = new System.Windows.Forms.RadioButton();
            this.radioButtonAES = new System.Windows.Forms.RadioButton();
            this.labelLinkFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(146, 274);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(183, 56);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEncryptKey
            // 
            this.textBoxEncryptKey.Location = new System.Drawing.Point(248, 161);
            this.textBoxEncryptKey.Name = "textBoxEncryptKey";
            this.textBoxEncryptKey.Size = new System.Drawing.Size(225, 22);
            this.textBoxEncryptKey.TabIndex = 1;
            // 
            // encryptFileButton
            // 
            this.encryptFileButton.Location = new System.Drawing.Point(395, 274);
            this.encryptFileButton.Name = "encryptFileButton";
            this.encryptFileButton.Size = new System.Drawing.Size(183, 56);
            this.encryptFileButton.TabIndex = 2;
            this.encryptFileButton.Text = "Encrypt";
            this.encryptFileButton.UseVisualStyleBackColor = true;
            this.encryptFileButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButtonDES
            // 
            this.radioButtonDES.AutoSize = true;
            this.radioButtonDES.Location = new System.Drawing.Point(237, 218);
            this.radioButtonDES.Name = "radioButtonDES";
            this.radioButtonDES.Size = new System.Drawing.Size(57, 21);
            this.radioButtonDES.TabIndex = 3;
            this.radioButtonDES.TabStop = true;
            this.radioButtonDES.Text = "DES";
            this.radioButtonDES.UseVisualStyleBackColor = true;
            // 
            // radioButtonAES
            // 
            this.radioButtonAES.AutoSize = true;
            this.radioButtonAES.Location = new System.Drawing.Point(404, 218);
            this.radioButtonAES.Name = "radioButtonAES";
            this.radioButtonAES.Size = new System.Drawing.Size(56, 21);
            this.radioButtonAES.TabIndex = 4;
            this.radioButtonAES.TabStop = true;
            this.radioButtonAES.Text = "AES";
            this.radioButtonAES.UseVisualStyleBackColor = true;
            // 
            // labelLinkFile
            // 
            this.labelLinkFile.AutoSize = true;
            this.labelLinkFile.Location = new System.Drawing.Point(262, 101);
            this.labelLinkFile.Name = "labelLinkFile";
            this.labelLinkFile.Size = new System.Drawing.Size(46, 17);
            this.labelLinkFile.TabIndex = 5;
            this.labelLinkFile.Text = "label1";
            this.labelLinkFile.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Encrypt File with DES and AES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Encryption Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Link File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLinkFile);
            this.Controls.Add(this.radioButtonAES);
            this.Controls.Add(this.radioButtonDES);
            this.Controls.Add(this.encryptFileButton);
            this.Controls.Add(this.textBoxEncryptKey);
            this.Controls.Add(this.selectFileButton);
            this.Name = "Form1";
            this.Text = "\'";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox textBoxEncryptKey;
        private System.Windows.Forms.Button encryptFileButton;
        private System.Windows.Forms.RadioButton radioButtonDES;
        private System.Windows.Forms.RadioButton radioButtonAES;
        private System.Windows.Forms.Label labelLinkFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

