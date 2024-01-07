namespace DesignPatterns.StrategyPattern.Behaviors
{
    internal class NoQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("No quack");
        }
    }
}
