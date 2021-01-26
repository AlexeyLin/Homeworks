using System;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] seaBattle = new string[10, 10];

            //однопалубные
            seaBattle[6, 7] = "X";
            seaBattle[8, 3] = "X";
            seaBattle[8, 5] = "X";
            seaBattle[9, 0] = "X";

            //двухпалубные
            for(int i = 0; i<2; i++)
            {
                seaBattle[0, i] = "X";
            }
            for (int i = 2; i < 4; i++)
            {
                seaBattle[i, 9] = "X";
            }
            for (int i = 8; i < 10; i++)
            {
                seaBattle[i, 8] = "X";
            }

            //трехпалубные
            for (int i = 0; i < 3; i++)
            {
                seaBattle[i, 3] = "X";
            }

            for (int i = 4; i < 7; i++)
            {
                seaBattle[i, 1] = "X";
            }

            //четырехпалубные
            for (int i = 6; i < 10; i++)
            {
                seaBattle[0, i] = "X";
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(seaBattle[i,j]!="X")
                    {
                        seaBattle[i, j] = "O";
                    }
                    Console.Write(seaBattle[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
