using System.Collections.Generic;
using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP_Tests
{
    public class FrameListModelExamples
    {

        public static Game NoSpareOrStrike()
        {
            return new Game
            {
                Frames = new List<Frame>
                {
                    new Frame('1','1'),
                    new Frame('1','1'),
                    new Frame('1','1')
                }
            };
        }

        public static Game SingleSpare()
        {
            return new Game
            {
                Frames = new List<Frame>
                {
                    new Frame('1','1'),
                    new Frame('1','/'),
                    new Frame('1','1'),
                    new Frame('1','1'),
                    new Frame('1','1'),
                }
            };
        }

        public static Game SingleStrike()
        {
            return new Game
            {
                Frames = new List<Frame>
                {
                    new Frame('1','1'),
                    new Frame('X'),
                    new Frame('1','1'),
                    new Frame('1','1'),
                    new Frame('1','1')
                }
            };
        }
    }
}
