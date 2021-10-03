
namespace BowlingBall.FrameFactory
{   
    using System.Collections;
    using BowlingBall.BowlingFrameTypes;
    using BowlingBall.FrameContract;

    class ServiceLocator
    {
        /// <summary>
        /// Factory that provides instance of frame to game based on type.
        /// </summary>
        /// <param name="frameType">Frame type</param>
        /// <param name="points">Points list till now</param>
        /// <param name="firstThrow">First score in frame</param>
        /// <param name="secondThrow">Second throw score</param>
        /// <returns>Instance of frame</returns>
        public static BowlingFrame GetInstance(string frameType, ArrayList points, int firstThrow =0, int secondThrow=0)
        {
            if(frameType == typeof(RegularFrame).Name)
            {
                return new RegularFrame(points, firstThrow, secondThrow);
            }
            if (frameType == typeof(RegularFrame).Name)
            {
                return new SpareFrame(points, firstThrow, secondThrow);
            }
            else if (frameType == typeof(StrikeFrame).Name)
            {
                return new StrikeFrame(points);
            }
            else
            {
                return new BonusFrame(points, firstThrow);
            }
        }
    }
}
