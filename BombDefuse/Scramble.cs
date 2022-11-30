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
            for(int i = 0; i < WinningWords.Length; i++)
            {
                File.AppendAllText("wordSaved.txt", $"\n{WinningWords[i]}");
            }
            
            
        }
        public string readFile()
        {
            string[] line;
            if (pickedWord == "TRADE")
            {
                line = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            }
            else if(pickedWord=="LEADS")
            {
                line = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };

            }
            else
            {
                line = new string[16] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };

            }

            if (File.Exists("wordSaved.txt"))
            {
                line = File.ReadAllLines("wordSaved.txt");
                pickedWord = line[0];
                data.SetMinutes(int.Parse(line[1]));
                data.SetSeconds(int.Parse(line[2]));
                int linenum = 3;
                for (int i = 0; linenum<line.Length; i++)
                {
                    if (line[linenum]!=" ")
                    {
                        WinningWords[i] = line[linenum];
                    }
                    linenum++;
                }
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
