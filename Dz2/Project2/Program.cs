using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number%2 == 0)
            {
                Console.WriteLine("Введенное число является четным.");
                return;
            }
            Console.WriteLine("Введенное число является нечетным.");
            Console.ReadKey();
        }
    }
}
