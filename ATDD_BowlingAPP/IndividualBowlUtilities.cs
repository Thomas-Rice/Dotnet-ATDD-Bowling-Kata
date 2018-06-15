using System.Linq;

namespace ATDD_BowlingAPP
{
    public class IndividualBowlUtilities
    {
        public bool FrameIsAStrike(string setOfRoundScores)
        {
            return setOfRoundScores.Contains('X');
        }
        public bool FrameIsASpare(string setOfRoundScores)
        {
            return setOfRoundScores.Contains('/');
        }

        public bool MissesPresentInAFrame(string setOfRoundScores)
        {
            return setOfRoundScores.Contains('-');
        }

    }
}