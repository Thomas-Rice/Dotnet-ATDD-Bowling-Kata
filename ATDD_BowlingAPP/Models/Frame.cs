using ATDD_BowlingAPP.Enums;

namespace ATDD_BowlingAPP.Models
{
    public class Frame
    {
        public int BowlOneScore { get; set; }
        public int BowlTwoScore { get; set; }
        public int OverallScore { get; set; }
        public FrameType FrameType { get; set; }

        public void SetOverallScore(int score1, int score2)
        {
            OverallScore = score1 + score2;
        }

    }
}