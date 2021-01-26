using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phoneBook =
            {
                {"Иван Абрамов","8-896-123-24-01"},
                {"Катя Иванова","8-896-123-24-02"},
                {"Игорь Абрамов","8-896-123-24-03"},
                {"Алексей Абрамов","8-896-123-24-04"},
                {"Леонид Абрамов","8-896-123-24-05"}
            };
            string searchName;
            bool noName;

            Console.WriteLine("Здравствуйте. Вас приветствует телефонный справочник.");
            while (true)
            {
                Console.WriteLine("Пожалуйста введите имя и фамилию интересующего вас абонента: ");
                searchName = Console.ReadLine();
                noName = true;
                for (int i = 0; i < phoneBook.GetLength(0); i++)
                {
                    if (phoneBook[i, 0] == searchName)
                    {
                        Console.WriteLine($"{phoneBook[i, 0]} {phoneBook[i, 1]}");
                        noName = false;
                        break;
                    }
                }
                if (noName == true)
                {
                    Console.WriteLine("Интересующий вас абонент отсутствует в телефонной книге.");
                }
            }
        }
    }
}
