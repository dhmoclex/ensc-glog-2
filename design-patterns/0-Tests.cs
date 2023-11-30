using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace design_patterns;

// https://www.dofactory.com/net/design-patterns
// https://refactoring.guru/fr/design-patterns

[TestClass]
public class DesignPatternsTest
{
    [TestMethod]
    public void SingletonTest()
    {
        // Constructor is protected -- cannot use new
        Singleton s1 = Singleton.Instance();
        Singleton s2 = Singleton.Instance();

        // Test for same instance
        Assert.AreSame(s1, s2);
    }

    [TestMethod]
    public void AbstractFactoryTest()
    {
        // Abstract factory #1
        AbstractFactory factory1 = new ConcreteFactory1();
        Client client1 = new Client(factory1);
        client1.Run();

        // Abstract factory #2
        AbstractFactory factory2 = new ConcreteFactory2();
        Client client2 = new Client(factory2);
        client2.Run();
    }

    [TestMethod]
    public void DecoratorTest()
    {
        // Create ConcreteComponent and two Decorators
        ConcreteComponent c = new ConcreteComponent();
        ConcreteDecoratorA d1 = new ConcreteDecoratorA();
        ConcreteDecoratorB d2 = new ConcreteDecoratorB();

        // Link decorators
        d1.SetComponent(c);
        d2.SetComponent(d1);
        d2.Operation();
    }

    [TestMethod]
    public void ObserverTest()
    {
        // Configure Observer pattern
        ConcreteSubject s = new ConcreteSubject();
        s.Attach(new ConcreteObserver(s, "X"));
        s.Attach(new ConcreteObserver(s, "Y"));
        s.Attach(new ConcreteObserver(s, "Z"));

        // Change subject and notify observers
        s.SubjectState = "ABC";
        s.Notify();
    }

    [TestMethod]
    public void StrategyTest()
    {
        Context context;
        // Three contexts following different strategies
        context = new Context(new ConcreteStrategyA());
        context.ContextInterface();
        context = new Context(new ConcreteStrategyB());
        context.ContextInterface();
        context = new Context(new ConcreteStrategyC());
        context.ContextInterface();
    }

    [TestMethod]
    public void StateTest()
    {
        // Setup context in a state
        var context = new StateContext(new ConcreteStateA());
        // Issue requests, which toggles state
        context.Request();
        context.Request();
        context.Request();
        context.Request();
    }
}
