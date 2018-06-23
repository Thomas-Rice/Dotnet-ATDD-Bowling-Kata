using System.Collections.Generic;
using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP
{
    public class FrameGenerator
    {
        public List<Frame> GenerateFrames(List<IConvertedFrame> gameFrameResults)
        {
            var frameResultScores = new List<Frame>();

            gameFrameResults.ForEach(x =>
            {
                frameResultScores.Add(new FrameTypeGenerator().GenerateFrame(x));
            });

            return frameResultScores;
        }
    }

}