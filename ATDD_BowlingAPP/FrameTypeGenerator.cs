using ATDD_BowlingAPP.Enums;
using ATDD_BowlingAPP.FrameScores;
using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP
{
    public class FrameTypeGenerator : IFrameType
    {
        public Frame GenerateFrame(IConvertedFrame frameScores)
        {
            return GetFrameResult(frameScores);
        }

        private Frame GetFrameResult(IConvertedFrame convertedFrame)
        {
            switch (convertedFrame.FrameResults)
            {
                case FrameType.Miss:
                    return new MissFrameScore(convertedFrame);
                case FrameType.Spare:
                    return new SpareFrameScore(convertedFrame);
                case FrameType.Strike:
                    return new StrikeFrameScore();
            }
            return new NormalFrameScore(convertedFrame);
        }
    }
}