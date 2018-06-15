using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP.ScoreCalculators
{
    public class SpareScoreCalculator
    {
        private readonly int _numberOfRounds;

        public SpareScoreCalculator(int numberOfRounds)
        {
            _numberOfRounds = numberOfRounds;
        }

        public Game CalculateSpareScore(Game gameResults)
        {
            for (var i = 0; i < _numberOfRounds; i++)
            {
                var round = gameResults.Frames[i];
                if (round.FrameType == Frame.FrameTypes.Spare)
                {
                    round.OverallScore += gameResults.Frames[i].BowlOneScore;
                }
            }
            return gameResults;
        }
    }
}