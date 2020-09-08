using System;

namespace CountCharsOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var statisticsCalculator = new StatisticsCalculator();
            while (true)
            {
                var text = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(text)) break;
                statisticsCalculator.Count(text);
                var txt = statisticsCalculator.GetStatsText();
                Console.WriteLine(txt);
            }
        }
    }
}
