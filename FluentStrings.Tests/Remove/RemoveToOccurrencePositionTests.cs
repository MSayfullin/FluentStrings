using System;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveToOccurrencePositionTests
    {
        #region Remove To Occurrence Position

        [Test]
        public void RemoveToStartOfOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 1, of: null);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 2, of: String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 1, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfNegativeOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, -1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToBeginningOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, 1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, 1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfZeroOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 0, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToStartOfOccurrence()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, 1, of: "long");
            transformed.Should().Be("long long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "Some");
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "string");
            transformed.Should().Be("string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, 2, of: "Long");
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 2, of: "very");
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(The.StartOf, 3, of: "very");
            transformed.Should().Be("very very long string at the end");
        }

        [Test]
        public void RemoveToStartOfExceedingOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 5, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 1, of: null);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 2, of: String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveToEndOfOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 1, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfNegativeOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, -1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOfZeroOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 0, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToEndOfOccurrence()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, 1, of: "long");
            transformed.Should().Be(" long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "Some");
            transformed.Should().Be(" very long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "string");
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, 2, of: "Long");
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 2, of: "very");
            transformed.Should().Be(" long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(The.EndOf, 3, of: "very");
            transformed.Should().Be(" very long string at the end");
        }

        [Test]
        public void RemoveToEndOfExceedingOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 5, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        #endregion

        #region Remove To Occurrence Position From

        [Test]
        public void RemoveToStartOfOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 3, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfNegativeOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, -1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToBeginningOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, 1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, 1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfOccurrenceIndexFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, 1, of: "very").From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfOccurrenceIndexFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, 1, of: "very").From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfNegativeOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, -1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToBeginningOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, 1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, 1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfZeroOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 0, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToStartOfZeroOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 0, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "long").From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "very").From(The.End);
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "Some").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "Some").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "string").From(The.Beginning);
            transformed.Should().Be("string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "string").From(The.End);
            transformed.Should().Be("string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, 2, of: "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, 2, of: "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 2, of: "very").From(The.Beginning);
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 2, of: "very").From(The.End);
            transformed.Should().Be("very very long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(The.StartOf, 3, of: "very").From(The.Beginning);
            transformed.Should().Be("very very long string at the end");
        }

        [Test]
        public void RemoveToStartOfOccurrenceFromEndHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(The.StartOf, 3, of: "very").From(The.End);
            transformed.Should().Be("very long string with very very long string at the end");
        }

        [Test]
        public void RemoveToStartOfExceedingOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 5, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToStartOfExceedingOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 5, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 3, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfNegativeOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, -1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOfNegativeOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, -1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOfZeroOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 0, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToEndOfZeroOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 0, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "long").From(The.Beginning);
            transformed.Should().Be(" string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "very").From(The.End);
            transformed.Should().Be(" long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "Some").From(The.Beginning);
            transformed.Should().Be(" very long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "Some").From(The.End);
            transformed.Should().Be(" very long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "string").From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "string").From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, 2, of: "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, 2, of: "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 2, of: "very").From(The.Beginning);
            transformed.Should().Be(" long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 2, of: "very").From(The.End);
            transformed.Should().Be(" very long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(The.EndOf, 3, of: "very").From(The.Beginning);
            transformed.Should().Be(" very long string at the end");
        }

        [Test]
        public void RemoveToEndOfOccurrenceFromEndHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(The.EndOf, 3, of: "very").From(The.End);
            transformed.Should().Be(" long string with very very long string at the end");
        }

        [Test]
        public void RemoveToEndOfExceedingOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 5, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToEndOfExceedingOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 5, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        #endregion

        #region Remove To Occurrence Position Ignoring Case

        [Test]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfNegativeOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, -1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToBeginningOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, 1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, 1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfZeroOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 0, of: "very").IgnoringCase();
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "lOnG").IgnoringCase();
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "SOME").IgnoringCase();
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.StartOf, 1, of: "string").IgnoringCase();
            transformed.Should().Be("STRING");
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().To(The.StartOf, 2, of: "VERY").IgnoringCase();
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with VERY very long string at the end".Remove().To(The.StartOf, 3, of: "vERy").IgnoringCase();
            transformed.Should().Be("VERY very long string at the end");
        }

        [Test]
        public void RemoveToStartOfExceedingOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very VERY long string".Remove().To(The.StartOf, 5, of: "VerY").IgnoringCase();
            transformed.Should().Be("Some very VERY long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveToEndOfOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfNegativeOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, -1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOfZeroOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 0, of: "very").IgnoringCase();
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "lOnG").IgnoringCase();
            transformed.Should().Be(" string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "SOME").IgnoringCase();
            transformed.Should().Be(" very long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.EndOf, 1, of: "string").IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().To(The.EndOf, 2, of: "VERY").IgnoringCase();
            transformed.Should().Be(" long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with VERY very long string at the end".Remove().To(The.EndOf, 3, of: "vERy").IgnoringCase();
            transformed.Should().Be(" very long string at the end");
        }

        [Test]
        public void RemoveToEndOfExceedingOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very VERY long string".Remove().To(The.EndOf, 5, of: "VerY").IgnoringCase();
            transformed.Should().Be("Some very VERY long string");
        }

        #endregion

        #region Remove To Occurrence Position Ignoring Case From

        [Test]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfNegativeOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, -1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToBeginningOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, 1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, 1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, 1, of: "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, 1, of: "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOfOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, 1, of: "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOfOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, 1, of: "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfNegativeOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, -1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToBeginningOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, 1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, 1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfZeroOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 0, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToStartOfZeroOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 0, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.StartOf, 1, of: "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("SOME VERY LONG STRING");
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().To(The.StartOf, 1, of: "Some").IgnoringCase().From(The.End);
            transformed.Should().Be("SOmE very long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().To(The.StartOf, 1, of: "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("sTRINg");
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().To(The.StartOf, 1, of: "string").IgnoringCase().From(The.End);
            transformed.Should().Be("STRING");
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.StartOf, 2, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("VERY long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.StartOf, 2, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("VERY VERY long string");
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().To(The.StartOf, 3, of: "vERy").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("very VERY long string at the end");
        }

        [Test]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromEndHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().To(The.StartOf, 3, of: "vERy").IgnoringCase().From(The.End);
            transformed.Should().Be("VERY long string with very VERY long string at the end");
        }

        [Test]
        public void RemoveToStartOfExceedingOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very VeRy long string".Remove().To(The.StartOf, 5, of: "VERY").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VeRy long string");
        }

        [Test]
        public void RemoveToStartOfExceedingOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very VeRy long string".Remove().To(The.StartOf, 5, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very VeRy long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfNegativeOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, -1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOfNegativeOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, -1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOfZeroOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 0, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToEndOfZeroOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 0, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be(" long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.EndOf, 1, of: "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" VERY LONG STRING");
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().To(The.EndOf, 1, of: "Some").IgnoringCase().From(The.End);
            transformed.Should().Be(" very long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().To(The.EndOf, 1, of: "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().To(The.EndOf, 1, of: "string").IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.EndOf, 2, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.EndOf, 2, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be(" VERY long string");
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().To(The.EndOf, 3, of: "vERy").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" VERY long string at the end");
        }

        [Test]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromEndHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().To(The.EndOf, 3, of: "vERy").IgnoringCase().From(The.End);
            transformed.Should().Be(" long string with very VERY long string at the end");
        }

        [Test]
        public void RemoveToEndOfExceedingOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very VeRy long string".Remove().To(The.EndOf, 5, of: "VERY").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VeRy long string");
        }

        [Test]
        public void RemoveToEndOfExceedingOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very VeRy long string".Remove().To(The.EndOf, 5, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very VeRy long string");
        }

        #endregion
    }
}
