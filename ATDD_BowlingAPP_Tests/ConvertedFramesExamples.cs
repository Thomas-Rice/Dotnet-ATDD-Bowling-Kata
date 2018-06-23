using System.Collections.Generic;
using ATDD_BowlingAPP;
using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP_Tests
{
    public class ConvertedFramesExamples
    {
        public static Dictionary<string, List<IConvertedFrame>> GetScoreExample()
        {
            return new Dictionary<string, List<IConvertedFrame>>
            {
                {
                    "Normal", new List<IConvertedFrame>
                    {
                        new ConvertedFrame(1,1),
                        new ConvertedFrame(1,1),
                        new ConvertedFrame(1,1)
                    }
                },
                {
                    "NormalWithStrikeAtStart", new List<IConvertedFrame>
                    {
                        new ConvertedStrikeFrame(),
                        new ConvertedFrame(1,1),
                        new ConvertedFrame(1,1),
                        new ConvertedFrame(1,1),
                    }
                },
                {
                    "Strikes", new List<IConvertedFrame>
                    {
                        new ConvertedStrikeFrame(),
                        new ConvertedStrikeFrame(),
                        new ConvertedStrikeFrame()
                    }
                },
                {
                    "Spares", new List<IConvertedFrame>
                    {
                        new ConvertedSpareFrame(5),
                        new ConvertedSpareFrame(9),
                        new ConvertedSpareFrame(8),
                    }
                }
            };
        }
    }
}