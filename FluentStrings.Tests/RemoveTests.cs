using System;
using dokas.FluentStrings;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringTransformerTests
{
    [TestClass()]
    public class RemoveTests
    {
        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Constants

        private const string NullString = null;
        private const string NothingShouldBeChanged = "Nothing should be changed";

        #endregion

        #region Remove

        [TestMethod()]
        public void RemoveTextFromNullString()
        {
            string transformed = NullString.Remove("bla");
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void RemoveNullText()
        {
            string transformed = NothingShouldBeChanged.Remove(null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void RemoveNullTextFromNullString()
        {
            string transformed = NullString.Remove(null);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void RemoveEmptyText()
        {
            string transformed = NothingShouldBeChanged.Remove(String.Empty);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void RemoveText()
        {
            string transformed = "TEST string will be removed".Remove("TEST");
            transformed.Should().Be(" string will be removed");

            transformed = "TEST string will be removed from both sides TEST".Remove("TEST");
            transformed.Should().Be(" string will be removed from both sides ");
        }

        #endregion

        #region Remove From

        [TestMethod()]
        public void RemoveTextFromBeginingOfNullString()
        {
            string transformed = NullString.Remove("bla").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void RemoveTextFromEndOfNullString()
        {
            string transformed = NullString.Remove("bla").From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void RemoveNullTextFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void RemoveNullTextFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void RemoveNullTextFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void RemoveNullTextFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void RemoveEmptyTextFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(String.Empty).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void RemoveEmptyTextFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(String.Empty).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void RemoveTextFromBegining()
        {
            string transformed = "TEST string will be removed".Remove("TEST").From(The.Beginning);
            transformed.Should().Be(" string will be removed");

            transformed = "TEST <- string will be removed, not this -> TEST".Remove("TEST").From(The.Beginning);
            transformed.Should().Be(" <- string will be removed, not this -> TEST");

            transformed = "Some additional string |TEST| string will be removed".Remove("TEST").From(The.Beginning);
            transformed.Should().Be("Some additional string || string will be removed");
        }

        [TestMethod()]
        public void RemoveTextFromEnd()
        {
            string transformed = "string will be removed -> TEST".Remove("TEST").From(The.End);
            transformed.Should().Be("string will be removed -> ");

            transformed = "TEST <- this string will be left, but this will be removed -> TEST".Remove("TEST").From(The.End);
            transformed.Should().Be("TEST <- this string will be left, but this will be removed -> ");

            transformed = "string will be removed -> |TEST| some additional string".Remove("TEST").From(The.End);
            transformed.Should().Be("string will be removed -> || some additional string");
        }

        #endregion

        #region Remove Before

        [TestMethod()]
        public void RemoveTextBefore()
        {
            string transformed = "string will be removed -> TEST".Remove("TEST").Before("Separator");
            transformed.Should().Be("string will be removed -> ");
        }

        #endregion

        #region Remove Before From

        [TestMethod()]
        public void RemoveTextBeforeFromBegining()
        {
            string transformed = "string will be removed -> TEST".Remove("TEST").Before("Separator").From(The.Beginning);
            transformed.Should().Be("string will be removed -> ");
        }

        [TestMethod()]
        public void RemoveTextBeforeFromEnd()
        {
            string transformed = "string will be removed -> TEST".Remove("TEST").Before("Separator").From(The.End);
            transformed.Should().Be("string will be removed -> ");
        }

        #endregion

        #region Remove Before Occurrence

        [TestMethod()]
        public void RemoveTextBeforeOccurrence()
        {
            string transformed = "string will be removed -> TEST".Remove("TEST").Before(2, "Separator");
            transformed.Should().Be("string will be removed -> ");
        }

        #endregion

        #region Remove Before Occurrence From

        [TestMethod()]
        public void RemoveTextBeforeOccurrenceFromBegining()
        {
            string transformed = "string will be removed -> TEST".Remove("TEST").Before(2, "Separator").From(The.Beginning);
            transformed.Should().Be("string will be removed -> ");
        }

        [TestMethod()]
        public void RemoveTextBeforeOccurrenceFromEnd()
        {
            string transformed = "string will be removed -> TEST".Remove("TEST").Before(2, "Separator").From(The.End);
            transformed.Should().Be("string will be removed -> ");
        }

        #endregion

        #region Remove After

        [TestMethod()]
        public void RemoveTextAfter()
        {
            string transformed = "string will be removed -> TEST".Remove("TEST").After("Separator");
            transformed.Should().Be("string will be removed -> ");
        }

        #endregion

        #region Remove After From

        [TestMethod()]
        public void RemoveTextAfterFromBegining()
        {
            string transformed = "string will be removed -> TEST".Remove("TEST").After("Separator").From(The.Beginning);
            transformed.Should().Be("string will be removed -> ");
        }

        [TestMethod()]
        public void RemoveTextAfterFromEnd()
        {
            string transformed = "string will be removed -> TEST".Remove("TEST").After("Separator").From(The.End);
            transformed.Should().Be("string will be removed -> ");
        }

        #endregion

        #region Remove After Occurrence

        [TestMethod()]
        public void RemoveTextAfterOccurrence()
        {
            string transformed = "string will be removed -> TEST".Remove("TEST").After(2, "Separator");
            transformed.Should().Be("string will be removed -> ");
        }

        #endregion

        #region Remove After Occurrence From

        [TestMethod()]
        public void RemoveTextAfterOccurrenceFromBegining()
        {
            string transformed = "string will be removed -> TEST".Remove("TEST").After(2, "Separator").From(The.Beginning);
            transformed.Should().Be("string will be removed -> ");
        }

        [TestMethod()]
        public void RemoveTextAfterOccurrenceFromEnd()
        {
            string transformed = "string will be removed -> TEST".Remove("TEST").After(2, "Separator").From(The.End);
            transformed.Should().Be("string will be removed -> ");
        }

        #endregion

        #region Remove Vowels

        [TestMethod()]
        public void RemoveVowels()
        {
            string transformed = "Vowels will be removed from this string".RemoveVowels();
            transformed.Should().Be("Vwls wll b rmvd frm ths strng");
        }

        #endregion

        [TestMethod()]
        public void RemoveSelectedChars()
        {
            string transformed = "Some very long string".RemoveChars('x', 'y', 'z');
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveChars()
        {
            string transformed = "Some very long string".RemoveChars(1);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveCharsFromBeginning()
        {
            string transformed = "Some very long string".RemoveChars(7).From(The.Beginning);
            transformed.Should().Be("ry long string");
        }

        [TestMethod()]
        public void RemoveCharsFromEnd()
        {
            string transformed = "Some very long string".RemoveChars(3).From(The.End);
            transformed.Should().Be("Some very long str");
        }

        [TestMethod()]
        public void RemoveStartingTo()
        {
            string transformed = "Some very long string".Remove().Starting(1).To(3);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveStartingToOccurrence()
        {
            string transformed = "Some very long string".Remove().Starting(1).To(3, "marker");
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveStartingToOccurrenceFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1).To(3, "marker").From(The.End);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveStartingFromTo()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(3);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveStartingFromToOccurrence()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(3, "marker");
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveStartingFromToOccurrenceFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(3, "marker").From(The.End);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveStartingFromToFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(3).From(The.End);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveFromNext()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).Next(3);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveFromPrevious()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).Previous(3);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveFromOccurrence()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker");
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveFromOccurrenceFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveFromOccurrenceTo()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(2);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveFromOccurrenceFromTo()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(2);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveFromOccurrenceToFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(2).From(The.End);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveFromOccurrenceFromToFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(2).From(The.End);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveFromOccurrenceToOccurrence()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(2, "marker");
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveFromOccurrenceToOccurrenceFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveFromOccurrenceFromToOccurrence()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(2, "marker");
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveFromOccurrenceFromToOccurrenceFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveStartingAtToStartOfMarker()
        {
            string transformed = "Some very long string".Remove().Starting(1).To(The.StartOf, 2, "marker");
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveStartingAtToStartOfMarkerFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1).To(The.StartOf, 2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveStartingAtFromBeginningToStartOfMarker()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(The.StartOf, 2, "marker");
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveStartingAtFromBeginningToStartOfMarkerFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(The.StartOf, 2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveStartingOfMarkerToStartOfMarker()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(The.StartOf, 2, "marker");
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveStartingOfMarkerToStartOfMarkerFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(The.StartOf, 2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveStartingOfMarkerFromBeginningToStartOfMarker()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(The.StartOf, 2, "marker");
            transformed.Should().Be("");
        }

        [TestMethod()]
        public void RemoveStartingOfMarkerFromBeginningToStartOfMarkerFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(The.StartOf, 2, "marker").From(The.End);
            transformed.Should().Be("");
        }
    }
}
