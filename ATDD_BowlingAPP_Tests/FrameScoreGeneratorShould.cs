using System.Collections.Generic;
using ATDD_BowlingAPP;
using ATDD_BowlingAPP.Models;
using NUnit.Framework;
using Shouldly;

namespace ATDD_BowlingAPP_Tests
{
    public class FrameScoreGeneratorShould
    {
        private readonly FrameScoreGenerator _frameScoreGenerator;
        private readonly Dictionary<string, ParsedFrames> _scoreExamples;

        public FrameScoreGeneratorShould()
        {
            _frameScoreGenerator = new FrameScoreGenerator();
            _scoreExamples = ScoreExamples.GetScoreExample();

        }

        [TestCase("Spares")]
        [TestCase("Strikes")]
        [TestCase("NormalWithStrikeAtStart")]
        [TestCase("Normal")]
        public void GenerateAListOfGameObjects(string input)
        {
            var result = _frameScoreGenerator.GenerateGame(_scoreExamples[input]);

            result.ShouldBeOfType<Game>();
        }

        [TestCase("Spares", 4)]
        [TestCase("Strikes", 5)]
        [TestCase("NormalWithStrikeAtStart", 10)]
        [TestCase("Normal", 3)]
        public void GenerateTheCorrectAmountOfRoundScoreObjects(string input, int numberOfInts)
        {
            var result = _frameScoreGenerator.GenerateGame(_scoreExamples[input]);

            result.Frames.Count.ShouldBe(numberOfInts);
        }
    }
}