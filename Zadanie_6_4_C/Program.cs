using System;

namespace Zadanie_6_4_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размер массива:");
            int n = int.Parse(Console.ReadLine());

            int[][] mas = new int[n][];
            int[] mas2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                mas[i] = new int[n];
                for (int j = 0; j < n; j++)
                {                    
                    mas[i][j] = int.Parse(Console.ReadLine());
                    mas2[i] = mas[i][j] % 2 == 0 ? mas[i][j] : mas2[i];
                }
            }

            Console.WriteLine("Первый массив:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Второй массив:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mas2[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
