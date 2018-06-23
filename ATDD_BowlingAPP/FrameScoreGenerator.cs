using System.Collections.Generic;
using ATDD_BowlingAPP.Models;
using ATDD_BowlingAPP.ScoreCalculators;

namespace ATDD_BowlingAPP
{
    public class FrameScoreGenerator
    {
        private readonly FrameGenerator _frameGenerator;
        private readonly FrameSymbolConverter _frameSymbolConverter;
        private readonly Game _game;

        public FrameScoreGenerator()
        {
            _frameSymbolConverter = new FrameSymbolConverter();
            _frameGenerator = new FrameGenerator();
            _game = new Game();
        }

        public Game GenerateGame(ParsedFrames parsedFrameScores)
        {
            var normalGameFrameResults = parsedFrameScores.Frames;
            var bonusGameFrameResults = parsedFrameScores.BonusFrames;

            var convertedNormalFrames = _frameSymbolConverter.ConvertSymbols(normalGameFrameResults);
            var convertedBonusFrames = _frameSymbolConverter.ConvertSymbols(bonusGameFrameResults);

             _game.Frames = _frameGenerator.GenerateFrames(convertedNormalFrames);
            if(BonusRoundScoresArePresent(bonusGameFrameResults))
                _game.Frames.AddRange(_frameGenerator.GenerateFrames(convertedBonusFrames));

            return _game;
        }

        private static bool BonusRoundScoresArePresent(IReadOnlyCollection<string> bonusGameFrameResults)
        {
            return bonusGameFrameResults.Count > 0;
        }
    }
}