using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveToOccurrencePositionTests
    {
        #region Remove To Occurrence Position

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 1, of: null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 2, of: String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 1, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfNegativeOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, -1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToBeginningOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, 1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, 1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfZeroOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 0, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrence()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, 1, of: "long");
            transformed.Should().Be("long long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "Some");
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "string");
            transformed.Should().Be("string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, 2, of: "Long");
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 2, of: "very");
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(The.StartOf, 3, of: "very");
            transformed.Should().Be("very very long string at the end");
        }

        [TestMethod]
        public void RemoveToStartOfExceedingOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 5, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 1, of: null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 2, of: String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 2, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 1, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfNegativeOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, -1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOfZeroOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 0, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrence()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, 1, of: "long");
            transformed.Should().Be(" long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "Some");
            transformed.Should().Be(" very long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "string");
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, 2, of: "Long");
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 2, of: "very");
            transformed.Should().Be(" long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(The.EndOf, 3, of: "very");
            transformed.Should().Be(" very long string at the end");
        }

        [TestMethod]
        public void RemoveToEndOfExceedingOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 5, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        #endregion

        #region Remove To Occurrence Position From

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 3, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfNegativeOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, -1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToBeginningOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, 1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, 1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIndexFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, 1, of: "very").From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIndexFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, 1, of: "very").From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfNegativeOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, -1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToBeginningOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, 1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, 1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfZeroOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 0, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToStartOfZeroOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 0, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "long").From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "very").From(The.End);
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "Some").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "Some").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "string").From(The.Beginning);
            transformed.Should().Be("string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "string").From(The.End);
            transformed.Should().Be("string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, 2, of: "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, 2, of: "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 2, of: "very").From(The.Beginning);
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 2, of: "very").From(The.End);
            transformed.Should().Be("very very long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(The.StartOf, 3, of: "very").From(The.Beginning);
            transformed.Should().Be("very very long string at the end");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceFromEndHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(The.StartOf, 3, of: "very").From(The.End);
            transformed.Should().Be("very long string with very very long string at the end");
        }

        [TestMethod]
        public void RemoveToStartOfExceedingOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 5, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToStartOfExceedingOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 5, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 3, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfNegativeOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, -1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOfNegativeOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, -1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOfZeroOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 0, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToEndOfZeroOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 0, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "long").From(The.Beginning);
            transformed.Should().Be(" string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "very").From(The.End);
            transformed.Should().Be(" long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "Some").From(The.Beginning);
            transformed.Should().Be(" very long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "Some").From(The.End);
            transformed.Should().Be(" very long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "string").From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "string").From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, 2, of: "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, 2, of: "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 2, of: "very").From(The.Beginning);
            transformed.Should().Be(" long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 2, of: "very").From(The.End);
            transformed.Should().Be(" very long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(The.EndOf, 3, of: "very").From(The.Beginning);
            transformed.Should().Be(" very long string at the end");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceFromEndHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(The.EndOf, 3, of: "very").From(The.End);
            transformed.Should().Be(" long string with very very long string at the end");
        }

        [TestMethod]
        public void RemoveToEndOfExceedingOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 5, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToEndOfExceedingOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 5, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        #endregion

        #region Remove To Occurrence Position Ignoring Case

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfNegativeOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, -1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToBeginningOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, 1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, 1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfZeroOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 0, of: "very").IgnoringCase();
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "lOnG").IgnoringCase();
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "SOME").IgnoringCase();
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.StartOf, 1, of: "string").IgnoringCase();
            transformed.Should().Be("STRING");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().To(The.StartOf, 2, of: "VERY").IgnoringCase();
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with VERY very long string at the end".Remove().To(The.StartOf, 3, of: "vERy").IgnoringCase();
            transformed.Should().Be("VERY very long string at the end");
        }

        [TestMethod]
        public void RemoveToStartOfExceedingOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very VERY long string".Remove().To(The.StartOf, 5, of: "VerY").IgnoringCase();
            transformed.Should().Be("Some very VERY long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 1, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfNegativeOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, -1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOfZeroOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 0, of: "very").IgnoringCase();
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "lOnG").IgnoringCase();
            transformed.Should().Be(" string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "SOME").IgnoringCase();
            transformed.Should().Be(" very long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.EndOf, 1, of: "string").IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().To(The.EndOf, 2, of: "VERY").IgnoringCase();
            transformed.Should().Be(" long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with VERY very long string at the end".Remove().To(The.EndOf, 3, of: "vERy").IgnoringCase();
            transformed.Should().Be(" very long string at the end");
        }

        [TestMethod]
        public void RemoveToEndOfExceedingOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very VERY long string".Remove().To(The.EndOf, 5, of: "VerY").IgnoringCase();
            transformed.Should().Be("Some very VERY long string");
        }

        #endregion

        #region Remove To Occurrence Position Ignoring Case From

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfNegativeOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, -1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToBeginningOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, 1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, 1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, 1, of: "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, 1, of: "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, 1, of: "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, 1, of: "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfNegativeOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, -1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToBeginningOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, 1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, 1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfZeroOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 0, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToStartOfZeroOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, 0, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, 1, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.StartOf, 1, of: "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("SOME VERY LONG STRING");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().To(The.StartOf, 1, of: "Some").IgnoringCase().From(The.End);
            transformed.Should().Be("SOmE very long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().To(The.StartOf, 1, of: "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("sTRINg");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().To(The.StartOf, 1, of: "string").IgnoringCase().From(The.End);
            transformed.Should().Be("STRING");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.StartOf, 2, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("VERY long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.StartOf, 2, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("VERY VERY long string");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().To(The.StartOf, 3, of: "vERy").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("very VERY long string at the end");
        }

        [TestMethod]
        public void RemoveToStartOfOccurrenceIgnoringCaseFromEndHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().To(The.StartOf, 3, of: "vERy").IgnoringCase().From(The.End);
            transformed.Should().Be("VERY long string with very VERY long string at the end");
        }

        [TestMethod]
        public void RemoveToStartOfExceedingOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very VeRy long string".Remove().To(The.StartOf, 5, of: "VERY").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VeRy long string");
        }

        [TestMethod]
        public void RemoveToStartOfExceedingOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very VeRy long string".Remove().To(The.StartOf, 5, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very VeRy long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, 3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, 2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfNegativeOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, -1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOfNegativeOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, -1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOfZeroOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 0, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToEndOfZeroOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, 0, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, 1, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be(" long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.EndOf, 1, of: "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" VERY LONG STRING");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().To(The.EndOf, 1, of: "Some").IgnoringCase().From(The.End);
            transformed.Should().Be(" very long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().To(The.EndOf, 1, of: "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().To(The.EndOf, 1, of: "string").IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.EndOf, 2, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.EndOf, 2, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be(" VERY long string");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().To(The.EndOf, 3, of: "vERy").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" VERY long string at the end");
        }

        [TestMethod]
        public void RemoveToEndOfOccurrenceIgnoringCaseFromEndHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().To(The.EndOf, 3, of: "vERy").IgnoringCase().From(The.End);
            transformed.Should().Be(" long string with very VERY long string at the end");
        }

        [TestMethod]
        public void RemoveToEndOfExceedingOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very VeRy long string".Remove().To(The.EndOf, 5, of: "VERY").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VeRy long string");
        }

        [TestMethod]
        public void RemoveToEndOfExceedingOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very VeRy long string".Remove().To(The.EndOf, 5, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very VeRy long string");
        }

        #endregion
    }
}
