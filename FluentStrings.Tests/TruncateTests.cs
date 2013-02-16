using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class TruncateTests
    {
        #region Truncate To

        [TestMethod]
        public void TruncateToOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void TruncateToOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void TruncateTo()
        {
            string transformed = "Some very long string".TruncateTo(8);
            transformed.Should().Be("Some ver");
        }

        #endregion

        #region Truncate To From

        [TestMethod]
        public void TruncateToFromBeginningOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void TruncateToFromEndOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void TruncateToFromBeginningOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void TruncateToFromEndOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void TruncateToFromBeginning()
        {
            string transformed = "Some very long string".TruncateTo(9).From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void TruncateToFromEnd()
        {
            string transformed = "Some very long string".TruncateTo(11).From(The.End);
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void TruncateToFromBeginningMoreThanAvailable()
        {
            string transformed = Const.SampleString.TruncateTo(100).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }
        
        [TestMethod]
        public void TruncateToFromEndMoreThanAvailable()
        {
            string transformed = Const.SampleString.TruncateTo(100).From (The.End);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion
    }
}
