namespace DesignPatterns.StrategyPattern.Behaviors
{
    internal class DisplayAsText : IDisplayBehavior
    {
        public void Display()
        {
            Console.WriteLine("Disaply As Text");
        }
    }
}
