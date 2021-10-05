namespace BowlingBall
{
    /// <summary>
    /// IGame interface
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// Initializes and adds frames to game
        /// </summary>
        /// <param name="firstThrowScore">First bowling throw</param>
        /// <param name="secondThrowScore">Second bowling throw</param>
        void Roll(int firstThrowScore, int secondThrowScore);

        /// <summary>
        /// Adds bonusframe if tenth frame user scores 10 in two attempts
        /// </summary>
        /// <param name="score">Pin points scored</param>
        void AddBonusFrame(int score);

        /// <summary>
        /// Adds strike frame to game frames indicating all pins.
        /// </summary>
        void AddStrikeFrame();

        /// <summary>
        /// Adds Spare frame to game
        /// </summary>
        /// <param name="firstThrow">First bowling throw</param>
        /// <param name="secondThrow">Second bowling throw</param>
        void AddSpareFrame(int firstThrow, int secondThrow);

        /// <summary>
        /// Adds regular frame
        /// </summary>
        /// <param name="firstThrow">First bowling throw</param>
        /// <param name="secondThrow">Second bowling throw</param>
        void AddRegularFrame(int firstThrow, int secondThrow);

        /// <summary>
        /// Calculates score of all frames for player
        /// </summary>
        /// <returns>Returns score</returns>
        int GetScore();
    }
}
