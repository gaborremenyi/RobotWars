using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Code;

namespace RobotWarsTest
{
    [TestClass]
    public class HeadingTest
    {
        [TestMethod]
        public void HeadingRightTest()
        {
            Heading north = Heading.N;
            Heading east = north.Right();
            Assert.AreEqual(Heading.E, east);
        }

        [TestMethod]
        public void HeadingLeftTest()
        {
            Heading north = Heading.N;
            Heading west = north.Left();
            Assert.AreEqual(Heading.W, west);
        }
    }
}
