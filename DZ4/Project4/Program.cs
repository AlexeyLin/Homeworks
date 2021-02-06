using System;

namespace Project4
{
    class Program
    {
        static int PhibonachiNumber (int number)
        {
            if (number == 1)
            {
                return 0;
            }
            else if(number == 2)
            {
                return 1;
            }
            else
            {
                return PhibonachiNumber(number - 1) + PhibonachiNumber(number - 2);
            }
        }
        static int ReadInt ()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.Write("Введите номер числа в последовательности Фибоначчи, которое хотите узнать: ");
            Console.WriteLine(PhibonachiNumber(ReadInt()));
            Console.ReadKey();
        }
    }
}
