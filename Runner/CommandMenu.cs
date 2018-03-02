using System;
namespace Runner
{
    /// <summary>
    /// Custom method attribute used in main menu containing the reference of menu and it's position
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public sealed class CommandMenu : Attribute
    {
        public int Order { get; private set; }

        public string Name { get; private set; }

        public CommandMenu (int order, string name) {
            Order = order;
            Name = name;
        }

    }
}
