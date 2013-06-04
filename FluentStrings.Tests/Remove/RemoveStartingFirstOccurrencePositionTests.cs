using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveStartingFirstOccurrencePositionTests
    {
        #region Remove Starting First Occurrence Position

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingBeginningFirstOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndFirstOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrence()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, " long");
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, "Some");
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, "string");
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, "Long");
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, "very");
            transformed.Should().Be("Some ");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrence()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, "long");
            transformed.Should().Be("Some very long");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "Some");
            transformed.Should().Be("Some");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "string");
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, "Long");
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, "very");
            transformed.Should().Be("Some very");
        }

        #endregion

        #region Remove Starting First Occurrence Position From

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingBeginningFirstOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndFirstOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIndexFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, "very").From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIndexFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, "very").From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingBeginningFirstOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndFirstOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, " long").From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, " very").From(The.End);
            transformed.Should().Be("Some");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, "Some").From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, "Some").From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, "string").From(The.Beginning);
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, "string").From(The.End);
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, "very").From(The.Beginning);
            transformed.Should().Be("Some ");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, "very").From(The.End);
            transformed.Should().Be("Some very ");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "long").From(The.Beginning);
            transformed.Should().Be("Some very long");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "very").From(The.End);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "Some").From(The.Beginning);
            transformed.Should().Be("Some");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "Some").From(The.End);
            transformed.Should().Be("Some");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "string").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "string").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, "very").From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, "very").From(The.End);
            transformed.Should().Be("Some very very");
        }

        #endregion

        #region Remove Starting First Occurrence Position Ignoring Case

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingBeginningFirstOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndFirstOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, " lOnG").IgnoringCase();
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, "SOME").IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.StartOf, "string").IgnoringCase();
            transformed.Should().Be("SOME VERY LONG ");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().Starting(The.StartOf, "VERY").IgnoringCase();
            transformed.Should().Be("Some ");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "lOnG").IgnoringCase();
            transformed.Should().Be("Some very long");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "SOME").IgnoringCase();
            transformed.Should().Be("Some");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.EndOf, "string").IgnoringCase();
            transformed.Should().Be("SOME VERY LONG STRING");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().Starting(The.EndOf, "VERY").IgnoringCase();
            transformed.Should().Be("Some vErY");
        }

        #endregion

        #region Remove Starting First Occurrence Position Ignoring Case From

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingBeginningFirstOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndFirstOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingBeginningFirstOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingEndFirstOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, " LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, " VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.StartOf, "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().Starting(The.StartOf, "Some").IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().Starting(The.StartOf, "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().Starting(The.StartOf, "string").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.StartOf, "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some ");
        }

        [TestMethod]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.StartOf, "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some VERY ");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.EndOf, "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("SOME");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().Starting(The.EndOf, "Some").IgnoringCase().From(The.End);
            transformed.Should().Be("SOmE");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().Starting(The.EndOf, "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long sTRINg");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().Starting(The.EndOf, "string").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very long STRING");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.EndOf, "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some VERY");
        }

        [TestMethod]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.EndOf, "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some VERY VERY");
        }

        #endregion
    }
}
