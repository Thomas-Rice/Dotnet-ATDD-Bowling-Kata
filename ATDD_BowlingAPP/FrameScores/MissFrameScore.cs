using ATDD_BowlingAPP.Enums;
using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP.FrameScores
{
    public class MissFrameScore : Frame
    {
        public MissFrameScore(IConvertedFrame convertedFrame)
        {

            var bowlOne = convertedFrame.Frame[0];
            var bowlTwo = convertedFrame.Frame[1];

            if (bowlOne.Equals(0) && bowlTwo.Equals(0))
            {
                BowlOneScore = (int)Scores.Miss;
                BowlTwoScore = (int)Scores.Miss;
                FrameType = FrameType.Miss;
                OverallScore = BowlOneScore + BowlTwoScore;
                return;
            }
            if (bowlOne.Equals(0))
            {
                BowlOneScore = (int)Scores.Miss;
                BowlTwoScore = bowlTwo;
                FrameType = FrameType.Miss;
                OverallScore = BowlOneScore + BowlTwoScore;
                return;
            }
            if (bowlTwo.Equals(0))
            {
                BowlOneScore = bowlOne;
                BowlTwoScore = (int)Scores.Miss;
                FrameType = FrameType.Miss;
                OverallScore = BowlOneScore + BowlTwoScore;
            }
        }
    }
}