namespace ZaIn_Lab6_test1
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
			this.button_STEP1 = new System.Windows.Forms.Button();
			this.label_p = new System.Windows.Forms.Label();
			this.label_q = new System.Windows.Forms.Label();
			this.label_n = new System.Windows.Forms.Label();
			this.label_Fn = new System.Windows.Forms.Label();
			this.label_e = new System.Windows.Forms.Label();
			this.label_d = new System.Windows.Forms.Label();
			this.label_PK_SK = new System.Windows.Forms.Label();
			this.button_STEP2_ENCRYPT = new System.Windows.Forms.Button();
			this.label_m = new System.Windows.Forms.Label();
			this.textBox_m = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_STEP1
			// 
			this.button_STEP1.Location = new System.Drawing.Point(16, 284);
			this.button_STEP1.Margin = new System.Windows.Forms.Padding(4);
			this.button_STEP1.Name = "button_STEP1";
			this.button_STEP1.Size = new System.Drawing.Size(197, 40);
			this.button_STEP1.TabIndex = 0;
			this.button_STEP1.Text = "ЭТАП 1";
			this.button_STEP1.UseVisualStyleBackColor = true;
			this.button_STEP1.Click += new System.EventHandler(this.button_STEP1_Click);
			// 
			// label_p
			// 
			this.label_p.AutoSize = true;
			this.label_p.Location = new System.Drawing.Point(12, 65);
			this.label_p.Name = "label_p";
			this.label_p.Size = new System.Drawing.Size(16, 16);
			this.label_p.TabIndex = 1;
			this.label_p.Text = "p";
			// 
			// label_q
			// 
			this.label_q.AutoSize = true;
			this.label_q.Location = new System.Drawing.Point(12, 93);
			this.label_q.Name = "label_q";
			this.label_q.Size = new System.Drawing.Size(16, 16);
			this.label_q.TabIndex = 2;
			this.label_q.Text = "q";
			// 
			// label_n
			// 
			this.label_n.AutoSize = true;
			this.label_n.Location = new System.Drawing.Point(12, 120);
			this.label_n.Name = "label_n";
			this.label_n.Size = new System.Drawing.Size(15, 16);
			this.label_n.TabIndex = 3;
			this.label_n.Text = "n";
			// 
			// label_Fn
			// 
			this.label_Fn.AutoSize = true;
			this.label_Fn.Location = new System.Drawing.Point(13, 160);
			this.label_Fn.Name = "label_Fn";
			this.label_Fn.Size = new System.Drawing.Size(23, 16);
			this.label_Fn.TabIndex = 4;
			this.label_Fn.Text = "Fn";
			// 
			// label_e
			// 
			this.label_e.AutoSize = true;
			this.label_e.Location = new System.Drawing.Point(13, 195);
			this.label_e.Name = "label_e";
			this.label_e.Size = new System.Drawing.Size(16, 16);
			this.label_e.TabIndex = 5;
			this.label_e.Text = "e";
			// 
			// label_d
			// 
			this.label_d.AutoSize = true;
			this.label_d.Location = new System.Drawing.Point(13, 223);
			this.label_d.Name = "label_d";
			this.label_d.Size = new System.Drawing.Size(16, 16);
			this.label_d.TabIndex = 6;
			this.label_d.Text = "d";
			// 
			// label_PK_SK
			// 
			this.label_PK_SK.AutoSize = true;
			this.label_PK_SK.Location = new System.Drawing.Point(13, 252);
			this.label_PK_SK.Name = "label_PK_SK";
			this.label_PK_SK.Size = new System.Drawing.Size(45, 16);
			this.label_PK_SK.TabIndex = 7;
			this.label_PK_SK.Text = "PK SK";
			// 
			// button_STEP2_ENCRYPT
			// 
			this.button_STEP2_ENCRYPT.Location = new System.Drawing.Point(242, 284);
			this.button_STEP2_ENCRYPT.Margin = new System.Windows.Forms.Padding(4);
			this.button_STEP2_ENCRYPT.Name = "button_STEP2_ENCRYPT";
			this.button_STEP2_ENCRYPT.Size = new System.Drawing.Size(197, 40);
			this.button_STEP2_ENCRYPT.TabIndex = 8;
			this.button_STEP2_ENCRYPT.Text = "ЭТАП 2";
			this.button_STEP2_ENCRYPT.UseVisualStyleBackColor = true;
			this.button_STEP2_ENCRYPT.Click += new System.EventHandler(this.button_STEP2_ENCRYPT_Click);
			// 
			// label_m
			// 
			this.label_m.AutoSize = true;
			this.label_m.Location = new System.Drawing.Point(239, 65);
			this.label_m.Name = "label_m";
			this.label_m.Size = new System.Drawing.Size(19, 16);
			this.label_m.TabIndex = 9;
			this.label_m.Text = "m";
			// 
			// textBox_m
			// 
			this.textBox_m.Location = new System.Drawing.Point(349, 65);
			this.textBox_m.Name = "textBox_m";
			this.textBox_m.Size = new System.Drawing.Size(90, 22);
			this.textBox_m.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(239, 132);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "Fn";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(239, 172);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 16);
			this.label2.TabIndex = 12;
			this.label2.Text = "Fn";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(925, 461);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_m);
			this.Controls.Add(this.label_m);
			this.Controls.Add(this.button_STEP2_ENCRYPT);
			this.Controls.Add(this.label_PK_SK);
			this.Controls.Add(this.label_d);
			this.Controls.Add(this.label_e);
			this.Controls.Add(this.label_Fn);
			this.Controls.Add(this.label_n);
			this.Controls.Add(this.label_q);
			this.Controls.Add(this.label_p);
			this.Controls.Add(this.button_STEP1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_STEP1;
        private System.Windows.Forms.Label label_p;
        private System.Windows.Forms.Label label_q;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.Label label_Fn;
        private System.Windows.Forms.Label label_e;
        private System.Windows.Forms.Label label_d;
		private System.Windows.Forms.Label label_PK_SK;
		private System.Windows.Forms.Button button_STEP2_ENCRYPT;
		private System.Windows.Forms.Label label_m;
		private System.Windows.Forms.TextBox textBox_m;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

