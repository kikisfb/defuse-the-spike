using System;
using System.Collections.Generic;
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

        public void SaveToFile()
        {

        }

        public void ReadFromFile()
        {

        }

        public bool checkButtonStatus(Button button)
        {
            return true;
        }

        public static MemoryMatch operator ++(MemoryMatch mm)
        {
            mm.turns++;
            return mm;
        }
    }
}
