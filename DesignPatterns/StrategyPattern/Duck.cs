using DesignPatterns.StrategyPattern.Behaviors;

namespace DesignPatterns.StrategyPattern
{
    internal class Duck
    {
        readonly IFlyBehavior _flyBehavior;
        readonly IQuackBehavior _quackBehavior;
        readonly IDisplayBehavior _displayBehavior;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, IDisplayBehavior displayBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
            _displayBehavior = displayBehavior;

        }

        public void Fly() { _flyBehavior.Fly(); }

        public void Quack() { _quackBehavior.Quack(); }

        public void Display() { _displayBehavior.Display(); }
    }
}
