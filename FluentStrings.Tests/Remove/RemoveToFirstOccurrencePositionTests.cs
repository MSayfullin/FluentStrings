using System;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveToFirstOccurrencePositionTests
    {
        #region Remove To First Occurrence Position

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, null);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToBeginningFirstOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndFirstOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfFirstOccurrence()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, "long");
            transformed.Should().Be("long long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "Some");
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "string");
            transformed.Should().Be("string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, "Long");
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, "very");
            transformed.Should().Be("very very long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, null);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrence()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, "long");
            transformed.Should().Be(" long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "Some");
            transformed.Should().Be(" very long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "string");
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, "Long");
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, "very");
            transformed.Should().Be(" very long string");
        }

        #endregion

        #region Remove To First Occurrence Position From

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToBeginningFirstOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndFirstOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIndexFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, "very").From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIndexFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, "very").From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToBeginningFirstOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndFirstOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "long").From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "very").From(The.End);
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "Some").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "Some").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "string").From(The.Beginning);
            transformed.Should().Be("string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "string").From(The.End);
            transformed.Should().Be("string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, "very").From(The.Beginning);
            transformed.Should().Be("very very long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, "very").From(The.End);
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "long").From(The.Beginning);
            transformed.Should().Be(" string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "very").From(The.End);
            transformed.Should().Be(" long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "Some").From(The.Beginning);
            transformed.Should().Be(" very long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "Some").From(The.End);
            transformed.Should().Be(" very long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "string").From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "string").From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, "very").From(The.Beginning);
            transformed.Should().Be(" very long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, "very").From(The.End);
            transformed.Should().Be(" long string");
        }

        #endregion

        #region Remove To First Occurrence Position Ignoring Case

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToBeginningFirstOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndFirstOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "lOnG").IgnoringCase();
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "SOME").IgnoringCase();
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.StartOf, "string").IgnoringCase();
            transformed.Should().Be("STRING");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().To(The.StartOf, "VERY").IgnoringCase();
            transformed.Should().Be("vErY very long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "lOnG").IgnoringCase();
            transformed.Should().Be(" string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "SOME").IgnoringCase();
            transformed.Should().Be(" very long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.EndOf, "string").IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().To(The.EndOf, "VERY").IgnoringCase();
            transformed.Should().Be(" very long string");
        }

        #endregion

        #region Remove To First Occurrence Position Ignoring Case From

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToBeginningFirstOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndFirstOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToBeginningFirstOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToEndFirstOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.StartOf, "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("SOME VERY LONG STRING");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().To(The.StartOf, "Some").IgnoringCase().From(The.End);
            transformed.Should().Be("SOmE very long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().To(The.StartOf, "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("sTRINg");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().To(The.StartOf, "string").IgnoringCase().From(The.End);
            transformed.Should().Be("STRING");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.StartOf, "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("VERY VERY long string");
        }

        [Test]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.StartOf, "very").IgnoringCase().From(The.End);
            transformed.Should().Be("VERY long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be(" long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.EndOf, "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" VERY LONG STRING");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().To(The.EndOf, "Some").IgnoringCase().From(The.End);
            transformed.Should().Be(" very long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().To(The.EndOf, "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().To(The.EndOf, "string").IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.EndOf, "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" VERY long string");
        }

        [Test]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.EndOf, "very").IgnoringCase().From(The.End);
            transformed.Should().Be(" long string");
        }

        #endregion
    }
}
