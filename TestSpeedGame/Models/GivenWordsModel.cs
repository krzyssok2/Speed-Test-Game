using System;
using System.Collections.Generic;
using System.Text;

namespace TestSpeedGame.Models
{
    class GivenWordsModel
    {
        private int ArrayLocation=0;
        private readonly string[] Words = new string[]
            {
                "some",
                "body",
                "once",
                "told",
                "me",
                "that",
                "world",
                "is",
                "gonna",
                "roll",
                "me",
                "I",
                "am",
                "not",
                "sharpest",
                "tool",
                "in",
                "the",
                "shed"
            };


        public string GetWordsByIndex(int index)
        {
            return Words[index];
        }
        public string[] GetWords()
        {
            return Words;
        }
        public int GetWordCount()
        {
            return Words.Length;
        }
        public void IncreaseArrayLocation()
        {
            ArrayLocation++;
        }
        public int GetArrayLocation()
        {
            return ArrayLocation;
        }
    }
}
