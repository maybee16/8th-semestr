using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaIn_Lab6_test1
{
    public partial class Form1 : Form
    {
        public long[] SimpleNumbers = new Int64[14];
        public long p, q, n;
        public long Fn, E, d;

        public long[] PK;
        public long[] SK;

        public long m;

        private void Form1_Load(object sender, EventArgs e)
        {
            SimpleNumbers[0] = 11;
            SimpleNumbers[1] = 13;
            SimpleNumbers[3] = 17;
            SimpleNumbers[4] = 19;
            SimpleNumbers[5] = 23;
            SimpleNumbers[6] = 29;
            SimpleNumbers[7] = 31;
            SimpleNumbers[8] = 37;
            SimpleNumbers[9] = 41;
            SimpleNumbers[10] = 43;
            SimpleNumbers[11] = 47;
            SimpleNumbers[12] = 53;
            SimpleNumbers[13] = 49;

            PK = new long[2];
            SK = new long[2];
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button_STEP1_Click(object sender, EventArgs e)
        {
            GenerateSimpleNumbers();

            p = 11;//13;
            q = 3;//11;

            label_p.Text = "p: " + p.ToString();
            label_q.Text = "q: " + q.ToString();

            n = p * q;
            label_n.Text = "n:" +  n.ToString();

            CalcFn();
            label_Fn.Text = "Fn:" + Fn.ToString();

            CalcE();
            //E = 23;
            label_e.Text = "e:" + E.ToString();            

            CalcD();
            label_d.Text = "d:" + d.ToString();

            PK[0] = E; PK[1] = n;
            SK[0] = d; SK[1] = n;

            label_PK_SK.Text = "PK[" + PK[0] + "," + PK[1] + "]   SK[" + SK[0] + "," + SK[1] + "]";

            label_m.Text = "m [1, " + (n - 1) + "]: ";
        }

        public void GenerateSimpleNumbers()
        {
            Random rnd = new Random();

            int r = rnd.Next(0, 13);
            p = SimpleNumbers[r];         
            while (p == 0)
            {
                r = rnd.Next(0, 13);
                p = SimpleNumbers[r];
            }

            r = rnd.Next(0, 13);
            q = SimpleNumbers[r];
            while (q == 0)
            {
                r = rnd.Next(0, 13);
                q = SimpleNumbers[r];
            }          
        }

        public void CalcFn()
        {
            Fn = (p - 1) * (q - 1);
        }

		private void button_STEP2_ENCRYPT_Click(object sender, EventArgs e)
		{
            m = Convert.ToInt64(textBox_m.Text);
            long c = 0;
            c = (long)(Math.Pow(m, E) % n);
            label1.Text = "Зашифрованное сообщение: " + c.ToString();

            c = (long)(Math.Pow(c, d) % n);
            label2.Text = "Расшифрованное сообщение: " + c.ToString();
		}

		public long GCD(long x, long y)
        {
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        }

        public void CalcE()
        {
            Random rnd = new Random();

            E = Convert.ToInt32(rnd.Next(3, (int)(Fn - 1)));

            while(GCD(E, Fn) != 1)
            {
                E = Convert.ToInt32(rnd.Next(3, (int)(Fn - 1)));
            }
        }

        public void CalcD()
        {
            d = Inverse(E, Fn);                  
        }

        public long Inverse(long _E, long _Fn)
		{
            if(_E % _Fn == 0)
			{
                return 0;
			}
            else
			{
                var result = 1;
                while(true)
				{
                    if((result * _E) % _Fn == 1)
					{
                        return result;
					}
                    result++;
				}
			}
		}
    }
}
