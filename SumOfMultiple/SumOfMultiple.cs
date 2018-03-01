﻿using McMaster.Extensions.CommandLineUtils;
using System.Linq;

namespace Runner
{
    /// <summary>
    /// Class responsible for making sum of multiples
    /// </summary>
    public class SumOfMultiple : ISumOfMultiple
    {
        /// <summary>
        /// Find the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input
        /// </summary>
        /// <param name="input">Input to be processed</param>
        /// <returns>Sum of all natural numbers that are multiple of 3 or 5</returns>
        public int Call(int input)
        {
            return input < 3 ? 0 : Enumerable.Range(0, input).Where(c => c % 3 == 0 || c % 5 == 0).Sum(c => c);
        }

    }
}
