using System.Data;

public class Action
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DueDate { get; set; }
    public Context? Context { get; set; }
    public Project? Project { get; set; }
    public bool IsInbox { get; set; }
    public bool IsScheduled { get; set; }

    public bool IsValid()
    {
        if (IsInbox)
        {
            return (Context == null) && (Project == null);
        }
        else if (IsScheduled)
        {
            return Context == null;
        }
        else
        {
            return Context != null;
        }
    }

    // override object.Equals
    public override bool Equals(Object? obj)
    {
        if (obj is not Action action)
        {
            return false;
        }
        return (Id == action.Id)
            && (Name == action.Name)
            && (DueDate == action.DueDate)
            && (Context?.Id == action.Context?.Id)
            && (Project?.Id == action.Project?.Id)
            && (IsInbox == action.IsInbox)
            && (IsScheduled == action.IsScheduled);
    }
}
