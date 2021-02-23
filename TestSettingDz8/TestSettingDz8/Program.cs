using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSettingDz8
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine($"{greeting}!");
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Console.WriteLine("Введите возраст пользователя:");
                Properties.Settings.Default.UserAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите род деятельности пользователя:");
                Properties.Settings.Default.UserOccupation = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string userName = Properties.Settings.Default.UserName;
            int userAge = Properties.Settings.Default.UserAge;
            string userOccupation = Properties.Settings.Default.UserOccupation;
            Console.WriteLine($"Имя пользователя: {userName}");
            Console.WriteLine($"Возраст: {userAge}\nРод деятельности: {userOccupation}");
            Console.ReadKey();
        }
    }
}
