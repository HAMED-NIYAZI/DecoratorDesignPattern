
using DecoratorDesignPattern;

public class ConcretComponent : Component
{
    public override void Operation()
    {
        Console.WriteLine("ConcretComponent : Component---> runs....");
    }
}