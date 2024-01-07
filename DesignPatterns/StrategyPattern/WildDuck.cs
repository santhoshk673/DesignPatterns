using DesignPatterns.StrategyPattern.Behaviors;

namespace DesignPatterns.StrategyPattern
{
    internal class WildDuck : Duck
    {
        public WildDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, IDisplayBehavior displayBehavior) 
            :base(flyBehavior, quackBehavior, displayBehavior)
        {
            
        }
    }
}
