using System;
using System.Text.Json;
using System.IO;

namespace Project5
{
    class Program
    {
        static void SerializFile(ToDo[] toDo)
        {
            string json = JsonSerializer.Serialize(toDo);
            File.WriteAllText("tasks.json", json);
        }

        static ToDo[] CreateToDo()
        {
            Console.Write("Введите сколько задач вы хотите добавить: ");
            int numberOfTasks = Convert.ToInt32(Console.ReadLine());
            ToDo[] toDo = new ToDo[numberOfTasks];
            for (int i = 0; i < numberOfTasks; i++)
            {
                Console.WriteLine($"Введите задачу №{i + 1}:");
                toDo[i] = new ToDo(i + 1, Console.ReadLine());
            }
            return toDo;
        }

        static void PrintTask(ToDo[] toDo)
        {
            for (int i = 0; i < toDo.Length; i++)
            {
                if (toDo[i].IsDone)
                {
                    Console.WriteLine($"[X] {toDo[i].NumberTask}. {toDo[i].Title}");
                }
                else
                {
                    Console.WriteLine($"[ ] {toDo[i].NumberTask}. {toDo[i].Title}");
                }
            }
        }

        static void MarkIsDone (ToDo[] toDo)
        {
            PrintTask(toDo);
            Console.Write("Введите номер выполненной задачи: ");
            int numberTask = Convert.ToInt32(Console.ReadLine());
            toDo[numberTask - 1].IsDone = true;
            PrintTask(toDo);
        }

        public static void Main(string[] args)
        {
            ToDo[] toDo;
            int numAction;
            bool exit = false;
            Console.WriteLine("Вас приветствует программа 'Список задач'!");
            if (File.Exists("tasks.json"))
            {
                Console.WriteLine("Считываем данные из файла.");
                string json = File.ReadAllText("tasks.json");
                toDo = JsonSerializer.Deserialize<ToDo[]>(json);
            }
            else
            {
                toDo = CreateToDo();
            }
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("Доступные действия:\n" +
                    "1.Вывести список задач на экран\n" +
                    "2.Отметить выполненную задачу\n" +
                    "3.Записать список задач в файл\n" +
                    "4.Выйти из программы");
                Console.Write("Введите номер действия для его выполнения:");
                numAction = Convert.ToInt32(Console.ReadLine());
                switch (numAction)
                {
                    case 1:
                        PrintTask(toDo);
                        break;
                    case 2:
                        Console.Clear();
                        MarkIsDone(toDo);
                        break;
                    case 3:
                        SerializFile(toDo);
                        Console.Write("Запись выполнена!");
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Введите номер из доступных действий.");
                        break;
                }
            }
        }
    }
}
