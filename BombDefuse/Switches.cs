using BombDefuse.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombDefuse
{
    public class Switches : Puzzle
    {
        //Switches default constructor
        public Switches() : base()
        {

        }

        //Switches parameterized constructor
        public Switches(PuzzleData data) : base(data)
        {

        }


        //Saves the current state of the game to a a file
        public void SaveState(bool[] states)
        {
            string fileName = "SaveFileSwitches.txt";
            string[] switchStateString = convertBoolToString(states);
            
            File.WriteAllLines(fileName, switchStateString);
            File.AppendAllText(fileName, $"\n{data.GetMinutes()}\n{data.GetSeconds()}");
            
        }

        //Reads the current state of the game from a file
        public bool[] ReadState()
        {
            string fileName = "SaveFileSwitches.txt";
            string[] lines = { "", "", "", "", "", "", "", "", "", "", "", ""};
            string[] stringStates = { "", "", "", "", "", "", "", "", "", "" };
            bool[] boolStates = new bool[10];

            if (File.Exists(fileName))
            {
                lines = File.ReadAllLines(fileName);

                for (int i = 0; i < 10; i++)
                {
                    stringStates[i] = lines[i];
                }

                data.SetMinutes(int.Parse(lines[11]));
                data.SetSeconds(int.Parse(lines[12]));

                boolStates = convertStringToBool(stringStates);
            }

            return boolStates;
        }

        private string[] convertBoolToString(bool[] states)
        {
            string[] array = new string[10];

            for (int i = 0; i < 10; i++)
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
            bool[] array = new bool[10];

            for (int i = 0; i < 10; i++)
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
