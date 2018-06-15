using System;
using ATDD_BowlingAPP.Extensions;
using NUnit.Framework;
using Shouldly;

namespace ATDD_BowlingAPP_Tests
{
    [TestFixture]
    public class CharToIntConverterShould
    {
        [Test]
        public void ConvertCharToInt()
        {
            const char charToConvert = '5';

            var result = CharToIntConverter.Convert(charToConvert);

            result.ShouldBeOfType<int>();
        }

        [TestCase('X')]
        [TestCase('x')]
        [TestCase('/')]
        [TestCase('A')]
        public void ThrowExceptionIfNotChar(char charToConvert)
        {
            Assert.Throws<FormatException>(() => CharToIntConverter.Convert(charToConvert));
        }

    }
}
