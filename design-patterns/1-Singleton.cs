namespace design_patterns;

// The Singleton design pattern ensures a class has only one instance and provide a global point of access to it.



/// <summary>
/// The 'Singleton' class
/// </summary>
public class Singleton
{
    static Singleton instance;

    // Constructor is 'protected'
    protected Singleton() { }

    public static Singleton Instance()
    {
        // Uses lazy initialization.
        // Note: this is not thread safe.
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}
