using System;
using System.Collections.Generic;
using ATDD_BowlingAPP.Enums;

namespace ATDD_BowlingAPP.Models
{
    public class ConvertedSpareFrame : BaseConvertedFrame
    {
        public ConvertedSpareFrame(int bowlOne)
        {
            SetFrameScores(bowlOne);
        }

        private void SetFrameScores(int bowlOne)
        {
            Frame = new List<int>
            {
                bowlOne,
                Math.Abs((int) Scores.Strike - bowlOne)
            };
            FrameResults = FrameType.Spare;
        }
    }
}