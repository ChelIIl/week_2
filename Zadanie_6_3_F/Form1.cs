using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_6_3_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = int.Parse(n_t.Text);

            int[,] mas = new int[size, size];
            int[,] mas2 = new int[size, size];

            string text = elem.Text;
            string[] value = text.Split(',');

            int n = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    mas[i, j] = int.Parse(value[n]);
                    mas2[i, j] = int.Parse(value[n]);
                    n++;
                }
            }

            n = int.Parse(stepen.Text);

            for (int z = 1; z < n; z++)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        mas[i, j] *= mas2[i, j];
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    res.Text += mas[i, j];
                    res.Text += " ";
                }
                res.Text += Environment.NewLine;
            }
        }
    }
}
