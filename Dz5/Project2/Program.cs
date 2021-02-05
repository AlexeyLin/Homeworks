using System;
using System.IO;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string curFile = @"C:\Users\Alex\Desktop\sturtup.txt";
            if(File.Exists(curFile))
            {
                File.AppendAllText(curFile, $"\n{DateTime.Now.ToString("F")}");
            }
            else
            {
                File.WriteAllText(curFile, DateTime.Now.ToString("F"));
            }
            //Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");
        }
    }
}
