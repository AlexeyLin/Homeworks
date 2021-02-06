using System;

namespace Project2
{
    class Program
    {
        static int SumNumber (string [] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += int.Parse(array[i]);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите через пробел числа, которые хотите суммировать:");
            Console.Write($"Сумма введенных чисел: {SumNumber(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries))}");
            Console.ReadKey();
        }
    }
}
