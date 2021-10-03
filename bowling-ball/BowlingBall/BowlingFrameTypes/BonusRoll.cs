
namespace BowlingBall.BowlingFrameTypes
{
    using System.Collections;
    using BowlingBall.FrameContract;

    public class BonusFrame : BowlingFrame
    {

        public BonusFrame(ArrayList throwPoints, int firstThrow) : base(throwPoints)
        {
            throwPoints.Add(firstThrow);
        }

        /// <summary>
        /// Gets frame score. As this will not be considered as individual frame
        /// </summary>
        /// <returns></returns>
        public override int FrameScore()
        {
            return 0;
        }

        /// <summary>
        /// Frame size
        /// </summary>
        /// <returns></returns>
        protected override int SizeOfFrame()
        {
            return 0;
        }
    }
}
