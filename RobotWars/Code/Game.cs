using System;

namespace RobotWars.Code
{
    public enum Instruction { L, R, M }

    public class Game
    {
        public Board Board { get; }

        public Robot Robot { get; set; }

        public Game(int boardHeight, int boardWidth)
        {
            Board = new Board(boardHeight, boardWidth);
        }

        public void CreateRobot(int x = 0, int y = 0, Heading heading = Heading.N)
        {
            Robot = new Robot(x, y, heading);
        }

        public void NextTurn(char instruction)
        {
            if (Enum.TryParse(instruction.ToString(), out Instruction temp))
                NextTurn(temp);
            else
                throw new InvalidInstructionException();
        }

        public void NextTurn(Instruction instruction)
        {
            if (Robot == null)
                return;

            switch (instruction)
            {
                case Instruction.L:
                    Robot.SpinLeft();
                    break;
                case Instruction.R:
                    Robot.SpinRight();
                    break;
                case Instruction.M:
                    var nextPosition = Robot.GetNextPosition();
                    if (Board.IsInsideBoundaries(nextPosition))
                        Robot.MoveToPosition(nextPosition);
                    else
                        Robot.Penalize();
                    break;
                default:
                    throw new InvalidInstructionException();
            }
        }
    }
}
