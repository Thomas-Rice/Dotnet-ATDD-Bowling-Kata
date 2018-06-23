using System.Collections.Generic;
using ATDD_BowlingAPP.Enums;

namespace ATDD_BowlingAPP.Models
{
    public class ConvertedStrikeFrame : BaseConvertedFrame  
    {
        public ConvertedStrikeFrame()
        {
            SetFrameScores();
        }

        public override void SetFrameScores()
        {
            Frame = new List<int>
            {
                (int)Scores.Strike,
                (int)Scores.Miss
            };
            FrameResults = FrameType.Strike;
        }
    }
}