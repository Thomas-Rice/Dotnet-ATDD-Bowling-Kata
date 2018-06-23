using System;
using System.Collections.Generic;
using System.Linq;
using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP
{
    public class ScoreCardParser
    {
        public ParsedFrames ParseToNormalAndBonusFrames(string scoreCardString)
        {
            var gameAndBonusFrames = SplitToFrameTypes(scoreCardString);

            var bonusRoundsExist = gameAndBonusFrames.Count > 1;

            return bonusRoundsExist ? GameWithBonusRounds(gameAndBonusFrames) : GameWithoutBonusRounds(gameAndBonusFrames);
        }

        public List<string> SplitToFrameTypes(string scoreCardString)
        {
            return scoreCardString.Split(new[] { "||" }, StringSplitOptions.None).Where(s => s != string.Empty).ToList();
        }

        public ParsedFrames GameWithBonusRounds(List<string> gameAndBonusScores)
        {
            return new ParsedFrames
            {
                Frames = ParseToListOfFrames(gameAndBonusScores.FirstOrDefault()),
                BonusFrames = ParseBonusScoresToListOfFrames(gameAndBonusScores.LastOrDefault())
            };
        }

        public ParsedFrames GameWithoutBonusRounds(List<string> gameAndBonusScores)
        {
            return new ParsedFrames
            {
                Frames = ParseToListOfFrames(gameAndBonusScores.FirstOrDefault()),
                BonusFrames = new List<string>()
            };
        }

        public List<string> ParseToListOfFrames(string scoreCardString)
        {
            return scoreCardString.Split('|').Where(s => s != string.Empty).ToList();
        }

        public List<string> ParseBonusScoresToListOfFrames(string scoreCardString)
        { 
            var bonusScoresToListOfFrames = scoreCardString.Select(c => c.ToString()).ToList();
            return bonusScoresToListOfFrames;
        }
    }
}