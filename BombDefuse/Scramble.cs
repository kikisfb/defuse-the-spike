using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombDefuse
{
    public class Scramble : Puzzle
    {
        private string pickedWord;
        private string[] WinningWords;

        public Scramble()
        {
            string[] words = File.ReadAllLines("words.txt");
            Random random = new Random();
            int numberInArray = random.Next(words.Length);
            pickedWord = words[numberInArray];
           // if (numberInArray == 0)
                WinningWords = File.ReadAllLines("TradeWordCombinations.txt");
           // else if (numberInArray == 1)
           //     WinningWords = File.ReadAllLines("LeadsWordCombinations.txt");
           // else
           //     WinningWords = File.ReadAllLines("TearsWordCombinations.txt");
        }

        public bool checkGuess(string guess)
        {

            bool result = false;
            for (int i = 0; i < WinningWords.Length; i++)
            {
                if (WinningWords[i] == guess)
                    result = true;
            }
            return result;
        }
        public string getWord()
        {
            return pickedWord;
        }
    }
}
