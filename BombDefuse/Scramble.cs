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
        private string[] words;

        private string pickedWord;
        private string[] WinningWords;
        int numberInArray;
        public Scramble()
        {
            string wordFile = Resources.words;

            words = wordFile.Split("\r\n");

            Random random = new Random();
            numberInArray = random.Next(words.Length);
            pickedWord = words[numberInArray];
            string File;
            if (numberInArray == 0)
                File = Resources.TradeWordCombinations;
            else if (numberInArray == 1)
                File = Resources.LeadsWordCombinations;
            else
                File = Resources.TearsWordCombinations;

            WinningWords = File.Split("\r\n");
        }
        public void SaveFile()
        {
            File.WriteAllText("wordSaved.txt", pickedWord);
            File.AppendAllText("wordSaved.txt", $"\n{data.GetMinutes()}\n{data.GetSeconds()}");

        }
        public string readFile()
        {
            string[] line = {" "};
           
            if (File.Exists("wordSaved.txt"))
            {
                 line = File.ReadAllLines("wordSaved.txt");
                
                pickedWord = line[0];
                
                data.SetMinutes(int.Parse(line[1]));
                data.SetSeconds(int.Parse(line[2]));
                string Files;
                if (pickedWord == "TRADE")
                    Files = Resources.TradeWordCombinations;
                else if (pickedWord == "LEADS")
                    Files = Resources.LeadsWordCombinations;
                else
                    Files = Resources.TearsWordCombinations;

                WinningWords = Files.Split("\r\n");

            }

            return line[0];

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
        public string[] getWinningWords()
        {
            return WinningWords;
        }
    }
}
