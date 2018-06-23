using ATDD_BowlingAPP.Enums;
using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP.FrameScores
{
    public class NormalFrameScore : Frame
    {
        public NormalFrameScore(IConvertedFrame convertedFrame)
        {
            BowlOneScore = convertedFrame.Frame[0];
            BowlTwoScore = convertedFrame.Frame[1];
            FrameType = FrameType.Normal;
            OverallScore = convertedFrame.Frame[0] + convertedFrame.Frame[1];
        }
    }
}