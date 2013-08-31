using System;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveStartingToTests
    {
        #region Remove Starting To

        [Test]
        public void RemoveStartingToPositionsInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).To(position: 8);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingToPositionsInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).To(position: 12);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingNegativePositionToPositivePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).To(position: 8).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingPositivePositionToNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).To(position: -8).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativePositionToNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).To(position: -6).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingZeroToZeroPositions()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).To(position: 0);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingZeroPositionToPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).To(position: 10);
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveStartingPositionToZeroPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 9).To(position: 0);
            transformed.Should().Be("Slong string");
        }

        [Test]
        public void RemoveStartingToSamePositions()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).To(position: 1);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingToPositions()
        {
            string transformed = "Some very long string".Remove().Starting(position: 5).To(position: 10);
            transformed.Should().Be("Some long string");
        }

        [Test]
        public void RemoveStartingToPositionsInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(position: 9).To(position: 4);
            transformed.Should().Be("Some long string");
        }

        [Test]
        public void RemoveStartingExactPositionToExceedingPosition()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length -1).To(position: testString.Length + 100);
            transformed.Should().Be("Some very long strin");
        }

        [Test]
        public void RemoveStartingExceedingPositionToExactPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).To(position: Const.SampleString.Length);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingExceedingPositionToExceedingPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).To(position: Const.SampleString.Length + 200);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingZeroPositionToExactPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).To(position: Const.SampleString.Length);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingExactPositionToZeroPosition()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).To(position: 0);
            transformed.Should().Be("S");
        }

        #endregion

        #region Remove Starting From To

        [Test]
        public void RemoveStartingPositionFromBeginningToPositionInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.Beginning).To(position: 8);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingPositionFromEndToPositionInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.End).To(position: 8);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingPositionFromBeginningToPositionInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.Beginning).To(position: 12);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingPositionFromEndToPositionInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.End).To(position: 12);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingNegativePositionFromBeginningToPositivePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.Beginning).To(position: 8).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativePositionFromEndToPositivePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.End).To(position: 8).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingPositivePositionFromBeginningToNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.Beginning).To(position: -8).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingPositivePositionFromEndToNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.End).To(position: -8).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativePositionFromBeginningToNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.Beginning).To(position: -6).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }


        [Test]
        public void RemoveStartingNegativePositionFromEndToNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.End).To(position: -6).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingPositionFromStartOfToPosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.StartOf).To(position: 6).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingPositionFromEndOfToPosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.EndOf).To(position: 6).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingZeroPositionFromBeginningToZeroPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.Beginning).To(position: 0);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingZeroPositionFromEndToZeroPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.End).To(position: 0);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingZeroPositionFromBeginningToPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.Beginning).To(position: 10);
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveStartingZeroPositionFromEndToPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.End).To(position: 9);
            transformed.Should().Be("Some very ");
        }

        [Test]
        public void RemoveStartingPositionFromBeginningToZeroPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 10).From(The.Beginning).To(position: 0);
            transformed.Should().Be("Song string");
        }

        [Test]
        public void RemoveStartingPositionFromEndToZeroPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 10).From(The.End).To(position: 0);
            transformed.Should().Be("Song string");
        }

        [Test]
        public void RemoveStartingPositionFromBeginningToSamePosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).From(The.Beginning).To(position: 1);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingPositionFromEndToSamePosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).From(The.End).To(position: Const.SampleString.Length - 2);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingPositionFromBeginningToPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 5).From(The.Beginning).To(position: 10);
            transformed.Should().Be("Some long string");
        }

        [Test]
        public void RemoveStartingPositionFromEndToPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 11).From(The.End).To(position: 4);
            transformed.Should().Be("Some long string");
        }

        [Test]
        public void RemoveStartingExactPositionFromBeginningToExceedingPosition()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).From(The.Beginning).To(position: testString.Length + 100);
            transformed.Should().Be("Some very long strin");
        }

        [Test]
        public void RemoveStartingExactPositionFromEndToExceedingPosition()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: 0).From(The.End).To(position: testString.Length + 100);
            transformed.Should().Be("Some very long strin");
        }

        [Test]
        public void RemoveStartingExceedingPositionFromBeginningToExactPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.Beginning).To(position: Const.SampleString.Length);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingExceedingPositionFromEndToExactPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.End).To(position: Const.SampleString.Length);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingZeroPositionFromBeginningToExactPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.Beginning).To(position: Const.SampleString.Length);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingZeroPositionFromEndToExactPosition()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: 0).From(The.End).To(position: testString.Length);
            transformed.Should().Be("Some very long strin");
        }

        [Test]
        public void RemoveStartingExactPositionFromBeginningToZeroPosition()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).From(The.Beginning).To(position: 0);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingExactPositionFromEndToZeroPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length - 1).From(The.End).To(position: 0);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove Starting To From

        [Test]
        public void RemoveStartingPositionToPositionFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).To(position: 8).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingPositionToPositionInFromEndNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).To(position: 8).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingPositionToPositionFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).To(position: 12).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingPositionToPositionFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).To(position: 12).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingNegativePositionToPositivePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).To(position: 8).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativePositionToPositivePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).To(position: 8).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingPositivePositionToNegativePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).To(position: -8).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingPositivePositionToNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).To(position: -8).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativePositionToNegativePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).To(position: -6).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }


        [Test]
        public void RemoveStartingNegativePositionToNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).To(position: -6).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingPositionToPositionFromStartOf()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).To(position: 6).From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingPositionToPositionFromEndOf()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).To(position: 6).From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingZeroPositionToZeroPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).To(position: 0).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingZeroPositionToZeroPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).To(position: 0).From(The.End);
            transformed.Should().Be("g");
        }

        [Test]
        public void RemoveStartingZeroPositionToPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).To(position: 10).From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveStartingZeroPositionToPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).To(position: 10).From(The.End);
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveStartingPositionToZeroPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 10).To(position: 0).From(The.Beginning);
            transformed.Should().Be("Song string");
        }

        [Test]
        public void RemoveStartingPositionToZeroPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 10).To(position: 0).From(The.End);
            transformed.Should().Be("Some very g");
        }

        [Test]
        public void RemoveStartingPositionToSamePositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).To(position: 1).From(The.Beginning);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingPositionToSamePositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).To(position: Const.SampleString.Length - 2).From(The.End);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingPositionToPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 5).To(position: 10).From(The.Beginning);
            transformed.Should().Be("Some long string");
        }

        [Test]
        public void RemoveStartingPositionToPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 5).To(position: 10).From(The.End);
            transformed.Should().Be("Some long string");
        }

        [Test]
        public void RemoveStartingExactPositionToExceedingPositionFromBeginning()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).To(position: testString.Length + 100).From(The.Beginning);
            transformed.Should().Be("Some very long strin");
        }

        [Test]
        public void RemoveStartingExactPositionToExceedingPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length - 1).To(position: Const.SampleString.Length + 100).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingExceedingPositionToExactPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).To(position: Const.SampleString.Length).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingExceedingPositionToExactPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).To(position: 0).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingZeroPositionToExactPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).To(position: Const.SampleString.Length).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingZeroPositionToExactPositionFromEnd()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: 0).To(position: testString.Length).From(The.End);
            transformed.Should().Be("ome very long string");
        }

        [Test]
        public void RemoveStartingExactPositionToZeroPositionFromBeginning()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).To(position: 0).From(The.Beginning);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingExactPositionToZeroPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length - 1).To(position: 0).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove Starting From To From

        [Test]
        public void RemoveStartingPositionFromBeginningToPositionFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.Beginning).To(position: 8).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingPositionFromBeginningToPositionFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.Beginning).To(position: 8).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingPositionFromEndToPositionFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.End).To(position: 8).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingPositionFromEndToPositionFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.End).To(position: 8).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingPositionFromBeginningToPositionFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.Beginning).To(position: 12).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingPositionFromBeginningToPositionFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.Beginning).To(position: 12).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingPositionFromEndToPositionFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.End).To(position: 12).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingPositionFromEndToPositionFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.End).To(position: 12).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingNegativePositionFromBeginningToPositivePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.Beginning).To(position: 8).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativePositionFromBeginningToPositivePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.Beginning).To(position: 8).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativePositionFromEndToPositivePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.End).To(position: 8).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativePositionFromEndToPositivePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.End).To(position: 8).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingPositivePositionFromBeginningToNegativePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.Beginning).To(position: -8).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingPositivePositionFromBeginningToNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.Beginning).To(position: -8).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingPositivePositionFromEndToNegativePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.End).To(position: -8).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingPositivePositionFromEndToNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.End).To(position: -8).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativePositionFromBeginningToNegativePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.Beginning).To(position: -6).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativePositionFromBeginningToNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.Beginning).To(position: -6).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativePositionFromEndToNegativePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.End).To(position: -6).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativePositionFromEndToNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.End).To(position: -6).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingPositionFromStartOfToPositionFromEndOf()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.StartOf).To(position: 6).From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingPositionFromEndOfToPositionFromStartOf()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.EndOf).To(position: 6).From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingZeroPositionFromBeginningToZeroPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.Beginning).To(position: 0).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingZeroPositionFromBeginningToZeroPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.Beginning).To(position: 0).From(The.End);
            transformed.Should().Be("g");
        }

        [Test]
        public void RemoveStartingZeroPositionFromEndToZeroPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.End).To(position: 0).From(The.Beginning);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingZeroPositionFromEndToZeroPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.End).To(position: 0).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingZeroPositionFromBeginningToPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.Beginning).To(position: 10).From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveStartingZeroPositionFromBeginningToPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.Beginning).To(position: 11).From(The.End);
            transformed.Should().Be(" long string");
        }

        [Test]
        public void RemoveStartingZeroPositionFromEndToPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.End).To(position: 9).From(The.Beginning);
            transformed.Should().Be("Some very ");
        }

        [Test]
        public void RemoveStartingZeroPositionFromEndToPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.End).To(position: 12).From(The.End);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingPositionFromBeginningToZeroPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 10).From(The.Beginning).To(position: 0).From(The.Beginning);
            transformed.Should().Be("Song string");
        }

        [Test]
        public void RemoveStartingPositionFromBeginningToZeroPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 10).From(The.Beginning).To(position: 0).From(The.End);
            transformed.Should().Be("Some very g");
        }

        [Test]
        public void RemoveStartingPositionFromEndToZeroPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 11).From(The.End).To(position: 0).From(The.Beginning);
            transformed.Should().Be("Slong string");
        }

        [Test]
        public void RemoveStartingPositionFromEndToZeroPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 10).From(The.End).To(position: 0).From(The.End);
            transformed.Should().Be("Some very g");
        }

        [Test]
        public void RemoveStartingPositionFromBeginningToSamePositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).From(The.Beginning).To(position: 1).From(The.Beginning);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingPositionFromBeginningToSamePositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).From(The.Beginning).To(position: Const.SampleString.Length - 2).From(The.End);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingPositionFromEndToSamePositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).From(The.End).To(position: Const.SampleString.Length - 2).From(The.Beginning);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingPositionFromEndToSamePositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).From(The.End).To(position: 1).From(The.End);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingPositionFromBeginningToPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 5).From(The.Beginning).To(position: 10).From(The.Beginning);
            transformed.Should().Be("Some long string");
        }

        [Test]
        public void RemoveStartingPositionFromBeginningToPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 5).From(The.Beginning).To(position: 10).From(The.End);
            transformed.Should().Be("Some long string");
        }

        [Test]
        public void RemoveStartingPositionFromEndToPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 11).From(The.End).To(position: 4).From(The.Beginning);
            transformed.Should().Be("Some long string");
        }

        [Test]
        public void RemoveStartingPositionFromEndToPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 15).From(The.End).To(position: 10).From(The.End);
            transformed.Should().Be("Some long string");
        }

        [Test]
        public void RemoveStartingPositionFromEndToPositionFromEndInStringWithoutSpaces()
        {
            string transformed = "Someverylongstringwithoutspaces".Remove().Starting(position: 17).From(The.End).To(position: 12).From(The.End);
            transformed.Should().Be("Someverylongswithoutspaces");
        }

        [Test]
        public void RemoveStartingPositionFromEndToPositionFromEndInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(position: 11).From(The.End).To(position: 16).From(The.End);
            transformed.Should().Be("Some long string");
        }

        [Test]
        public void RemoveStartingPositionFromEndToPositionFromEndInStringWithoutSpacesInReverse()
        {
            string transformed = "Someverylongstringwithoutspaces".Remove().Starting(position: 11).From(The.End).To(position: 16).From(The.End);
            transformed.Should().Be("Someverylongstrthoutspaces");
        }

        [Test]
        public void RemoveStartingExactPositionFromBeginningToExceedingPositionFromBeginning()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).From(The.Beginning).To(position: testString.Length + 100).From(The.Beginning);
            transformed.Should().Be("Some very long strin");
        }

        [Test]
        public void RemoveStartingExactPositionFromBeginningToExceedingPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length - 1).From(The.Beginning).To(position: Const.SampleString.Length + 100).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingExactPositionFromEndToExceedingPositionFromBeginning()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: 0).From(The.End).To(position: testString.Length + 100).From(The.Beginning);
            transformed.Should().Be("Some very long strin");
        }

        [Test]
        public void RemoveStartingExactPositionFromEndToExceedingPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.End).To(position: Const.SampleString.Length + 100).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingExceedingPositionFromBeginningToExactPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.Beginning).To(position: Const.SampleString.Length).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingExceedingPositionFromBeginningToExactPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.Beginning).To(position: Const.SampleString.Length).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingExceedingPositionFromEndToExactPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.End).To(position: Const.SampleString.Length).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingExceedingPositionFromEndToExactPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.End).To(position: Const.SampleString.Length).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingZeroPositionFromBeginningToExactPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.Beginning).To(position: Const.SampleString.Length).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingZeroPositionFromBeginningToExactPositionFromEnd()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: 0).From(The.Beginning).To(position: testString.Length).From(The.End);
            transformed.Should().Be("ome very long string");
        }

        [Test]
        public void RemoveStartingZeroPositionFromEndToExactPositionFromBeginning()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: 0).From(The.End).To(position: testString.Length).From(The.Beginning);
            transformed.Should().Be("Some very long strin");
        }

        [Test]
        public void RemoveStartingZeroPositionFromEndToExactPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.End).To(position: Const.SampleString.Length).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingExactPositionFromBeginningToZeroPositionFromBeginning()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).From(The.Beginning).To(position: 0).From(The.Beginning);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingExactPositionFromBeginningToZeroPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length - 1).From(The.Beginning).To(position: 0).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingExactPositionFromEndToZeroPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length - 1).From(The.End).To(position: 0).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingExactPositionFromEndToZeroPositionFromEnd()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).From(The.End).To(position: 0).From(The.End);
            transformed.Should().Be("g");
        }

        #endregion
    }
}
