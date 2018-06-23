using System;
using System.Collections.Generic;
using ATDD_BowlingAPP;
using ATDD_BowlingAPP.Models;
using NUnit.Framework;
using Shouldly;

namespace ATDD_BowlingAPP_Tests
{
    public class FrameGeneratorShould
    {
        private readonly FrameGenerator _frameGenerator;
        private readonly Dictionary<string, List<IConvertedFrame>> _scoreExamples;

        public FrameGeneratorShould()
        {
            _frameGenerator = new FrameGenerator();
            _scoreExamples = ConvertedFramesExamples.GetScoreExample();

        }

        [TestCase("Strikes")]
        [TestCase("Normal")]
        [TestCase("Spares")]
        [TestCase("NormalWithStrikeAtStart")]
        public void GenerateAListOfFrames(string input)
        {
            var result = _frameGenerator.GenerateFrames(_scoreExamples[input]);

            result.ShouldBeOfType<List<Frame>>();
        }

        [TestCase("Strikes", 3)]
        [TestCase("Normal", 3)]
        [TestCase("Spares", 3)]
        [TestCase("NormalWithStrikeAtStart", 4)]
        public void ReturnTheCorrectAmountOfFrames(string input, int count)
        {
            var result = _frameGenerator.GenerateFrames(_scoreExamples[input]);

            result.Count.ShouldBe(count);
        }
    }
}