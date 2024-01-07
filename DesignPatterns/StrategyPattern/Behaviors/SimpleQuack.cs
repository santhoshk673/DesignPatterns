namespace DesignPatterns.StrategyPattern.Behaviors
{
    internal class SimpleQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Simple Quack");
        }
    }
}
