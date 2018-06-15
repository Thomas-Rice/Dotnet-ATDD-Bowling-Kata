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
            
            var calculatedNormalResults = CalculateResultsForStandardFrames(gameResults);

            var enrichedResults = EnrichSpecialScoreModifiers(calculatedNormalResults);

            return SummateOverallScores(enrichedResults);
        }

        private Game GenerateGameResults(string scoreCard)
        {
            _parsedFrameLists = _scoreCardParser.ParseToNormalAndBonusFrames(scoreCard);
            return _gameGenerator.GenerateGame(_parsedFrameLists);
        }

        private Game CalculateResultsForStandardFrames(Game gameResults)
        {
            gameResults.Frames.ForEach(CalculateOverallScoreForFrame);
            return gameResults;
        }

        private Game EnrichSpecialScoreModifiers(Game frameResults)
        {
            return _specialScoreModifier.CalculateStrikeOrSpareScores(frameResults);
        }

        private void CalculateOverallScoreForFrame(Frame roundScores)
        {
            roundScores.OverallScore = roundScores.BowlOneScore + roundScores.BowlTwoScore;
        }

        private int SummateOverallScores(Game enrichedResults)
        {
            return enrichedResults.Frames.Sum(x => x.OverallScore);
        }
    }

}



