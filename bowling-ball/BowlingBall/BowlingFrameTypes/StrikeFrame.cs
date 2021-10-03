
namespace BowlingBall.BowlingFrameTypes
{
    using System.Collections;
    using BowlingBall.FrameContract;

    public class StrikeFrame : BowlingFrame
    {
        public StrikeFrame(ArrayList throwPoints) : base(throwPoints)
        {
            this.throwPoints = throwPoints;
            initialThrowIndex = throwPoints.Count;
            throwPoints.Add(10);
        }

        /// <summary>
        /// Calculates score of frame
        /// </summary>
        /// <returns>Final fram escore</returns>
        public override int FrameScore()
        {
            return 10 + FirstBonusBall() + SecondBonusBall();
        }

        /// <summary>
        /// Gets size of frame
        /// </summary>
        /// <returns>Frame Size</returns>
        protected override int SizeOfFrame()
        {
            return 1;
        }

    }
}
