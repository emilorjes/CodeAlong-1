using System;
using System.Linq;

namespace CodeAlong_1
{
    class Program
    {
        static void Main(string[] args)
        {/*
            // CTRL + k, CTRL + d för att fina till koden
            // Ett sätt
            int[] arrayOfNumbers = new int[5];
            arrayOfNumbers[0] = 13;
            arrayOfNumbers[1] = 22;
            arrayOfNumbers[2] = 3;
            arrayOfNumbers[3] = 93;
            arrayOfNumbers[4] = 1;

            Console.WriteLine("Check if you picked a lucky number");
            string nr = Console.ReadLine();
            int myNr = Convert.ToInt32(nr);

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if(myNr == arrayOfNumbers[i])
                {
                    Console.WriteLine("Winner chicken dinner");
                }
                else
                {
                    Console.WriteLine("Not this time");
                }
            }

            Console.WriteLine(arrayOfNumbers.Contains(3));
            


            //Öning 2
            // Ett sätt
            int[] firstOne = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] secondOne = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Console.WriteLine(string.Join('.', firstOne));
            Console.WriteLine(string.Join(',', secondOne));

            // Ett annat sätt
            Console.WriteLine(string.Join(',', firstOne));
            */
            string[] stringArray = new string[] { "January", "Februari", "Mars", "April", "Maj", "Juni", "Juli", "Augusti", "September", "Oktober", "November", "December" };
            string number;
            int choice;

            do
            {

                Console.WriteLine("Select a number from 1-12");
                number = Console.ReadLine();
                choice = Convert.ToInt32(number);
                if (choice < 12)
                {
                    Console.WriteLine(stringArray[choice - 1]);
                }

            } while (choice < 12);
         


        }
    }
}
