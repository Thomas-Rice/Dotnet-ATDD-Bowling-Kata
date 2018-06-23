using System.Collections.Generic;

namespace ATDD_BowlingAPP.ScoreCalculators
{
    public class FrameSymbolConverter
    {
        public List<IConvertedFrame> ConvertSymbols(List<string> parsedFrameList)
        {
            var convertedFrames = new List<IConvertedFrame>();
            foreach (var frame in parsedFrameList)
            {
                var convertedFrame = ConvertedFrameFactory.GetConvertedFrame(frame);
                convertedFrames.Add(convertedFrame);
            }

            return convertedFrames;
        }
    }
}
