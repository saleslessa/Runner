using Runner.Domain;
using System;

namespace Runner
{
    /// <summary>
    /// Menu of "Sum of multiples" functionality
    /// </summary>
    public class SumOfMultipleMenu : MainMenu
    {
     
        public SumOfMultipleMenu()
        {
            Description = "Find the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input";
        }


        public override void Execute()
        {
            Console.WriteLine("Please insert the number to be evaluated");
            var input = Console.ReadLine();

            var sumOfMultiple = Container.GetService<ISumOfMultiple>();

            try
            {
                if (!int.TryParse(input, out var number))
                {
                    throw new ArgumentException("The value provided is not a number");
                }

                var result = sumOfMultiple.Call(number);
                Console.WriteLine(string.Format("The sum of multiples of 3 and 5 below {0} is: {1}", number, result));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Something went wrong. Please see error below:\r\n{0}", ex.Message));
            }
        }
    }
}
