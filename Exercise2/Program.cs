using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            // Infinite loop till user selects 0
            while (!Console.KeyAvailable && key.Key != ConsoleKey.D0)

            {

                ShowMenu();

                // Wait for users menu selection
                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    // 0 Exit Program
                    case ConsoleKey.D0:

                        break;

                    // 1 Show ticket price based on age
                    case ConsoleKey.D1:

                        ShowTicketPriceForAge();
                        break;

                    // Repeat input 10 times
                    case ConsoleKey.D2:

                        RepeatText();

                        break;

                    // The Third Word
                    case ConsoleKey.D3:

                        ThirdWordSentence();
                        break;

                    // Group Tickets based on age
                    case ConsoleKey.D4:

                        GroupTickets();
                        break;

                    default:

                        Console.WriteLine("Wrong Option Selected");
                        Console.ReadKey();
                        break;
                }

            }

        }

        private static void GroupTickets()
        {
            int qty = Tools.GetInputInt("Hur många ska se på bio?");

            Console.WriteLine(" ");

            int sum = 0;
            int personPrice = 0;

            for (int x = 0; x < qty; x++)
            {
                int personAge = Tools.GetInputInt($"Ange ålder för person {x + 1}:");

                Console.WriteLine(" ");

                if (personAge < 20)
                {
                    personPrice = 80;
                }
                else if (personAge > 64)
                {
                    personPrice = 90;
                }
                else
                {
                    personPrice = 120;
                }

                sum += personPrice;
            }

            Console.WriteLine(" ");
            Console.WriteLine($"För dessa {qty} personer blir totalsumman {sum} kr");

            Console.ReadKey();
        }

        private static void ThirdWordSentence()
        {

            string[] input = Tools.GetWords("Skriv in en mening på 3 ord: ", 3);

            Console.WriteLine(" ");
            Console.WriteLine(input[2]);
            Console.WriteLine(" ");

            Console.ReadKey();
        }

        private static void RepeatText()
        {
            Console.Write("Ange text att upprepa: ");
            string input = Console.ReadLine();

            Console.WriteLine(" ");

            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{ i}. {input} ");
            }

            Console.ReadKey();
        }

        private static void ShowTicketPriceForAge()
        {
            Console.Write("Ange din ålder: ");

            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            if (age < 20)
            {
                Console.WriteLine("Ungdomspris: 80kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("Pensionärspris: 90kr");
            }
            else
            {
                Console.WriteLine("Standardpris: 120kr");
            }

            Console.ReadKey();
        }

        private static void ShowMenu()
        {
            Console.Clear();

            // Show menu
            Console.WriteLine("Main Menu.");
            Console.WriteLine("---------");
            Console.WriteLine("1 Ungdom / Pensionär");
            Console.WriteLine("2 Upprepa input 10 gånger");
            Console.WriteLine("3 Det tredje ordet");
            Console.WriteLine("4 Grupp");

            Console.WriteLine(" ");
            Console.WriteLine("0 Quit");
            Console.WriteLine("---------");
        }
    }
}
