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
    }
}
