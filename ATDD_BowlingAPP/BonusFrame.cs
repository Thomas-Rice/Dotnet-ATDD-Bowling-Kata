using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP
{
    public class BonusFrame : IFrameType
    {
        public Frame GenerateFrame(string frameScores)
        {
            return new Frame(frameScores[0]);
        }
    }
}