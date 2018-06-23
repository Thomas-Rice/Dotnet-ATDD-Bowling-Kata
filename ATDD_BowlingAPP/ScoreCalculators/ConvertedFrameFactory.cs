using ATDD_BowlingAPP.Extensions;
using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP.ScoreCalculators
{
    public class ConvertedFrameFactory
    {
        private const int Zero = 0;

        public static IConvertedFrame GetConvertedFrame(string frame)
        {
            int bowlOneScore;
            int bowlTwoScore;
            var bowlTwo = frame.Length == 1 ? '0' : frame[1];

            if (frame.Contains("X"))
            {
                return new ConvertedStrikeFrame();
            }
            if (frame.Contains("/"))
            {
                bowlOneScore = CharToIntConverter.Convert(frame[0]);
                return new ConvertedSpareFrame(bowlOneScore);
            }
            if (frame[0].Equals('-'))
            {
                bowlTwoScore = CharToIntConverter.Convert(bowlTwo);
                return new ConvertedMissFrame(Zero, bowlTwoScore);
            }
            if (bowlTwo.Equals('-'))
            {
                bowlOneScore = CharToIntConverter.Convert(frame[0]);
                return new ConvertedMissFrame(bowlOneScore, Zero);
            }
            if (frame[0].Equals('-') && bowlTwo.Equals('-'))
            {
                return new ConvertedMissFrame(Zero, Zero);
            }

            bowlOneScore = CharToIntConverter.Convert(frame[0]);
            bowlTwoScore = CharToIntConverter.Convert(bowlTwo);
            return new ConvertedFrame(bowlOneScore, bowlTwoScore);
        }
    }
}