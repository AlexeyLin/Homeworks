using System;

namespace Project1
{
    class Program
    {
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{firstName} {lastName} {patronymic}";
        }
        static void Main(string[] args)
        {
            string[,] listOfName = {
                {"Иванов","Кирилл","Олегович"},
                {"Соколова","Ольга","Петровна"},
                {"Лапин","Олег","Алексеевич"},
                {"Дружинин","Дмитрий","Александрович"}
            };
            Console.WriteLine("Нажмите любую клавишу, чтобы вывести список посетителей за сегодня...");
            Console.ReadKey();
            for (int i = 0; i < listOfName.GetLength(0); i++)
            {
                Console.WriteLine(GetFullName(listOfName[i,0], listOfName[i, 1], listOfName[i, 2]));
            }
            Console.ReadKey();
        }
    }
}
