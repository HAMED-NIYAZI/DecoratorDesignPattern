
using DecoratorDesignPattern;

public class ConcretComponent : Component
{
    public override void Calculate()
    {
        Console.WriteLine("ConcretComponent : Component---> Calculate   runs....");
    }

    public override void Operation()
    {
        Console.WriteLine("ConcretComponent : Component---> Operation   runs....");
    }
}