using System.Collections.Generic;
using System.Linq;
using ATDD_BowlingAPP;
using ATDD_BowlingAPP.Enums;
using ATDD_BowlingAPP.ScoreCalculators;
using NUnit.Framework;
using Shouldly;

namespace ATDD_BowlingAPP_Tests
{
    [TestFixture]
    public class FrameSymbolConverterShould
    {
        private FrameSymbolConverter _frameSymblConverter;

        [SetUp]
        public void BeforeEachTest()
        {
            _frameSymblConverter = new FrameSymbolConverter();
        }

        [Test]
        public void ReturnAListOfConvertedFrames()
        {
            var test = new List<string>
            {
                "11",
                "11"
            };

            var result = _frameSymblConverter.ConvertSymbols(test);

            result.ShouldBeOfType<List<IConvertedFrame>>();
        }


        [Test]
        public void CreateANormalGame()
        {
            var normalGame = new List<string>
            {
                "12",
            };

            var result = _frameSymblConverter.ConvertSymbols(normalGame);

            result.FirstOrDefault()?.Frame.FirstOrDefault().ShouldBe(1);
            result.FirstOrDefault()?.Frame.LastOrDefault().ShouldBe(2);
            result.FirstOrDefault()?.FrameResults.ShouldBe(FrameType.Normal);
        }

        [Test]
        public void CreateASpareGame()
        {
            var normalGame = new List<string>
            {
                "1/",
            };

            var result = _frameSymblConverter.ConvertSymbols(normalGame);

            result.FirstOrDefault()?.Frame.FirstOrDefault().ShouldBe(1);
            result.FirstOrDefault()?.Frame.LastOrDefault().ShouldBe(9);
            result.FirstOrDefault()?.FrameResults.ShouldBe(FrameType.Spare);
        }

        [Test]
        public void CreateAStrikeGame()
        {
            var normalGame = new List<string>
            {
                "X",
            };

            var result = _frameSymblConverter.ConvertSymbols(normalGame);

            result.FirstOrDefault()?.Frame.FirstOrDefault().ShouldBe(10);
            result.FirstOrDefault()?.Frame.LastOrDefault().ShouldBe(0);
            result.FirstOrDefault()?.FrameResults.ShouldBe(FrameType.Strike);
        }

        [Test]
        public void CreateAMissGame()
        {
            var normalGame = new List<string>
            {
                "1-",
            };

            var result = _frameSymblConverter.ConvertSymbols(normalGame);

            result.FirstOrDefault()?.Frame.FirstOrDefault().ShouldBe(1);
            result.FirstOrDefault()?.Frame.LastOrDefault().ShouldBe(0);
            result.FirstOrDefault()?.FrameResults.ShouldBe(FrameType.Miss);
        }

        //Too Big?
        [Test]
        public void CalculateARangeOfScores()
        {
            var normalGame = new List<string>
            {
                "11",
                "1-",
                "1/",
                "X"
            };

            var result = _frameSymblConverter.ConvertSymbols(normalGame);

            result.FirstOrDefault()?.Frame.FirstOrDefault().ShouldBe(1);
            result.FirstOrDefault()?.Frame.LastOrDefault().ShouldBe(1);
            result.FirstOrDefault()?.FrameResults.ShouldBe(FrameType.Normal);
            result[1].Frame.FirstOrDefault().ShouldBe(1);
            result[1].Frame.LastOrDefault().ShouldBe(0);
            result[1].FrameResults.ShouldBe(FrameType.Miss);
            result[2].Frame.FirstOrDefault().ShouldBe(1);
            result[2].Frame.LastOrDefault().ShouldBe(9);
            result[2].FrameResults.ShouldBe(FrameType.Spare);
            result[3].Frame.FirstOrDefault().ShouldBe(10);
            result[3].Frame.LastOrDefault().ShouldBe(0);
            result[3].FrameResults.ShouldBe(FrameType.Strike);
        }



    }
}
