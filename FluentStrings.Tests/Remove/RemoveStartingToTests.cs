using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveStartingToTests
    {
        #region Remove Starting To

        [TestMethod]
        public void RemoveStartingToPositionsInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).To(position: 8);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingToPositionsInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).To(position: 12);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingNegativePositionToPositivePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).To(position: 8).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingPositivePositionToNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).To(position: -8).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingNegativePositionToNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).To(position: -6).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingZeroToZeroPositions()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).To(position: 0);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingZeroPositionToPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).To(position: 10);
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveStartingPositionToZeroPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 9).To(position: 0);
            transformed.Should().Be("Slong string");
        }

        [TestMethod]
        public void RemoveStartingToSamePositions()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).To(position: 1);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingToPositions()
        {
            string transformed = "Some very long string".Remove().Starting(position: 5).To(position: 10);
            transformed.Should().Be("Some long string");
        }

        [TestMethod]
        public void RemoveStartingToPositionsInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(position: 9).To(position: 4);
            transformed.Should().Be("Some long string");
        }

        [TestMethod]
        public void RemoveStartingExactPositionToExceedingPosition()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length -1).To(position: testString.Length + 100);
            transformed.Should().Be("Some very long strin");
        }

        [TestMethod]
        public void RemoveStartingExceedingPositionToExactPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).To(position: Const.SampleString.Length);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingExceedingPositionToExceedingPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).To(position: Const.SampleString.Length + 200);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingZeroPositionToExactPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).To(position: Const.SampleString.Length);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingExactPositionToZeroPosition()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).To(position: 0);
            transformed.Should().Be("S");
        }

        #endregion

        #region Remove Starting From To

        [TestMethod]
        public void RemoveStartingPositionFromBeginningToPositionInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.Beginning).To(position: 8);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToPositionInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.End).To(position: 8);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingPositionFromBeginningToPositionInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.Beginning).To(position: 12);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToPositionInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.End).To(position: 12);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingNegativePositionFromBeginningToPositivePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.Beginning).To(position: 8).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingNegativePositionFromEndToPositivePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.End).To(position: 8).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingPositivePositionFromBeginningToNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.Beginning).To(position: -8).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingPositivePositionFromEndToNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.End).To(position: -8).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingNegativePositionFromBeginningToNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.Beginning).To(position: -6).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }


        [TestMethod]
        public void RemoveStartingNegativePositionFromEndToNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.End).To(position: -6).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingPositionFromStartOfToPosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.StartOf).To(position: 6).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndOfToPosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.EndOf).To(position: 6).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromBeginningToZeroPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.Beginning).To(position: 0);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromEndToZeroPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.End).To(position: 0);
            transformed.Should().Be("S");
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromBeginningToPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.Beginning).To(position: 10);
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromEndToPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.End).To(position: 9);
            transformed.Should().Be("Some very ");
        }

        [TestMethod]
        public void RemoveStartingPositionFromBeginningToZeroPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 10).From(The.Beginning).To(position: 0);
            transformed.Should().Be("Song string");
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToZeroPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 10).From(The.End).To(position: 0);
            transformed.Should().Be("Song string");
        }

        [TestMethod]
        public void RemoveStartingPositionFromBeginningToSamePosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).From(The.Beginning).To(position: 1);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToSamePosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).From(The.End).To(position: Const.SampleString.Length - 2);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingPositionFromBeginningToPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 5).From(The.Beginning).To(position: 10);
            transformed.Should().Be("Some long string");
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 11).From(The.End).To(position: 4);
            transformed.Should().Be("Some long string");
        }

        [TestMethod]
        public void RemoveStartingExactPositionFromBeginningToExceedingPosition()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).From(The.Beginning).To(position: testString.Length + 100);
            transformed.Should().Be("Some very long strin");
        }

        [TestMethod]
        public void RemoveStartingExactPositionFromEndToExceedingPosition()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: 0).From(The.End).To(position: testString.Length + 100);
            transformed.Should().Be("Some very long strin");
        }

        [TestMethod]
        public void RemoveStartingExceedingPositionFromBeginningToExactPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.Beginning).To(position: Const.SampleString.Length);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingExceedingPositionFromEndToExactPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.End).To(position: Const.SampleString.Length);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromBeginningToExactPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.Beginning).To(position: Const.SampleString.Length);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromEndToExactPosition()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: 0).From(The.End).To(position: testString.Length);
            transformed.Should().Be("Some very long strin");
        }

        [TestMethod]
        public void RemoveStartingExactPositionFromBeginningToZeroPosition()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).From(The.Beginning).To(position: 0);
            transformed.Should().Be("S");
        }

        [TestMethod]
        public void RemoveStartingExactPositionFromEndToZeroPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length - 1).From(The.End).To(position: 0);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove Starting To From

        [TestMethod]
        public void RemoveStartingPositionToPositionFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).To(position: 8).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingPositionToPositionInFromEndNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).To(position: 8).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingPositionToPositionFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).To(position: 12).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingPositionToPositionFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).To(position: 12).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingNegativePositionToPositivePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).To(position: 8).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingNegativePositionToPositivePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).To(position: 8).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingPositivePositionToNegativePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).To(position: -8).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingPositivePositionToNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).To(position: -8).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingNegativePositionToNegativePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).To(position: -6).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }


        [TestMethod]
        public void RemoveStartingNegativePositionToNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).To(position: -6).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingPositionToPositionFromStartOf()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).To(position: 6).From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingPositionToPositionFromEndOf()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).To(position: 6).From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingZeroPositionToZeroPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).To(position: 0).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingZeroPositionToZeroPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).To(position: 0).From(The.End);
            transformed.Should().Be("g");
        }

        [TestMethod]
        public void RemoveStartingZeroPositionToPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).To(position: 10).From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveStartingZeroPositionToPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).To(position: 10).From(The.End);
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveStartingPositionToZeroPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 10).To(position: 0).From(The.Beginning);
            transformed.Should().Be("Song string");
        }

        [TestMethod]
        public void RemoveStartingPositionToZeroPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 10).To(position: 0).From(The.End);
            transformed.Should().Be("Some very g");
        }

        [TestMethod]
        public void RemoveStartingPositionToSamePositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).To(position: 1).From(The.Beginning);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingPositionToSamePositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).To(position: Const.SampleString.Length - 2).From(The.End);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingPositionToPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 5).To(position: 10).From(The.Beginning);
            transformed.Should().Be("Some long string");
        }

        [TestMethod]
        public void RemoveStartingPositionToPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 5).To(position: 10).From(The.End);
            transformed.Should().Be("Some long string");
        }

        [TestMethod]
        public void RemoveStartingExactPositionToExceedingPositionFromBeginning()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).To(position: testString.Length + 100).From(The.Beginning);
            transformed.Should().Be("Some very long strin");
        }

        [TestMethod]
        public void RemoveStartingExactPositionToExceedingPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length - 1).To(position: Const.SampleString.Length + 100).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingExceedingPositionToExactPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).To(position: Const.SampleString.Length).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingExceedingPositionToExactPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).To(position: 0).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingZeroPositionToExactPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).To(position: Const.SampleString.Length).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingZeroPositionToExactPositionFromEnd()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: 0).To(position: testString.Length).From(The.End);
            transformed.Should().Be("ome very long string");
        }

        [TestMethod]
        public void RemoveStartingExactPositionToZeroPositionFromBeginning()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).To(position: 0).From(The.Beginning);
            transformed.Should().Be("S");
        }

        [TestMethod]
        public void RemoveStartingExactPositionToZeroPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length - 1).To(position: 0).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove Starting From To From

        [TestMethod]
        public void RemoveStartingPositionFromBeginningToPositionFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.Beginning).To(position: 8).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingPositionFromBeginningToPositionFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.Beginning).To(position: 8).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToPositionFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.End).To(position: 8).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToPositionFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.End).To(position: 8).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingPositionFromBeginningToPositionFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.Beginning).To(position: 12).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingPositionFromBeginningToPositionFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.Beginning).To(position: 12).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToPositionFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.End).To(position: 12).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToPositionFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.End).To(position: 12).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingNegativePositionFromBeginningToPositivePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.Beginning).To(position: 8).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingNegativePositionFromBeginningToPositivePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.Beginning).To(position: 8).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingNegativePositionFromEndToPositivePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.End).To(position: 8).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingNegativePositionFromEndToPositivePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.End).To(position: 8).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingPositivePositionFromBeginningToNegativePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.Beginning).To(position: -8).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingPositivePositionFromBeginningToNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.Beginning).To(position: -8).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingPositivePositionFromEndToNegativePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.End).To(position: -8).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingPositivePositionFromEndToNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.End).To(position: -8).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingNegativePositionFromBeginningToNegativePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.Beginning).To(position: -6).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingNegativePositionFromBeginningToNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.Beginning).To(position: -6).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingNegativePositionFromEndToNegativePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.End).To(position: -6).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingNegativePositionFromEndToNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.End).To(position: -6).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingPositionFromStartOfToPositionFromEndOf()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.StartOf).To(position: 6).From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndOfToPositionFromStartOf()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: 1).From(The.EndOf).To(position: 6).From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromBeginningToZeroPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.Beginning).To(position: 0).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromBeginningToZeroPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.Beginning).To(position: 0).From(The.End);
            transformed.Should().Be("g");
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromEndToZeroPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.End).To(position: 0).From(The.Beginning);
            transformed.Should().Be("S");
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromEndToZeroPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.End).To(position: 0).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromBeginningToPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.Beginning).To(position: 10).From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromBeginningToPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.Beginning).To(position: 11).From(The.End);
            transformed.Should().Be(" long string");
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromEndToPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.End).To(position: 9).From(The.Beginning);
            transformed.Should().Be("Some very ");
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromEndToPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 0).From(The.End).To(position: 12).From(The.End);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingPositionFromBeginningToZeroPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 10).From(The.Beginning).To(position: 0).From(The.Beginning);
            transformed.Should().Be("Song string");
        }

        [TestMethod]
        public void RemoveStartingPositionFromBeginningToZeroPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 10).From(The.Beginning).To(position: 0).From(The.End);
            transformed.Should().Be("Some very g");
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToZeroPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 11).From(The.End).To(position: 0).From(The.Beginning);
            transformed.Should().Be("Slong string");
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToZeroPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 10).From(The.End).To(position: 0).From(The.End);
            transformed.Should().Be("Some very g");
        }

        [TestMethod]
        public void RemoveStartingPositionFromBeginningToSamePositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).From(The.Beginning).To(position: 1).From(The.Beginning);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingPositionFromBeginningToSamePositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).From(The.Beginning).To(position: Const.SampleString.Length - 2).From(The.End);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToSamePositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).From(The.End).To(position: Const.SampleString.Length - 2).From(The.Beginning);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToSamePositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 1).From(The.End).To(position: 1).From(The.End);
            // nothing to remove
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingPositionFromBeginningToPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 5).From(The.Beginning).To(position: 10).From(The.Beginning);
            transformed.Should().Be("Some long string");
        }

        [TestMethod]
        public void RemoveStartingPositionFromBeginningToPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 5).From(The.Beginning).To(position: 10).From(The.End);
            transformed.Should().Be("Some long string");
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(position: 11).From(The.End).To(position: 4).From(The.Beginning);
            transformed.Should().Be("Some long string");
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 15).From(The.End).To(position: 10).From(The.End);
            transformed.Should().Be("Some long string");
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToPositionFromEndInStringWithoutSpaces()
        {
            string transformed = "Someverylongstringwithoutspaces".Remove().Starting(position: 17).From(The.End).To(position: 12).From(The.End);
            transformed.Should().Be("Someverylongswithoutspaces");
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToPositionFromEndInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(position: 11).From(The.End).To(position: 16).From(The.End);
            transformed.Should().Be("Some long string");
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndToPositionFromEndInStringWithoutSpacesInReverse()
        {
            string transformed = "Someverylongstringwithoutspaces".Remove().Starting(position: 11).From(The.End).To(position: 16).From(The.End);
            transformed.Should().Be("Someverylongstrthoutspaces");
        }

        [TestMethod]
        public void RemoveStartingExactPositionFromBeginningToExceedingPositionFromBeginning()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).From(The.Beginning).To(position: testString.Length + 100).From(The.Beginning);
            transformed.Should().Be("Some very long strin");
        }

        [TestMethod]
        public void RemoveStartingExactPositionFromBeginningToExceedingPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length - 1).From(The.Beginning).To(position: Const.SampleString.Length + 100).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingExactPositionFromEndToExceedingPositionFromBeginning()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: 0).From(The.End).To(position: testString.Length + 100).From(The.Beginning);
            transformed.Should().Be("Some very long strin");
        }

        [TestMethod]
        public void RemoveStartingExactPositionFromEndToExceedingPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.End).To(position: Const.SampleString.Length + 100).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingExceedingPositionFromBeginningToExactPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.Beginning).To(position: Const.SampleString.Length).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingExceedingPositionFromBeginningToExactPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.Beginning).To(position: Const.SampleString.Length).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingExceedingPositionFromEndToExactPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.End).To(position: Const.SampleString.Length).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingExceedingPositionFromEndToExactPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.End).To(position: Const.SampleString.Length).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromBeginningToExactPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.Beginning).To(position: Const.SampleString.Length).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromBeginningToExactPositionFromEnd()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: 0).From(The.Beginning).To(position: testString.Length).From(The.End);
            transformed.Should().Be("ome very long string");
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromEndToExactPositionFromBeginning()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: 0).From(The.End).To(position: testString.Length).From(The.Beginning);
            transformed.Should().Be("Some very long strin");
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromEndToExactPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.End).To(position: Const.SampleString.Length).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingExactPositionFromBeginningToZeroPositionFromBeginning()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).From(The.Beginning).To(position: 0).From(The.Beginning);
            transformed.Should().Be("S");
        }

        [TestMethod]
        public void RemoveStartingExactPositionFromBeginningToZeroPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length - 1).From(The.Beginning).To(position: 0).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingExactPositionFromEndToZeroPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length - 1).From(The.End).To(position: 0).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingExactPositionFromEndToZeroPositionFromEnd()
        {
            var testString = "Some very long string";
            string transformed = testString.Remove().Starting(position: testString.Length - 1).From(The.End).To(position: 0).From(The.End);
            transformed.Should().Be("g");
        }

        #endregion
    }
}
