
namespace BowlingBall.BowlingFrameTypes
{
    using System.Collections;
    using BowlingBall.FrameContract;

    class SpareFrame : BowlingFrame
    {
        public SpareFrame(ArrayList throwPoints, int firstThrow, int secondThrow) : base(throwPoints)
        {
            throwPoints.Add(firstThrow);
            throwPoints.Add(secondThrow);
        }

        /// <summary>
        /// Calculate score for frame
        /// </summary>
        /// <returns></returns>
        public override int FrameScore()
        {
            return Bonus_Point + GetBonusForFrame();
        }

        /// <summary>
        /// Gets size of frame
        /// </summary>
        /// <returns></returns>
        protected override int SizeOfFrame()
        {
            return 2;
        }

        /// <summary>
        /// Next throw score
        /// </summary>
        /// <returns></returns>
        private int GetBonusForFrame()
        {
            return (int)throwPoints[initialThrowIndex + 2];
        }
    }
}
