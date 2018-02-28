using System;

namespace Runner
{
    class Program
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            Main_Menu();
        }

        /// <summary>
        /// Menu of "Sum of multiples" functionality
        /// </summary>
        static void Sum_Of_Multiple_Menu()
        {
            Console.WriteLine("Please insert the number to be evaluated");
            var input = Console.ReadLine();

            if (int.TryParse(input, out var number))
            {
                var result = SumOfMultiple.Call(number);
                Console.WriteLine(string.Format("The sum of multiples of 3 and 5 below {0} is: {1}", number, result));
                Return_To_Main_Menu();
            }
            else
            {
                Sum_Of_Multiple_Menu();
            }
        }

        /// <summary>
        /// Refactoring code following DRY principle
        /// </summary>
        static void Return_To_Main_Menu()
        {
            Console.WriteLine("Please press [1] to return to main menu or press any other character to exit.");
            var option = Console.ReadLine();
            if (option == "1")
            {
                Main_Menu();
            }
        }

        /// <summary>
        /// Menu of "Sequence Analysis" functionality
        /// </summary>
        static void Sequence_Analysis_Menu()
        {
            Console.WriteLine("Please insert the word or phrase to be evaluated");
            var input = Console.ReadLine();

            if(string.IsNullOrEmpty(input))
            {
                Sequence_Analysis_Menu();
            }
            else
            {
                var result = SequenceAnalysis.Call(input);
                Console.WriteLine(string.Format("The uppercase words ordered alphabetically is: {0}", result));
                Return_To_Main_Menu();
            }
        }

        /// <summary>
        /// System's Main menu
        /// </summary>
        static void Main_Menu()
        {
            Console.Clear();
            Console.WriteLine("Hello! Please select the option below");
            Console.WriteLine("[1] Find the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input");
            Console.WriteLine("[2] Find the uppercase words in a string, provided as input, and order all characters in these words alphabetically");
            Console.WriteLine("[3] Exit");

            var option = Console.ReadLine();

            if (!int.TryParse(option, out var selected)) return;

            if (selected == 1)
            {
                Sum_Of_Multiple_Menu();
            }
            else if (selected == 2)
            {
                Sequence_Analysis_Menu();
            }
        }
    }
}
