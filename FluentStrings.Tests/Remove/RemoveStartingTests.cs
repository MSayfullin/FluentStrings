using System;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveStartingTests
    {
        #region Remove Starting

        [Test]
        public void RemoveStartingPositionInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingPositionInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingZeroPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 1);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 7);
            transformed.Should().Be("Some ve");
        }

        [Test]
        public void RemoveStartingExactPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingExceedingPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove Starting From

        [Test]
        public void RemoveStartingPositionFromBeginnigInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingPositionFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingPositionFromBeginnigInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingPositionFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingNegativePositionFromBeginnig()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingZeroPositionFromBeginnig()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingZeroPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstPositionFromBeginnig()
        {
            string transformed = "Some very long string".Remove().Starting(position: 1).From(The.Beginning);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingFirstPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 1).From(The.End);
            transformed.Should().Be("g");
        }

        [Test]
        public void RemoveStartingPositionFromBeginnig()
        {
            string transformed = "Some very long string".Remove().Starting(position: 7).From(The.Beginning);
            transformed.Should().Be("Some ve");
        }

        [Test]
        public void RemoveStartingPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 7).From(The.End);
            transformed.Should().Be(" string");
        }

        [Test]
        public void RemoveStartingExactPositionFromBeginnig()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingExactPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingExceedingPositionFromBeginnig()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingExceedingPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion
    }
}
