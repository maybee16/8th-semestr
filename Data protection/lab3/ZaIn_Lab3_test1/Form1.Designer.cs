namespace ZaIn_Lab3_test1
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
            this.comboBox_WORD_List = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_CreateMatrixWORD = new System.Windows.Forms.Button();
            this.textBox_WORD_matrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_HELP_matrix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ENCRYPT_matrix = new System.Windows.Forms.TextBox();
            this.label_HelpDET = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_HELP_matrix_INV = new System.Windows.Forms.TextBox();
            this.button_DECRYPT = new System.Windows.Forms.Button();
            this.textBox_DECRYPT_matrix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_DECRYPT_str = new System.Windows.Forms.Label();
            this.label_ENCRYPT_str = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_WORD_List
            // 
            this.comboBox_WORD_List.FormattingEnabled = true;
            this.comboBox_WORD_List.Items.AddRange(new object[] {
            "Анестезия",
            "Желудочек",
            "Недоспать",
            "Хранитель",
            "Цирюльник",
            "Шарманщик",
            "Щитовидка",
            "Эскалатор",
            "Ясновидец"});
            this.comboBox_WORD_List.Location = new System.Drawing.Point(13, 38);
            this.comboBox_WORD_List.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_WORD_List.Name = "comboBox_WORD_List";
            this.comboBox_WORD_List.Size = new System.Drawing.Size(173, 28);
            this.comboBox_WORD_List.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список слов из 9 букв";
            // 
            // button_CreateMatrixWORD
            // 
            this.button_CreateMatrixWORD.Location = new System.Drawing.Point(13, 73);
            this.button_CreateMatrixWORD.Name = "button_CreateMatrixWORD";
            this.button_CreateMatrixWORD.Size = new System.Drawing.Size(173, 30);
            this.button_CreateMatrixWORD.TabIndex = 2;
            this.button_CreateMatrixWORD.Text = "Зашифровать";
            this.button_CreateMatrixWORD.UseVisualStyleBackColor = true;
            this.button_CreateMatrixWORD.Click += new System.EventHandler(this.button_CreateMatrixWORD_Click);
            // 
            // textBox_WORD_matrix
            // 
            this.textBox_WORD_matrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_WORD_matrix.Location = new System.Drawing.Point(13, 109);
            this.textBox_WORD_matrix.Multiline = true;
            this.textBox_WORD_matrix.Name = "textBox_WORD_matrix";
            this.textBox_WORD_matrix.Size = new System.Drawing.Size(170, 60);
            this.textBox_WORD_matrix.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вспомогательная матрица";
            // 
            // textBox_HELP_matrix
            // 
            this.textBox_HELP_matrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_HELP_matrix.Location = new System.Drawing.Point(13, 209);
            this.textBox_HELP_matrix.Multiline = true;
            this.textBox_HELP_matrix.Name = "textBox_HELP_matrix";
            this.textBox_HELP_matrix.Size = new System.Drawing.Size(170, 60);
            this.textBox_HELP_matrix.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Зашифрованная матрица";
            // 
            // textBox_ENCRYPT_matrix
            // 
            this.textBox_ENCRYPT_matrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ENCRYPT_matrix.Location = new System.Drawing.Point(13, 309);
            this.textBox_ENCRYPT_matrix.Multiline = true;
            this.textBox_ENCRYPT_matrix.Name = "textBox_ENCRYPT_matrix";
            this.textBox_ENCRYPT_matrix.Size = new System.Drawing.Size(170, 60);
            this.textBox_ENCRYPT_matrix.TabIndex = 7;
            // 
            // label_HelpDET
            // 
            this.label_HelpDET.AutoSize = true;
            this.label_HelpDET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_HelpDET.Location = new System.Drawing.Point(315, 52);
            this.label_HelpDET.Name = "label_HelpDET";
            this.label_HelpDET.Size = new System.Drawing.Size(284, 25);
            this.label_HelpDET.TabIndex = 8;
            this.label_HelpDET.Text = "Определитель всп. матрицы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(315, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Обратная Всп. матрица";
            // 
            // textBox_HELP_matrix_INV
            // 
            this.textBox_HELP_matrix_INV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_HELP_matrix_INV.Location = new System.Drawing.Point(319, 109);
            this.textBox_HELP_matrix_INV.Multiline = true;
            this.textBox_HELP_matrix_INV.Name = "textBox_HELP_matrix_INV";
            this.textBox_HELP_matrix_INV.Size = new System.Drawing.Size(170, 60);
            this.textBox_HELP_matrix_INV.TabIndex = 10;
            // 
            // button_DECRYPT
            // 
            this.button_DECRYPT.Location = new System.Drawing.Point(319, 9);
            this.button_DECRYPT.Name = "button_DECRYPT";
            this.button_DECRYPT.Size = new System.Drawing.Size(170, 30);
            this.button_DECRYPT.TabIndex = 11;
            this.button_DECRYPT.Text = "Расшифровать";
            this.button_DECRYPT.UseVisualStyleBackColor = true;
            this.button_DECRYPT.Click += new System.EventHandler(this.button_DECRYPT_Click);
            // 
            // textBox_DECRYPT_matrix
            // 
            this.textBox_DECRYPT_matrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_DECRYPT_matrix.Location = new System.Drawing.Point(319, 209);
            this.textBox_DECRYPT_matrix.Multiline = true;
            this.textBox_DECRYPT_matrix.Name = "textBox_DECRYPT_matrix";
            this.textBox_DECRYPT_matrix.Size = new System.Drawing.Size(170, 60);
            this.textBox_DECRYPT_matrix.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(315, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Расшифрованная матрица";
            // 
            // label_DECRYPT_str
            // 
            this.label_DECRYPT_str.AutoSize = true;
            this.label_DECRYPT_str.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DECRYPT_str.Location = new System.Drawing.Point(314, 281);
            this.label_DECRYPT_str.Name = "label_DECRYPT_str";
            this.label_DECRYPT_str.Size = new System.Drawing.Size(235, 25);
            this.label_DECRYPT_str.TabIndex = 14;
            this.label_DECRYPT_str.Text = "Расшифрованное слово";
            // 
            // label_ENCRYPT_str
            // 
            this.label_ENCRYPT_str.AutoSize = true;
            this.label_ENCRYPT_str.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ENCRYPT_str.Location = new System.Drawing.Point(12, 381);
            this.label_ENCRYPT_str.Name = "label_ENCRYPT_str";
            this.label_ENCRYPT_str.Size = new System.Drawing.Size(226, 25);
            this.label_ENCRYPT_str.TabIndex = 15;
            this.label_ENCRYPT_str.Text = "Зашифрованное слово";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 439);
            this.Controls.Add(this.label_ENCRYPT_str);
            this.Controls.Add(this.label_DECRYPT_str);
            this.Controls.Add(this.textBox_DECRYPT_matrix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_DECRYPT);
            this.Controls.Add(this.textBox_HELP_matrix_INV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_HelpDET);
            this.Controls.Add(this.textBox_ENCRYPT_matrix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_HELP_matrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_WORD_matrix);
            this.Controls.Add(this.button_CreateMatrixWORD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_WORD_List);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_WORD_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_CreateMatrixWORD;
        private System.Windows.Forms.TextBox textBox_WORD_matrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_HELP_matrix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ENCRYPT_matrix;
        private System.Windows.Forms.Label label_HelpDET;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_HELP_matrix_INV;
        private System.Windows.Forms.Button button_DECRYPT;
        private System.Windows.Forms.TextBox textBox_DECRYPT_matrix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_DECRYPT_str;
        private System.Windows.Forms.Label label_ENCRYPT_str;
    }
}

