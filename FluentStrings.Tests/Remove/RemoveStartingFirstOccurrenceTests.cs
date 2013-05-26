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
    }
}
