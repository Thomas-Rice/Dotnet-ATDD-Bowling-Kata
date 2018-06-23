using System.Linq;
using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP.ScoreCalculators
{
    public class ScoreCalculator
    {
        private readonly ScoreCardParser _scoreCardParser;
        private ParsedFrames _parsedFrameLists;
        private readonly SpecialScoreModifier _specialScoreModifier;
        private readonly FrameScoreGenerator _gameGenerator;
        private const int NumberOfRounds = 9;

        public ScoreCalculator()
        {
            _specialScoreModifier = new SpecialScoreModifier(NumberOfRounds);
            _scoreCardParser = new ScoreCardParser();
            _gameGenerator = new FrameScoreGenerator();
        }

        public int CalculateOverallGameScore(string scoreCard)
        {
            var gameResults = GenerateGameResults(scoreCard);

            var enrichedResults = EnrichSpecialScoreModifiers(gameResults);

            return SummateOverallScores(enrichedResults);
        }

        private Game GenerateGameResults(string scoreCard)
        {
            _parsedFrameLists = _scoreCardParser.ParseToNormalAndBonusFrames(scoreCard);
            return _gameGenerator.GenerateGame(_parsedFrameLists);
        }

        private Game EnrichSpecialScoreModifiers(Game frameResults)
        {
            return _specialScoreModifier.CalculateStrikeOrSpareScores(frameResults);
        }

        private int SummateOverallScores(Game enrichedResults)
        {
            return enrichedResults.Frames.Sum(x => x.OverallScore);
        }
    }
}



