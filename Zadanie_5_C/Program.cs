using System;

namespace Zadanie_5_C
{
    class Program
    {
        static void f(int a, int b, int h)
        {
            double res = 0;

            for(int i = a; i <= b; i += h)
            {
                try
                {
                    if (i - 2 <= 0)
                        throw new Exception();
                    res = Math.Log(i - 2, Math.E);
                    Console.WriteLine("f({0}) = {1}", i, res);
                }
                catch
                {
                    Console.WriteLine("f({0}) - не попадает в область определения!", i);
                }
            }
        }

        static void Main(string[] args)
        {
            int a, b, h;
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                h = int.Parse(Console.ReadLine());

                f(a, b, h);
            }
            catch
            {
                Console.WriteLine("Введены некоректные данные!");
            }

            Console.ReadKey();
        }
    }
}
