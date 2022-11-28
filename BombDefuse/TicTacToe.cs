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
        private int amountStuck;

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

        public int GetAmountStuck()
        {
            return amountStuck;
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
        public void SetAmountStuck(int amountStuck)
        {
            this.amountStuck = amountStuck;
        }
    }
    public class TicTacToe : Puzzle
    {
        public TicStats stats;

        /// <summary>
        /// Default TicTacToe constructor.
        /// </summary>
        public TicTacToe() : base()
        {
            stats = new TicStats();
        }

        /// <summary>
        /// Parameterized TicTacToe constructor.
        /// </summary>
        /// <param name="data">new PuzzleData ADT to be set.</param>
        public TicTacToe(PuzzleData data) : base(data) { }

        /// <summary>
        /// Determines if a position in the grid is filled or not.
        /// </summary>
        /// <param name="x">1D index converted to height.</param>
        /// <param name="y">1D index converted to width.</param>
        /// <param name="board">the 2D grid being used in the game.</param>
        /// <returns>a boolean indicating if that position of the board is filled or not.</returns>
        private bool PositionFilled(int x, int y, Key[,] board)
        {
            if (board[x, y] != Key.EMPTY)
                return true;

            return false;
        }

        /// <summary>
        /// Determines the current status of the game from a specific player's perspective.
        /// </summary>
        /// <param name="board">the 2D grid being used in the game.</param>
        /// <param name="Key">last player to take a turn.</param>
        /// <returns>type of Status(PLAYABLE, WINNER or STUCK). </returns>
        private Status CheckGrid(Key[,] board, Key Key)
        {
            Status Status = Status.PLAYABLE;

            Key e = Key.EMPTY;

            if (board[0, 0] == Key && board[0, 1] == Key && board[0, 2] == Key)
                Status = Status.WINNER;
            else if (board[1, 0] == Key && board[1, 1] == Key && board[1, 2] == Key)
                Status = Status.WINNER;
            else if (board[2, 0] == Key && board[2, 1] == Key && board[2, 2] == Key)
                Status = Status.WINNER;
            else if (board[0, 0] == Key && board[1, 0] == Key && board[2, 0] == Key)
                Status = Status.WINNER;
            else if (board[0, 1] == Key && board[1, 1] == Key && board[2, 1] == Key)
                Status = Status.WINNER;
            else if (board[0, 2] == Key && board[1, 2] == Key && board[2, 2] == Key)
                Status = Status.WINNER;
            else if (board[0, 0] == Key && board[1, 1] == Key && board[2, 2] == Key)
                Status = Status.WINNER;
            else if (board[0, 2] == Key && board[1, 1] == Key && board[2, 0] == Key)
                Status = Status.WINNER;
            else if (board[0, 0] != e && board[0, 1] != e && board[0, 2] != e
                  && board[1, 0] != e && board[1, 1] != e && board[1, 2] != e
                  && board[2, 0] != e && board[2, 1] != e && board[2, 2] != e)
                Status = Status.STUCK;

            return Status;
        }

        /// <summary>
        /// Makes a player move given an index and key if the index is available.
        /// </summary>
        /// <param name="board">the 2D grid being used in the game.</param>
        /// <param name="index">1D index to be converted into a 2D index (height, width).</param>
        /// <param name="k">Key representing the current player that is making the move.</param>
        /// <returns>a boolean indicating if the move was successful or not.</returns>
        public bool PlayerMove(Key[,] board, int index, Key k)
        {
            int height = board.GetLength(0);

            int x = index / height;
            int y = index % height;

            if (PositionFilled(x, y, board))
                return false;
            else
            {
                board[x, y] = k;
                stats.SetMoves(stats.GetMoves() + 1);
                Status s = CheckGrid(board, k);

                stats.SetStatus(s);
                stats.SetKey(k);
                return true;
            }
        }

        /// <summary>
        /// Saves the current state of the game using the TicStats ADT and the grid.
        /// </summary>
        /// <param name="board">the 2D grid being used in the game.</param>
        public void SaveState(Key[,] board)
        {
            
        }

        /// <summary>
        /// Loads the state of the game into the TicStats ADT and the grid.
        /// </summary>
        /// <param name="board">the 2D grid that will be loaded from a file.</param>
        public void ReadState(Key[,] board)
        {
            
        }
    }
}
