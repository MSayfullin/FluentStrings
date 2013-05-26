using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveStartingFirstOccurrenceTests
    {
        #region Remove Starting First Occurrence

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().Starting(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrence()
        {
            string transformed = "Some very long string".Remove().Starting(" long");
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting("Some");
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting("string");
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceCaseSensitive()
        {
            string transformed = "Some very long string".Remove().Starting("Long");
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting("very");
            transformed.Should().Be("Some ");
        }

        #endregion

        #region Remove Starting First Occurrence From

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(" long").From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(" very").From(The.End);
            transformed.Should().Be("Some");
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting("Some").From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting("Some").From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting("string").From(The.Beginning);
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting("string").From(The.End);
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long string".Remove().Starting("Long").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long string".Remove().Starting("Long").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting("very").From(The.Beginning);
            transformed.Should().Be("Some ");
        }

        [TestMethod]
        public void RemoveStartingFirstOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting("very").From(The.End);
            transformed.Should().Be("Some very ");
        }

        #endregion
    }
}
