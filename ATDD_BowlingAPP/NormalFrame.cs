using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP
{
    public class NormalFrame : IFrameType
    {
        private const string StrikeSymbol = "X";

        public Frame GenerateFrame(string frameScores)
        {
            return frameScores.Contains(StrikeSymbol) ? new Frame(frameScores[0]) : new Frame(frameScores[0], frameScores[1]);
        }
    }
}