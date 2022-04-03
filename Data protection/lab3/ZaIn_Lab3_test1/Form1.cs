using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaIn_Lab3_test1
{
    public partial class Form1 : Form
    {
        public string WORD_str; //слово для зашифровки
        public char[] ABC;      //алфавит

        public Matrix WORD_matrix;    // слово для зашифровки в виде матрицы
        public Matrix HELP_matrix;    // вспомогательная матрица
        public Matrix HELP_matrix_INV;// вспомогательная обратная по модулю матрица
        public Matrix ENCRYPT_matrix; // зашифрованное слово в виде матрицы
        public Matrix DECRYPT_matrix; // расшифрованное слово в виде матрицы

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ABC = new char[33]; //Алфавит из 33 букв

            ABC[0] = 'А';
            ABC[1] = 'Б';
            ABC[2] = 'В';
            ABC[3] = 'Г';
            ABC[4] = 'Д';

            ABC[5] = 'Е';
            ABC[6] = 'Ё';
            ABC[7] = 'Ж';
            ABC[8] = 'З';
            ABC[9] = 'И';

            ABC[10] = 'Й';

            ABC[11] = 'К';
            ABC[12] = 'Л';
            ABC[13] = 'М';
            ABC[14] = 'Н';

            ABC[15] = 'О';
            ABC[16] = 'П';
            ABC[17] = 'Р';
            ABC[18] = 'С';
            ABC[19] = 'Т';

            ABC[20] = 'У';
            ABC[21] = 'Ф';
            ABC[22] = 'Х';
            ABC[23] = 'Ц';
            ABC[24] = 'Ч';

            ABC[25] = 'Ш';
            ABC[26] = 'Щ';

            ABC[27] = 'Ъ';

            ABC[28] = 'Ы';

            ABC[29] = 'Ь';

            ABC[30] = 'Э';
            ABC[31] = 'Ю';
            ABC[32] = 'Я';

            comboBox_WORD_List.Text = comboBox_WORD_List.Items[0].ToString();
            //comboBox_WORD_List.Text = "ТЕЛЕВИЗОР";
        }

        //Найти букву в алфавите и вернуть индекс
        public int FindCharInABC(char C)
        {
            for(int i = 0; i < ABC.Length; i++)
            {
                if(C == ABC[i])
                {
                    return i;
                }
            }
            return 0;
        }

        //Зашифровка слова
        private void button_CreateMatrixWORD_Click(object sender, EventArgs e)
        {
            WORD_str = comboBox_WORD_List.Text.ToUpper();
            WORD_matrix = new Matrix(3, 3);
            int n = 0;
            int char_position = 0;

            //Превратить слово из букв в матрицу из чисел
            for(int i = 0; i < WORD_matrix.Row; i++)
            {
                for(int j = 0; j < WORD_matrix.Column; j++)
                {
                    char_position = FindCharInABC(WORD_str[n]);
                    WORD_matrix.array[i, j] = char_position;
                    n++;
                }
            }

            textBox_WORD_matrix.Text = WORD_matrix.ToString();

            //Создать вспомогательную матрицу с модулем 33
            HELP_matrix = GenerateMatrix(3, 33);
            //Вывести матрицу в текстбокс
            textBox_HELP_matrix.Text = HELP_matrix.ToString();

            decimal[] tmpEncryptedArr = new decimal[9];            
            n = 0;
            int n2 = 0;

            //ЗАШИФРОВКА
            //первые 3 буквы
            for (int i = 0; i < HELP_matrix.Row; i++)
            {
                for (int j = 0; j < HELP_matrix.Column; j++)
                {
                    tmpEncryptedArr[n] += WORD_matrix.array[n2, j] * HELP_matrix.array[i, j];
                }
                tmpEncryptedArr[n] = tmpEncryptedArr[n] % 33;
                n++;
            }
            //вторые 3 буквы
            n2++;
            for (int i = 0; i < HELP_matrix.Row; i++)
            {
                for (int j = 0; j < HELP_matrix.Column; j++)
                {
                    tmpEncryptedArr[n] += WORD_matrix.array[n2, j] * HELP_matrix.array[i, j];
                }
                tmpEncryptedArr[n] = tmpEncryptedArr[n] % 33;
                n++;
            }
            //последние 3 буквы
            n2++;
            for (int i = 0; i < HELP_matrix.Row; i++)
            {
                for (int j = 0; j < HELP_matrix.Column; j++)
                {
                    tmpEncryptedArr[n] += WORD_matrix.array[n2, j] * HELP_matrix.array[i, j];
                }
                tmpEncryptedArr[n] = tmpEncryptedArr[n] % 33;
                n++;
            }

            n = 0;
            ENCRYPT_matrix = new Matrix(3, 3);
            for (int i = 0; i < ENCRYPT_matrix.Row; i++)
            {
                for(int j = 0; j < ENCRYPT_matrix.Column; j++)
                {
                    ENCRYPT_matrix.array[i, j] = tmpEncryptedArr[n];
                    n++;
                }
            }
            //Вывести зашифрованную матрицу в текстбокс
            textBox_ENCRYPT_matrix.Text = ENCRYPT_matrix.ToString();

            //Превратить матрицу из чисел в слово из букв
            string ENCRYPT_str = "";
            for (int i = 0; i < ENCRYPT_matrix.Row; i++)
            {
                for (int j = 0; j < ENCRYPT_matrix.Column; j++)
                {
                    ENCRYPT_str += ABC[Convert.ToInt32(ENCRYPT_matrix.array[i, j])].ToString();
                }
            }

            label_ENCRYPT_str.Text = "Зашифрованное слово: " + ENCRYPT_str;
        }

        //Расшифровка слова
        private void button_DECRYPT_Click(object sender, EventArgs e)
        {
            //Вычисление определителя матрицы
            label_HelpDET.Text = "Определитель всп. матрицы: " + HELP_matrix.Determinant().ToString();
            //Создать обратную матрицу по модулю 33
            HELP_matrix_INV = InverseMatrix(HELP_matrix, 33);
            //Вывести матрицу в текстбокс
            textBox_HELP_matrix_INV.Text = HELP_matrix_INV.ToString();

            decimal[] tmpDecryptedArr = new decimal[9];
            int n = 0;
            int n2 = 0;

            //РАСШИФРОВКА
            //первые 3 буквы
            for (int i = 0; i < HELP_matrix_INV.Row; i++)
            {
                for (int j = 0; j < HELP_matrix_INV.Column; j++)
                {
                    tmpDecryptedArr[n] += ENCRYPT_matrix.array[n2, j] * HELP_matrix.array[i, j];
                }
                tmpDecryptedArr[n] = tmpDecryptedArr[n] % 33;
                n++;
            }
            //вторые 3 буквы
            n2++;
            for (int i = 0; i < HELP_matrix_INV.Row; i++)
            {
                for (int j = 0; j < HELP_matrix_INV.Column; j++)
                {
                    tmpDecryptedArr[n] += ENCRYPT_matrix.array[n2, j] * HELP_matrix.array[i, j];
                }
                tmpDecryptedArr[n] = tmpDecryptedArr[n] % 33;
                n++;
            }
            //последние 3 буквы
            n2++;
            for (int i = 0; i < HELP_matrix_INV.Row; i++)
            {
                for (int j = 0; j < HELP_matrix_INV.Column; j++)
                {
                    tmpDecryptedArr[n] += ENCRYPT_matrix.array[n2, j] * HELP_matrix.array[i, j];
                }
                tmpDecryptedArr[n] = tmpDecryptedArr[n] % 33;
                n++;
            }

            n = 0;
            DECRYPT_matrix = new Matrix(3, 3);
            for (int i = 0; i < DECRYPT_matrix.Row; i++)
            {
                for (int j = 0; j < DECRYPT_matrix.Column; j++)
                {
                    DECRYPT_matrix.array[i, j] = tmpDecryptedArr[n];
                    n++;
                }
            }
            //Вывести расшифрованную матрицу в текстбокс
            textBox_DECRYPT_matrix.Text = DECRYPT_matrix.ToString();

            //Превратить матрицу из чисел в слово из букв
            string DECRYPT_str = "";
            for(int i = 0; i < DECRYPT_matrix.Row; i++)
            {
                for(int j = 0; j < DECRYPT_matrix.Column; j++)
                {
                    DECRYPT_str += ABC[Convert.ToInt32(DECRYPT_matrix.array[i, j])].ToString();
                }
            }

            label_DECRYPT_str.Text = "Расшифрованное слово: " + DECRYPT_str;
        }















        Matrix GenerateMatrix(int m, int N)
        {
            Matrix matrix = new Matrix(m, m);
            matrix.array[0, 0] = 6; matrix.array[0, 1] = 27; matrix.array[0, 2] = 1;
            matrix.array[1, 0] = 13; matrix.array[1, 1] = 16; matrix.array[1, 2] = 32;
            matrix.array[2, 0] = 28; matrix.array[2, 1] = 17; matrix.array[2, 2] = 15;

            return matrix;
        }


        Matrix InverseMatrix(Matrix A, int N)
        {
            A.array[0, 0] = 2; A.array[0, 1] = 26; A.array[0, 2] = 17;
            A.array[1, 0] = 26; A.array[1, 1] = 20; A.array[1, 2] = 4;
            A.array[2, 0] = 13; A.array[2, 1] = 30; A.array[2, 2] = 21;

            return A;
        }
    }
}
