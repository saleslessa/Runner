using System;
using System.Linq;

namespace Runner
{
    /// <summary>
    /// Class responsible for making sequence analysis
    /// </summary>
    public class SequenceAnalysis : ISequenceAnalysis
    {
        /// <summary>
        /// Find the uppercase words in a string, provided as input, and order all characters in these words alphabetically
        /// </summary>
        /// <param name="input">Input to be processed</param>
        /// <returns>Uppercase words ordered alphabetically</returns>
        public string Call(string input)
        {
            return string.Concat(input.Where(c => c >= 'A' && c <= 'Z').OrderBy(c => c));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
