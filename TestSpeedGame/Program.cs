using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TestSpeedGame.Models;
using TestSpeedGame.Utilities;

namespace TestSpeedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRenderer renderer = new GameRenderer();

            GivenWordsModel givenWords = new GivenWordsModel();

            PlayerModel player = new PlayerModel();

            GameRules gameRules = new GameRules(player, givenWords);

            ClockModel clock = new ClockModel();

            renderer.RenderGameStart();
            clock.StartClock();
            while (!gameRules.GetGameStatus())
            {
                renderer.RenderClearConsole();
                renderer.RenderCurrentWords(givenWords);
                renderer.RenderPlayerInput(player);

                ConsoleKeyInfo userKey = Console.ReadKey();
                gameRules.CheckPlayerInput(userKey);
                gameRules.CheckGameOver();
            }
            clock.StopClock();

            StatisticsModel statistics = new StatisticsModel(givenWords, player);

            renderer.RenderEndGame(statistics, clock.GetTimeInSeconds());
            Console.ReadKey();

        }
    }
}
