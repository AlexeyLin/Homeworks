using System;
using System.IO;

namespace Project3
{
    class Program
    {
        static byte[] GetByte ()
        {
            Console.WriteLine("Введите произвольный набор чисел(0...255):");
            string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            byte[] byteArr = new byte[arr.Length];
            for(int i = 0; i<arr.Length; i++)
            {
                byteArr[i] = Convert.ToByte(arr[i]);
            }
            return byteArr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте. Введите имя бинарного файла, который хотите создать:");
            string filename = $"{Console.ReadLine()}.bin";
            File.WriteAllBytes(filename, GetByte());
            //byte[] test = File.ReadAllBytes(filename);
            //for (int i = 0; i < test.Length; i++)
            //{
            //    Console.WriteLine(test[i]);
            //}
        }
    }
}
