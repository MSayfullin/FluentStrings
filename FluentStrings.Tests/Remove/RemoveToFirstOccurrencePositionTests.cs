using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveToFirstOccurrencePositionTests
    {
        #region Remove To First Occurrence Position

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToBeginningFirstOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndFirstOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrence()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, "long");
            transformed.Should().Be("long long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "Some");
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "string");
            transformed.Should().Be("string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, "Long");
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, "very");
            transformed.Should().Be("very very long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrence()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, "long");
            transformed.Should().Be(" long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "Some");
            transformed.Should().Be(" very long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "string");
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, "Long");
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, "very");
            transformed.Should().Be(" very long string");
        }

        #endregion

        #region Remove To First Occurrence Position From

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToBeginningFirstOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndFirstOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIndexFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, "very").From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIndexFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, "very").From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToBeginningFirstOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndFirstOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "long").From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "very").From(The.End);
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "Some").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "Some").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "string").From(The.Beginning);
            transformed.Should().Be("string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "string").From(The.End);
            transformed.Should().Be("string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.StartOf, "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, "very").From(The.Beginning);
            transformed.Should().Be("very very long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.StartOf, "very").From(The.End);
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "long").From(The.Beginning);
            transformed.Should().Be(" string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "very").From(The.End);
            transformed.Should().Be(" long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "Some").From(The.Beginning);
            transformed.Should().Be(" very long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "Some").From(The.End);
            transformed.Should().Be(" very long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "string").From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "string").From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(The.EndOf, "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, "very").From(The.Beginning);
            transformed.Should().Be(" very long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(The.EndOf, "very").From(The.End);
            transformed.Should().Be(" long string");
        }

        #endregion

        #region Remove To First Occurrence Position Ignoring Case

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToBeginningFirstOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndFirstOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "lOnG").IgnoringCase();
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "SOME").IgnoringCase();
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.StartOf, "string").IgnoringCase();
            transformed.Should().Be("STRING");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().To(The.StartOf, "VERY").IgnoringCase();
            transformed.Should().Be("vErY very long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "lOnG").IgnoringCase();
            transformed.Should().Be(" string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "SOME").IgnoringCase();
            transformed.Should().Be(" very long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.EndOf, "string").IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().To(The.EndOf, "VERY").IgnoringCase();
            transformed.Should().Be(" very long string");
        }

        #endregion

        #region Remove To First Occurrence Position Ignoring Case From

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.StartOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.StartOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToBeginningFirstOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndFirstOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.StartOf, "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIndexIgnoringCaseFromStartOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, "very").IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIndexIgnoringCaseFromEndOf()
        {
            Action action = () => "Some very very long string".Remove().To(The.EndOf, "very").IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToBeginningFirstOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.Beginning, "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToEndFirstOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(The.End, "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.StartOf, "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.StartOf, "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("SOME VERY LONG STRING");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().To(The.StartOf, "Some").IgnoringCase().From(The.End);
            transformed.Should().Be("SOmE very long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().To(The.StartOf, "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("sTRINg");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().To(The.StartOf, "string").IgnoringCase().From(The.End);
            transformed.Should().Be("STRING");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.StartOf, "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("VERY VERY long string");
        }

        [TestMethod]
        public void RemoveToStartOfFirstOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.StartOf, "very").IgnoringCase().From(The.End);
            transformed.Should().Be("VERY long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(The.EndOf, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(The.EndOf, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().To(The.EndOf, "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be(" long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(The.EndOf, "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" VERY LONG STRING");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().To(The.EndOf, "Some").IgnoringCase().From(The.End);
            transformed.Should().Be(" very long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().To(The.EndOf, "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().To(The.EndOf, "string").IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.EndOf, "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" VERY long string");
        }

        [TestMethod]
        public void RemoveToEndOfFirstOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(The.EndOf, "very").IgnoringCase().From(The.End);
            transformed.Should().Be(" long string");
        }

        #endregion
    }
}
