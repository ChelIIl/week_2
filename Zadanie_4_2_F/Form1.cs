using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_4_2_F
{
    public partial class Form1 : Form
    {
        static void f(double[] mas, int n, int j)
        {
            if (n == 0)
                return;
            else
            {
                mas[j] = mas[j] * Math.Pow(2, n - 1);
                f(mas, n - 1, j + 1);
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double res = 0;
                int j = 0;

                string num = mas_t.Text;
                char[] str = num.ToCharArray();

                double[] mas = new double[str.Length];

                for (int i = 0; i < mas.Length; i++)
                    mas[i] = double.Parse(str[i].ToString());

                f(mas, mas.Length, j);

                for (int i = 0; i < mas.Length; i++)
                    res += mas[i];

                res_t.Text = res.ToString();
            }

            catch
            {
                Console.WriteLine("Введены некоректные данные!");
            }
        }
    }
}
