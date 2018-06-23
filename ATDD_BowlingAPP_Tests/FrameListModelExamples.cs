using System.Collections.Generic;
using ATDD_BowlingAPP.Enums;
using ATDD_BowlingAPP.FrameScores;
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
                    new NormalFrameScore(new ConvertedFrame(1,1)),
                    new NormalFrameScore(new ConvertedFrame(1,1)),
                    new NormalFrameScore(new ConvertedFrame(1,1))

                }
            };
        }

        public static Game SingleSpare()
        {
            return new Game
            {
                Frames = new List<Frame>
                {
                    new NormalFrameScore(new ConvertedFrame(1,1)),
                    new SpareFrameScore(new ConvertedSpareFrame(1)),
                    new NormalFrameScore(new ConvertedFrame(1,1))
                }
            };
        }

        public static Game SingleStrike()
        {
            return new Game
            {
                Frames = new List<Frame>
                {
                    new NormalFrameScore(new ConvertedFrame(1,1)),
                    new StrikeFrameScore(),
                    new NormalFrameScore(new ConvertedFrame(1,1))
                }
            };
        }
    }
}
