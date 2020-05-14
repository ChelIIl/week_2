using System;

namespace Zadanie_6_3_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размер массива:");
            int size = int.Parse(Console.ReadLine());

            int[,] mas = new int[size, size];
            int[,] mas2 = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    mas[i,j] = int.Parse(Console.ReadLine());
                    mas2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Степень:");
            int n = int.Parse(Console.ReadLine());

            for (int z = 1; z < n; z++)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        mas[i, j] *= mas2[i,j];
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
