using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Todo.UnitTests;

[TestClass]
public class MoqTest
{

    [TestMethod]
    public void OkMockMethodTest(){
        // Given
        var mock = new Mock<IFoo>();
        mock.Setup(foo => foo.DoSomething("ping")).Returns(true);

        // When
        var actual = mock.Object.DoSomething("ping");

        // Then
        Assert.AreEqual(actual, true);
    }

    [TestMethod]
    public void KoMockMethodTest(){
        // Given
        var mock = new Mock<IFoo>();
        mock.Setup(foo => foo.DoSomething("ping")).Returns(true);

        // When
        var actual = mock.Object.DoSomething("pong");

        // Then
        Assert.AreEqual(actual, true);
    }

    [TestMethod]
    public void OkArgTest()
    {
        var mock = new Mock<IFoo>();

        // ref arguments
        var instance = new Bar();
        // Only matches if the ref argument to the invocation is the same instance
        mock.Setup(foo => foo.Submit(instance)).Returns(true);

        // When
        var actual = mock.Object.Submit(instance);

        // Then
        Assert.AreEqual(actual, true);
    }

    [TestMethod]
    public void KoArgTest()
    {
        var mock = new Mock<IFoo>();

        // ref arguments
        var instance = new Bar();
        // Only matches if the ref argument to the invocation is the same instance
        mock.Setup(foo => foo.Submit(instance)).Returns(true);

        // When
        var anotherIdenticalBar = new Bar();
        var actual = mock.Object.Submit(anotherIdenticalBar);

        // Then
        Assert.AreEqual(actual, true);
    }
}
