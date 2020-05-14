using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_6_4_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res.Text = "";
            int n = int.Parse(n_t.Text);
            int s = 0;

            int[][] mas = new int[n][];
            int[] mas2 = new int[n];

            string text = elem.Text;
            string[] value = text.Split(',');


            for (int i = 0; i < n; i++)
            {
                mas[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    mas[i][j] = int.Parse(value[s]);
                    mas2[i] = mas[i][j] % 2 == 0 ? mas[i][j] : mas2[i];
                    s++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                res.Text += mas2[i];
                res.Text += " ";
            }
        }
    }
}
