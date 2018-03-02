using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Runner
{
    public class Program
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
        /// System's Main menu. To add new menu options, just add a command menu attribute 
        /// with name of the class which implements MainMenu and it's position
        /// </summary>
        [CommandMenu(order: 1, name: "SequenceAnalysisMenu")]
        [CommandMenu(order: 2, name: "SumOfMultipleMenu")]
        public static void Main_Menu()
        {
            try
            {
                var configuredOptions = typeof(Program).GetMethod("Main_Menu")
                                               .GetCustomAttributes(typeof(CommandMenu), false);

                if (configuredOptions == null) throw new Exception("There is no command configured");

                Console.WriteLine("Hello! Please select the option below");

                Dictionary<int, object> menuOption = GenerateMenu((IEnumerable<CommandMenu>)configuredOptions);

                ExecuteCommand(menuOption);
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Something went wrong. Please see errors below:\r\n{0}", ex.Message));
                Console.WriteLine("Press any key to close program");
                Console.ReadKey();
            }
        }

        private static void ExecuteCommand(Dictionary<int, object> menuOption)
        {
            var selected = Console.ReadLine();

            if (int.TryParse(selected, out var selectedNumber))
            {
                var action = menuOption.FirstOrDefault(t => t.Key == selectedNumber);

                if (action.Value == null) throw new InvalidOperationException("Invalid Option");

                ((MainMenu)action.Value).Execute();
            }
            else
            {
                throw new InvalidOperationException("Invalid option");
            }
        }

        private static Dictionary<int, object> GenerateMenu(IEnumerable<CommandMenu> configuredOptions)
        {
            var menuOption = new Dictionary<int, object>();

            foreach (var item in configuredOptions)
            {
                var assembly = Assembly.GetExecutingAssembly();
                var type = assembly.GetTypes().FirstOrDefault(t => t.Name == item.Name);

                if (type != null)
                {
                    var instance = Activator.CreateInstance(type);

                    if (instance is MainMenu)
                    {
                        menuOption.Add(item.Order, instance);
                        Console.WriteLine(string.Format("[{0}] {1}", item.Order, ((MainMenu)instance).Description));
                    }
                }
            }

            if (!menuOption.Any())
            {
                throw new InvalidProgramException("There is no command configured");
            }

            return menuOption;
        }
    }
}
