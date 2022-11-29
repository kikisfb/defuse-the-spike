using BombDefuse.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombDefuse
{
    public enum Validation { EMPTY, NOALPHA, ALPHA};
    public class GuessTheFlag : Puzzle
    {
        private string currentFlag = "";
        HashSet<string> flagsUsed = new ();

        /// <summary>
        /// GuessTheFlag default constructor.
        /// </summary>
        public GuessTheFlag() : base() { }   

        /// <summary>
        /// GuessTheFlag parameterized constructor.
        /// </summary>
        /// <param name="data">New PuzzleData ADT to be set.</param>
        public GuessTheFlag(PuzzleData data) : base(data) {}

        /// <summary>
        /// currentFlag member getter
        /// </summary>
        /// <returns>a string indicating the current flag of the GuessTheFlag object.</returns>
        public string GetCurrentFlag()
        {
            return currentFlag;
        }

        /// <summary>
        /// currentFlag member setter
        /// </summary>
        /// <param name="flag">the new string flag to be set.</param>
        public void SetCurrentFlag(string flag)
        {
            currentFlag = flag;
        }

        /// <summary>
        /// Checks if a given flag from input matches with the current.
        /// </summary>
        /// <param name="anotherFlag">string given by user input.</param>
        /// <returns>boolean indicating if they match or not.</returns>
        public bool FlagMatches(string anotherFlag)
        {
            return currentFlag == anotherFlag.ToLower();
        }

        /// <summary>
        /// Determines the type of Validation that an input matches with.
        /// </summary>
        /// <param name="input">string given by user input.</param>
        /// <returns>type of Validation (EMPTY, NOALPHA or ALPHA).</returns>
        public Validation TakeInput(string input)
        {
            Validation validation = Validation.ALPHA;

            if (String.IsNullOrEmpty(input)) { validation = Validation.EMPTY; }
            else if (input.Any(Char.IsDigit)) { validation = Validation.NOALPHA;  }

            return validation;
        }

        /// <summary>
        /// Algorithm to determine the next flag available in the module.
        /// </summary>
        /// <param name="random">pseudo-random number generator.</param>
        public void NextFlag(Random random)
        {
            string file = Resources.gflFlags;
            bool found = false;
            int index;

            if (flagsUsed.Count == 10)
                flagsUsed.Clear();

            string[] flags = file.Split("\r\n");
            while (!found)
            {
                index = random.Next(0, flags.Length);
                if (!flagsUsed.Contains(flags[index]))
                {
                    currentFlag = flags[index];
                    found = true;
                }
            }
        }

        /// <summary>
        /// Saves the current state of the game to a file using the flagsUsed HashSet of strings object.
        /// </summary>
        public void SaveState()
        {
            /* Save current state of the game */
            List<string> strings = new();
            if(flagsUsed.Count > 0)
            {
                strings.Add("Used");
                foreach (string flag in flagsUsed)
                {
                    strings.Add(flag);
                }
            }
            else
            {
                strings.Add("Not used");
            }

            strings.Add(currentFlag);
            strings.Add(data.GetMinutes().ToString());
            strings.Add(data.GetSeconds().ToString());

            File.WriteAllLines("gflState.txt", strings);
        }

        /// <summary>
        /// Loads the current state of the game into the flagsUsed HashSet of strings object from a file.
        /// </summary>
        public void ReadState()
        {
            string filePath = "gflState.txt";
            if(File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                int i = 0;
                if (lines[i++] == "Used")
                {
                    for (; i < lines.Length - 3; i++)
                    {
                        flagsUsed.Add(lines[i]);
                    }
                }
                currentFlag = lines[i];
                data.SetMinutes(int.Parse(lines[++i]));
                data.SetSeconds(int.Parse(lines[++i]));
            }
        }

        /// <summary>
        /// Adds the currentFlag member to the HashSet of strings object containing the flags that have been used.
        /// </summary>
        public void AddCurrentToUsed()
        {
            flagsUsed.Add(currentFlag);
        }
    }
}
