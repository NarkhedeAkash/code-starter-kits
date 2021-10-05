using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
        IGame game;

        public GameFixture()
        {
        }

        /// <summary>
        /// Initialize Game using TestInitialize
        /// </summary>
        [TestInitialize]
        public void SetUpGame()
        {
            game = new Game();
        }

        /// <summary>
        /// Checks for all regular frames with no score
        /// </summary>
        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            Roll(game, 0, 0, 10);
            Assert.AreEqual(0, game.GetScore());
        }

        /// <summary>
        /// Checks for Spare and Regular frame combination frame
        /// </summary>
        [TestMethod]
        public void CheckSpareANdRegularScroeEquals23_Test()
        {
            game.AddSpareFrame(5, 5);
            game.AddRegularFrame(4, 5);
            InitializeMultipleRegularFrames(8, 0, 0);
            Assert.AreEqual<int>(23, game.GetScore());
        }

        /// <summary>
        /// Checks for all Regular frames with 2 pins score
        /// </summary>
        [TestMethod]
        public void Gutter_Game_All_Regular_Frames_Test()
        {
            InitializeMultipleRegularFrames(10, 2, 2);
            Assert.AreEqual<int>(40, game.GetScore());
        }

        /// <summary>
        /// Check for Spare and Regular frame combination of frame
        /// </summary>
        [TestMethod]
        public void CheckSpareAndRegularFrameScoreEquals27_Test()
        {
            InitializeMultipleRegularFrames(8, 0, 0);
            game.AddSpareFrame(4, 6);
            game.AddRegularFrame(8, 1);
            Assert.AreEqual<int>(27, game.GetScore());
        }

        /// <summary>
        /// Check for strike and spare combination of frame
        /// </summary>
        [TestMethod]
        public void CheckStrikeAndRegularEquals24_Test()
        {
            game.AddStrikeFrame();
            game.AddRegularFrame(6, 1);
            InitializeMultipleRegularFrames(8, 0, 0);
            Assert.AreEqual<int>(24, game.GetScore());
        }

        /// <summary>
        /// Check for spare in last frame test
        /// </summary>
        [TestMethod]
        public void CheckSpareFinalFrameEquals19_Test()
        {
            InitializeMultipleRegularFrames(9, 0, 0);
            game.AddSpareFrame(2, 8);
            game.AddBonusFrame(9);
            Assert.AreEqual<int>(19, game.GetScore());
        }

        /// <summary>
        /// Check for all strike frames
        /// </summary>
        [TestMethod]
        public void CheckForAllStrikeFrameEquals300_Test()
        {
            for (int i = 0; i < 10; i++)
                game.AddStrikeFrame();
            game.AddBonusFrame(10);
            game.AddBonusFrame(10);
            Assert.AreEqual<int>(300, game.GetScore());
        }

        /// <summary>
        /// Check for alternate strike and spare frame combination
        /// </summary>
        [TestMethod]
        public void CheckStrikeAndSpareFrameEquals200_Test()
        {
            for (int i = 0; i < 5; i++)
            {
                game.AddStrikeFrame();
                game.AddSpareFrame(1, 9);
            }
            game.AddBonusFrame(10);
            Assert.AreEqual<int>(200, game.GetScore());
        }

        /// <summary>
        /// Check for strike frame in last last test
        /// </summary>
        [TestMethod]
        public void CheckRegularAndStrikeFinalFrameEquals24_Test()
        {
            InitializeMultipleRegularFrames(9, 0, 0);
            game.AddStrikeFrame();
            game.AddBonusFrame(6);
            game.AddBonusFrame(8);
            Assert.AreEqual<int>(24, game.GetScore());
        }

        /// <summary>
        /// Generate multiple regular frames
        /// </summary>
        /// <param name="count">Totale frames</param>
        /// <param name="firstThrow">First throw score</param>
        /// <param name="secondThrow">Second throw score</param>
        private void InitializeMultipleRegularFrames(int count, int firstThrow, int secondThrow)
        {
            for (int frame = 0; frame < count; frame++)
                game.AddRegularFrame(firstThrow, secondThrow);
        }

        /// <summary>
        /// Start game
        /// </summary>
        /// <param name="game">Game obj</param>
        /// <param name="firstThrow">First throw value</param>
        /// <param name="secondThrow">second throw value</param>
        /// <param name="times">No of frames</param>
        private void Roll(IGame game, int firstThrow, int secondThrow, int times)
        {
            for (int i = 0; i < times; i++)
            {
                game.Roll(firstThrow, secondThrow);
            }
        }
    }
}
