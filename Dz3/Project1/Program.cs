using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задайте размер равностороннего массива: ");
            int ar = int.Parse(Console.ReadLine());
            int[,] arr = new int[ar, ar];
            Random rnd = new Random();
            for(int i=0; i<ar; i++)
            {
                for(int j=0; j < ar; j++)
                {
                    arr[i, j] = rnd.Next(10);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Write("Диагональ сгенерированного массива: ");
            for (int i = 0; i < ar; i++)
            {
                for (int j = 0; j < ar; j++)
                {
                    if( i == j )
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                }
            }
            Console.WriteLine();

            Console.Write("Обратная диагональ сгенерированного массива: ");
            for (int i = 0; i < ar; i++)
            {
                for (int j = 0; j < ar; j++)
                {
                    if ((ar-1-i) == j)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
