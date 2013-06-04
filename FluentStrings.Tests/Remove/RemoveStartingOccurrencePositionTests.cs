using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveStartingOccurrencePositionTests
    {
        #region Remove Starting Occurrence Position

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 1, of: null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 2, of: String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 1, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfNegativeOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, -1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingBeginnigOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, 1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, 1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfZeroOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 0, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrence()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, 1, of: " long");
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: "Some");
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: "string");
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, 2, of: "Long");
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 2, of: "very");
            transformed.Should().Be("Some very ");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().Starting(The.StartOf, 3, of: "very");
            transformed.Should().Be("Some very very long string with ");
        }

        [TestMethod]
        public void RemoveStartingStartOfExceedingOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 5, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 1, of: null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 2, of: String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 1, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfNegativeOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, -1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOfZeroOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 0, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrence()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, 1, of: "long");
            transformed.Should().Be("Some very long");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "Some");
            transformed.Should().Be("Some");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "string");
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, 2, of: "Long");
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 2, of: "very");
            transformed.Should().Be("Some very very");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().Starting(The.EndOf, 3, of: "very");
            transformed.Should().Be("Some very very long string with very");
        }

        [TestMethod]
        public void RemoveStartingEndOfExceedingOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 5, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        #endregion

        #region Remove Starting Occurrence Position From

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 3, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfNegativeOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, -1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingBeginningOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, 1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, 1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIndexFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, 1, of: "very").From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIndexFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, 1, of: "very").From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfNegativeOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, -1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingBeginningOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, 1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, 1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfZeroOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 0, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingStartOfZeroOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 0, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: " long").From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: " very").From(The.End);
            transformed.Should().Be("Some");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: "Some").From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: "Some").From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: "string").From(The.Beginning);
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: "string").From(The.End);
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, 2, of: "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, 2, of: "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 2, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very ");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 2, of: "very").From(The.End);
            transformed.Should().Be("Some ");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().Starting(The.StartOf, 3, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string with ");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceFromEndHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().Starting(The.StartOf, 3, of: "very").From(The.End);
            transformed.Should().Be("Some very ");
        }

        [TestMethod]
        public void RemoveStartingStartOfExceedingOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 5, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingStartOfExceedingOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 5, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 3, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfNegativeOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, -1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOfNegativeOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, -1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOfZeroOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 0, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfZeroOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 0, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "long").From(The.Beginning);
            transformed.Should().Be("Some very long");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "very").From(The.End);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "Some").From(The.Beginning);
            transformed.Should().Be("Some");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "Some").From(The.End);
            transformed.Should().Be("Some");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "string").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "string").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, 2, of: "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, 2, of: "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 2, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 2, of: "very").From(The.End);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().Starting(The.EndOf, 3, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string with very");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceFromEndHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().Starting(The.EndOf, 3, of: "very").From(The.End);
            transformed.Should().Be("Some very very");
        }

        [TestMethod]
        public void RemoveStartingEndOfExceedingOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 5, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfExceedingOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 5, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        #endregion

        #region Remove Starting Occurrence Position Ignoring Case

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfNegativeOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, -1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingBeginningOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, 1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, 1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfZeroOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 0, of: "very").IgnoringCase();
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: " lOnG").IgnoringCase();
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: "SOME").IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.StartOf, 1, of: "string").IgnoringCase();
            transformed.Should().Be("SOME VERY LONG ");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().Starting(The.StartOf, 2, of: "VERY").IgnoringCase();
            transformed.Should().Be("Some vErY ");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with VERY very long string at the end".Remove().Starting(The.StartOf, 3, of: "vERy").IgnoringCase();
            transformed.Should().Be("Some very VERY long string with ");
        }

        [TestMethod]
        public void RemoveStartingStartOfExceedingOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very VERY long string".Remove().Starting(The.StartOf, 5, of: "VerY").IgnoringCase();
            transformed.Should().Be("Some very VERY long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfNegativeOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, -1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOfZeroOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 0, of: "very").IgnoringCase();
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "lOnG").IgnoringCase();
            transformed.Should().Be("Some very long");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "SOME").IgnoringCase();
            transformed.Should().Be("Some");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.EndOf, 1, of: "string").IgnoringCase();
            transformed.Should().Be("SOME VERY LONG STRING");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().Starting(The.EndOf, 2, of: "VERY").IgnoringCase();
            transformed.Should().Be("Some vErY very");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with VERY very long string at the end".Remove().Starting(The.EndOf, 3, of: "vERy").IgnoringCase();
            transformed.Should().Be("Some very VERY long string with VERY");
        }

        [TestMethod]
        public void RemoveStartingEndOfExceedingOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very VERY long string".Remove().Starting(The.EndOf, 5, of: "VerY").IgnoringCase();
            transformed.Should().Be("Some very VERY long string");
        }

        #endregion

        #region Remove Starting Occurrence Position Ignoring Case From

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfNegativeOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, -1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingBeginningOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, 1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, 1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, 1, of: "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, 1, of: "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, 1, of: "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, 1, of: "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfNegativeOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, -1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingBeginningOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, 1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, 1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfZeroOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 0, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingStartOfZeroOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 0, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: " LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: " VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.StartOf, 1, of: "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().Starting(The.StartOf, 1, of: "Some").IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().Starting(The.StartOf, 1, of: "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().Starting(The.StartOf, 1, of: "string").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.StartOf, 2, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some VERY ");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.StartOf, 2, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some ");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().Starting(The.StartOf, 3, of: "vERy").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VERY long string with ");
        }

        [TestMethod]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromEndHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().Starting(The.StartOf, 3, of: "vERy").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very ");
        }

        [TestMethod]
        public void RemoveStartingStartOfExceedingOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very VeRy long string".Remove().Starting(The.StartOf, 5, of: "VERY").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VeRy long string");
        }

        [TestMethod]
        public void RemoveStartingStartOfExceedingOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very VeRy long string".Remove().Starting(The.StartOf, 5, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very VeRy long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfNegativeOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, -1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOfNegativeOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, -1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOfZeroOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 0, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfZeroOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 0, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.EndOf, 1, of: "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("SOME");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().Starting(The.EndOf, 1, of: "Some").IgnoringCase().From(The.End);
            transformed.Should().Be("SOmE");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().Starting(The.EndOf, 1, of: "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long sTRINg");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().Starting(The.EndOf, 1, of: "string").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very long STRING");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.EndOf, 2, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some VERY VERY");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.EndOf, 2, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some VERY");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().Starting(The.EndOf, 3, of: "vERy").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VERY long string with very");
        }

        [TestMethod]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromEndHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().Starting(The.EndOf, 3, of: "vERy").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very VERY");
        }

        [TestMethod]
        public void RemoveStartingEndOfExceedingOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very VeRy long string".Remove().Starting(The.EndOf, 5, of: "VERY").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VeRy long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfExceedingOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very VeRy long string".Remove().Starting(The.EndOf, 5, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very VeRy long string");
        }

        #endregion
    }
}
