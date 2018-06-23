using ATDD_BowlingAPP.Enums;
using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP.FrameScores
{
    public class StrikeFrameScore : Frame
    {
        public StrikeFrameScore()
        {
            BowlOneScore = (int)Scores.Strike;
            BowlTwoScore = (int)Scores.Miss;
            FrameType = FrameType.Strike;
            OverallScore = 10;
        }
    }
}