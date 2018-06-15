using ATDD_BowlingAPP.ScoreCalculators;
using NUnit.Framework;
using Shouldly;

namespace ATDD_BowlingAPP_Tests
{
    [TestFixture]
    public class ScoreCalculatorShould
    {
        private ScoreCalculator _scoreCalulator;

        [SetUp]
        public void BeforeEachTest()
        {
            _scoreCalulator = new ScoreCalculator();
        }

        [TestCase("11|11|11|11|11|11|11|11|11|11||", 20)]
        [TestCase("12|11|11|11|11|11|11|11|11|11||", 21)]
        [TestCase("13|11|11|11|11|11|11|11|11|11||", 22)]
        [TestCase("1-|11|11|11|11|11|11|11|11|11||", 19)]
        [TestCase("1-|1-|1-|1-|1-|1-|1-|1-|1-|1-||", 10)]
        public void CalculateAScoreFromTheInput(string input, int score)
        {
            var result = _scoreCalulator.CalculateOverallGameScore(input);

            result.ShouldBe(score);
        }


        [TestCase("X|X|X|X|X|X|X|X|X|X||XX", 300)]
        [TestCase("X|81|81|81|81|81|81|81|81|81||", 109)]
        [TestCase("X|81|81|81|81|81|81|81|81|X||XX", 130)]
        public void CalculateAGameWithStrikesIn(string input, int score)
        {
            var result = _scoreCalulator.CalculateOverallGameScore(input);

            result.ShouldBe(score);
        }

        [TestCase("5/|5/|5/|5/|5/|5/|5/|5/|5/|5/||5", 150)]
        [TestCase("5/|51|51|51|51|51|51|51|51|51||", 69)]
        public void CalculateAGameWithSparesIn(string input, int score)
        {
            var result = _scoreCalulator.CalculateOverallGameScore(input);

            result.ShouldBe(score);
        }
    }
}
