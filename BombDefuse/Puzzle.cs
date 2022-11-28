using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombDefuse
{
    /// <summary>
    /// PuzzleData ADT to facilitate communication between Main and Puzzle interfaces.
    /// </summary>
    public struct PuzzleData
    {
        private int id = -1;
        private bool completionStatus = false;
        private bool activityStatus = false;
        private int minutes = 0;
        private int seconds = 0;

        /// <summary>
        /// Default PuzzleData constructor
        /// </summary>
        public PuzzleData() { }

        /// <summary>
        /// This method changes the PuzzleData ADT's id to a given id.
        /// </summary>
        /// <param name="id">the new integer number id.</param>
        public void SetId(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// This method changes the PuzzleData ADT's completionStatus to a given status.
        /// </summary>
        /// <param name="completionStatus">the new boolean completion status.</param>
        public void SetCompletionStatus(bool completionStatus)
        {
            this.completionStatus = completionStatus;
        }

        /// <summary>
        /// This method changes the PuzzleData ADT's activityStatus to a given status.
        /// </summary>
        /// <param name="activityStatus">the new boolean activity status.</param>
        public void SetActivityStatus(bool activityStatus)
        {
            this.activityStatus = activityStatus;
        }

        /// <summary>
        /// This method returns the id of the ADT.
        /// </summary>
        /// <returns>an integer indicating the id of the PuzzleData ADT.</returns>
        public int GetId()
        {
            return id;
        }
        /// <summary>
        /// This method returns the completion status of the ADT.
        /// </summary>
        /// <returns>a boolean indicating the completion status of the PuzzleData ADT.</returns>
        public bool GetCompletionStatus()
        {
            return completionStatus;
        }

        /// <summary>
        /// This method returns the activity status of the ADT.
        /// </summary>
        /// <returns>a boolean indicating the activity status of the PuzzleData ADT.</returns>
        public bool GetActivityStatus()
        {
            return activityStatus;
        }

        public int GetMinutes()
        {
            return minutes;
        }

        public int GetSeconds()
        {
            return seconds;
        }

        public void SetMinutes(int minutes)
        {
            this.minutes = minutes;
        }

        public void SetSeconds(int seconds)
        {
            this.seconds = seconds;
        }
    }
    public abstract class Puzzle
    {
        public PuzzleData data;

        /// <summary>
        /// Default Puzzle class constructor
        /// </summary>
        public Puzzle()
        {
            data = new PuzzleData();
        }

        /// <summary>
        /// Parameterized Puzzle class constructor
        /// </summary>
        /// <param name="data">PuzzleData ADT with non-default values.</param>
        public Puzzle(PuzzleData data)
        {
            this.data = data;
        }
    }
}
