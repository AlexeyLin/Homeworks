using System;

namespace Project3
{
    class Program
    {
        enum Seasons
        {
            Зима,
            Весна,
            Лето,
            Осень,
            Ошибка
        }
        static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static bool CurrentSeason (int numberMonth, out Seasons currentSeason)
        {
            switch (numberMonth)
            {
                case 12:
                case 1:
                case 2:
                    currentSeason = Seasons.Зима;
                    return true;
                case 3:
                case 4:
                case 5:
                    currentSeason =  Seasons.Весна;
                    return true;
                case 6:
                case 7:
                case 8:
                    currentSeason = Seasons.Лето;
                    return true;
                case 9:
                case 10:
                case 11:
                    currentSeason = Seasons.Осень;
                    return true;
                default:
                    currentSeason = Seasons.Ошибка;
                    return false;
            }
            
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите номер месяца: ");
                if (CurrentSeason(ReadInt(), out Seasons currentSeason))
                {
                    Console.WriteLine($"Введенный месяц относится ко времени года {currentSeason}");
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12.");
                }
            }
            
        }
    }
}
