namespace DesignPatterns.StrategyPattern.Behaviors
{
    internal class DisplayAsGraphics : IDisplayBehavior
    {
        public void Display()
        {
            Console.WriteLine("Display As Graphics");
        }
    }
}
