using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Todo.UnitTests;

[TestClass]
public class ActionControllerTest
{
    static DbContextOptions<DataContext> options = new DbContextOptionsBuilder<DataContext>()
        .UseInMemoryDatabase(databaseName: "TodoDatabase")
        .Options;

    readonly Action a = new Action
    {
        Id = 1,
        Name = "Action 1",
        IsInbox = true
    };
    readonly Action b = new Action
    {
        Id = 2,
        Name = "Action 2",
        IsInbox = true
    };
    readonly Action c = new Action
    {
        Id = 3,
        Name = "Action 3",
        IsInbox = false
    };

    [TestInitialize()]
    public void Setup()
    {
        // This method will be called before each MSTest test method
        using var context = new DataContext(options);
        context.Actions.AddRange(a, b, c);
        context.SaveChanges();
    }

    [TestMethod]
    public void ThisIsOneTest()
    {
        using var context = new DataContext(options);
        var controller = new ActionController(context);
        var result = controller.GetInbox().Result.Value?.ToList();
        CollectionAssert.AreEqual(result, new List<Action>() { a, b });
    }
}
