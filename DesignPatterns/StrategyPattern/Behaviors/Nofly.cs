namespace DesignPatterns.StrategyPattern.Behaviors
{
    internal class Nofly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("No Fly");
        }
    }
}
