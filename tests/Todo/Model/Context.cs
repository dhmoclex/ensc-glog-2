public class Context
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Action> Actions { get; set; }

    public Context()
    {
        Actions = new();
    }
}
