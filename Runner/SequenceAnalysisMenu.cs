using Runner.Domain;
using System;

namespace Runner
{
    public static class SequenceAnalysisMenu
    {
        /// <summary>
        /// Menu of "Sequence Analysis" functionality
        /// </summary>
        public static void Sequence_Analysis_Menu()
        {
            Console.WriteLine("Please insert the word or phrase to be evaluated");

            var sequenceAnalysis = Container.GetService<ISequenceAnalysis>();
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Sequence_Analysis_Menu();
            }
            else
            {
                var result = sequenceAnalysis.Call(input);
                Console.WriteLine(string.Format("The uppercase words ordered alphabetically is: {0}", result));
            }
        }
    }
}
