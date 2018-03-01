using System;
using System.Globalization;
using System.Resources;
using System.Linq;

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
        /// System's Main menu
        /// </summary>
        static void Main_Menu()
        {
            var rm = new ResourceManager(typeof(Resources));
            var x = rm.GetResourceSet(CultureInfo.CurrentCulture, true, false);
            

            Console.WriteLine("Hello! Please select the option below");
            Console.WriteLine("[1] Find the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input");
            Console.WriteLine("[2] Find the uppercase words in a string, provided as input, and order all characters in these words alphabetically");
            Console.WriteLine("[3] Exit");

            var option = Console.ReadLine();

            if (!int.TryParse(option, out var selected)) return;

            if (selected == 1)
            {
                SumOfMultipleMenu.Sum_Of_Multiple_Menu();
            }
            else if (selected == 2)
            {
                SequenceAnalysisMenu.Sequence_Analysis_Menu();
            }
        }


    }
}
