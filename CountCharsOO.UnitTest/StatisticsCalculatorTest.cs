using System;
using NUnit.Framework;

namespace CountCharsOO.UnitTest
{
    public class StatisticsCalculatorTest
    {
        [Test]
        public void Test1()
        {
            var statisticsCalculator = new StatisticsCalculator();
            statisticsCalculator.Count("aabc");
            var actualTxt = statisticsCalculator.GetStatsText();
            var n = Environment.NewLine;
            var expectedTxt = $"a - 2{n}b - 1{n}c - 1{n}";
            Assert.AreEqual(expectedTxt, actualTxt);
        }

        [Test]
        public void TestNoInput()
        {
            var statisticsCalculator = new StatisticsCalculator();
            var actualTxt = statisticsCalculator.GetStatsText();
            var n = Environment.NewLine;
            var expectedTxt = "";
            Assert.AreEqual(expectedTxt, actualTxt);
        }
    }
}