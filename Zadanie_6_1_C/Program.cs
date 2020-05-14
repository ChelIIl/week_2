using System;

namespace Zadanie_6_1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, s = 0;

            Console.Write("Размер массива:");
            int n = int.Parse(Console.ReadLine());

            int[] mas = new int[n];

            for (int i = 0; i < n; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Диапазон А:");
            A = int.Parse(Console.ReadLine());

            Console.Write("Диапазон B:");
            B = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
            }

            for (int i = 0; i < n; i++)
            {
                s = mas[i] < A || mas[i] > B ? s + 1 : s;
            }

            Console.WriteLine("\n" + s);

            Console.ReadKey();
        }

        static void Main2(string[] args)
        {
            int A, B, s = 0;

            Console.Write("Размер массива:");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] mas = new int[n,m];

            for (int i = 0; i < n; i++)
            {
                    for (int j = 0; j < m; j++)
                    {
                        mas[i,j] = int.Parse(Console.ReadLine());
                    }
            }

            Console.Write("Диапазон А:");
            A = int.Parse(Console.ReadLine());

            Console.Write("Диапазон B:");
            B = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mas[i,j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    s = mas[i,j] < A || mas[i,j] > B ? s + 1 : s;
                }
            }

            Console.WriteLine("\n" + s);

            Console.ReadKey();
        }
    }
}
