using System;
using System.Linq;

namespace Runner
{
    /// <summary>
    /// Class responsible for making sequence analysis
    /// </summary>
    public static class SequenceAnalysis
    {
        /// <summary>
        /// Find the uppercase words in a string, provided as input, and order all characters in these words alphabetically
        /// </summary>
        /// <param name="input">Input to be processed</param>
        /// <returns>Uppercase words ordered alphabetically</returns>
        public static string Call(string input)
        {
            return string.Concat(input.Where(c => c >= 'A' && c <= 'Z').OrderBy(c => c));
        }
    }
}
