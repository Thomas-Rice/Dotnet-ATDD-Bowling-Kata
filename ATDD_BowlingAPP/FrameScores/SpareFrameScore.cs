using ATDD_BowlingAPP.Enums;
using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP.FrameScores
{
    public class SpareFrameScore : Frame
    {
        public SpareFrameScore(IConvertedFrame convertedFrame)
        {
            BowlOneScore = convertedFrame.Frame[0];
            BowlTwoScore = convertedFrame.Frame[1];
            FrameType = FrameType.Spare;
            OverallScore = 10;
        }
    }
}