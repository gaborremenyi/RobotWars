namespace RobotWars.Code
{
    public class Board
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public Board(int width, int height)
        {
            Height = height;
            Width = width;
        }

        public bool IsInsideBoundaries(Position position)
        {
            return position.X >= 0 && position.Y >= 0 && position.X < Width && position.Y < Height;
        }
    }
}
