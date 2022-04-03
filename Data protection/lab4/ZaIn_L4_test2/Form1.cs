using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaIn_L4_test2
{
    public partial class Form1 : Form
    {
        string FilePath_32 = System.IO.Directory.GetCurrentDirectory() + "\\Sets32.txt";
        string FilePath_16 = System.IO.Directory.GetCurrentDirectory() + "\\Sets16.txt";

        string FirstLetter, SecondLetter, OriginalBin_str, EncryptedBin_str, EncryptedBin_De_str, DecryptedBin_str;
        string FirstLetter_Encrypted, SecondLetter_Encrypted;
        string FirstLetter_Decrypted, SecondLetter_Decrypted;
        string Word;

        string DecTemp;

        int[] FSall_set = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
        int[] FSall_set_temp = new int[32];

        int[] TheChosenOne = new int[32];
        int[] OriginalBin_intArr = new int[32];
        int[] EncryptedBin_intArr = new int[32]; int[] EncryptedBin_intArr_final = new int[32];


        int[] Dec_set = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        int[] Dec_set_temp = new int[16];


        List<int[]> TheChosensSets_int_32 = new List<int[]>();
        int indexOfChosen_32 = 0;
        List<int[]> TheChosensSets_int_16 = new List<int[]>();
        int indexOfChosen_16 = 0;


        int[] DecryptedBin_intArr = new int[32]; int[] DecryptedBin_intArr_final = new int[32];
        string FirstLetter_Encrypted_de, SecondLetter_Encrypted_de;
        string Word_Encrypted;

        public Form1()
        {
            InitializeComponent();

            Array.Copy(FSall_set, FSall_set_temp, FSall_set.Length);
            Array.Copy(Dec_set, Dec_set_temp, Dec_set.Length);

            for (int i = 0; i < 20; i++)
            {
                TheChosensSets_int_32.Add(new int[32]);
                TheChosensSets_int_16.Add(new int[16]);
            }
        }

        //Первый шаг
        private void btn_Encrypt_Step1_Click(object sender, EventArgs e)
        {
            Word = tbx_OriginalString.Text;

            FirstLetter = Convert.ToString(Word[0], 2);
            FirstLetter = CompleteZeroes(FirstLetter, 16);

            SecondLetter = Convert.ToString(Word[1], 2);
            SecondLetter = CompleteZeroes(SecondLetter, 16);

            OriginalBin_str = FirstLetter + SecondLetter;
            tbx_OriginalBin.Text = FirstLetter + "   " + SecondLetter;

            GenerateSets();
        }

        //Второй шаг
        private void btn_Pblock_Step2_Click(object sender, EventArgs e)
        {
            indexOfChosen_32 = int.Parse(nUD_TheChosenPset.Value.ToString());
            Array.Copy(TheChosensSets_int_32[indexOfChosen_32], TheChosenOne, TheChosensSets_int_32[indexOfChosen_32].Length);

            for (int i = 0; i < OriginalBin_str.Length; i++)
            {
                OriginalBin_intArr[i] = int.Parse(OriginalBin_str[i].ToString());
            }         
            for (int i = 0; i < EncryptedBin_intArr.Length; i++)
            {
                int tmp = OriginalBin_intArr[TheChosenOne[i]];
                EncryptedBin_intArr[i] = tmp;
            }

            EncryptedBin_str = IntArrToString(EncryptedBin_intArr);
            tbx_PblockBin.Text = EncryptedBin_str;
        }

        //Третий шаг
        private void btn_Sblock_Step3_Click(object sender, EventArgs e)
        {
            EncryptedBin_str = tbx_PblockBin.Text;

            //выбрать перестановку чисел от 0 до 15
            indexOfChosen_16 = int.Parse(nUD_TheChosenSset.Value.ToString());

            //разбить 32 битную зашифрованную строку по 4 бита
            //8 чисел
            List<string> FourBitBin = new List<string>();
            string fbstr = "";
            for (int i = 0; i < EncryptedBin_str.Length; i++)
            {
                fbstr += EncryptedBin_str[i].ToString();
                if (i == 3 || i == 7 || i == 11 || i == 15 || i == 19 || i == 23 || i == 27 || i == 31)
                {
                    FourBitBin.Add(fbstr);
                    fbstr = "";
                }
            }

            //перевести 8 двоичных чисел в десятичные
            List<string> FourBitDec = new List<string>();
            for (int i = 0; i < FourBitBin.Count; i++)
            {
                FourBitDec.Add(BinToDec(FourBitBin[i]));
            }

            //используюя перестановку меняем числа
            for (int i = 0; i < FourBitDec.Count; i++)
            {
                int tmp = int.Parse(FourBitDec[i]);

                for (int j = 0; j < 16; j++)
                {
                    if (tmp == j)
                    {
                        tmp = TheChosensSets_int_16[indexOfChosen_16][j];
                        break;
                    }
                }
                FourBitDec[i] = tmp.ToString();
            }

            //переводим новые десятичные числа обратно в двоичные и соединяем в 32 бит последовательность
            EncryptedBin_str = "";
            for (int i = 0; i < FourBitBin.Count; i++)
            {
                FourBitBin[i] = CompleteZeroes(DecToBin(FourBitDec[i]), 4);
                EncryptedBin_str += FourBitBin[i];
            }

            //использовать ещё один p блок
            for (int i = 0; i < EncryptedBin_str.Length; i++)
            {
                EncryptedBin_intArr[i] = int.Parse(EncryptedBin_str[i].ToString());
            }
            for (int i = 0; i < EncryptedBin_intArr.Length; i++)
            {
                int tmp = EncryptedBin_intArr[TheChosenOne[i]];
                EncryptedBin_intArr_final[i] = tmp;
            }

            EncryptedBin_str = IntArrToString(EncryptedBin_intArr_final);


            //раскодировать 01 в символы и вывести результаты
            FirstLetter_Encrypted = "";
            byte[] FirstLetter_Encrypted_bin = new byte[16];
            for (int i = 0; i < 16; i++)
            {
                FirstLetter_Encrypted += EncryptedBin_str[i].ToString();
                FirstLetter_Encrypted_bin[i] = byte.Parse(EncryptedBin_str[i].ToString());
            }

            SecondLetter_Encrypted = "";
            byte[] SecondLetter_Encrypted_bin = new byte[16];
            for (int i = 16; i < 32; i++)
            {
                SecondLetter_Encrypted += EncryptedBin_str[i].ToString();
                SecondLetter_Encrypted_bin[i - 16] = byte.Parse(EncryptedBin_str[i].ToString());
            }

            char result = (char)Convert.ToInt32(FirstLetter_Encrypted, 2);
            tbx_FinalEncrypt.Text = result.ToString();

            result = (char)Convert.ToInt32(SecondLetter_Encrypted, 2);
            tbx_FinalEncrypt.Text += result.ToString();

            label7.Text = EncryptedBin_str;

            tbx_EncryptString.Text = tbx_FinalEncrypt.Text;
        }


        private void btn_Decrypt_Step1_Click(object sender, EventArgs e)
        {
            Word_Encrypted = tbx_EncryptString.Text;

            FirstLetter_Encrypted_de = Convert.ToString(Word_Encrypted[0], 2);
            FirstLetter_Encrypted_de = CompleteZeroes(FirstLetter_Encrypted_de, 16);

            SecondLetter_Encrypted_de = Convert.ToString(Word_Encrypted[1], 2);
            SecondLetter_Encrypted_de = CompleteZeroes(SecondLetter_Encrypted_de, 16);

            EncryptedBin_De_str = FirstLetter_Encrypted_de + SecondLetter_Encrypted_de;
            tbx_EncryptBin.Text = FirstLetter_Encrypted_de + "   " + SecondLetter_Encrypted_de;
        }

        private void btn_Pblock_Step2_DE_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < EncryptedBin_De_str.Length; i++)
            {
                EncryptedBin_intArr[i] = int.Parse(EncryptedBin_De_str[i].ToString());
            }
            
            for (int i = 0; i < DecryptedBin_intArr.Length; i++)
            {
                int tmp = EncryptedBin_intArr[i];
                DecryptedBin_intArr[TheChosenOne[i]] = tmp;
            }

            DecryptedBin_str = IntArrToString(DecryptedBin_intArr);
            tbx_PblockBin_DE.Text = DecryptedBin_str;

        }

        private void btn_Sblock_Step3_DE_Click(object sender, EventArgs e)
        {
            DecryptedBin_str = tbx_PblockBin_DE.Text;

            //разбить 32 битную зашифрованную строку по 4 бита
            //8 чисел
            List<string> FourBitBin = new List<string>();
            string fbstr = "";
            for (int i = 0; i < DecryptedBin_str.Length; i++)
            {
                fbstr += DecryptedBin_str[i].ToString();
                if (i == 3 || i == 7 || i == 11 || i == 15 || i == 19 || i == 23 || i == 27 || i == 31)
                {
                    FourBitBin.Add(fbstr);
                    fbstr = "";
                }
            }

            //перевести 8 двоичных чисел в десятичные
            List<string> FourBitDec = new List<string>();
            for (int i = 0; i < FourBitBin.Count; i++)
            {
                FourBitDec.Add(BinToDec(FourBitBin[i]));
            }

            //используюя перестановку меняем числа
            for(int i = 0; i < FourBitDec.Count; i++)
            {
                int tmp = int.Parse(FourBitDec[i]);

                for(int j = 0; j < TheChosensSets_int_16[indexOfChosen_16].Length; j++)
                {
                    if(tmp == TheChosensSets_int_16[indexOfChosen_16][j])
                    {
                        tmp = j;
                        break;
                    }
                }
                FourBitDec[i] = tmp.ToString();
            }

            //переводим новые десятичные числа обратно в двоичные и соединяем в 32 бит последовательность
            DecryptedBin_str = "";
            for (int i = 0; i < FourBitBin.Count; i++)
            {
                FourBitBin[i] = CompleteZeroes(DecToBin(FourBitDec[i]), 4);
                DecryptedBin_str += FourBitBin[i];
            }

            //использовать ещё один p блок
            for (int i = 0; i < DecryptedBin_str.Length; i++)
            {
                DecryptedBin_intArr[i] = int.Parse(DecryptedBin_str[i].ToString());
            }
            for (int i = 0; i < DecryptedBin_intArr.Length; i++)
            {
                int tmp = DecryptedBin_intArr[i];
                DecryptedBin_intArr_final[TheChosenOne[i]] = tmp;
            }

            DecryptedBin_str = IntArrToString(DecryptedBin_intArr_final);


            //раскодировать 01 в символы и вывести результаты
            FirstLetter_Decrypted = "";
            byte[] FirstLetter_Decrypted_bin = new byte[16];
            for (int i = 0; i < 16; i++)
            {
                FirstLetter_Decrypted += DecryptedBin_str[i].ToString();
                FirstLetter_Decrypted_bin[i] = byte.Parse(DecryptedBin_str[i].ToString());
            }

            SecondLetter_Decrypted = "";
            byte[] SecondLetter_Decrypted_bin = new byte[16];
            for (int i = 16; i < 32; i++)
            {
                SecondLetter_Decrypted += DecryptedBin_str[i].ToString();
                SecondLetter_Decrypted_bin[i - 16] = byte.Parse(DecryptedBin_str[i].ToString());
            }

            char result = (char)Convert.ToInt32(FirstLetter_Decrypted, 2);
            tbx_FinalDecrypt.Text = result.ToString();

            result = (char)Convert.ToInt32(SecondLetter_Decrypted, 2);
            tbx_FinalDecrypt.Text += result.ToString();

            label17.Text = DecryptedBin_str;

            //for (int i = 0; i < FourBitDec.Count; i++)
            //{
            //    int tmp = int.Parse(FourBitDec[i]);

            //    for (int j = 0; j < TheChosensSets_int_16[indexOfChosen_16].Length; j++)
            //    {
            //        if (tmp == j)
            //        {
            //            tmp = TheChosensSets_int_16[indexOfChosen_16][j];
            //            break;
            //        }
            //    }
            //    FourBitDec[i] = tmp.ToString();
            //}



            //for(int j = 0; j < 16; j++)
            //{
            //    int tmp = TheChosensSets_int_16[indexOfChosen_16][j];

            //    for(int i = 0; i < FourBitBin.Count; i++)
            //    {
            //        if(tmp == int.Parse(FourBitDec[i]))
            //        {
            //           tmp = TheChosensSets_int_16[indexOfChosen_16][i];
            //           FourBitDec[i] = tmp.ToString();                       
            //        }
            //    }                
            //}



            //List<string> FourBitDec = new List<string>();
            //for (int i = 0; i < FourBitBin.Count; i++)
            //{
            //    FourBitDec.Add(BinToDec(FourBitBin[i]));
            //}

            ////используюя перестановку меняем числа
            //for (int i = 0; i < FourBitDec.Count; i++)
            //{
            //    int tmp = int.Parse(FourBitDec[i]);

            //    for (int j = 0; j < 16; j++)
            //    {
            //        if (tmp == j)
            //        {
            //            tmp = TheChosensSets_int_16[indexOfChosen_16][j];
            //            break;
            //        }
            //    }
            //    FourBitDec[i] = tmp.ToString();
            //}

            //переводим новые десятичные числа обратно в двоичные и соединяем в 32 бит последовательность
            //DecryptedBin_str = "";
            //for (int i = 0; i < FourBitBin.Count; i++)
            //{
            //    FourBitBin[i] = CompleteZeroes(DecToBin(FourBitDec[i]), 4);
            //    DecryptedBin_str += FourBitBin[i];
            //}

            ////использовать ещё один p блок
            //for (int i = 0; i < DecryptedBin_str.Length; i++)
            //{
            //    DecryptedBin_intArr[i] = int.Parse(DecryptedBin_str[i].ToString());
            //}
            //for (int i = 0; i < DecryptedBin_intArr.Length; i++)
            //{
            //    int tmp = DecryptedBin_intArr[i];
            //    DecryptedBin_intArr_final[TheChosenOne[i]] = tmp;
            //}

            //DecryptedBin_str = IntArrToString(DecryptedBin_intArr_final);


            //раскодировать 01 в символы и вывести результаты
            //FirstLetter_Decrypted = "";
            //byte[] FirstLetter_Decrypted_bin = new byte[16];
            //for (int i = 0; i < 16; i++)
            //{
            //    FirstLetter_Decrypted += DecryptedBin_str[i].ToString();
            //    FirstLetter_Decrypted_bin[i] = byte.Parse(DecryptedBin_str[i].ToString());
            //}

            //SecondLetter_Decrypted = "";
            //byte[] SecondLetter_Decrypted_bin = new byte[16];
            //for (int i = 16; i < 32; i++)
            //{
            //    SecondLetter_Decrypted += DecryptedBin_str[i].ToString();
            //    SecondLetter_Decrypted_bin[i - 16] = byte.Parse(DecryptedBin_str[i].ToString());
            //}

            //char result = (char)Convert.ToInt32(FirstLetter_Decrypted, 2);
            //tbx_FinalDecrypt.Text = result.ToString();

            //result = (char)Convert.ToInt32(SecondLetter_Decrypted, 2);
            //tbx_FinalDecrypt.Text += result.ToString();

            //label17.Text = DecryptedBin_str;
        }

        private void btn_PsetsShow_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(FilePath_32);
        }

        private void btn_PsetsShow_DE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(FilePath_32);
        }

        private void btn_SsetsShow_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(FilePath_16);
        }

        private void btn_SsetsShow_DE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(FilePath_16);
        }




        // перевести Int массив в строку
        public string IntArrToString(int[] IntArr)
        {
            string result = "";
            for (int i = 0; i < IntArr.Length; i++)
            {
                result += IntArr[i];
            }
            return result;
        }

        //генерация последовательностей и запись их в файлы
        public void GenerateSets()
        {
            //последовательности из 32 чисел
            for (int i = 0; i < 20; i++)
            {
                Shuffle(FSall_set_temp);

                for (int j = 0; j < FSall_set_temp.Length; j++)
                {
                    TheChosensSets_int_32[i][j] = FSall_set_temp[j];
                }

                Array.Copy(FSall_set, FSall_set_temp, FSall_set.Length);
            }
            if (File.Exists(FilePath_32))
            {
                File.Delete(FilePath_32);
            }
            int Nset = 1;
            foreach (int[] set in TheChosensSets_int_32)
            {
                string setSTR = "";
                for (int i = 0; i < set.Length; i++)
                {
                    setSTR += set[i].ToString();
                    setSTR += ", ";
                }
                using (StreamWriter sw = new StreamWriter(FilePath_32, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(Nset + ": " + setSTR);
                }
                Nset++;
            }


            //последовательности из 16 чисел
            for (int i = 0; i < 20; i++)
            {
                Shuffle(Dec_set_temp);

                for (int j = 0; j < Dec_set_temp.Length; j++)
                {
                    TheChosensSets_int_16[i][j] = Dec_set_temp[j];
                }

                Array.Copy(Dec_set, Dec_set_temp, Dec_set.Length);
            }
            if (File.Exists(FilePath_16))
            {
                File.Delete(FilePath_16);
            }
            Nset = 1;
            foreach (int[] set in TheChosensSets_int_16)
            {
                string setSTR = "";
                for (int i = 0; i < set.Length; i++)
                {
                    setSTR += set[i].ToString();
                    setSTR += ", ";
                }
                using (StreamWriter sw = new StreamWriter(FilePath_16, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(Nset + ": " + setSTR);
                }
                Nset++;
            }
        }

        //Перевести двоичную строку в десятичную
        public string BinToDec(string bin)
        {
            return Convert.ToInt32(bin, 2).ToString();
        }

        //Перевести десятичную строку в двоичную
        public string DecToBin(string bin)
        {
            return Convert.ToString(Int32.Parse(bin), 2);
        }

        //дополнить двоичное число нулями, в соответствии с разрядом
        string CompleteZeroes(string bin, int R)
        {
            if (bin.Length != R)
            {
                int dif = R - bin.Length;
                string difZeroes = "";

                for (int i = 0; i < dif; i++)
                {
                    difZeroes += "0";
                }

                return difZeroes + bin;
            }
            else
                return bin;
        }

        //случайно перемешать список из чисел
        public static Random rng = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        public static void Shuffle(int[] list)
        {
            int n = list.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
