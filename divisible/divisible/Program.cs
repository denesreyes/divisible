using System;

namespace divisible
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            Console.WriteLine("Lets find divisible of a given number within the provided range.");

            while (again)
            {
                try
                {
                    Console.Write("Enter minimum range. For example, -100, 5... I choose: ");
                    string min = Console.ReadLine();

                    Console.Write("Enter maximum range. For example, -5, 100... I choose: ");
                    string max = Console.ReadLine();

                    Console.Write("Enter divisible number. For example, -3, 6... I choose: ");
                    string by = Console.ReadLine();
                    Console.WriteLine("");

                    Console.WriteLine("Calculating...");
                    Console.WriteLine("");
                    var numbers = MathHelper.FindDivisible(Convert.ToInt32(by), Convert.ToInt32(min), Convert.ToInt32(max));
                    Console.WriteLine("Results are as follow: ");
                    for(var i = numbers.Count; i > 0; i--)
                    {
                        Console.WriteLine(Outputter.NumberToEnglish(numbers[i-1]));
                    }

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("That was fun lets calculate some more?");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong. {ex.Message}");
                }

                Console.Write("Continue? Yes or No?: ");
                string restart = Console.ReadLine();
                if (restart.ToLower() == "no") { again = false; }
            }
        }
    }
}
