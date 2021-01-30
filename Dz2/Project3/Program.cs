using System;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание на формирование чека. Вывод получается приемлимым вроде. Однако код меня немного смущает(возможно могло быть лучше).
            string shopName = "ОАО Остин";
            long codeRWC = 85932046566;
            int codeTrans = 45896;
            int numberOper = 458766;
            string productName = "Свитер мужской XL";
            double costProduct = 1990;
            string productName2 = "Носки размер 44";
            double costProduct2 = 990;
            double pay = 5000;
            Console.WriteLine(
                "\t    КАССОВЫЙ ЧЕК\n"+
                $"{shopName}\n"+
                $"{DateTime.Now}\n"+
                ($"RWC: {codeRWC}\tТранз: {codeTrans}\n")+
                ("").PadRight(36, '=')+
                "\nНаименование\t\t\tЦена"+
                $"\n{productName}\t\t{costProduct}\n"+
                $"{productName2}\t\t\t{costProduct2}\n"+
                $"Итог\t\t\t\t{costProduct+costProduct2}\n\n"+
                "Способ оплаты: наличные\n"+
                $"Получено\t\t\t{pay}\n"+
                $"Сдача\t\t\t\t{pay-(costProduct + costProduct2)}\n"+
                ("").PadRight(36, '=') +
                $"\nНомер операции: {numberOper}\n"+
                "Кассир: Иванова Татьяна Ивановна\n"+
                $"{shopName}\n"+
                "ЗН ККТ 02555100010122\nРН ККТ 02555100010133\n" +
                "ФН 928654211366645\nИНН 7707088460\n");
            Console.ReadKey();
        }
    }
}
