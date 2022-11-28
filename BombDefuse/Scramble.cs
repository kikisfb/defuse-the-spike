using BombDefuse.Properties;
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
            string wordFile = Resources.words;

            string[] words = wordFile.Split("\r\n");

            Random random = new Random();
            int numberInArray = random.Next(words.Length);
            pickedWord = words[numberInArray];
            string File;
          //  if (numberInArray == 0)
                File = Resources.TradeWordCombinations;
          //  else if (numberInArray == 1)
           //     File = Resources.LeadsWordCombinations;
          //  else
            //    File = Resources.TearsWordCombinations;

            WinningWords = File.Split("\r\n");
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
