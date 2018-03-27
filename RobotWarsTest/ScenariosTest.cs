using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Code;

namespace RobotWarsTest
{
    /// <summary>
    /// Summary description for ScenariosTest
    /// </summary>
    [TestClass]
    public class ScenariosTest
    {
        Game game;

        public ScenariosTest()
        {
            game = new Game(5, 5);
        }

        [TestMethod]
        public void Scenario1()
        {
            var instructions = "MLMRMMMRMMRR".ToCharArray();
            try
            {
                game.CreateRobot(0, 2, Heading.E);

                foreach (char instruction in instructions)
                {
                    game.NextTurn(instruction);
                }

                // Position:  4, 1
                Assert.AreEqual(new Position(4, 1), game.Robot.Position);

                // Heading:   N
                Assert.AreEqual(Heading.N, game.Robot.Heading);

                // Penalties: 0
                Assert.AreEqual(0, game.Robot.Penalties);
            }
            catch (Exception) { Assert.Fail(); }
        }

        [TestMethod]
        public void Scenario2()
        {
            var instructions = "LMLLMMLMMMRMM".ToCharArray();
            try
            {
                game.CreateRobot(4, 4, Heading.S);

                foreach (char instruction in instructions)
                {
                    game.NextTurn(instruction);
                }

                // Position:  0, 1
                Assert.AreEqual(new Position(0, 1), game.Robot.Position);

                // Heading:   W
                Assert.AreEqual(Heading.W, game.Robot.Heading);

                // Penalties: 1
                Assert.AreEqual(1, game.Robot.Penalties);
            }
            catch (Exception) { Assert.Fail(); }
        }

        [TestMethod]
        public void Scenario3()
        {
            var instructions = "MLMLMLMRMRMRMRM".ToCharArray();
            try
            {
                game.CreateRobot(2, 2, Heading.W);

                foreach (char instruction in instructions)
                {
                    game.NextTurn(instruction);
                }

                // Position:  2, 2
                Assert.AreEqual(new Position(2, 2), game.Robot.Position);

                // Heading:   N
                Assert.AreEqual(Heading.N, game.Robot.Heading);

                // Penalties: 0
                Assert.AreEqual(0, game.Robot.Penalties);
            }
            catch (Exception) { Assert.Fail(); }
        }

        [TestMethod]
        public void Scenario4()
        {
            var instructions = "MMLMMLMMMMM".ToCharArray();
            try
            {
                game.CreateRobot(1, 3, Heading.N);

                foreach (char instruction in instructions)
                {
                    game.NextTurn(instruction);
                }

                // Position:  0, 0
                Assert.AreEqual(new Position(0, 0), game.Robot.Position);

                // Heading:   S
                Assert.AreEqual(Heading.S, game.Robot.Heading);

                // Penalties: 3
                Assert.AreEqual(3, game.Robot.Penalties);
            }
            catch (Exception) { Assert.Fail(); }
        }
    }
}
