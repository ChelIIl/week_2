using System;

namespace Zadanie_6_2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, min, s;

            Console.Write("Размер массива:");
            n = int.Parse(Console.ReadLine());

            int[] mas = new int[n];

            for (int i = 0; i < n; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }

            min = s = mas[0];

            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
                if(mas[i] < min)
                {
                    min = mas[i];
                    s = i;
                }
            }

            Console.WriteLine("\n" + s);

            Console.ReadKey();
        }
    }
}
