using ATDD_BowlingAPP.Enums;
using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP.ScoreCalculators
{
    public class SpecialScoreModifier
    {
        private readonly int _numberOfRounds;
        public SpecialScoreModifier(int numberOfRounds)
        {
            _numberOfRounds = numberOfRounds;
        }

        public Game CalculateStrikeOrSpareScores(Game gameResults)
        {
            for (var i = 0; i < _numberOfRounds; i++)
            {
                var frame = gameResults.Frames[i];
                if (frame.FrameType == FrameType.Strike)
                {
                    var nextTwoFrameScores = gameResults.Frames[i + 1].OverallScore + gameResults.Frames[i + 2].OverallScore;
                    frame.SetOverallScore(nextTwoFrameScores, frame.OverallScore);
                }
                if (frame.FrameType == FrameType.Spare)
                {
                    frame.SetOverallScore(frame.OverallScore, gameResults.Frames[i].BowlOneScore);
                }
            }
            return gameResults;
        }
    }
}