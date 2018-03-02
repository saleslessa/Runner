namespace Runner
{
    /// <summary>
    /// Abstract class responsible for behavior of application's menu
    /// </summary>
    public abstract class MainMenu
    {
        public string Description { get; set; }

        public abstract void Execute();
    }
}