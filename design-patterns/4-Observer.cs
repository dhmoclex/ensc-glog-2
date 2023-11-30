using System.Collections.Generic;
using System.Diagnostics;

namespace design_patterns;

// The Observer design pattern defines a one-to-many dependency between objects so that when one object changes state,
// all its dependents are notified and updated automatically.






/// <summary>
/// The 'Subject' abstract class
/// </summary>
public abstract class Subject
{
    private List<Observer> observers = new List<Observer>();

    public void Attach(Observer observer)
    {
        observers.Add(observer);
    }

    public void Detach(Observer observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (Observer o in observers)
        {
            o.Update();
        }
    }
}

/// <summary>
/// The 'ConcreteSubject' class
/// </summary>
public class ConcreteSubject : Subject
{
    private string subjectState;

    // Gets or sets subject state
    public string SubjectState
    {
        get { return subjectState; }
        set { subjectState = value; }
    }
}

/// <summary>
/// The 'Observer' abstract class
/// </summary>
public abstract class Observer
{
    public abstract void Update();
}

/// <summary>
/// The 'ConcreteObserver' class
/// </summary>
public class ConcreteObserver : Observer
{
    private string name;
    private string observerState;
    private ConcreteSubject subject;

    // Constructor
    public ConcreteObserver(ConcreteSubject subject, string name)
    {
        this.subject = subject;
        this.name = name;
    }

    public override void Update()
    {
        observerState = subject.SubjectState;
        Debug.WriteLine("Observer {0}'s new state is {1}", name, observerState);
    }

    // Gets or sets subject
    public ConcreteSubject Subject
    {
        get { return subject; }
        set { subject = value; }
    }
}