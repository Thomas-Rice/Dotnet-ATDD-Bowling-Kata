//using ATDD_BowlingAPP;
//using ATDD_BowlingAPP.Models;
//using NUnit.Framework;
//using Shouldly;

//namespace ATDD_BowlingAPP_Tests
//{
//    [TestFixture]
//    public class FrameObjectGeneratorShould
//    {
//        private FrameObjectGenerator _frameObjectgenerator;

//        [SetUp]
//        public void BeforeEachTest()
//        {
//            _frameObjectgenerator = new FrameObjectGenerator();
//        }

//        [Test]
//        public void ReturnFrameObjectForNormalScores()
//        {
//            var scores = new[] {'1', '2'};

//            var result = _frameObjectgenerator.NormalTwoBowlFrame(scores);

//            result.ShouldBeOfType<Frame>();
//        }

//        [Test]
//        public void ReturnCorrectScoresForNormalTwoBowlRound()
//        {
//            var scores = new[] { '1', '2' };

//            var result = _frameObjectgenerator.NormalTwoBowlFrame(scores);

//            result.BowlOneScore.ShouldBe(1);
//            result.BowlTwoScore.ShouldBe(2);
//            result.IsSpare.ShouldBe(false);
//            result.IsStrike.ShouldBe(false);
//            result.OverallScore.ShouldBe(0);
//        }

//        [TestCase(new[]{'1','-'})]
//        [TestCase(new[]{'-','1'})]
//        public void ReturnFrameObjectForFrameWithMisses(char[] scores)
//        {
//            var result = _frameObjectgenerator.FrameWithMisses(scores);

//            result.ShouldBeOfType<Frame>();
//        }

//        [TestCase(new[] { '1', '-' }, 1, 0)]
//        [TestCase(new[] { '-', '1' }, 0, 1)]
//        public void ReturnCorrectScoresForFrameWithMisses(char[] scores, int bowlOneScore, int bowlTwoScore)
//        {
//            var result = _frameObjectgenerator.FrameWithMisses(scores);

//            result.BowlOneScore.ShouldBe(bowlOneScore);
//            result.BowlTwoScore.ShouldBe(bowlTwoScore);
//            result.IsSpare.ShouldBe(false);
//            result.IsStrike.ShouldBe(false);
//            result.OverallScore.ShouldBe(0);
//        }

//        [Test]
//        public void ReturnFrameObjectForFrameWithStrike()
//        {
//            var result = _frameObjectgenerator.FameWithStrike();

//            result.ShouldBeOfType<Frame>();
//        }

//        [TestCase(10, 0)]
//        public void ReturnCorrectScoresForFrameWithStrike(int bowlOneScore, int bowlTwoScore)
//        {
//            var result = _frameObjectgenerator.FameWithStrike();

//            result.BowlOneScore.ShouldBe(bowlOneScore);
//            result.BowlTwoScore.ShouldBe(bowlTwoScore);
//            result.IsSpare.ShouldBe(false);
//            result.IsStrike.ShouldBe(true);
//            result.OverallScore.ShouldBe(0);
//        }

//        [TestCase(new[] { '1', '/' })]
//        public void ReturnFrameObjectForFrameWithSpare(char[] scores)
//        {
//            var result = _frameObjectgenerator.FrameWithSpare(scores);

//            result.ShouldBeOfType<Frame>();
//        }

//        [TestCase(new[] { '1', '/' }, 1, 9)]
//        [TestCase(new[] { '9', '/' }, 9, 1)]
//        public void ReturnCorrectScoresForFrameWithSpare(char[] scores, int bowlOneScore, int bowlTwoScore)
//        {
//            var result = _frameObjectgenerator.FrameWithSpare(scores);

//            result.BowlOneScore.ShouldBe(bowlOneScore);
//            result.BowlTwoScore.ShouldBe(bowlTwoScore);
//            result.IsSpare.ShouldBe(true);
//            result.IsStrike.ShouldBe(false);
//            result.OverallScore.ShouldBe(0);
//        }

//        [TestCase(new[] {'1'})]
//        public void ReturnFrameObjectForBonusSpare(char[] scores)
//        {
//            var result = _frameObjectgenerator.BonusRoundWithSpare(scores);

//            result.ShouldBeOfType<Frame>();
//        }

//        [TestCase(new[] { '1' }, 1, 0)]
//        public void ReturnCorrectScoresForBonusSpare(char[] scores, int bowlOneScore, int bowlTwoScore)
//        {
//            var result = _frameObjectgenerator.BonusRoundWithSpare(scores);

//            result.BowlOneScore.ShouldBe(bowlOneScore);
//            result.BowlTwoScore.ShouldBe(bowlTwoScore);
//            result.IsSpare.ShouldBe(true);
//            result.IsStrike.ShouldBe(false);
//            result.OverallScore.ShouldBe(0);
//        }

//    }
//}
