using DecoratorDesignPattern;

public class ConcretDecorator:Decorator
{
    public ConcretDecorator(Component component):base(component)
    {

    }


    public override  void Operation()
    {
        base.Operation();
        NewFeature();
    }


    public void NewFeature() 
    {
        Console.WriteLine("This is new feature.");
    }

}