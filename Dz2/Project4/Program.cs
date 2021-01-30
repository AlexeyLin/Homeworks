using System;

namespace Project4
{
    class Program
    {   
        [Flags]
        enum dayOfWork
        {
            Monday = 0b_1000000,
            Tuesday = 0b_0100000,
            Wednesday = 0b_0010000,
            Thursday = 0b_0001000,
            Friday = 0b_0000100,
            Saturday = 0b_0000010,
            Sunday = 0b_0000001
        }

        static void Main(string[] args)
        {
            //Программа выводит все рабоющие сегодня организиции 
            dayOfWork office1 =  dayOfWork.Tuesday | dayOfWork.Wednesday | dayOfWork.Thursday | dayOfWork.Friday;
            dayOfWork office2 = dayOfWork.Monday | dayOfWork.Tuesday | dayOfWork.Wednesday | dayOfWork.Thursday | dayOfWork.Friday | dayOfWork.Saturday | dayOfWork.Sunday;
            int today = 0b0000000;
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    today = (int)dayOfWork.Monday;
                    break;
                case DayOfWeek.Tuesday:
                    today = (int)dayOfWork.Tuesday;
                    break;
                case DayOfWeek.Wednesday:
                    today = (int)dayOfWork.Wednesday;
                    break;
                case DayOfWeek.Thursday:
                    today = (int)dayOfWork.Thursday;
                    break;
                case DayOfWeek.Friday:
                    today = (int)dayOfWork.Friday;
                    break;
                case DayOfWeek.Saturday:
                    today = (int)dayOfWork.Saturday;
                    break;
                case DayOfWeek.Sunday:
                    today = (int)dayOfWork.Sunday;
                    break;
            }
            Console.WriteLine("Сегодня работают следующие организации:");
            if ((today & (int)office1)== today)
            {
                Console.WriteLine("Офис1");
            }
            if ((today & (int)office2) == today)
            {
                Console.WriteLine("Офис2");
            }
        }
    }
}
