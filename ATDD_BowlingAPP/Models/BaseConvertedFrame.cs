using System.Collections.Generic;
using ATDD_BowlingAPP.Enums;

namespace ATDD_BowlingAPP.Models
{
    public class BaseConvertedFrame : IConvertedFrame
    {
        public List<int> Frame { get; set; }
        public FrameType FrameResults { get; set; }
        public virtual void SetFrameScores(){}
    }
}