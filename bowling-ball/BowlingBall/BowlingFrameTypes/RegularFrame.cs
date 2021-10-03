
namespace BowlingBall.BowlingFrameTypes
{
    using System.Collections;
    using BowlingBall.FrameContract;

    class RegularFrame : BowlingFrame
    {
        public RegularFrame(ArrayList throwPoints, int firstThrow, int secondThrow) : base(throwPoints)
        {            
            throwPoints.Add(firstThrow);
            throwPoints.Add(secondThrow);
        }

        /// <summary>
        /// Calculate frame score
        /// </summary>
        /// <returns>Frame score</returns>
        public override int FrameScore()
        {
            return (int)throwPoints[initialThrowIndex] + (int)throwPoints[initialThrowIndex + 1];
        }

        /// <summary>
        /// Size of frame
        /// </summary>
        /// <returns></returns>
        protected override int SizeOfFrame()
        {
            return 2;
        }

    }
}
