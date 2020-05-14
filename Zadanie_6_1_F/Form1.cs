using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_6_1_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            n_t2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mas1.Checked)
            {
                int s = 0;

                int A = int.Parse(a.Text);
                int B = int.Parse(b.Text);
                int n = int.Parse(n_t.Text);

                string text = elem.Text;
                string[] value = text.Split(',');

                int[] mas = new int[n];

                for (int i = 0; i < n; i++)
                {
                    mas[i] = int.Parse(value[i]);
                }

                for (int i = 0; i < n; i++)
                {
                    s = mas[i] < A || mas[i] > B ? s + 1 : s;
                }

                res.Text = s.ToString();
            }

            else if(mas2.Checked)
            {
                int s = 0;

                int A = int.Parse(a.Text);
                int B = int.Parse(b.Text);
                int n = int.Parse(n_t.Text);
                int m = int.Parse(n_t2.Text);

                string text = elem.Text;
                string[] value = text.Split(',');

                int[,] mas = new int[n,m];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        mas[i, j] = int.Parse(value[s]);
                        s++;
                    }                    
                }

                s = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        s = mas[i, j] < A || mas[i, j] > B ? s + 1 : s;
                    }
                }

                res.Text = s.ToString();
            }

            else
            {
                res.Text = "Выберете массив!";
            }
        }

        private void mas1_CheckedChanged(object sender, EventArgs e)
        {
            mas2.Checked = false;
            n_t2.Hide();
        }

        private void mas2_CheckedChanged(object sender, EventArgs e)
        {
            mas1.Checked = false;
            n_t2.Show();
        }
    }
}
