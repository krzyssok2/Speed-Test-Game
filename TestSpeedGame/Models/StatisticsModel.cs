using System;
using System.Collections.Generic;
using System.Text;
using TestSpeedGame.Utilities;

namespace TestSpeedGame.Models
{
    class StatisticsModel
    {
        private double NetWpm = 0;
        private int ErrorCount = 0;
        private int CorrectWords = 0;
        private int NumberOfChars = 0;
        public StatisticsModel(GivenWordsModel words, PlayerModel player)
        {
            GameCalculator gameCalculator = new GameCalculator();
            CorrectWords = gameCalculator.CalculateCorrectWords(words.GetWords(), player.GetPlayerWords());
            ErrorCount = gameCalculator.CalculateErrors(words.GetWords(), player.GetPlayerWords());
            NetWpm = gameCalculator.CalculateNumberOfChars(words.GetWords());
        }

        public double GetNetWpm()
        {
            return NetWpm;
        }
        public int GetErrorCount()
        {
            return ErrorCount;
        }
        public int GetCorrectWords()
        {
            return CorrectWords;
        }
    }
}
