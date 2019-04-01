using System;
using System.Text;

namespace divisible
{
    public static class Outputter
    {
        static readonly string[] _unitsMap = new[] {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };
        static readonly string[] _tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        public static string NumberToEnglish(int num)
        {
            if (num == 0)
                return "zero";

            if (num < 0)
                return "minus " + NumberToEnglish(Math.Abs(num));

            var builder = new StringBuilder();
            if ((num / 1000000) > 0)
            {
                builder.Append(NumberToEnglish(num / 1000000) + " million ");
                num %= 1000000;
            }

            if ((num / 1000) > 0)
            {
                builder.Append(NumberToEnglish(num / 1000) + " thousand ");
                num %= 1000;
            }

            if ((num / 100) > 0)
            {
                builder.Append(NumberToEnglish(num / 100) + " hundred ");
                num %= 100;
            }

            if (num > 0)
            {
                if (num < 20)
                    builder.Append(_unitsMap[num]);
                else
                {
                    builder.Append(_tensMap[num / 10]);
                    if ((num % 10) > 0)
                        builder.Append("-" + _unitsMap[num % 10]);
                }
            }

            return builder.ToString();
        }
    }
}
