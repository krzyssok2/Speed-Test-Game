using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TestSpeedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start the game!");
            Console.ReadKey();
            string[] words = new string[]
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
            int arrayLocation = 0;
            List<string> userWords = new List<string>();
            string userInput="";
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            while (words.Length != userWords.Count)
            {
                Console.Clear();
                for(int i= arrayLocation; i<words.Length;i++)
                {
                    Console.Write(words[i]+" ");
                }
                Console.WriteLine();
                Console.WriteLine(userInput + "\n");
                ConsoleKeyInfo userKey = new ConsoleKeyInfo();
                userKey=Console.ReadKey();
                if (userKey.Key == ConsoleKey.Backspace) 
                {
                    if (userInput.Length - 1 >= 0) userInput = userInput[0..^1];
                }
                else if(userKey.Key==ConsoleKey.Spacebar)
                {
                    userWords.Add(userInput);
                    userInput = "";
                    arrayLocation++;
                }
                else userInput += userKey.KeyChar;
            }
            stopWatch.Stop();
            int correctWords = 0;
            int wrongWords = 0;
            for(int i=0;i<words.Length;i++)
            {
                if (words[i] == userWords[i]) correctWords++;
                else wrongWords++;
            }
            int errors = 0;
            int numberOfChar = 0;
            for(int i=0;i<words.Length;i++)
            {
                numberOfChar += words[i].Length;
                for(int j=0;j<userWords[i].Length;j++)
                {
                    if (words[i][j] != userWords[i][j]) errors++;
                    if (words[i].Length - 1 == j) break;
                }
                errors += Math.Abs(words[i].Length - userWords[i].Count());
            }

            double NetWpm= ((numberOfChar / 5) -errors)/ stopWatch.Elapsed.TotalMinutes;
            NetWpm = Math.Round(NetWpm);
            if (NetWpm < 0) NetWpm = 0;
            Console.WriteLine("Words per minute: " + NetWpm);
            Console.WriteLine("Correct words: " + correctWords);
            Console.WriteLine("wrong words: " + wrongWords);
            Console.WriteLine("Elapsed time: " + stopWatch.Elapsed.TotalSeconds);
            Console.WriteLine("errors: " + errors);


            Console.ReadKey();
        }
    }
}
