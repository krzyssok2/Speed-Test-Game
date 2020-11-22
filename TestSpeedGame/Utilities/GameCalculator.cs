using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSpeedGame.Utilities
{
    public class GameCalculator
    {
        public int CalculateCorrectWords(string[] words, List<string> PlayerWords)
        {
            int correctWords=0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == PlayerWords[i]) correctWords++;
            }
            return correctWords;
        }
        public int CalculateWrongsWords(string[] words, List<string> PlayerWords)
        {
            int wrongWords = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != PlayerWords[i]) wrongWords++;
            }
            return wrongWords;
        }
        public int CalculateErrors(string[] words, List<string> PlayerWords)
        {
            int errors=0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < PlayerWords[i].Length; j++)
                {
                    if (words[i][j] != PlayerWords[i][j]) errors++;
                    if (words[i].Length - 1 == j) break;
                }
                errors += Math.Abs(words[i].Length - PlayerWords[i].Count());
            }
            return errors;
        }
        public double CalculateNetWpm(int numberOfChars, int numberOfErrors, double time)
        {
            double netWpm = ((numberOfChars / 5) - numberOfErrors) / time;
            netWpm = Math.Round(netWpm);
            if (netWpm < 0) netWpm = 0;
            return netWpm;
        }
        public int CalculateNumberOfChars(string[] words)
        {
            int numberofChars = 0;
            for(int i=0;i<words.Length;i++)
            {
                numberofChars += words[i].Length;
            }
            return numberofChars;
        }
    }
}
