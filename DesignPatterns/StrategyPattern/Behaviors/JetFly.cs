namespace DesignPatterns.StrategyPattern.Behaviors
{
    internal class JetFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Jet Fly");
        }
    }
}
