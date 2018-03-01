using Runner.Domain;
using System;

namespace Runner
{
    public static class SumOfMultipleMenu
    {
        /// <summary>
        /// Menu of "Sum of multiples" functionality
        /// </summary>
        public static void Sum_Of_Multiple_Menu()
        {
            Console.WriteLine("Please insert the number to be evaluated");

            var sumOfMultiple = Container.GetService<ISumOfMultiple>();
            var input = Console.ReadLine();

            if (int.TryParse(input, out var number))
            {
                var result = sumOfMultiple.Call(number);
                Console.WriteLine(string.Format("The sum of multiples of 3 and 5 below {0} is: {1}", number, result));
            }
            else
            {
                Sum_Of_Multiple_Menu();
            }
        }
    }
}
