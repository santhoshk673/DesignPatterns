// See https://aka.ms/new-console-template for more information
using DesignPatterns.StrategyPattern;
using DesignPatterns.StrategyPattern.Behaviors;

Duck duck = new WildDuck(new SimpleFly(), new SimpleQuack(), new DisplayAsText());
duck.Fly();
duck.Quack();
duck.Display();
