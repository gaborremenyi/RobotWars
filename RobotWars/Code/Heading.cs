using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Code
{
    public enum Heading { N, E, S, W }

    public static class HeadingExtension
    {
        public static Heading Right(this Heading heading)
        {
            Heading[] values = (Heading[])Enum.GetValues(heading.GetType());
            int current = Array.IndexOf(values, heading) + 1;
            return (values.Length == current) ? values[0] : values[current];
        }

        public static Heading Left(this Heading heading)
        {
            Heading[] values = (Heading[])Enum.GetValues(heading.GetType());
            int current = Array.IndexOf(values, heading) - 1;
            return (current < 0) ? values[values.Length - 1] : values[current];
        }
    }
}
