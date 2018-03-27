using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Code;

namespace RobotWarsTest
{
    /// <summary>
    /// Summary description for BoardTest
    /// </summary>
    [TestClass]
    public class BoardTest
    {
        const int boardWidth = 10;
        const int boardHeight = 10;

        Board board;

        public BoardTest()
        {
            board = new Board(boardWidth, boardHeight);
        }

        [TestMethod]
        public void BoundariesTest()
        {
            var validPositions = new List<Position>();

            for (int i = 0; i < boardWidth; i++)
                for (int j = 0; j < boardHeight; j++)
                    validPositions.Add(new Position(i, j));

            Console.WriteLine("Test Boundaries");

            // test all valid positions inside the boundary
            foreach (var validPosition in validPositions)
            {
                Console.WriteLine(string.Format("Valid Postion: {0}", validPosition.ToString()));
                Assert.IsTrue(board.IsInsideBoundaries(validPosition));
            }

            // test some invalid positions outside the boundary
            var invalidPostions = new List<Position>() {
                new Position(-1, -1),
                new Position(0, boardHeight),
                new Position(boardWidth, 0),
                new Position(boardWidth, boardHeight)
            };

            foreach (var invalidPostion in invalidPostions)
            {
                Console.WriteLine(string.Format("Invalid Postion: {0}", invalidPostion.ToString()));
                Assert.IsFalse(board.IsInsideBoundaries(invalidPostion));
            }
        }
    }
}
