using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleProject;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public void AddTest()
        {
            Assert.AreEqual(Program.Add(2,3),5);
        }

    [Test]
        public void MultTest()
    {
        Assert.AreEqual(Program.Mult(3, 5), 15);
    }
    }
}
