using System.Collections.Generic;

namespace ATDD_BowlingAPP.Models
{
    public class Game
    {
        public List<Frame> Frames { get; set; }
        public bool HasStrike { get; set; }
        public bool HasSpare { get; set; }
    }
}