using System;

namespace RobotWars.Code
{
    public class Position
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("Position: ({0},{1})", X, Y);
        }

        public override bool Equals(object other)
        {
            var compareWith = other as Position;
            if (compareWith == null)
                return false;
            return this.X == compareWith.X && this.Y == compareWith.Y;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
