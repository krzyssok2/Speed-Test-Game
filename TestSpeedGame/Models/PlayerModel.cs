using System;
using System.Collections.Generic;
using System.Text;

namespace TestSpeedGame.Models
{
    class PlayerModel
    {
        List<string> PlayerWords = new List<string>();
        private string PlayerInput="";

        public string GetPlayerInput()
        {
            return PlayerInput;
        }
        public void AddInputKey(char key)
        {
            PlayerInput += key;
        }
        public void ResetUserInput()
        {
            PlayerWords.Add(PlayerInput);
            PlayerInput = "";
        }
        public void DeleteLastInput()
        {
            PlayerInput = PlayerInput[0..^1];
        }
        public List<string> GetPlayerWords()
        {
            return PlayerWords;
        }

    }
}
