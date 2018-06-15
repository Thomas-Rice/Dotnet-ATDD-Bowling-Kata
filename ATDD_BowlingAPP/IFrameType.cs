using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP
{
    public interface IFrameType
    {
        Frame GenerateFrame(string frameScores);
    }
}