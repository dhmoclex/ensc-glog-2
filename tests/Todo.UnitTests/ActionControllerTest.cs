using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Todo.UnitTests;

[TestClass]
public class ActionControllerTest
{
    [TestMethod]
    public void InboxTest()
    {
        var context = new DataContext();
        var controller = new ActionController(context);
        var answer = controller.GetInbox().Result.ToString();
        Assert.AreEqual(answer, "");
    }

    [TestMethod]
    public void InMemoryInboxTest()
    {
        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(databaseName: "TodoDatabase")
            .Options;

        var a = new Action
        {
            Id = 1,
            Name = "Action 1",
            IsInbox = true
        };
        var b = new Action
        {
            Id = 2,
            Name = "Action 2",
            IsInbox = true
        };
        var c = new Action
        {
            Id = 3,
            Name = "Action 3",
            IsInbox = false
        };

        // Insert seed data into the database using one instance of the context
        using (var context = new DataContext(options))
        {
            context.Actions.AddRange(a, b, c);
            context.SaveChanges();
        }

        // Use a clean instance of the context to run the test
        using (var context = new DataContext(options))
        {
            var controller = new ActionController(context);
            var result = controller.GetInbox().Result.Value?.ToList();
            CollectionAssert.AreEqual(result, new List<Action>() { a, b });
        }
    }
}
