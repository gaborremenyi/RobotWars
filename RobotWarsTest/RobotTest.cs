using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Code;

namespace RobotWarsTest
{
    /// <summary>
    /// Summary description for RobotTest
    /// </summary>
    [TestClass]
    public class RobotTest
    {
        Robot robot;

        public RobotTest()
        {
            
        }

        [TestMethod]
        public void RobotGetNextPositionTest()
        {
            robot = new Robot(0, 0, Heading.N);
            Assert.AreEqual(new Position(0, 1), robot.GetNextPosition());           
        }

        [TestMethod]
        public void RobotMoveToPositionTest()
        {
            var nextPosition = new Position(0, 1);

            robot = new Robot(0, 0, Heading.N);
            robot.MoveToPosition(nextPosition);

            Assert.AreEqual(nextPosition, robot.Position);
        }

        [TestMethod]
        public void RobotSpinLeftTest()
        {
            robot = new Robot(0, 0, Heading.N);
            robot.SpinLeft();

            Assert.AreEqual(Heading.W, robot.Heading);
        }

        [TestMethod]
        public void RobotSpinRightTest()
        {
            robot = new Robot(0, 0, Heading.N);
            robot.SpinRight();

            Assert.AreEqual(Heading.E, robot.Heading);
        }

        [TestMethod]
        public void RobotPenalizeTest()
        {
            robot = new Robot(0, 0, Heading.N);
            robot.Penalize();

            Assert.AreEqual(1, robot.Penalties);
        }
    }
}
