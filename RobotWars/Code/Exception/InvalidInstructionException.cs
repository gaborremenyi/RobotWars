using System;

namespace RobotWars.Code
{
    public class InvalidInstructionException : Exception
    {
        const string defaultMessage = "Invalid instruction detected. (Valid: 'L', 'R' and 'M'";

        public InvalidInstructionException() : base(defaultMessage) { }

        public InvalidInstructionException(string message) : base(message) { }
    }
}
