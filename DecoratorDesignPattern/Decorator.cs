using DecoratorDesignPattern;

<<<<<<< HEAD
public abstract  class Decorator :Component
=======
public class Decorator : Component
>>>>>>> b40e008be9be5d2d35580faa169b49e353fd5e36
{
    private readonly Component _component;
    public Decorator(Component component)
    {
        _component = component;
    }

<<<<<<< HEAD
    public override void Calculate()
    {
        _component.Calculate();
    }

 

=======
>>>>>>> b40e008be9be5d2d35580faa169b49e353fd5e36
    public override void Operation()
    {
        _component.Operation();
    }
}