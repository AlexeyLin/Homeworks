using System;
using System.IO;

namespace Project4
{
    class Program
    {
        static void GetKatalog (string pathKat, string pathFile)
        {
            File.AppendAllText(pathFile, pathKat);
            File.AppendAllText(pathFile, Environment.NewLine);
            string[] katDir = Directory.GetDirectories(pathKat);
            for(int i = 0; i<katDir.Length; i++)
            {
                GetKatalog(katDir[i], pathFile);
            }
            File.AppendAllLines(pathFile, Directory.GetFiles(pathKat));
        }
        static void Main(string[] args)
        {
            string curFile = @"C:\Users\Alex\Saved Games";
            string pathFile = Path.Combine(curFile, "katalog.txt");
            GetKatalog(curFile, pathFile);

            //Другой способ
            //string[] arrFile = Directory.GetFileSystemEntries(curFile);
            //for (int i = 0; i < arrFile.Length; i++)
            //{
            //    Console.WriteLine(arrFile[i]);
            //}
        }
    }
}
