using System.Diagnostics;

namespace design_patterns;

// The Decorator design pattern attaches additional responsibilities to an object dynamically.
// This pattern provide a flexible alternative to subclassing for extending functionality.






/// <summary>
/// The 'Component' abstract class
/// </summary>
public abstract class Component
{
    public abstract void Operation();
}

/// <summary>
/// The 'ConcreteComponent' class
/// </summary>
public class ConcreteComponent : Component
{
    public override void Operation()
    {
        Debug.WriteLine("ConcreteComponent.Operation()");
    }
}

/// <summary>
/// The 'Decorator' abstract class
/// </summary>
public abstract class Decorator : Component
{
    protected Component component;

    public void SetComponent(Component component)
    {
        this.component = component;
    }

    public override void Operation()
    {
        if (component != null)
        {
            component.Operation();
        }
    }
}

/// <summary>
/// The 'ConcreteDecoratorA' class
/// </summary>
public class ConcreteDecoratorA : Decorator
{
    public override void Operation()
    {
        base.Operation();
        Debug.WriteLine("ConcreteDecoratorA.Operation()");
    }
}

/// <summary>
/// The 'ConcreteDecoratorB' class
/// </summary>
public class ConcreteDecoratorB : Decorator
{
    public override void Operation()
    {
        base.Operation();
        AddedBehavior();
        Debug.WriteLine("ConcreteDecoratorB.Operation()");
    }

    void AddedBehavior() { }
}
