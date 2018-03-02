using Runner.Domain;
using System;

namespace Runner
{
    /// <summary>
    /// Menu of "Sequence Analysis" functionality
    /// </summary>
    public class SequenceAnalysisMenu : MainMenu
    {
        
        public SequenceAnalysisMenu()
        {
            Description = "Find the uppercase words in a string, and order all characters in these words alphabetically";
        }

        public override void Execute()
        {
            try
            {
                var sequenceAnalysis = Container.GetService<ISequenceAnalysis>();
                Console.WriteLine("Please insert the word or phrase to be evaluated");
                var input = Console.ReadLine();

                var result = sequenceAnalysis.Call(input);
                Console.WriteLine(string.Format("The uppercase words ordered alphabetically is: {0}", result));
                Console.WriteLine(Resources.ExitMessage);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Something went wrong. Please see error below:\r\n{0}", ex.Message));
            }
        }
    }
}
