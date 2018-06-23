using System.Collections.Generic;
using ATDD_BowlingAPP;
using ATDD_BowlingAPP.Models;
using NUnit.Framework;
using Shouldly;

namespace ATDD_BowlingAPP_Tests
{
    [TestFixture]
    public class ScoreInputParserShould
    {
        private ScoreCardParser _scoreCardParser;

        [SetUp]
        public void BeforeEachTest()
        {
            _scoreCardParser = new ScoreCardParser();
        }

        [TestCase("11|11|11|11|11|11|11|11|11|11||")]
        [TestCase("11|11|11|11|11|11|11|11|11|11||11")]
        public void GenerateAParsedFramesObject(string scoreCard)
        {
            var result = _scoreCardParser.ParseToNormalAndBonusFrames(scoreCard);

            result.ShouldBeOfType<ParsedFrames>();
        }

        [TestCase("11|11|11|11|11|11|11|11|11|11||", 1)]
        [TestCase("11|11|11|11|11|11|11|11|11|11||11", 2)]
        public void SplitBonusRounds(string scoreCardString, int count)
        {
            var result = _scoreCardParser.SplitToFrameTypes(scoreCardString);

            result.ShouldBeOfType<List<string>>();
            result.Count.ShouldBe(count);
        }

        [Test]
        public void ReturnGameForGameWithBonusRounds()
        {
            var input = new List<string> {"11|11|11|11|11|11|11|11|11|11||", "11"};

            var result = _scoreCardParser.GameWithBonusRounds(input);

            result.ShouldBeOfType<ParsedFrames>();
            result.Frames.ShouldBeOfType<List<string>>();
            result.BonusFrames.ShouldBeOfType<List<string>>();
        }

        [Test]
        public void ReturnGameForGameWithoutBonusRounds()
        {
            var input = new List<string> { "11|11|11|11|11|11|11|11|11|11||", "11" };

            var result = _scoreCardParser.GameWithoutBonusRounds(input);

            result.ShouldBeOfType<ParsedFrames>();
            result.Frames.ShouldBeOfType<List<string>>();
            result.BonusFrames.ShouldBeOfType<List<string>>();
            result.BonusFrames.ShouldBeEmpty();
        }

        [TestCase("11|11|11|11|11|11|11|11|11|11||")]
        public void ReturnAListOfStringsFromTheInput(string input)
        {
            var result = _scoreCardParser.ParseToListOfFrames(input);

            result.ShouldBeOfType<List<string>>();
        }

        [TestCase("11", 2)]
        [TestCase("111", 3)]
        public void ReturnAListOfStringsFromBonusScores(string input, int count)
        {
            var result = _scoreCardParser.ParseBonusScoresToListOfFrames(input);

            result.ShouldBeOfType<List<string>>();
            result.Count.ShouldBe(count);
        }

        [TestCase("11|11|11|11|11|11|11|11|11|11||", 10)]
        [TestCase("12|13|11|14|11|11|15|11|11|11||", 10)]
        [TestCase("10|10|10|10|10|10|10|10|10|10||", 10)]
        [TestCase("10|10|10|10|10||", 5)]
        public void ReturnTheCorrectAmountOfIntsInAList(string input, int numberOfInts)
        {
            var result = _scoreCardParser.ParseToListOfFrames(input);

            result.Count.ShouldBe(numberOfInts);
        }
    }
}
