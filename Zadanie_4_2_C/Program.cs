using System;

namespace Zadanie_4_2_C
{
    class Program
    {
        static void f (double[] mas, double res, int n, int j)
        {
            if (n == 0)
                return;
            else
            {
                mas[j] = mas[j] * Math.Pow(2, n - 1);
                f(mas, res, n - 1, j + 1);
            }
            
        }

        static void Main(string[] args)
        {
            try
            {
                double res = 0;
                int j = 0;
                int n = int.Parse(Console.ReadLine());

                double[] mas = new double[n];

                for (int i = 0; i < n; i++)
                {
                    mas[i] = int.Parse(Console.ReadLine());
                }

                f(mas, res, n, j);

                for (int i = 0; i < n; i++)
                {
                    res += mas[i];
                }

                Console.WriteLine(res);

                Console.ReadKey();
            }

            catch
            {
                Console.WriteLine("Введены некоректные данные!");
            }
        }
    }
}
