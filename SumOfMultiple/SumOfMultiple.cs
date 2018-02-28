using System;

namespace Runner
{
    /// <summary>
    /// Class responsible for making sum of multiples
    /// </summary>
    public static class SumOfMultiple
    {
        /// <summary>
        /// Find the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input
        /// </summary>
        /// <param name="input">Input to be processed</param>
        /// <returns>Sum of all natural numbers that are multiple of 3 or 5</returns>
        public static int Call(int input)
        {
            int result = 0;

            for (int i = 1; i < input; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    result += i;
                }
            }

            return result;
        }
    }
}
