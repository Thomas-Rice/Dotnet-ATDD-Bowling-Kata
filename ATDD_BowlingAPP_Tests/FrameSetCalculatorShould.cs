using System.Collections.Generic;
using ATDD_BowlingAPP;
using ATDD_BowlingAPP.Models;
using NUnit.Framework;
using Shouldly;

namespace ATDD_BowlingAPP_Tests
{
    public class FrameSetCalculatorShould
    {
        private readonly FrameSetCalculator _frameSetCalculator;
        private readonly Dictionary<string, ParsedFrames> _scoreExamples;

        public FrameSetCalculatorShould()
        {
            _frameSetCalculator = new FrameSetCalculator();
            _scoreExamples = ScoreExamples.GetScoreExample();

        }

        [TestCase("Normal")]
        public void GenerateAListOfFrames(string input)
        {
            var result = _frameSetCalculator.GenerateFrames(_scoreExamples[input].Frames, false);

            result.ShouldBeOfType<List<Frame>>();
        }

        [TestCase("Normal", false)]
        public void ReturnTheCorrectAmountOfFrames(string input, bool isBonus)
        {
            var result = _frameSetCalculator.GenerateFrames(_scoreExamples[input].Frames, isBonus);

            result.Count.ShouldBe(3);
        }

        [TestCase("Strikes")]
        public void GenerateAListOfBonusFrames(string input)
        {
            var result = _frameSetCalculator.GenerateFrames(_scoreExamples[input].BonusFrames, true);

            result.ShouldBeOfType<List<Frame>>();
        }

        [TestCase("Bonus", true)]
        public void ReturnTheCorrectAmountOfBonusFrames(string input, bool isBonus)
        {
            var result = _frameSetCalculator.GenerateFrames(_scoreExamples[input].BonusFrames, isBonus);

            result.Count.ShouldBe(1);
        }

    }
}