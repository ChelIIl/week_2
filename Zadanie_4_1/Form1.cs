using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_4_1
{
    public partial class Form1 : Form
    {
        static double f(int n, double x, int plus)
        {
            if (plus > n)
                return (plus - 1 + x) * (plus - 1 + x);
            else
            {
                return f(n, x, plus + 1) / (plus + x);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            double x;
            try
            {
                n = int.Parse(n_t.Text);

                x = double.Parse(x_t.Text);

                int plus = 0;

                res_t.Text = f(n, x, plus).ToString();
            }
            catch
            {
                res_t.Text = "Некоректно введены данные!";
            }
        }
    }
}
