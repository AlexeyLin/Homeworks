using System;
using System.IO;


namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте. Введите имя файла, который хотите создать:");
            string filename = $"{Console.ReadLine()}.txt";
            Console.WriteLine("Теперь введите текст, который хотите записать в файл:");
            string textTo = Console.ReadLine();
            File.WriteAllText(filename, textTo);
        }
    }
}
