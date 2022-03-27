namespace ZaIn_L4_test2
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
            this.tbx_OriginalString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Encrypt_Step1 = new System.Windows.Forms.Button();
            this.tbx_OriginalBin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_PsetsShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_PblockBin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Pblock_Step2 = new System.Windows.Forms.Button();
            this.nUD_TheChosenPset = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbx_FinalEncrypt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Sblock_Step3 = new System.Windows.Forms.Button();
            this.nUD_TheChosenSset = new System.Windows.Forms.NumericUpDown();
            this.btn_SsetsShow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_EncryptString = new System.Windows.Forms.TextBox();
            this.tbx_EncryptBin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Decrypt_Step1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbx_PblockBin_DE = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Pblock_Step2_DE = new System.Windows.Forms.Button();
            this.nUD_TheChosenPset_DE = new System.Windows.Forms.NumericUpDown();
            this.btn_PsetsShow_DE = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbx_FinalDecrypt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Sblock_Step3_DE = new System.Windows.Forms.Button();
            this.nUD_TheChosenSset_DE = new System.Windows.Forms.NumericUpDown();
            this.btn_SsetsShow_DE = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TheChosenPset)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TheChosenSset)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TheChosenPset_DE)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TheChosenSset_DE)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_OriginalString
            // 
            this.tbx_OriginalString.Location = new System.Drawing.Point(10, 56);
            this.tbx_OriginalString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_OriginalString.Name = "tbx_OriginalString";
            this.tbx_OriginalString.Size = new System.Drawing.Size(335, 26);
            this.tbx_OriginalString.TabIndex = 0;
            this.tbx_OriginalString.Text = "ЖП";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Строка для шифрования";
            // 
            // btn_Encrypt_Step1
            // 
            this.btn_Encrypt_Step1.Location = new System.Drawing.Point(9, 90);
            this.btn_Encrypt_Step1.Name = "btn_Encrypt_Step1";
            this.btn_Encrypt_Step1.Size = new System.Drawing.Size(336, 30);
            this.btn_Encrypt_Step1.TabIndex = 2;
            this.btn_Encrypt_Step1.Text = "Перевести в двоичный код";
            this.btn_Encrypt_Step1.UseVisualStyleBackColor = true;
            this.btn_Encrypt_Step1.Click += new System.EventHandler(this.btn_Encrypt_Step1_Click);
            // 
            // tbx_OriginalBin
            // 
            this.tbx_OriginalBin.Location = new System.Drawing.Point(9, 157);
            this.tbx_OriginalBin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_OriginalBin.Name = "tbx_OriginalBin";
            this.tbx_OriginalBin.Size = new System.Drawing.Size(336, 26);
            this.tbx_OriginalBin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Строка для шифрования в двоичном коде";
            // 
            // btn_PsetsShow
            // 
            this.btn_PsetsShow.Location = new System.Drawing.Point(119, 53);
            this.btn_PsetsShow.Name = "btn_PsetsShow";
            this.btn_PsetsShow.Size = new System.Drawing.Size(232, 31);
            this.btn_PsetsShow.TabIndex = 5;
            this.btn_PsetsShow.Text = "Список перестановок";
            this.btn_PsetsShow.UseVisualStyleBackColor = true;
            this.btn_PsetsShow.Click += new System.EventHandler(this.btn_PsetsShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbx_OriginalString);
            this.groupBox1.Controls.Add(this.tbx_OriginalBin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Encrypt_Step1);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 207);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шаг 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbx_PblockBin);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_Pblock_Step2);
            this.groupBox2.Controls.Add(this.nUD_TheChosenPset);
            this.groupBox2.Controls.Add(this.btn_PsetsShow);
            this.groupBox2.Location = new System.Drawing.Point(375, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 207);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шаг2";
            // 
            // tbx_PblockBin
            // 
            this.tbx_PblockBin.Location = new System.Drawing.Point(10, 157);
            this.tbx_PblockBin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_PblockBin.Name = "tbx_PblockBin";
            this.tbx_PblockBin.Size = new System.Drawing.Size(336, 26);
            this.tbx_PblockBin.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "После перестановок P блока";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выбрать перестановку для P-блока";
            // 
            // btn_Pblock_Step2
            // 
            this.btn_Pblock_Step2.Location = new System.Drawing.Point(6, 90);
            this.btn_Pblock_Step2.Name = "btn_Pblock_Step2";
            this.btn_Pblock_Step2.Size = new System.Drawing.Size(345, 31);
            this.btn_Pblock_Step2.TabIndex = 11;
            this.btn_Pblock_Step2.Text = "Сделать перестановку P блоком";
            this.btn_Pblock_Step2.UseVisualStyleBackColor = true;
            this.btn_Pblock_Step2.Click += new System.EventHandler(this.btn_Pblock_Step2_Click);
            // 
            // nUD_TheChosenPset
            // 
            this.nUD_TheChosenPset.Location = new System.Drawing.Point(6, 56);
            this.nUD_TheChosenPset.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.nUD_TheChosenPset.Name = "nUD_TheChosenPset";
            this.nUD_TheChosenPset.Size = new System.Drawing.Size(107, 26);
            this.nUD_TheChosenPset.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbx_FinalEncrypt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_Sblock_Step3);
            this.groupBox3.Controls.Add(this.nUD_TheChosenSset);
            this.groupBox3.Controls.Add(this.btn_SsetsShow);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(738, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 207);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Шаг3";
            // 
            // tbx_FinalEncrypt
            // 
            this.tbx_FinalEncrypt.Location = new System.Drawing.Point(6, 157);
            this.tbx_FinalEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_FinalEncrypt.Name = "tbx_FinalEncrypt";
            this.tbx_FinalEncrypt.Size = new System.Drawing.Size(336, 26);
            this.tbx_FinalEncrypt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Зашифрованная строка";
            // 
            // btn_Sblock_Step3
            // 
            this.btn_Sblock_Step3.Location = new System.Drawing.Point(6, 91);
            this.btn_Sblock_Step3.Name = "btn_Sblock_Step3";
            this.btn_Sblock_Step3.Size = new System.Drawing.Size(345, 31);
            this.btn_Sblock_Step3.TabIndex = 12;
            this.btn_Sblock_Step3.Text = "Сделать перестановку S блоком";
            this.btn_Sblock_Step3.UseVisualStyleBackColor = true;
            this.btn_Sblock_Step3.Click += new System.EventHandler(this.btn_Sblock_Step3_Click);
            // 
            // nUD_TheChosenSset
            // 
            this.nUD_TheChosenSset.Location = new System.Drawing.Point(6, 57);
            this.nUD_TheChosenSset.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.nUD_TheChosenSset.Name = "nUD_TheChosenSset";
            this.nUD_TheChosenSset.Size = new System.Drawing.Size(107, 26);
            this.nUD_TheChosenSset.TabIndex = 12;
            // 
            // btn_SsetsShow
            // 
            this.btn_SsetsShow.Location = new System.Drawing.Point(119, 54);
            this.btn_SsetsShow.Name = "btn_SsetsShow";
            this.btn_SsetsShow.Size = new System.Drawing.Size(232, 31);
            this.btn_SsetsShow.TabIndex = 11;
            this.btn_SsetsShow.Text = "Список перестановок";
            this.btn_SsetsShow.UseVisualStyleBackColor = true;
            this.btn_SsetsShow.Click += new System.EventHandler(this.btn_SsetsShow_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Выбрать перестановку для S-блока";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(744, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(489, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "SP - сеть";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(16, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "Зашифровка";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbx_EncryptString);
            this.groupBox4.Controls.Add(this.tbx_EncryptBin);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btn_Decrypt_Step1);
            this.groupBox4.Location = new System.Drawing.Point(12, 322);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 207);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Шаг 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Строка для расшифрования";
            // 
            // tbx_EncryptString
            // 
            this.tbx_EncryptString.Location = new System.Drawing.Point(10, 56);
            this.tbx_EncryptString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_EncryptString.Name = "tbx_EncryptString";
            this.tbx_EncryptString.Size = new System.Drawing.Size(335, 26);
            this.tbx_EncryptString.TabIndex = 0;
            this.tbx_EncryptString.Text = "ЖП";
            // 
            // tbx_EncryptBin
            // 
            this.tbx_EncryptBin.Location = new System.Drawing.Point(9, 157);
            this.tbx_EncryptBin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_EncryptBin.Name = "tbx_EncryptBin";
            this.tbx_EncryptBin.Size = new System.Drawing.Size(336, 26);
            this.tbx_EncryptBin.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Двоичное представление";
            // 
            // btn_Decrypt_Step1
            // 
            this.btn_Decrypt_Step1.Location = new System.Drawing.Point(9, 90);
            this.btn_Decrypt_Step1.Name = "btn_Decrypt_Step1";
            this.btn_Decrypt_Step1.Size = new System.Drawing.Size(336, 30);
            this.btn_Decrypt_Step1.TabIndex = 2;
            this.btn_Decrypt_Step1.Text = "Перевести в двоичный код";
            this.btn_Decrypt_Step1.UseVisualStyleBackColor = true;
            this.btn_Decrypt_Step1.Click += new System.EventHandler(this.btn_Decrypt_Step1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(20, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 29);
            this.label12.TabIndex = 14;
            this.label12.Text = "Расшифровка";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbx_PblockBin_DE);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.btn_Pblock_Step2_DE);
            this.groupBox5.Controls.Add(this.nUD_TheChosenPset_DE);
            this.groupBox5.Controls.Add(this.btn_PsetsShow_DE);
            this.groupBox5.Location = new System.Drawing.Point(375, 322);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(357, 207);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Шаг2";
            // 
            // tbx_PblockBin_DE
            // 
            this.tbx_PblockBin_DE.Location = new System.Drawing.Point(10, 157);
            this.tbx_PblockBin_DE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_PblockBin_DE.Name = "tbx_PblockBin_DE";
            this.tbx_PblockBin_DE.Size = new System.Drawing.Size(336, 26);
            this.tbx_PblockBin_DE.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "После перестановок P блока";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(282, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Выбрать перестановку для P-блока";
            // 
            // btn_Pblock_Step2_DE
            // 
            this.btn_Pblock_Step2_DE.Location = new System.Drawing.Point(6, 90);
            this.btn_Pblock_Step2_DE.Name = "btn_Pblock_Step2_DE";
            this.btn_Pblock_Step2_DE.Size = new System.Drawing.Size(345, 31);
            this.btn_Pblock_Step2_DE.TabIndex = 11;
            this.btn_Pblock_Step2_DE.Text = "Сделать расшифровку P блоком";
            this.btn_Pblock_Step2_DE.UseVisualStyleBackColor = true;
            this.btn_Pblock_Step2_DE.Click += new System.EventHandler(this.btn_Pblock_Step2_DE_Click);
            // 
            // nUD_TheChosenPset_DE
            // 
            this.nUD_TheChosenPset_DE.Location = new System.Drawing.Point(6, 56);
            this.nUD_TheChosenPset_DE.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.nUD_TheChosenPset_DE.Name = "nUD_TheChosenPset_DE";
            this.nUD_TheChosenPset_DE.Size = new System.Drawing.Size(107, 26);
            this.nUD_TheChosenPset_DE.TabIndex = 10;
            // 
            // btn_PsetsShow_DE
            // 
            this.btn_PsetsShow_DE.Location = new System.Drawing.Point(119, 53);
            this.btn_PsetsShow_DE.Name = "btn_PsetsShow_DE";
            this.btn_PsetsShow_DE.Size = new System.Drawing.Size(232, 31);
            this.btn_PsetsShow_DE.TabIndex = 5;
            this.btn_PsetsShow_DE.Text = "Список перестановок";
            this.btn_PsetsShow_DE.UseVisualStyleBackColor = true;
            this.btn_PsetsShow_DE.Click += new System.EventHandler(this.btn_PsetsShow_DE_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbx_FinalDecrypt);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.btn_Sblock_Step3_DE);
            this.groupBox6.Controls.Add(this.nUD_TheChosenSset_DE);
            this.groupBox6.Controls.Add(this.btn_SsetsShow_DE);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Location = new System.Drawing.Point(738, 322);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(357, 207);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Шаг3";
            // 
            // tbx_FinalDecrypt
            // 
            this.tbx_FinalDecrypt.Location = new System.Drawing.Point(6, 157);
            this.tbx_FinalDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_FinalDecrypt.Name = "tbx_FinalDecrypt";
            this.tbx_FinalDecrypt.Size = new System.Drawing.Size(336, 26);
            this.tbx_FinalDecrypt.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "Зашифрованная строка";
            // 
            // btn_Sblock_Step3_DE
            // 
            this.btn_Sblock_Step3_DE.Location = new System.Drawing.Point(6, 91);
            this.btn_Sblock_Step3_DE.Name = "btn_Sblock_Step3_DE";
            this.btn_Sblock_Step3_DE.Size = new System.Drawing.Size(345, 31);
            this.btn_Sblock_Step3_DE.TabIndex = 12;
            this.btn_Sblock_Step3_DE.Text = "Сделать перестановку S блоком";
            this.btn_Sblock_Step3_DE.UseVisualStyleBackColor = true;
            this.btn_Sblock_Step3_DE.Click += new System.EventHandler(this.btn_Sblock_Step3_DE_Click);
            // 
            // nUD_TheChosenSset_DE
            // 
            this.nUD_TheChosenSset_DE.Location = new System.Drawing.Point(6, 57);
            this.nUD_TheChosenSset_DE.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.nUD_TheChosenSset_DE.Name = "nUD_TheChosenSset_DE";
            this.nUD_TheChosenSset_DE.Size = new System.Drawing.Size(107, 26);
            this.nUD_TheChosenSset_DE.TabIndex = 12;
            // 
            // btn_SsetsShow_DE
            // 
            this.btn_SsetsShow_DE.Location = new System.Drawing.Point(119, 54);
            this.btn_SsetsShow_DE.Name = "btn_SsetsShow_DE";
            this.btn_SsetsShow_DE.Size = new System.Drawing.Size(232, 31);
            this.btn_SsetsShow_DE.TabIndex = 11;
            this.btn_SsetsShow_DE.Text = "Список перестановок";
            this.btn_SsetsShow_DE.UseVisualStyleBackColor = true;
            this.btn_SsetsShow_DE.Click += new System.EventHandler(this.btn_SsetsShow_DE_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(283, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "Выбрать перестановку для S-блока";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(740, 532);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 20);
            this.label17.TabIndex = 17;
            this.label17.Text = "label17";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 577);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "SP-сеть";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TheChosenPset)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TheChosenSset)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TheChosenPset_DE)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TheChosenSset_DE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_OriginalString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Encrypt_Step1;
        private System.Windows.Forms.TextBox tbx_OriginalBin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_PsetsShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Pblock_Step2;
        private System.Windows.Forms.NumericUpDown nUD_TheChosenPset;
        private System.Windows.Forms.TextBox tbx_PblockBin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUD_TheChosenSset;
        private System.Windows.Forms.Button btn_SsetsShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_FinalEncrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Sblock_Step3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_EncryptString;
        private System.Windows.Forms.TextBox tbx_EncryptBin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Decrypt_Step1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbx_PblockBin_DE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Pblock_Step2_DE;
        private System.Windows.Forms.NumericUpDown nUD_TheChosenPset_DE;
        private System.Windows.Forms.Button btn_PsetsShow_DE;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbx_FinalDecrypt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_Sblock_Step3_DE;
        private System.Windows.Forms.NumericUpDown nUD_TheChosenSset_DE;
        private System.Windows.Forms.Button btn_SsetsShow_DE;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

