using System.Collections.Generic;
using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP
{
    public class FrameScoreGenerator
    {
        private readonly FrameSetCalculator _framesGenerator;

        public FrameScoreGenerator()
        {
            _framesGenerator = new FrameSetCalculator();
        }

        public Game GenerateGame(ParsedFrames parsedFrameScores)
        {
            var normalGameFrameResults = parsedFrameScores.Frames;
            var bonusGameFrameResults = parsedFrameScores.BonusFrames;

            var frameList = _framesGenerator.GenerateFrames(normalGameFrameResults, false);
            if(BonusRoundScoresArePresent(bonusGameFrameResults))
                frameList.AddRange(_framesGenerator.GenerateFrames(bonusGameFrameResults, true));

            return new Game
            {
                Frames = frameList
            };
        }

        private static bool BonusRoundScoresArePresent(List<string> bonusGameFrameResults)
        {
            return bonusGameFrameResults.Count > 0;
        }
    }
}