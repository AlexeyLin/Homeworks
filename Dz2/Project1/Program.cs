using System;

namespace Project1
{
    class Program
    {
        enum MonthOfYear
        {
            январь = 1,
            февраль,
            март,
            апрель,
            май,
            июнь,
            июль,
            август,
            сентябрь,
            октябрь,
            ноябрь,
            декабрь
        }
        static void Main(string[] args)
        {
            //Задание с температурой выполнил через float, потому что хотел чтобы полградуса не терялись.
            Console.Write("Введите минимальную температуру сегодня(°C): ");
            int minTemp = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальную температуру сегодня(°C): ");
            int maxTemp = int.Parse(Console.ReadLine());
            float midTemp = (float)(minTemp + maxTemp) / 2; 
            Console.WriteLine($"Среднесуточная температура сегодня: {midTemp}°C");

            //Задание текущего месяца
            Console.Write("Введите номер текущего месяца: ");
            int monthNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Текущий месяц: {(MonthOfYear)monthNum}");

            //Задание определения дождливой зимы
            if ((monthNum == 12 || monthNum < 3) && midTemp > 0)
            {
                Console.WriteLine("Дождливая зима");
            }
            Console.ReadKey();
        }
    }
}
