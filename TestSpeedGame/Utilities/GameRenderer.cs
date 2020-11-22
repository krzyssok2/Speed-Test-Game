using System;
using System.Collections.Generic;
using System.Text;
using TestSpeedGame.Models;

namespace TestSpeedGame.Utilities
{
    class GameRenderer
    {
        public void RenderGameStart()
        {
            Console.WriteLine("Welcome to typing speed test!");
            Console.WriteLine("You will be given words to type, make sure you type them correctly");
            Console.WriteLine("Pressing space after a word will shift sentence and save your word");
            Console.WriteLine("Press any button to start!");
            Console.ReadKey();
        }
        public void RenderClearConsole()
        {
            Console.Clear();
        }
        public void RenderCurrentWords(GivenWordsModel words)
        {
            for (int i = words.GetArrayLocation(); i < words.GetWordCount(); i++)
            {
                Console.Write(words.GetWordsByIndex(i)+" ");
            }
            Console.WriteLine();
        }
        public void RenderPlayerInput(PlayerModel player)
        {
            Console.WriteLine(player.GetPlayerInput() + "\n");
        }
        public void RenderEndGame(StatisticsModel statistics, double time)
        {
            Console.WriteLine("Words per minute: " + statistics.GetNetWpm());
            Console.WriteLine("Correct words: " + statistics.GetCorrectWords());
            Console.WriteLine("Mistake count: " + statistics.GetErrorCount());
            Console.WriteLine("Elapsed time: " + time + " seconds");
        }
    }
}
