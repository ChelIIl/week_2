using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_6_2_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(n_t.Text);
            int min, s;

            string text = elem.Text;
            string[] value = text.Split(',');

            int[] mas = new int[n];

            for (int i = 0; i < n; i++)
            {
                mas[i] = int.Parse(value[i]);
            }

            min = s = mas[0];

            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
                if (mas[i] < min)
                {
                    min = mas[i];
                    s = i;
                }
            }

            res.Text = s.ToString();
        }
    }
}
