using ATDD_BowlingAPP.Extensions;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ATDD_BowlingAPP.Models
{
    public class Frame
    {
        public static readonly List<char> SpecialScoreModifiers = new List<char> {'-','X','/'};
        public int BowlOneScore { get; set; }
        public int BowlTwoScore { get; set; }
        public int OverallScore { get; set; }
        public FrameTypes FrameType { get; set; }

        //Questionable?
        public Frame(char inputBowlOne, char inputBowlTwo = '0')
        {
            SetIfStrike(inputBowlOne);
            SetIfSpare(inputBowlOne, inputBowlTwo);
            SetIfMiss(inputBowlOne, inputBowlTwo);
            SetIfNormalRound(inputBowlOne, inputBowlTwo);
        }

        private void SetIfNormalRound(char inputBowlOne, char inputBowlTwo)
        {
            if(SpecialScoreModifiers.Contains(inputBowlOne)) return;
            if(SpecialScoreModifiers.Contains(inputBowlTwo)) return;

            BowlOneScore = CharToIntConverter.Convert(inputBowlOne);
            BowlTwoScore = CharToIntConverter.Convert(inputBowlTwo);
            FrameType = FrameTypes.Normal;
            OverallScore = BowlOneScore + BowlTwoScore;
        }

        private void SetIfStrike(char inputBowlOne)
        {
            if (!inputBowlOne.Equals('X')) return;
            BowlOneScore = 10;
            BowlTwoScore = 0;
            FrameType = FrameTypes.Strike;
            OverallScore = 10;
        }

        private void SetIfSpare(char inputBowlOne, char inputBowlTwo)
        {
            if (!inputBowlTwo.Equals('/')) return;
            BowlOneScore = CharToIntConverter.Convert(inputBowlOne);
            BowlTwoScore = Math.Abs(10 - CharToIntConverter.Convert(inputBowlOne));
            FrameType = FrameTypes.Spare;
            OverallScore = 10;
        }

        private void SetIfMiss(char inputBowlOne, char inputBowlTwo)
        {
            if (inputBowlOne.Equals('-') && inputBowlTwo.Equals('-'))
            {
                BowlOneScore = 0;
                BowlTwoScore = 0;
                FrameType = FrameTypes.Miss;
                OverallScore = BowlOneScore + BowlTwoScore;
                return;
            }
            if (inputBowlOne.Equals('-'))
            {
                BowlOneScore = 0;
                BowlTwoScore = CharToIntConverter.Convert(inputBowlTwo);
                FrameType = FrameTypes.Miss;
                OverallScore = BowlOneScore + BowlTwoScore;
                return;
            }
            if (inputBowlTwo.Equals('-'))
            {
                BowlOneScore = CharToIntConverter.Convert(inputBowlOne);
                BowlTwoScore = 0;
                FrameType = FrameTypes.Miss;
                OverallScore = BowlOneScore + BowlTwoScore;
            }

        }

        public enum FrameTypes
        {
            Strike,
            Spare,
            Normal,
            Miss
        }

    }
}