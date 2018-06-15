using System.Collections.Generic;
using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP
{
    public class FrameSetCalculator
    {
        public List<Frame> GenerateFrames(List<string> gameFrameResults, bool isBonus)
        {
            var frameResultScores = new List<Frame>();

            var frameType = GetFrameType(isBonus);
            gameFrameResults.ForEach(x =>
            {
                frameResultScores.Add(frameType.GenerateFrame(x));
            });

            return frameResultScores;
        }

        private IFrameType GetFrameType(bool isBonus)
        {
            if (isBonus)
                return new BonusFrame();
            return new NormalFrame();
        }
    }
}