namespace RobotWars.Code
{
    public class Robot
    {
        const int DEFAULT_SPEED = 1;

        public Position Position { get; set; }

        public Heading Heading { get; set; }

        public int Penalties { get; set; }

        public Robot(int x, int y, Heading heading = Heading.N)
        {
            Position = new Position(x, y);
            Heading = heading;
            Penalties = 0;
        }

        public Position GetNextPosition(int speed = DEFAULT_SPEED)
        {
            switch (Heading)
            {
                case Heading.N:
                    return new Position(Position.X, Position.Y + speed);
                case Heading.E:
                    return new Position(Position.X + speed, Position.Y);
                case Heading.S:
                    return new Position(Position.X, Position.Y - speed);
                case Heading.W:
                    return new Position(Position.X - speed, Position.Y);
                default:
                    return null;
            }
        }

        public void MoveToPosition(Position position)
        {
            this.Position = position;
        }

        public void SpinLeft()
        {
            this.Heading = this.Heading.Left();
        }

        public void SpinRight()
        {
            this.Heading = this.Heading.Right();
        }

        public void Penalize()
        {
            this.Penalties++;
        }
    }
}
