using System.Collections.Generic;
using ATDD_BowlingAPP.Models;

namespace ATDD_BowlingAPP_Tests
{
    public class ScoreExamples
    {
        public static Dictionary<string, ParsedFrames> GetScoreExample()
        {
            return new Dictionary<string, ParsedFrames>
            {
                {
                    "Normal", new ParsedFrames
                    {
                        Frames = new List<string>
                        {
                            "11",
                            "11",
                            "11"
                        },
                        BonusFrames = new List<string>()
                    }
                },
                {
                    "NormalWithStrikeAtStart", new ParsedFrames
                    {
                        Frames = new List<string>
                        {
                            "X",
                            "11",
                            "11",
                            "11",
                            "11",
                            "11",
                            "11",
                            "11",
                            "11",
                            "11"
                        },
                        BonusFrames = new List<string>()
                    }
                },
                {
                    "Strikes", new ParsedFrames
                    {
                        Frames = new List<string>
                        {
                            "X",
                            "X",
                            "X"
                        },
                        BonusFrames = new List<string>
                        {
                            "X",
                            "X"
                        }
                    }
                },
                {
                    "Spares", new ParsedFrames
                    {
                        Frames = new List<string>
                        {
                            "5/",
                            "5/",
                            "5/"
                        },
                        BonusFrames = new List<string>
                        {
                            "5"
                        }
                    }
                },
                {
                    "Bonus", new ParsedFrames
                    {
                        Frames = new List<string>(),
                        BonusFrames = new List<string>()
                        {
                            "5"
                        }
                    }
                }
            };
        }
    }
}