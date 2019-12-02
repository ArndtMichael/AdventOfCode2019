using System;
using System.IO;
using System.Reflection;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Assembly.GetCallingAssembly().GetManifestResourceStream("Day1.Data.txt") ?? throw new ArgumentNullException();
            uint requiredFuel = 0;
            uint iterations = 0;

            using (var reader = new StreamReader(input))
            {
                string lineAsString;
                do
                {
                    lineAsString = reader.ReadLine();
                    if (lineAsString != null)
                    {
                        var moduleMass = uint.Parse(lineAsString);
                        requiredFuel += (moduleMass / 3) - 2;
                        iterations++;
                    }

                } while (lineAsString != null);
            }

            Console.WriteLine($" {requiredFuel} calculated in {iterations} iterations");
            Console.ReadKey();
        }
    }
}
