using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Todo.UnitTests;

[TestClass]
public class ActionTest
{
    [TestMethod]
    public void VoidTest()
    {
        Console.WriteLine("Ce test ne fait rien.");
    }

    [TestMethod]
    public void NotImplementedTest()
    {
        throw new NotImplementedException();
    }

    [TestMethod]
    public void OkAddTest()
    {
        var a = 2;
        var b = 7;
        var result = a + b;
        if (result != 9)
            throw new Exception("L'addition n'est pas ok !");
    }

    [TestMethod]
    public void KoAddTest()
    {
        var a = 2;
        var b = 7;
        var result = a + b + 1;
        if (result != 9)
            throw new Exception("L'addition n'est pas ok !");
    }

    [TestMethod]
    public void AssertFailTest()
    {
        var a = 2;
        var b = 7;
        var result = a + b;
        if (result != 9)
            Assert.Fail();
    }

    [TestMethod]
    public void AreEqualTest()
    {
        var a = 2;
        var b = 7;
        var result = a + b;
        Assert.AreEqual(result, 9);
    }

    [TestMethod]
    public void KoAssertTest()
    {
        var a = 2;
        var b = 7;
        var result = a + b + 1;
        Assert.AreEqual(result, 9);
    }

    [TestMethod]
    public void CatchAssertTest()
    {
        try
        {
            var a = 2;
            var b = 7;
            var result = a + b + 1;
            Assert.AreEqual(result, 9);
        }
        catch (Exception)
        {
            // Just ignore the exception
        }
    }

    [TestMethod]
    public void AssertEqualCollectionTest()
    {
        var a = new List<int>() { 2, 4, 8 };
        var b = new List<int>() { 2, 4, 8 };
        Assert.AreEqual(a, b);
    }

    [TestMethod]
    public void CollectionAssertTest()
    {
        var a = new List<int>() { 2, 4, 8 };
        var b = new List<int>() { 2, 4, 8 };
        CollectionAssert.AreEqual(a, b);
    }

    [TestMethod]
    public void KoCollectionAssertTest()
    {
        var a = new List<int>() { 2, 4, 8 };
        var b = new List<int>() { 2, 4, 9 };
        CollectionAssert.AreEqual(a, b);
    }

    [TestMethod]
    public void KoUnorderedCollectionAssertTest()
    {
        var a = new List<int>() { 2, 4, 8 };
        var b = new List<int>() { 8, 4, 2 };
        CollectionAssert.AreEqual(a, b);
    }

    [TestMethod]
    public void EquivalentCollectionAssertTest()
    {
        var a = new List<int>() { 2, 4, 8 };
        var b = new List<int>() { 8, 4, 2 };
        CollectionAssert.AreEquivalent(a, b);
    }

    [TestMethod]
    public void ObjectAssertEqualTest()
    {
        var a = new Action();
        a.Id = 0;
        a.Name = "A faire";
        var b = new Action();
        b.Id = 0;
        b.Name = "A faire";
        Assert.AreEqual(a, b);
    }

    [TestMethod]
    public void AssertTest()
    {
        Assert.AreEqual(1, 1); // égalité entre entier
        Assert.AreEqual(3.14, 6.28 / 2); // égalité entre double
        Assert.AreEqual("une chaine", "une " + "chaine"); // égalité entre chaînes
        Assert.AreNotEqual(1, 2); // inégalité
        Assert.IsFalse(1 == 2); // booléen vaut faux
        Assert.IsTrue(1 <= 2); // booléen vaut vrai
        Action a = new();
        Action b = a;
        Assert.AreSame(a, b); // les références de l'objet sont identiques
        b = new();
        Assert.AreNotSame(a, b); // les références ne sont pas identiques
        Assert.IsInstanceOfType(a, typeof(Action)); // comparaison de type
        Assert.IsNotInstanceOfType(a, typeof(Project)); // différence de type
        Assert.IsNotNull(a); // différence à null
        Action? c = null;
        Assert.IsNull(c); // comparaison à null
    }

    [TestMethod]
    public void FluentTest()
    {
        var valeur = -1;
        valeur.Should().BeNegative();
        Assert.IsTrue(valeur < 0);

        Math.PI.Should().BeApproximately(3.14, 0.1);
        valeur.Should().BeInRange(-5, 5);
        "chaine".Should().Contain("i").And.Contain("e").And.NotStartWith("p");

        Action a = new();
        a.Name = "A faire";
        var plop = a.Should().BeOfType<Action>().Which.Name.Should().Be("A faire");

        string email = "nico@openclassrooms.com";
        email.Should().Match("*@*.com");

        DateTime.Now.Should().BeAfter(new DateTime(2000, 1, 1));
        var dateDeLivraison = DateTime.Now.AddDays(3);
        DateTime.Now.Should().BeAtLeast(TimeSpan.FromDays(2)).Before(dateDeLivraison);
    }
}
