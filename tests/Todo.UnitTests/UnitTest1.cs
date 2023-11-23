using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Todo.UnitTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
    }
    [TestMethod]
    public void TestMethod2()
    {
        throw new Exception("error");
    }
}