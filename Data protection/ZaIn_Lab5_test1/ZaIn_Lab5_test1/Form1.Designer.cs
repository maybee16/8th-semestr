namespace ZaIn_Lab5_test1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_MESSAGE = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBox_ENCRYPT = new System.Windows.Forms.TextBox();
            this.button_Decrypt = new System.Windows.Forms.Button();
            this.textBox_Decrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_MESSAGE
            // 
            this.textBox_MESSAGE.Location = new System.Drawing.Point(15, 77);
            this.textBox_MESSAGE.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MESSAGE.Name = "textBox_MESSAGE";
            this.textBox_MESSAGE.Size = new System.Drawing.Size(500, 22);
            this.textBox_MESSAGE.TabIndex = 0;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(15, 106);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(500, 23);
            this.buttonEncrypt.TabIndex = 1;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // textBox_ENCRYPT
            // 
            this.textBox_ENCRYPT.Location = new System.Drawing.Point(15, 188);
            this.textBox_ENCRYPT.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ENCRYPT.Name = "textBox_ENCRYPT";
            this.textBox_ENCRYPT.Size = new System.Drawing.Size(500, 22);
            this.textBox_ENCRYPT.TabIndex = 2;
            // 
            // button_Decrypt
            // 
            this.button_Decrypt.Location = new System.Drawing.Point(15, 217);
            this.button_Decrypt.Name = "button_Decrypt";
            this.button_Decrypt.Size = new System.Drawing.Size(500, 23);
            this.button_Decrypt.TabIndex = 3;
            this.button_Decrypt.Text = "Расшифровать";
            this.button_Decrypt.UseVisualStyleBackColor = true;
            this.button_Decrypt.Click += new System.EventHandler(this.button_Decrypt_Click);
            // 
            // textBox_Decrypt
            // 
            this.textBox_Decrypt.Location = new System.Drawing.Point(15, 297);
            this.textBox_Decrypt.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Decrypt.Name = "textBox_Decrypt";
            this.textBox_Decrypt.Size = new System.Drawing.Size(500, 22);
            this.textBox_Decrypt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сообщение для зашифровки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Зашифрованное сообщение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Расшифрованное сообщение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(161, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ПОТОКОВЫЙ ШИФР";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 350);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Decrypt);
            this.Controls.Add(this.button_Decrypt);
            this.Controls.Add(this.textBox_ENCRYPT);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBox_MESSAGE);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_MESSAGE;
        private System.Windows.Forms.Button buttonEncrypt;
		private System.Windows.Forms.TextBox textBox_ENCRYPT;
		private System.Windows.Forms.Button button_Decrypt;
		private System.Windows.Forms.TextBox textBox_Decrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

