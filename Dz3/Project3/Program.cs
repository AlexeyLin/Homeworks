using System;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение:");
            string letter = Console.ReadLine();
            for (int i = letter.Length-1; i >=0; i--)
            {
                Console.Write(letter[i]);
            }
        }

    }
}
