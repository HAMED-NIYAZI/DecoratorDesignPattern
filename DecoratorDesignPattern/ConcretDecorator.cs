using DecoratorDesignPattern;

public class ConcretDecorator:Decorator
{
    public ConcretDecorator(Component component):base(component)
    {

    }


<<<<<<< HEAD
    public override  void Operation()
=======
    public override void Operation()
>>>>>>> b40e008be9be5d2d35580faa169b49e353fd5e36
    {
        base.Operation();
        NewFeature();
    }


    public void NewFeature() 
    {
        Console.WriteLine("This is new feature.");
    }

}