using System.Diagnostics;

namespace design_patterns;

// The Strategy design pattern defines a family of algorithms, encapsulate each one, and make them interchangeable.
// This pattern lets the algorithm vary independently from clients that use it.





/// <summary>
/// The 'Strategy' abstract class
/// </summary>
public abstract class Strategy
{
    public abstract void AlgorithmInterface();
}

/// <summary>
/// A 'ConcreteStrategy' class
/// </summary>
public class ConcreteStrategyA : Strategy
{
    public override void AlgorithmInterface()
    {
        Debug.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
    }
}

/// <summary>
/// A 'ConcreteStrategy' class
/// </summary>
public class ConcreteStrategyB : Strategy
{
    public override void AlgorithmInterface()
    {
        Debug.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
    }
}

/// <summary>
/// A 'ConcreteStrategy' class
/// </summary>
public class ConcreteStrategyC : Strategy
{
    public override void AlgorithmInterface()
    {
        Debug.WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
    }
}

/// <summary>
/// The 'Context' class
/// </summary>
public class Context
{
    Strategy strategy;

    // Constructor
    public Context(Strategy strategy)
    {
        this.strategy = strategy;
    }

    public void ContextInterface()
    {
        strategy.AlgorithmInterface();
    }
}
