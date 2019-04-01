using System;
using System.Collections.Generic;

namespace divisible
{
    public static class MathHelper
    {
        public static List<int> FindDivisible(int by, int min, int max)
        {
            var divisibles = new List<int>();
            int num1 = (min % by) == 0 ? min / by : (int)Math.Floor((decimal)min / by) + 1;
            int num2 = (max % by) == 0 ? max / by : max > 0 ? (int)Math.Floor((decimal)(max / by)) : (int)Math.Floor((decimal)(max / by)) - 1;

            var start = Math.Min(num1, num2);
            var end = Math.Max(num1, num2);
            var divisor = Math.Abs(by);
            for (var i = start; i <= end; i++)
            {
                divisibles.Add(i * divisor);
            }

            return divisibles;
        }
    }
}
