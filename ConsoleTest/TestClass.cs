using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ConsoleProject;

namespace ConsoleTest
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public void AddTest()
        {
            Assert.AreEqual(ConsoleProject.Add(2,3),5);
        }
    }
}
