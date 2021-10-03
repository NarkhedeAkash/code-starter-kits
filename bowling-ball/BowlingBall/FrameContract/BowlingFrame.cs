namespace BowlingBall.FrameContract
{
    using System.Collections;

    abstract public class BowlingFrame
    {
        /// <summary>
        /// Points earned in throws in all frames
        /// </summary>
        protected ArrayList throwPoints;

        /// <summary>
        /// Start throw 
        /// </summary>
        protected int initialThrowIndex;

        /// <summary>
        /// Bonus point
        /// </summary>
        public const int Bonus_Point = 10;

        public BowlingFrame(ArrayList _throwPoints)
        {
            throwPoints = _throwPoints;
            initialThrowIndex = _throwPoints.Count;
        }

        /// <summary>
        /// Calculates the score of frame based on type of frame and will be overidden in child impl
        /// </summary>
        /// <returns>Final result of game</returns>
        public abstract int FrameScore();

        /// <summary>
        /// Fetches frame size for spare of stike frame
        /// </summary>
        /// <returns></returns>
        protected abstract int SizeOfFrame();

        /// <summary>
        /// Gets score of first throw after strike
        /// </summary>
        /// <returns>Score of throw</returns>
        protected int FirstBonusBall()
        {
            return (int)throwPoints[initialThrowIndex + SizeOfFrame()];
        }

        /// <summary>
        /// Gets score of second throw after stike
        /// </summary>
        /// <returns>Score of throw</returns>
        protected int SecondBonusBall()
        {
            return (int)throwPoints[initialThrowIndex + SizeOfFrame() + 1];
        }
    }
}
