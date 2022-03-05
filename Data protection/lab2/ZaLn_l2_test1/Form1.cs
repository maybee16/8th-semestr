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

namespace ZaLn_l2_test1
{
    public partial class Form1 : Form
    {
        string FilePath = System.IO.Directory.GetCurrentDirectory() + "\\Sets.txt";
        int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
        string[] ABC = new string[] { "А", "О", "И", "У", "Н", "Т", "К", "_" };
        string[] tempABC = new string[] { "x", "x", "x", "x", "x", "x", "x", "x" };
        List<string> AllSets = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }

            string SetToWrite = "";
            int Nset = 1;
            while (NextSet(ref a, a.Length))
            {
                SetToWrite = Nset + ": ";
                for (int i = 0; i < a.Length; i++)
                {
                    SetToWrite += ABC[a[i]] + " ";
                }
                using (StreamWriter sw = new StreamWriter(FilePath, true, System.Text.Encoding.Default))
                {                    
                    sw.WriteLine(SetToWrite);

                    SetToWrite = SetToWrite.Replace(Nset + ": ", "");
                    AllSets.Add(SetToWrite);

                    SetToWrite = "";
                    Nset++;                   
                }
                //PrintToFile(a);
            }            
        }

        private void Swap(ref int[] a, int i, int j)
        {
            int s = a[i];
            a[i] = a[j];
            a[j] = s;
        }

        private void PrintToFile(int[] a)
        {
            string SetToWrite = "";
            for (int i = 0; i < a.Length; i++)
            {
                SetToWrite += a[i] + " ";
            }
            using (StreamWriter sw = new StreamWriter(FilePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(SetToWrite);
            }           
        }
        
        private bool NextSet(ref int[] a, int n)
        {
            int j = n - 2;
            while (j != -1 && a[j] >= a[j + 1]) j--;
            if (j == -1)
                return false;

            int k = n - 1;
            while (a[j] >= a[k]) k--;
            Swap(ref a, j, k);

            int l = j + 1, r = n - 1; // сортируем оставшуюся часть последовательности
            while (l < r)
                Swap(ref a, l++, r--);
            return true;
        }



        private void button_Encrypt_Click(object sender, EventArgs e)
        {
            int N_set = int.Parse(TP1_nUD_NumberOfSet.Value.ToString());
            string StringToEncrypt = TP1_textBox_StringToEncrypt.Text;
            string EncryptedString = "";
            string ABC_set = AllSets[N_set-1];
            label11.Text = ABC_set;

            ABC_set = ABC_set.Replace(" ", "");

            for(int i = 0; i < tempABC.Length; i++)
            {
                tempABC[i] = ABC_set[i].ToString();
            }

            for(int i = 0; i < StringToEncrypt.Length; i++)
            {
                string OrigChar = StringToEncrypt[i].ToString();
                int OrigChar_InABC = Array.IndexOf(ABC, OrigChar);
                string EncryptedChar = tempABC[OrigChar_InABC];
                EncryptedString += EncryptedChar;
            }
            TP1_textBox_EncryptedString.Text = EncryptedString;
        }

        private void TP2_button_Decrypt_Click(object sender, EventArgs e)
        {
            int N_set = int.Parse(TP2_nUD_NumberOfSet.Value.ToString());
            string StringToDecrypt = TP2_textBox_StringToDecrypt.Text;
            string DecryptedString = "";
            string ABC_set = AllSets[N_set - 1];
            label12.Text = ABC_set;

            ABC_set = ABC_set.Replace(" ", "");

            for (int i = 0; i < tempABC.Length; i++)
            {
                tempABC[i] = ABC_set[i].ToString();
            }

            for (int i = 0; i < StringToDecrypt.Length; i++)
            {
                string EncryptedChar = StringToDecrypt[i].ToString();
                int EncryptedChar_InSetABC = Array.IndexOf(tempABC, EncryptedChar);
                string OrigChar = ABC[EncryptedChar_InSetABC];
                DecryptedString += OrigChar;
            }
            TP2_textBox_DecryptedString.Text = DecryptedString;
        }

        private void TP3_button_Decrypt_Click(object sender, EventArgs e)
        {            
            string StringToDecrypt = TP3_textBox_StringToDecrypt.Text;
            string DecryptedString = "";
            string StrToTBX = "";
            int NumOfSet = 1;

            TP3_richTextBox_Variants.Text = "";

            foreach (string Set in AllSets)
            {
                string tempABC_set = Set;
                StrToTBX = NumOfSet + ": " + Set;
                NumOfSet++;

                tempABC_set = Set.Replace(" ", "");
                for (int i = 0; i < tempABC.Length; i++)
                {
                    tempABC[i] = tempABC_set[i].ToString();
                }

                for (int i = 0; i < StringToDecrypt.Length; i++)
                {
                    string EncryptedChar = StringToDecrypt[i].ToString();
                    int EncryptedChar_InSetABC = Array.IndexOf(tempABC, EncryptedChar);
                    string OrigChar = ABC[EncryptedChar_InSetABC];
                    DecryptedString += OrigChar;
                }
                TP3_richTextBox_Variants.Text += StrToTBX;
                TP3_richTextBox_Variants.Text += Environment.NewLine;
                TP3_richTextBox_Variants.Text += DecryptedString;
                TP3_richTextBox_Variants.Text += Environment.NewLine;
                TP3_richTextBox_Variants.Text += Environment.NewLine;
                DecryptedString = "";

                if (NumOfSet == 100) //чтобы не считал по несколько минут
                    break;           //100n = 1s.   1000n = 22s.     2500n = 2m 11s.     5039n = ?m ?s
            }

            //string ABC_set = AllSets[N_set - 1];
            //TP2_label_NewABC.Text = "Переставленый алфавит: " + ABC_set;
        }

        private void ShowFile(string Path)
        {
            System.Diagnostics.Process.Start(Path);
        }

        private void TP1_button_ShowFile_Click(object sender, EventArgs e)
        {
            ShowFile(FilePath);
        }

        private void TP2_button_ShowFile_Click(object sender, EventArgs e)
        {
            ShowFile(FilePath);
        }
    }
}
