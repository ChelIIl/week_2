using System;

namespace _2_week
{
    class Program
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

        static void Main(string[] args)
        {
            int n;
            double x;
            try
            {
                Console.Write("Количествво циклов:");
                n = int.Parse(Console.ReadLine());

                Console.Write("Х=");
                x = double.Parse(Console.ReadLine());

                int plus = 0;
                Console.WriteLine(f(n, x, plus));
            }
            catch
            {
                Console.Write("Некоректно введены данные!");
            }

            Console.ReadKey();
        }
    }
}
