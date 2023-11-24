using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DbSet<Action> Actions { get; set; }
    public DbSet<Context> Contexts { get; set; }
    public DbSet<Project> Projects { get; set; }

    public DataContext() : base()
    {
    }

    public DataContext(DbContextOptions options) : base(options)
    {
    }
}