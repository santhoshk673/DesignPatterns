namespace DesignPatterns.StrategyPattern.Behaviors
{
    internal class SimpleFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Simle Fly");
        }
    }
}
