using System.Diagnostics;

namespace design_patterns;

// The State design pattern allows an object to alter its behavior when its internal state changes.
// The object will appear to change its class.






/// <summary>
/// The 'State' abstract class
/// </summary>
public abstract class State
{
    public abstract void Handle(StateContext context);
}

/// <summary>
/// A 'ConcreteState' class
/// </summary>
public class ConcreteStateA : State
{
    public override void Handle(StateContext context)
    {
        context.State = new ConcreteStateB();
    }
}

/// <summary>
/// A 'ConcreteState' class
/// </summary>
public class ConcreteStateB : State
{
    public override void Handle(StateContext context)
    {
        context.State = new ConcreteStateA();
    }
}

/// <summary>
/// The 'Context' class
/// </summary>
public class StateContext
{
    State state;

    // Constructor
    public StateContext(State state)
    {
        this.State = state;
    }

    // Gets or sets the state
    public State State
    {
        get { return state; }
        set
        {
            state = value;
            Debug.WriteLine("State: " + state.GetType().Name);
        }
    }

    public void Request()
    {
        state.Handle(this);
    }
}
