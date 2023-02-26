namespace Encrypt_DeCrypt_Program
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.FileTxt = new System.Windows.Forms.TextBox();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.DeCryptBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // FileBtn
            // 
            this.FileBtn.Location = new System.Drawing.Point(457, 29);
            this.FileBtn.Name = "FileBtn";
            this.FileBtn.Size = new System.Drawing.Size(103, 31);
            this.FileBtn.TabIndex = 0;
            this.FileBtn.Text = "Select File";
            this.FileBtn.UseVisualStyleBackColor = true;
            this.FileBtn.Click += new System.EventHandler(this.FileBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 127);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(428, 29);
            this.progressBar1.TabIndex = 1;
            // 
            // FileTxt
            // 
            this.FileTxt.Location = new System.Drawing.Point(12, 31);
            this.FileTxt.Name = "FileTxt";
            this.FileTxt.Size = new System.Drawing.Size(428, 27);
            this.FileTxt.TabIndex = 2;
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(12, 76);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(103, 31);
            this.EncryptBtn.TabIndex = 3;
            this.EncryptBtn.Text = "Ecrypt";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // DeCryptBtn
            // 
            this.DeCryptBtn.Location = new System.Drawing.Point(121, 76);
            this.DeCryptBtn.Name = "DeCryptBtn";
            this.DeCryptBtn.Size = new System.Drawing.Size(103, 31);
            this.DeCryptBtn.TabIndex = 4;
            this.DeCryptBtn.Text = "Decrypt";
            this.DeCryptBtn.UseVisualStyleBackColor = true;
            this.DeCryptBtn.Click += new System.EventHandler(this.DeCryptBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(337, 76);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(103, 31);
            this.StartBtn.TabIndex = 5;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(457, 76);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(103, 31);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 197);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.DeCryptBtn);
            this.Controls.Add(this.EncryptBtn);
            this.Controls.Add(this.FileTxt);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FileBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button FileBtn;
        private ProgressBar progressBar1;
        private TextBox FileTxt;
        private Button EncryptBtn;
        private Button DeCryptBtn;
        private Button StartBtn;
        private Button CancelBtn;
        private OpenFileDialog openFileDialog1;
    }
}