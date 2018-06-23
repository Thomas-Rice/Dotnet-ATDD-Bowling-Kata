using System.Collections.Generic;
using ATDD_BowlingAPP.Enums;

namespace ATDD_BowlingAPP.Models
{
    public class ConvertedFrame : BaseConvertedFrame
    {
        public ConvertedFrame(int bowlOne, int bowlTwo)
        {
            SetFrameScores(bowlOne, bowlTwo);
        }
        public void SetFrameScores(int bowlOne, int bowlTwo)
        {
            Frame = new List<int>
            {
                bowlOne,
                bowlTwo
            };
            FrameResults = FrameType.Normal;
        }
    }










}