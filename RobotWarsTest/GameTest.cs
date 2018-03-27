using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Code;
using System;

namespace RobotWarsTest
{
    /// <summary>
    /// Summary description for GameTest
    /// </summary>
    [TestClass]
    public class GameTest
    {
        Game game;

        public GameTest()
        {
            game = new Game(5, 5);
            game.CreateRobot();
        }

        [TestMethod]
        public void GameNextTurnTest()
        {
            try
            {
                game.NextTurn('M');
                game.NextTurn('L');
                game.NextTurn('R');
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
