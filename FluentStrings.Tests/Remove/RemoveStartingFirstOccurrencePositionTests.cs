using System;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveStartingFirstOccurrencePositionTests
    {
        #region Remove Starting First Occurrence Position

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, null);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingBeginningFirstOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndFirstOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrence()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, " long");
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, "Some");
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, "string");
            transformed.Should().Be("Some very long ");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, "Long");
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, "very");
            transformed.Should().Be("Some ");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, null);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrence()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, "long");
            transformed.Should().Be("Some very long");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "Some");
            transformed.Should().Be("Some");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "string");
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, "Long");
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, "very");
            transformed.Should().Be("Some very");
        }

        #endregion

        #region Remove Starting First Occurrence Position From

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingBeginningFirstOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndFirstOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIndexFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, "very").From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIndexFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, "very").From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingBeginningFirstOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndFirstOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, " long").From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, " very").From(The.End);
            transformed.Should().Be("Some");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, "Some").From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, "Some").From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, "string").From(The.Beginning);
            transformed.Should().Be("Some very long ");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, "string").From(The.End);
            transformed.Should().Be("Some very long ");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.StartOf, "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, "very").From(The.Beginning);
            transformed.Should().Be("Some ");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.StartOf, "very").From(The.End);
            transformed.Should().Be("Some very ");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "long").From(The.Beginning);
            transformed.Should().Be("Some very long");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "very").From(The.End);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "Some").From(The.Beginning);
            transformed.Should().Be("Some");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "Some").From(The.End);
            transformed.Should().Be("Some");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "string").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "string").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(The.EndOf, "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, "very").From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(The.EndOf, "very").From(The.End);
            transformed.Should().Be("Some very very");
        }

        #endregion

        #region Remove Starting First Occurrence Position Ignoring Case

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingBeginningFirstOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndFirstOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, " lOnG").IgnoringCase();
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, "SOME").IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.StartOf, "string").IgnoringCase();
            transformed.Should().Be("SOME VERY LONG ");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().Starting(The.StartOf, "VERY").IgnoringCase();
            transformed.Should().Be("Some ");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "lOnG").IgnoringCase();
            transformed.Should().Be("Some very long");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "SOME").IgnoringCase();
            transformed.Should().Be("Some");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.EndOf, "string").IgnoringCase();
            transformed.Should().Be("SOME VERY LONG STRING");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().Starting(The.EndOf, "VERY").IgnoringCase();
            transformed.Should().Be("Some vErY");
        }

        #endregion

        #region Remove Starting First Occurrence Position Ignoring Case From

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.StartOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingBeginningFirstOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndFirstOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.StartOf, "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.EndOf, "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingBeginningFirstOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.Beginning, "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingEndFirstOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(The.End, "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, " LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.StartOf, " VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.StartOf, "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().Starting(The.StartOf, "Some").IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().Starting(The.StartOf, "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long ");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().Starting(The.StartOf, "string").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very long ");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.StartOf, "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some ");
        }

        [Test]
        public void RemoveStartingStartOfFirstOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.StartOf, "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some VERY ");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(The.EndOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(The.EndOf, "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(The.EndOf, "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("SOME");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().Starting(The.EndOf, "Some").IgnoringCase().From(The.End);
            transformed.Should().Be("SOmE");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().Starting(The.EndOf, "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long sTRINg");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().Starting(The.EndOf, "string").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very long STRING");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.EndOf, "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some VERY");
        }

        [Test]
        public void RemoveStartingEndOfFirstOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(The.EndOf, "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some VERY VERY");
        }

        #endregion
    }
}
