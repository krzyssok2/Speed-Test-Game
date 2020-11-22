using System;
using System.Collections.Generic;
using System.Text;
using TestSpeedGame.Models;

namespace TestSpeedGame.Utilities
{
    class GameRules
    {
        private PlayerModel Player;
        private GivenWordsModel GivenWords;
        public GameRules(PlayerModel player, GivenWordsModel givenwords)
        {
            Player = player;
            GivenWords = givenwords;
        }
        private bool GameOver = false;

        public void CheckGameOver()
        {
            if (Player.GetPlayerWords().Count == GivenWords.GetWordCount()) GameOver = true;
        }
        public void CheckPlayerInput(ConsoleKeyInfo PlayerInput)
        {
            switch (PlayerInput.Key)
            {
                case ConsoleKey.Backspace:
                    Player.DeleteLastInput();
                    break;
                case ConsoleKey.Spacebar:
                    Player.ResetUserInput();
                    GivenWords.IncreaseArrayLocation();
                    break;
                default:
                    Player.AddInputKey(PlayerInput.KeyChar);
                    break;
            }
        }
        public bool GetGameStatus()
        {
            return GameOver;
        }
    }
}
