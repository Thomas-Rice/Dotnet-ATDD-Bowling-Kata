using System.Collections.Generic;
using ATDD_BowlingAPP.Enums;

namespace ATDD_BowlingAPP
{
    public interface IConvertedFrame
    {
        List<int> Frame { get; set; }
        FrameType FrameResults { get; set; }
    }
}