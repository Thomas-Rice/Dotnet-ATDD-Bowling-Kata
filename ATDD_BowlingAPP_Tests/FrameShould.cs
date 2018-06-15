using ATDD_BowlingAPP.Models;
using NUnit.Framework;
using Shouldly;

namespace ATDD_BowlingAPP_Tests
{
    [TestFixture]
    public class FrameShould
    {
        [TestCase('1', '1')]
        public void ReturnAFrameObject(char bowlOne, char bowlTwo)
        {
            var result = new Frame(bowlOne, bowlTwo);

            result.ShouldBeOfType<Frame>();
        }

        [TestCase('1', '1', Frame.FrameTypes.Normal)]
        [TestCase('1', '-', Frame.FrameTypes.Miss)]
        [TestCase('1', '/', Frame.FrameTypes.Spare)]
        [TestCase('X', '0', Frame.FrameTypes.Strike)]
        public void SetSpecificFrameType(char bowlOne, char bowlTwo, Frame.FrameTypes frameType)
        {
            var result = new Frame(bowlOne, bowlTwo);

            result.FrameType.ShouldBe(frameType);
        }

        [TestCase('5', '/', 5,5, 10)]
        [TestCase('1', '/', 1, 9, 10)]
        [TestCase('9', '/', 9, 1, 10)]
        [TestCase('3', '/', 3, 7, 10)]
        public void SetCorrectScoresForSpare(char bowlOne, char bowlTwo, int bowlOneScore, int bowlTwoScore, int overallScore)
        {
            var result = new Frame(bowlOne, bowlTwo);

            result.BowlOneScore.ShouldBe(bowlOneScore);
            result.BowlTwoScore.ShouldBe(bowlTwoScore);
            result.OverallScore.ShouldBe(overallScore);
        }

        [TestCase('X', '0', 10, 0, 10)]
        public void SetCorrectScoresForStrike(char bowlOne, char bowlTwo, int bowlOneScore, int bowlTwoScore, int overallScore)
        {
            var result = new Frame(bowlOne, bowlTwo);

            result.BowlOneScore.ShouldBe(bowlOneScore);
            result.BowlTwoScore.ShouldBe(bowlTwoScore);
            result.OverallScore.ShouldBe(overallScore);
        }

        [TestCase('3', '-', 3, 0, 3)]
        [TestCase('-', '3', 0, 3, 3)]
        [TestCase('-', '-', 0, 0, 0)]
        public void SetCorrectBowlScoresForMiss(char bowlOne, char bowlTwo, int bowlOneScore, int bowlTwoScore, int overallScore)
        {
            var result = new Frame(bowlOne, bowlTwo);

            result.BowlOneScore.ShouldBe(bowlOneScore);
            result.BowlTwoScore.ShouldBe(bowlTwoScore);
            result.OverallScore.ShouldBe(overallScore);
        }

        [TestCase('1', '3', 1, 3, 4)]
        [TestCase('8', '1', 8, 1, 9)]
        [TestCase('1', '8', 1, 8, 9)]
        public void SetCorrectBowlScoresForNormal(char bowlOne, char bowlTwo, int bowlOneScore, int bowlTwoScore, int overallScore)
        {
            var result = new Frame(bowlOne, bowlTwo);

            result.BowlOneScore.ShouldBe(bowlOneScore);
            result.BowlTwoScore.ShouldBe(bowlTwoScore);
            result.OverallScore.ShouldBe(overallScore);
        }

    }
}
