using System;
using System.Collections.Generic;
using System.Text;

namespace CountCharsOO
{
    public class StatisticsCalculator
    {
        private int[] _counts;

        public StatisticsCalculator()
        {
            var characterAsciiValueMax = 255;
            _counts = new int[characterAsciiValueMax];
        }

        public void Count(string text)
        {
            foreach (var character in text)
            {
                _counts[character]++;
            }
        }

        public string GetStatsText()
        {
            var txt = new StringBuilder();
            for (var i = 0; i < _counts.Length; i++)
            {
                if (_counts[i] > 0)
                {
                    var character = (char)i;
                    txt.AppendLine(character + " - " + _counts[i]);
                }
            }

            return txt.ToString();
        }
    }
}
