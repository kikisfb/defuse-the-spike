using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombDefuse
{
    public class Battleship : Puzzle
    {
        private int turnsRemaining;

        public Battleship()
        {
            turnsRemaining = 10;
        }

        public void setTurns(int turnsRemaining)
        {
            this.turnsRemaining = turnsRemaining;
        }

        public int getTurns()
        {
            return this.turnsRemaining;
        }

        public static Battleship operator --(Battleship bat)
        {
            bat.turnsRemaining--;
            return bat;
        }

        public void SaveState(bool[] battleshipStates)
        {
            string fileName = "SaveFileBattleship.txt";

            string remainingTurns = getTurns().ToString();
            //string remainingTurns2 = Convert.ToString(turnsRemaining);

            string[] battleshipStatesString = convertBoolToString(battleshipStates);

            File.WriteAllLines(fileName, battleshipStatesString);
            File.AppendAllText(fileName, remainingTurns);
            File.AppendAllText(fileName, $"\n{data.GetMinutes()}\n{data.GetSeconds()}");
        }

        public bool[] ReadState()
        {
            string fileName = "SaveFileBattleship.txt";
            string[] lines = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
            string[] stringStates = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
            bool[] boolStates = new bool[16];

            if (File.Exists(fileName))
            {
                lines = File.ReadAllLines(fileName);

                for (int i = 0; i < 16; i++)
                {
                    stringStates[i] = lines[i];
                }

                setTurns(int.Parse(lines[16]));
                data.SetMinutes(int.Parse(lines[17]));
                data.SetSeconds(int.Parse(lines[18]));

                boolStates = convertStringToBool(stringStates);
            }

            return boolStates;
        }

        private string[] convertBoolToString(bool[] states)
        {
            string[] array = new string[16];

            for (int i = 0; i < 16; i++)
            {
                if (states[i] == true)
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

        private bool[] convertStringToBool(string[] states)
        {
            bool[] array = new bool[16];

            for (int i = 0; i < 16; i++)
            {
                if (states[i] == "true")
                {
                    array[i] = true;
                }

                else
                {
                    array[i] = false;
                }
            }

            return array;
        }
    }
}
