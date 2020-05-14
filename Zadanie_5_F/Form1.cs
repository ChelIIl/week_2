using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_5_F
{
    public partial class Form1 : Form
    {
        void f(int a, int b, int h)
        {
            double res = 0;
            res_t.Text = "";

            for (int i = a; i <= b; i += h)
            {
                try
                {
                    if (i - 2 <= 0)
                        throw new Exception();
                    res = Math.Log(i - 2, Math.E);
                    res_t.Text += "f(";
                    res_t.Text += i;
                    res_t.Text += ") =";
                    res_t.Text += res;
                    res_t.Text += Environment.NewLine;
                }
                catch
                {
                    res_t.Text += "f(";
                    res_t.Text += i;
                    res_t.Text += ") -";
                    res_t.Text += "не попадает в область определения!";
                    res_t.Text += Environment.NewLine;
                }
                
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, h;

            try
            {
                a = int.Parse(A.Text);
                b = int.Parse(B.Text);
                h = int.Parse(H.Text);

                f(a, b, h);
            }
            catch
            {
                res_t.Text = "Введены некоректные данные!";
            }
        }
    }
}
