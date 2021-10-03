
namespace BowlingBall
{
    using System.Collections;
    using BowlingBall.BowlingFrameTypes;
    using BowlingBall.FrameContract;
    using BowlingBall.FrameFactory;

    public class Game : IGame
    {
        // Frames in game
        ArrayList bowlingFrames;

        // Points earned in bowling game
        ArrayList bowlingThrowPoints;

        /// <summary>
        /// Initializes game
        /// </summary>
        public Game()
        {
            bowlingFrames = new ArrayList();
            bowlingThrowPoints = new ArrayList();
        }

        /// <summary>
        /// Adds regular frame
        /// </summary>
        /// <param name="firstThrow">First bowling throw</param>
        /// <param name="secondThrow">Second bowling throw</param>
        public void AddRegularFrame(int firstThrow, int secondThrow)
        {
            bowlingFrames.Add(ServiceLocator.GetInstance(typeof(RegularFrame).Name, bowlingThrowPoints, firstThrow, secondThrow));
        }        

        /// <summary>
        /// Calculates score of all frames for player
        /// </summary>
        /// <returns>Returns score</returns>
        public int GetScore()
        {
            int finalScore = 0;

            foreach (BowlingFrame frame in bowlingFrames)
            {
                finalScore += frame.FrameScore();
            }

            return finalScore;
        }

        /// <summary>
        /// Adds Spare frame to game
        /// </summary>
        /// <param name="firstThrow">First bowling throw</param>
        /// <param name="secondThrow">Second bowling throw</param>
        public void AddSpareFrame(int firstThrow, int secondThrow)
        {
            bowlingFrames.Add(new SpareFrame(bowlingThrowPoints, firstThrow, secondThrow));
        }

        /// <summary>
        /// Adds strike frame to game frames indicating all pins.
        /// </summary>
        public void AddStrikeFrame()
        {
            bowlingFrames.Add(ServiceLocator.GetInstance(typeof(StrikeFrame).Name, bowlingThrowPoints));
        }

        /// <summary>
        /// Adds bonusframe if tenth frame user scores 10 in two attempts
        /// </summary>
        /// <param name="score">Pin points scored</param>
        public void AddBonusFrame(int score)
        {
            bowlingFrames.Add(ServiceLocator.GetInstance(typeof(BonusFrame).Name, bowlingThrowPoints, score));
        }

        /// <summary>
        /// Initializes and adds frames to game
        /// </summary>
        /// <param name="firstThrowScore">First bowling throw</param>
        /// <param name="secondThrowScore">Second bowling throw</param>
        public void Roll(int firstThrowScore, int secondThrowScore)
        {
            if (firstThrowScore == 10)
            {
                AddStrikeFrame();
            }
            else if (firstThrowScore + secondThrowScore < 10)
            {
                AddRegularFrame(firstThrowScore, secondThrowScore);
            }
            else if (firstThrowScore + secondThrowScore == 10)
            {
                AddSpareFrame(firstThrowScore, secondThrowScore);
            }
        }
    }
}
