using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Initial branch development
namespace BombDefuse
{
    public enum Key { EMPTY = '-', PLAYER = 'X', AI = 'O' };
    public enum Status { PLAYABLE = 0, WINNER = 1, STUCK = 2 };
    public struct TicStats
    {
        private Status Status;
        private Key Key;
        private int moves;

        /// <summary>
        /// status member getter.
        /// </summary>
        /// <returns>a Status enum datatype indicating the current status of the game.</returns>
        public Status GetStatus()
        {
            return Status;
        }

        /// <summary>
        /// key member getter.
        /// </summary>
        /// <returns>a Key enum datatype indicating the last player that made a move.</returns>
        public Key GetKey()
        {
            return Key;
        }

        /// <summary>
        /// moves member setter.
        /// </summary>
        /// <returns>an integer number indicating the amount of moves in the game.</returns>
        public int GetMoves()
        {
            return moves;
        }

        /// <summary>
        /// status member setter.
        /// </summary>
        /// <param name="status">the new Status datatype to be set.</param>
        public void SetStatus(Status status)
        {
            this.Status = status;
        }

        /// <summary>
        /// key member setter.
        /// </summary>
        /// <param name="key">the new Key datatype to be set.</param>
        public void SetKey(Key key)
        {
            this.Key = key;
        }

        /// <summary>
        /// moves member setter.
        /// </summary>
        /// <param name="moves">the integer number moves to be set.</param>
        public void SetMoves(int moves)
        {
            this.moves = moves;
        }
    }
    public class TicTacToe : Puzzle
    {
    }
}
