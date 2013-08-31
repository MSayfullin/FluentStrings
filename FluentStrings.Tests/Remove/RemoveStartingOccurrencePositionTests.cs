using System;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveStartingOccurrencePositionTests
    {
        #region Remove Starting Occurrence Position

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 1, of: null);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 2, of: String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 1, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfNegativeOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, -1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingBeginningOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, 1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, 1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfZeroOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 0, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingStartOfOccurrence()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, 1, of: " long");
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: "Some");
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: "string");
            transformed.Should().Be("Some very long ");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, 2, of: "Long");
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 2, of: "very");
            transformed.Should().Be("Some very ");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().Starting(The.StartOf, 3, of: "very");
            transformed.Should().Be("Some very very long string with ");
        }

        [Test]
        public void RemoveStartingStartOfExceedingOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 5, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 1, of: null);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 2, of: String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 1, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfNegativeOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, -1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOfZeroOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 0, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingEndOfOccurrence()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, 1, of: "long");
            transformed.Should().Be("Some very long");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "Some");
            transformed.Should().Be("Some");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "string");
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, 2, of: "Long");
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 2, of: "very");
            transformed.Should().Be("Some very very");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().Starting(The.EndOf, 3, of: "very");
            transformed.Should().Be("Some very very long string with very");
        }

        [Test]
        public void RemoveStartingEndOfExceedingOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 5, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        #endregion

        #region Remove Starting Occurrence Position From

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 3, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfNegativeOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, -1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingBeginningOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, 1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, 1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIndexFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, 1, of: "very").From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIndexFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, 1, of: "very").From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfNegativeOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, -1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingBeginningOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, 1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, 1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfZeroOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 0, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingStartOfZeroOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 0, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: " long").From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: " very").From(The.End);
            transformed.Should().Be("Some");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: "Some").From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: "Some").From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: "string").From(The.Beginning);
            transformed.Should().Be("Some very long ");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: "string").From(The.End);
            transformed.Should().Be("Some very long ");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, 2, of: "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, 2, of: "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 2, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very ");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 2, of: "very").From(The.End);
            transformed.Should().Be("Some ");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().Starting(The.StartOf, 3, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string with ");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceFromEndHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().Starting(The.StartOf, 3, of: "very").From(The.End);
            transformed.Should().Be("Some very ");
        }

        [Test]
        public void RemoveStartingStartOfExceedingOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 5, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingStartOfExceedingOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 5, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 3, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfNegativeOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, -1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOfNegativeOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, -1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOfZeroOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 0, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingEndOfZeroOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 0, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "long").From(The.Beginning);
            transformed.Should().Be("Some very long");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "very").From(The.End);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "Some").From(The.Beginning);
            transformed.Should().Be("Some");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "Some").From(The.End);
            transformed.Should().Be("Some");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "string").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "string").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, 2, of: "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, 2, of: "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 2, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 2, of: "very").From(The.End);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().Starting(The.EndOf, 3, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string with very");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceFromEndHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().Starting(The.EndOf, 3, of: "very").From(The.End);
            transformed.Should().Be("Some very very");
        }

        [Test]
        public void RemoveStartingEndOfExceedingOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 5, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingEndOfExceedingOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 5, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        #endregion

        #region Remove Starting Occurrence Position Ignoring Case

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfNegativeOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, -1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingBeginningOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, 1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, 1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfZeroOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 0, of: "very").IgnoringCase();
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: " lOnG").IgnoringCase();
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: "SOME").IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.StartOf, 1, of: "string").IgnoringCase();
            transformed.Should().Be("SOME VERY LONG ");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().Starting(The.StartOf, 2, of: "VERY").IgnoringCase();
            transformed.Should().Be("Some vErY ");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with VERY very long string at the end".Remove().Starting(The.StartOf, 3, of: "vERy").IgnoringCase();
            transformed.Should().Be("Some very VERY long string with ");
        }

        [Test]
        public void RemoveStartingStartOfExceedingOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very VERY long string".Remove().Starting(The.StartOf, 5, of: "VerY").IgnoringCase();
            transformed.Should().Be("Some very VERY long string");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfNegativeOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, -1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOfZeroOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 0, of: "very").IgnoringCase();
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "lOnG").IgnoringCase();
            transformed.Should().Be("Some very long");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "SOME").IgnoringCase();
            transformed.Should().Be("Some");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.EndOf, 1, of: "string").IgnoringCase();
            transformed.Should().Be("SOME VERY LONG STRING");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().Starting(The.EndOf, 2, of: "VERY").IgnoringCase();
            transformed.Should().Be("Some vErY very");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with VERY very long string at the end".Remove().Starting(The.EndOf, 3, of: "vERy").IgnoringCase();
            transformed.Should().Be("Some very VERY long string with VERY");
        }

        [Test]
        public void RemoveStartingEndOfExceedingOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very VERY long string".Remove().Starting(The.EndOf, 5, of: "VerY").IgnoringCase();
            transformed.Should().Be("Some very VERY long string");
        }

        #endregion

        #region Remove Starting Occurrence Position Ignoring Case From

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfNegativeOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, -1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingBeginningOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, 1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, 1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, 1, of: "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, 1, of: "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, 1, of: "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, 1, of: "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfNegativeOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, -1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingBeginningOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, 1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, 1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfZeroOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 0, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingStartOfZeroOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, 0, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: " LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, 1, of: " VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.StartOf, 1, of: "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().Starting(The.StartOf, 1, of: "Some").IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().Starting(The.StartOf, 1, of: "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long ");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().Starting(The.StartOf, 1, of: "string").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very long ");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.StartOf, 2, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some VERY ");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.StartOf, 2, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some ");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().Starting(The.StartOf, 3, of: "vERy").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VERY long string with ");
        }

        [Test]
        public void RemoveStartingStartOfOccurrenceIgnoringCaseFromEndHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().Starting(The.StartOf, 3, of: "vERy").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very ");
        }

        [Test]
        public void RemoveStartingStartOfExceedingOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very VeRy long string".Remove().Starting(The.StartOf, 5, of: "VERY").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VeRy long string");
        }

        [Test]
        public void RemoveStartingStartOfExceedingOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very VeRy long string".Remove().Starting(The.StartOf, 5, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very VeRy long string");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfNegativeOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, -1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOfNegativeOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, -1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOfZeroOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 0, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingEndOfZeroOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, 0, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, 1, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.EndOf, 1, of: "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("SOME");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().Starting(The.EndOf, 1, of: "Some").IgnoringCase().From(The.End);
            transformed.Should().Be("SOmE");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().Starting(The.EndOf, 1, of: "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long sTRINg");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().Starting(The.EndOf, 1, of: "string").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very long STRING");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.EndOf, 2, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some VERY VERY");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.EndOf, 2, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some VERY");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().Starting(The.EndOf, 3, of: "vERy").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VERY long string with very");
        }

        [Test]
        public void RemoveStartingEndOfOccurrenceIgnoringCaseFromEndHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().Starting(The.EndOf, 3, of: "vERy").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very VERY");
        }

        [Test]
        public void RemoveStartingEndOfExceedingOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very VeRy long string".Remove().Starting(The.EndOf, 5, of: "VERY").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VeRy long string");
        }

        [Test]
        public void RemoveStartingEndOfExceedingOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very VeRy long string".Remove().Starting(The.EndOf, 5, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very VeRy long string");
        }

        #endregion
    }
}
