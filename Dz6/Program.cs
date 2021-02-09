using System;
using System.Diagnostics;

namespace Dz6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string answerExit;
            while(!exit)
            {
                Console.WriteLine("Task manager 0.0.1");
                foreach (Process process in Process.GetProcesses())
                {
                    Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}");
                }
                Console.WriteLine();
                Console.WriteLine("Введите ID или Name процесса, чтобы принудительно его завершить:");
                string killProc = Console.ReadLine();
                foreach (Process process in Process.GetProcesses())
                {
                    if (killProc == process.ProcessName || killProc == Convert.ToString(process.Id)) ;
                    {
                        process.Kill();
                    }
                }
                Console.WriteLine("Продолжить выполнение программы?(Да/Нет)");
                answerExit = Console.ReadLine();
                if (answerExit.ToLower() == "нет")
                {
                    exit = true;
                }               
            }
        }
    }
}
