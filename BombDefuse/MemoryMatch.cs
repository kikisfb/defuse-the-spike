using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombDefuse
{
    //test branch push
    public class MemoryMatch : Puzzle
    {
        private int flippedPairs;
        private int turns;

        public MemoryMatch()
        {
            turns = 0;
        }

        public int getFlippedPairs()
        {
            return this.flippedPairs;
        }

        public void setFlippedPairs(int flippedPairs)
        {
            this.flippedPairs = flippedPairs;
        }

        public void setTurns(int turns)
        {
            this.turns = turns;
        }

        public int getTurns()
        {
            return this.turns;
        }

        public void SaveToFile(bool[] buttonStates)
        {
            string fileName = "SaveFileMM.txt";
            string flippedPair = Convert.ToString(flippedPairs);
            string[] buttonStateString = convertBoolToString(buttonStates);
            File.WriteAllLines(fileName, buttonStateString);
            File.AppendAllText(fileName, flippedPair);
            File.AppendAllText(fileName, $"\n{data.GetMinutes()}\n{data.GetSeconds()}");
        }

        public bool[] ReadFromFile()
        {

            string fileName = "SaveFileMM.txt";
            string[] lines = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "};
            string[] buttonState = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "};
            bool[] buttonStates = new bool[16];
            if (File.Exists(fileName))
            {
                lines = File.ReadAllLines(fileName);
                for (int i = 0; i < 16; i++)
                {
                    buttonState[i] = lines[i];
                }
                flippedPairs = int.Parse(lines[16]);
                data.SetMinutes(int.Parse(lines[17]));
                data.SetSeconds(int.Parse(lines[18]));
                buttonStates = convertStringToBool(buttonState);
            }
            return buttonStates;
        }

        public static MemoryMatch operator ++(MemoryMatch mm)
        {
            mm.turns++;
            return mm;
        }
        public void IncrementPairs()
        {
            flippedPairs++;
        }

        private string[] convertBoolToString(bool[] buttonStates)
        {
            string[] array = new string[16];
            for(int i = 0; i < 16; i++)
            {
                if (buttonStates[i] == true)
                {
                    array[i] = "true";
                }
                else
                {
                    array[i] = "false";
                }
            }
            return array;
        }
        private bool[] convertStringToBool(string[] buttonStateString)
        {
            bool[] buttonStates = new bool[16];
            for(int i = 0; i < 16; i++)
            {
                if (buttonStateString[i] == "true")
                {
                    buttonStates[i] = true;
                }
                else
                {
                    buttonStates[i] = false;
                }
            }
            return buttonStates;
        }
    }
}
