using System;
using dokas.FluentStrings;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentStrings.Tests
{
    [TestClass]
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

        [TestMethod]
        public void RemoveTextFromNullString()
        {
            string transformed = NullString.Remove("bla");
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullText()
        {
            string transformed = NothingShouldBeChanged.Remove(null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveNullTextFromNullString()
        {
            string transformed = NullString.Remove(null);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveEmptyText()
        {
            string transformed = NothingShouldBeChanged.Remove(String.Empty);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveText()
        {
            string transformed = "TEST string will be removed".Remove("TEST");
            transformed.Should().Be(" string will be removed");

            transformed = "TEST string will be removed from both sides TEST".Remove("TEST");
            transformed.Should().Be(" string will be removed from both sides ");
        }

        #endregion

        #region Remove From

        [TestMethod]
        public void RemoveTextFromBeginingOfNullString()
        {
            string transformed = NullString.Remove("bla").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveTextFromEndOfNullString()
        {
            string transformed = NullString.Remove("bla").From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullTextFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveNullTextFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveNullTextFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullTextFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveEmptyTextFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(String.Empty).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveEmptyTextFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(String.Empty).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveTextFromBegining()
        {
            string transformed = "TEST string will be removed".Remove("TEST").From(The.Beginning);
            transformed.Should().Be(" string will be removed");

            transformed = "TEST <- string will be removed, not this -> TEST".Remove("TEST").From(The.Beginning);
            transformed.Should().Be(" <- string will be removed, not this -> TEST");

            transformed = "Some additional string |TEST| string will be removed".Remove("TEST").From(The.Beginning);
            transformed.Should().Be("Some additional string || string will be removed");
        }

        [TestMethod]
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

        #region Full Remove

        [TestMethod]
        public void RemoveFromNullString()
        {
            string transformed = NullString.Remove();
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveFromEmptyString()
        {
            string transformed = String.Empty.Remove();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void Remove()
        {
            string transformed = "Some string".Remove();
            transformed.Should().Be(String.Empty);
        }

        #endregion

        #region Remove Before

        [TestMethod]
        public void RemoveNullBeforeNullMarkerFromNullString()
        {
            string transformed = NullString.Remove(null).Before(null);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerFromNullString()
        {
            string transformed = NullString.Remove(null).Before("marker");
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerFromNullString()
        {
            string transformed = NullString.Remove("something").Before("marker");
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarker()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveNullBeforeMarker()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before("marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).Before("marker");
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextBeforeNonExistingMarker()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").Before("marker");
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveTextBeforeMarker()
        {
            string transformed = "This string will be removed -> TEST and this -> TEST also because 'marker' is here. And this TEST will be left".Remove("TEST").Before("marker");
            transformed.Should().Be("This string will be removed ->  and this ->  also because 'marker' is here. And this TEST will be left");
        }

        #endregion

        #region Remove Before From

        [TestMethod]
        public void RemoveNullBeforeNullMarkerFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).Before(null).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarkerFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).Before(null).From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).Before("marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).Before("marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerFromBeginingOfNullString()
        {
            string transformed = NullString.Remove("something").Before("marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerFromEndOfNullString()
        {
            string transformed = NullString.Remove("something").Before("marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarkerFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(null).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarkerFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(null).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before("marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).Before("marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before("marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).Before("marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextBeforeNonExistingMarkerFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").Before("marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveTextBeforeNonExistingMarkerFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").Before("marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerFromBegining()
        {
            string transformed = "This string will be removed -> TEST and this -> TEST also because 'marker' is here. And this TEST will be left".Remove("TEST").Before("marker").From(The.Beginning);
            transformed.Should().Be("This string will be removed ->  and this ->  also because 'marker' is here. And this TEST will be left");
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerFromEnd()
        {
            string transformed = "This string will NOT be removed -> TEST and this also -> TEST also because 'marker' is here. And this TEST will NOT be left".Remove("TEST").Before("marker").From(The.End);
            transformed.Should().Be("This string will NOT be removed -> TEST and this also -> TEST also because 'marker' is here. And this  will NOT be left");

            transformed = "This string will be left -> TEST because 'marker' is here. And this TEST and this TEST and even this TEST will be removed".Remove("TEST").Before("marker").From(The.End);
            transformed.Should().Be("This string will be left -> TEST because 'marker' is here. And this  and this  and even this  will be removed");
        }

        #endregion

        #region Remove Before Occurrence

        [TestMethod]
        public void RemoveNullBeforeNullMarkerOccurrenceFromNullString()
        {
            string transformed = NullString.Remove(null).Before(3, null);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).Before(1, null);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerOccurrenceFromNullString()
        {
            string transformed = NullString.Remove(null).Before(4, "marker");
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).Before(0, "marker");
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerOccurrenceFromNullString()
        {
            string transformed = NullString.Remove("something").Before(2, "marker");
            transformed.Should().Be(NullString);

            transformed = NullString.Remove("something").Before(4, "marker");
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarkerOccurrence()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(2, null);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).Before(0, null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerOccurrence()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(1, "marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).Before(7, "marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).Before(1, "marker");
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextBeforeNonExistingMarkerOccurrence()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").Before(3, "marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove("TEST").Before(1, "marker");
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerOccurrence()
        {
            string transformed = "This string will be removed -> TEST and this -> TEST also because 'marker' is here. And this TEST will be left".Remove("TEST").Before(1, "marker");
            transformed.Should().Be("This string will be removed ->  and this ->  also because 'marker' is here. And this TEST will be left");

            transformed = "This string will be removed -> TEST and this -> TEST also because of next 'marker'. And this TEST will be removed either because of this 'marker'. And this TEST will be left".Remove("TEST").Before(2, "marker");
            transformed.Should().Be("This string will be removed ->  and this ->  also because of next 'marker'. And this  will be removed either because of this 'marker'. And this TEST will be left");

            transformed = "some some some TEST some TEST another TEST marker TEST TEST TEST marker TEST some words TEST".Remove("TEST").Before(2, "marker");
            transformed.Should().Be("some some some  some  another  marker    marker TEST some words TEST");
        }

        #endregion

        #region Remove Before Occurrence From

        [TestMethod]
        public void RemoveNullBeforeNullMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).Before(3, null).From(The.Beginning);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).Before(1, null).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).Before(3, null).From(The.End);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).Before(1, null).From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).Before(4, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).Before(0, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).Before(4, "marker").From(The.End);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).Before(0, "marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = NullString.Remove("something").Before(2, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove("something").Before(4, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Remove("something").Before(2, "marker").From(The.End);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove("something").Before(4, "marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarkerOccurrenceFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(2, null).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).Before(0, null).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarkerOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(2, null).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).Before(0, null).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerOccurrenceFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(1, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).Before(7, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).Before(1, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(1, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).Before(7, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).Before(1, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextBeforeNonExistingMarkerOccurrenceFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").Before(3, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);  

            transformed = NothingShouldBeChanged + "even if marker is here".Remove("TEST").Before(1, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextBeforeNonExistingMarkerOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").Before(3, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove("TEST").Before(1, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerOccurrenceFromBegining()
        {
            string transformed = "This string will be removed -> TEST and this -> TEST also because 'marker' is here. And this TEST will be left".Remove("TEST").Before(1, "marker").From(The.Beginning);
            transformed.Should().Be("This string will be removed ->  and this ->  also because 'marker' is here. And this TEST will be left");

            transformed = @"This string will be removed -> TEST and this -> TEST also because of next 'marker'.
                            And this TEST will be removed either because of this 'marker'. And this TEST will be left".Remove("TEST").Before(2, "marker").From(The.Beginning);
            transformed.Should().Be("This string will be removed ->  and this ->  also because of next 'marker'. And this  will be removed either because of this 'marker'. And this TEST will be left");

            transformed = "some some some TEST some TEST another TEST marker TEST TEST TEST marker TEST some words TEST".Remove("TEST").Before(2, "marker").From(The.Beginning);
            transformed.Should().Be("some some some  some  another  marker    marker TEST some words TEST");
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerOccurrenceFromEnd()
        {
            string transformed = "This string will be removed -> TEST and this -> TEST also because 'marker' is here. And this TEST will be left".Remove("TEST").Before(1, "marker").From(The.End);
            transformed.Should().Be("This string will be removed ->  and this ->  also because 'marker' is here. And this TEST will be left");

            transformed = @"This string will be removed -> TEST and this -> TEST also because of second 'marker' from the END.
                            And this TEST will be removed either because of second 'marker'. And here is is! Second 'marker' from the end. And this TEST will be left, as all the others TEST".Remove("TEST").Before(2, "marker").From(The.End);
            transformed.Should().Be("This string will be removed ->  and this ->  also because of second 'marker' from the END. And this  will be removed either because of second 'marker'. And here is is! Second 'marker' from the end. And this TEST will be left, as all the others TEST");

            transformed = "some some some TEST marker some TEST another TEST marker TEST TEST TEST marker TEST some words TEST marker some some TEST words".Remove("TEST").Before(2, "marker").From(The.End);
            transformed.Should().Be("some some some  marker some  another  marker    marker TEST some words TEST marker some some TEST words");
        }

        #endregion

        #region Remove After

        [TestMethod]
        public void RemoveNullAfterNullMarkerFromNullString()
        {
            string transformed = NullString.Remove(null).After(null);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerFromNullString()
        {
            string transformed = NullString.Remove(null).After("marker");
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveTextAfterMarkerFromNullString()
        {
            string transformed = NullString.Remove("something").After("marker");
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarker()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveNullAfterMarker()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After("marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).After("marker");
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextAfterNonExistingMarker()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").After("marker");
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveTextAfterMarker()
        {
            string transformed = "This string will be left -> TEST and this -> TEST also because 'marker' is here. And this TEST will be removed".Remove("TEST").After("marker");
            transformed.Should().Be("This string will be left -> TEST and this -> TEST also because 'marker' is here. And this  will be removed");

            transformed = "This string will be left -> TEST and this -> TEST also because 'marker' is here. And this TEST will be removed with this TEST one".Remove("TEST").After("marker");
            transformed.Should().Be("This string will be left -> TEST and this -> TEST also because 'marker' is here. And this  will be removed with this  one");
        }

        #endregion

        #region Remove After From

        [TestMethod]
        public void RemoveNullAfterNullMarkerFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).After(null).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarkerFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).After(null).From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).After("marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).After("marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveTextAfterMarkerFromBeginingOfNullString()
        {
            string transformed = NullString.Remove("something").After("marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveTextAfterMarkerFromEndOfNullString()
        {
            string transformed = NullString.Remove("something").After("marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarkerFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(null).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarkerFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(null).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After("marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).After("marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveNullAfterMarkerFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After("marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).After("marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextAfterNonExistingMarkerFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").After("marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveTextAfterNonExistingMarkerFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").After("marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveTextAfterMarkerFromBegining()
        {
            string transformed = "This string will be left -> TEST and this -> TEST also because 'marker' is here. And this TEST will be removed".Remove("TEST").After("marker").From(The.Beginning);
            transformed.Should().Be("This string will be left -> TEST and this -> TEST also because 'marker' is here. And this  will be removed");

            transformed = "This string will be left -> TEST and this -> TEST also because 'marker' is here. And this TEST will be removed with this TEST one".Remove("TEST").After("marker").From(The.Beginning);
            transformed.Should().Be("This string will be left -> TEST and this -> TEST also because 'marker' is here. And this  will be removed with this  one");
        }

        [TestMethod]
        public void RemoveTextAfterMarkerFromEnd()
        {
            string transformed = "This string will be removed -> TEST and this also -> TEST because 'marker' is here. And this TEST will be left".Remove("TEST").After("marker").From(The.End);
            transformed.Should().Be("This string will be removed ->  and this also ->  because 'marker' is here. And this TEST will be left");

            transformed = "This string will be removed -> TEST because 'marker' is here. And this TEST and this TEST and even this TEST will be left".Remove("TEST").After("marker").From(The.End);
            transformed.Should().Be("This string will be removed ->  because 'marker' is here. And this TEST and this TEST and even this TEST will be left");
        }

        #endregion

        #region Remove After Occurrence

        [TestMethod]
        public void RemoveNullAfterNullMarkerOccurrenceFromNullString()
        {
            string transformed = NullString.Remove(null).After(3, null);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).After(1, null);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerOccurrenceFromNullString()
        {
            string transformed = NullString.Remove(null).After(4, "marker");
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).After(0, "marker");
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveTextAfterMarkerOccurrenceFromNullString()
        {
            string transformed = NullString.Remove("something").After(2, "marker");
            transformed.Should().Be(NullString);

            transformed = NullString.Remove("something").After(4, "marker");
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarkerOccurrence()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(2, null);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).After(0, null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerOccurrence()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(1, "marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).After(7, "marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).After(1, "marker");
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextAfterNonExistingMarkerOccurrence()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").After(3, "marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove("TEST").After(1, "marker");
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextAfterMarkerOccurrence()
        {
            string transformed = "This string will be left -> TEST and this -> TEST also because 'marker' is here. And this TEST will be removed".Remove("TEST").After(1, "marker");
            transformed.Should().Be("This string will be left -> TEST and this -> TEST also because 'marker' is here. And this  will be removed");

            transformed = @"This string will be left -> TEST and this -> TEST also because of next 'marker'.
                            And this TEST will be left either because of this 'marker'. And this TEST will be removed with this one TEST".Remove("TEST").After(2, "marker");
            transformed.Should().Be("This string will be left -> TEST and this -> TEST also because of next 'marker'. And this TEST will be left either because of this 'marker'. And this  will be removed with this one ");

            transformed = "some some some TEST some TEST another TEST marker TEST TEST TEST marker TEST some words TEST".Remove("TEST").After(2, "marker");
            transformed.Should().Be("some some some TEST some TEST another TEST marker TEST TEST TEST marker  some words ");
        }

        #endregion

        #region Remove After Occurrence From

        [TestMethod]
        public void RemoveNullAfterNullMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).After(3, null).From(The.Beginning);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).After(1, null).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).After(3, null).From(The.End);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).After(1, null).From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).After(4, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).After(0, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).After(4, "marker").From(The.End);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).After(0, "marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveTextAfterMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = NullString.Remove("something").After(2, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove("something").After(4, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveTextAfterMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Remove("something").After(2, "marker").From(The.End);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove("something").After(4, "marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarkerOccurrenceFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(2, null).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).After(0, null).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarkerOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(2, null).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).After(0, null).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerOccurrenceFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(1, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).After(7, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).After(1, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveNullAfterMarkerOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(1, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).After(7, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).After(1, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextAfterNonExistingMarkerOccurrenceFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").After(3, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove("TEST").After(1, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextAfterNonExistingMarkerOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").After(3, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove("TEST").After(1, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextAfterMarkerOccurrenceFromBegining()
        {
            string transformed = "This string will be left -> TEST and this -> TEST also because 'marker' is here. And this TEST will be removed".Remove("TEST").After(1, "marker").From(The.Beginning);
            transformed.Should().Be("This string will be left -> TEST and this -> TEST also because 'marker' is here. And this  will be removed");

            transformed = @"This string will be left -> TEST and this -> TEST also because of next 'marker'.
                            And this TEST will be left either because of this 'marker'. And this TEST will be removed with this one TEST".Remove("TEST").After(2, "marker").From(The.Beginning);
            transformed.Should().Be("This string will be left -> TEST and this -> TEST also because of next 'marker'. And this TEST will be left either because of this 'marker'. And this  will be removed with this one ");

            transformed = "some some some TEST some TEST another TEST marker TEST TEST TEST marker TEST some words TEST".Remove("TEST").After(2, "marker").From(The.Beginning);
            transformed.Should().Be("some some some TEST some TEST another TEST marker TEST TEST TEST marker  some words ");
        }

        [TestMethod]
        public void RemoveTextAfterMarkerOccurrenceFromEnd()
        {
            string transformed = "This string will be left -> TEST and this -> TEST also because 'marker' is here and searching from END. And this TEST will be removed".Remove("TEST").After(1, "marker").From(The.End);
            transformed.Should().Be("This string will be left -> TEST and this -> TEST also because 'marker' is here and searching from END. And this  will be removed");

            transformed = @"This string will be left -> TEST and this -> TEST also because of this 'marker' and searching from END.
                            This TEST will be removed NOT because of this 'marker'. This TEST and this TEST will be removed also".Remove("TEST").After(2, "marker").From(The.End);
            transformed.Should().Be("This string will be left -> TEST and this -> TEST also because of this 'marker' and searching from END. This  will be removed NOT because of this 'marker'. This  and this  will be removed also");

            transformed = "some some some TEST marker some TEST another TEST marker TEST TEST TEST marker TEST some words TEST".Remove("TEST").After(2, "marker").From(The.End);
            transformed.Should().Be("some some some TEST marker some TEST another TEST marker    marker  some words ");

            transformed = "some some some TEST marker some TEST another TEST marker TEST TEST TEST marker TEST some marker words TEST".Remove("TEST").After(3, "marker").From(The.End);
            transformed.Should().Be("some some some TEST marker some TEST another TEST marker    marker  some marker words ");
        }

        #endregion

        #region Remove Vowels

        [TestMethod]
        public void RemoveVowelsFromNullString()
        {
            string transformed = NullString.RemoveVowels();
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveVowelsFromEmptyString()
        {
            string transformed = String.Empty.RemoveVowels();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveVowels()
        {
            string transformed = "Vowels will be removed from this string".RemoveVowels();
            transformed.Should().Be("Vwls wll b rmvd frm ths strng");
        }

        #endregion

        #region Remove Chars

        [TestMethod]
        public void RemoveSelectedChars()
        {
            string transformed = "Some very long string".RemoveChars('e', 'l', 'g');
            transformed.Should().Be("Som vry on strin");
        }

        [TestMethod]
        public void RemoveChars()
        {
            string transformed = "Some very long string".RemoveChars(3);
            transformed.Should().Be("e very long string");
        }

        [TestMethod]
        public void RemoveCharsFromBeginning()
        {
            string transformed = "Some very long string".RemoveChars(7).From(The.Beginning);
            transformed.Should().Be("ry long string");
        }

        [TestMethod]
        public void RemoveCharsFromEnd()
        {
            string transformed = "Some very long string".RemoveChars(5).From(The.End);
            transformed.Should().Be("Some very long s");
        }

        #endregion

        #region Remove Starting

        [TestMethod]
        public void RemoveStartingCharacterInNullString()
        {
            string transformed = NullString.Remove().Starting(3);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacter()
        {
            string transformed = "Some very long string".Remove().Starting(0);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(1);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(7);
            transformed.Should().Be("Some v");

            transformed = "Some very long string".Remove().Starting(100);
            transformed.Should().Be("Some very long string");
        }

        #endregion

        #region Remove To

        [TestMethod]
        public void RemoveToCharacterInNullString()
        {
            string transformed = NullString.Remove().To(3);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveToCharacterInEmptyString()
        {
            string transformed = String.Empty.Remove().To(5);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToCharacter()
        {
            string transformed = "Some very long string".Remove().To(0);
            transformed.Should().Be("Some very long string");

            transformed = "Some very long string".Remove().To(1);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().To(7);
            transformed.Should().Be("ry long string");

            transformed = "Some very long string".Remove().To(100);
            transformed.Should().Be(String.Empty);
        }

        #endregion

        #region Remove To From

        [TestMethod]
        public void RemoveToCharacterFromBeginningInNullString()
        {
            string transformed = NullString.Remove().To(3).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveToCharacterFromEndInNullString()
        {
            string transformed = NullString.Remove().To(3).From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveToCharacterFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(5).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToCharacterFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(5).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToCharacterFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(0).From(The.Beginning);
            transformed.Should().Be("Some very long string");

            transformed = "Some very long string".Remove().To(1).From(The.Beginning);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().To(7).From(The.Beginning);
            transformed.Should().Be("ry long string");

            transformed = "Some very long string".Remove().To(100).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToCharacterFromEnd()
        {
            string transformed = "Some very long string".Remove().To(0).From(The.End);
            transformed.Should().Be("Some very long string");

            transformed = "Some very long string".Remove().To(1).From(The.End);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().To(7).From(The.End);
            transformed.Should().Be("ry long string");

            transformed = "Some very long string".Remove().To(100).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        #endregion

        #region Remove Starting To

        [TestMethod]
        public void RemoveStartingCharacterToCharacterInNullString()
        {
            string transformed = NullString.Remove().Starting(3).To(6);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToCharacterInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).To(14);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterToCharacter()
        {
            string transformed = NothingShouldBeChanged.Remove().Starting(0).To(0);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = "Some very long string".Remove().Starting(0).To(1);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(1).To(1);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(1).To(100);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(5).To(100);
            transformed.Should().Be("Some");

            transformed = "Some very long string".Remove().Starting(7).To(11);
            transformed.Should().Be("Some vlong string");
        }

        [TestMethod]
        public void RemoveStartingCharacterToCharacterInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(1).To(0);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(100).To(1);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(100).To(5);
            transformed.Should().Be("Some");

            transformed = "Some very long string".Remove().Starting(13).To(6);
            transformed.Should().Be("Some g string");
        }

        #endregion

        #region Remove Starting To Occurrence

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfNullMarkerInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(3, null);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(2, String.Empty);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfMarkerInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(2, "marker");
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfNullMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(3, null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(2, String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(2, "marker");
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfMarker()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).To(1, "marker");
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and another marker".Remove().Starting(1).To(1, "marker");
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and another marker".Remove().Starting(1).To(0, "marker");
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and another marker".Remove().Starting(6).To(1, "marker");
            transformed.Should().Be("Some marker and another marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(6).To(3, "mark");
            transformed.Should().Be("Some markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(11).To(2, "marker");
            transformed.Should().Be("Some very marker");
        }

        [TestMethod]
        public void RemoveStartingCharacterExceedingToOccurrenceOfMarker()
        {
            string transformed = "Some string with marker and markers and markable words".Remove().Starting(25).To(2, "mark");
            transformed.Should().Be("Some string with marker markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(11).To(2, "marker");
            transformed.Should().Be("Some very marker");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(12).To(2, "marker");
            transformed.Should().Be("Some very 'marker");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(13).To(2, "marker");
            transformed.Should().Be("Some very 'm");
        }

        #endregion

        #region Remove To Occurrence

        [TestMethod]
        public void RemoveToOccurrenceOfNullMarkerInNullString()
        {
            string transformed = NullString.Remove().To(3, null);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = NullString.Remove().To(2, String.Empty);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfMarkerInNullString()
        {
            string transformed = NullString.Remove().To(2, "marker");
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(3, null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, "marker");
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfMarker()
        {
            string transformed = "Some very long string with marker and another marker".Remove().To(0, "marker");
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and another marker".Remove().To(1, "marker");
            transformed.Should().Be("marker and another marker");

            transformed = "Some very 'marker' long string with marker".Remove().To(2, "marker");
            transformed.Should().Be("marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().To(3, "mark");
            transformed.Should().Be("markable words");
        }

        #endregion

        #region Remove Starting To Occurrence From

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfNullMarkerFromBeginningInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(3, null).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfNullMarkerFromEndInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(3, null).From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(2, String.Empty).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(2, String.Empty).From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfMarkerFromBeginningInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(2, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfMarkerFromEndInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(2, "marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfNullMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(3, null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfNullMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(3, null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(2, String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(2, String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(2, "marker").From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(2, "marker").From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfMarkerFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).To(1, "marker").From(The.Beginning);
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and another marker".Remove().Starting(1).To(1, "marker").From(The.Beginning);
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and another marker".Remove().Starting(1).To(0, "marker").From(The.Beginning);
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and another marker".Remove().Starting(6).To(1, "marker").From(The.Beginning);
            transformed.Should().Be("Some marker and another marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(6).To(3, "mark").From(The.Beginning);
            transformed.Should().Be("Some markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(11).To(2, "marker").From(The.Beginning);
            transformed.Should().Be("Some very marker");
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfMarkerFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).To(1, "marker").From(The.End);
            transformed.Should().Be("marker");

            transformed = "Some very long string with marker and another marker".Remove().Starting(1).To(1, "marker").From(The.End);
            transformed.Should().Be("marker");

            transformed = "Some very long string with marker and another marker".Remove().Starting(1).To(0, "marker").From(The.End);
            transformed.Should().Be("marker");

            transformed = "Some very long string with marker and another marker".Remove().Starting(6).To(2, "marker").From(The.End);
            transformed.Should().Be("Some marker and another marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(6).To(3, "mark").From(The.End);
            transformed.Should().Be("Some marker and markers and markable words");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(6).To(2, "mark").From(The.End);
            transformed.Should().Be("Some markers and markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(11).To(2, "marker").From(The.End);
            transformed.Should().Be("Some very marker' long string with marker");
        }

        [TestMethod]
        public void RemoveStartingCharacterExceedingToOccurrenceOfMarkerFromBeginning()
        {
            string transformed = "Some string with marker and markers and markable words".Remove().Starting(25).To(2, "mark").From(The.Beginning);
            transformed.Should().Be("Some string with marker markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(11).To(2, "marker").From(The.Beginning);
            transformed.Should().Be("Some very marker");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(12).To(2, "marker").From(The.Beginning);
            transformed.Should().Be("Some very 'marker");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(13).To(2, "marker").From(The.Beginning);
            transformed.Should().Be("Some very 'm");
        }

        [TestMethod]
        public void RemoveStartingCharacterExceedingToOccurrenceOfMarkerFromEnd()
        {
            string transformed = "Some string with marker and markers and markable words".Remove().Starting(25).To(2, "mark").From(The.End);
            transformed.Should().Be("Some string with marker markers and markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(11).To(2, "marker").From(The.End);
            transformed.Should().Be("Some very marker' long string with marker");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(12).To(2, "marker").From(The.End);
            transformed.Should().Be("Some very 'marker' long string with marker");
        }

        #endregion

        #region Remove To Occurrence From

        [TestMethod]
        public void RemoveToOccurrenceOfNullMarkerFromBeginningInNullString()
        {
            string transformed = NullString.Remove().To(3, null).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullMarkerFromEndInNullString()
        {
            string transformed = NullString.Remove().To(3, null).From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = NullString.Remove().To(2, String.Empty).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = NullString.Remove().To(2, String.Empty).From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfMarkerFromBeginningInNullString()
        {
            string transformed = NullString.Remove().To(2, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfMarkerFromEndInNullString()
        {
            string transformed = NullString.Remove().To(2, "marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(3, null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(3, null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(2, String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, "marker").From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, "marker").From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfMarkerFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().To(0, "marker").From(The.Beginning);
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and another marker".Remove().To(1, "marker").From(The.Beginning);
            transformed.Should().Be("marker and another marker");

            transformed = "Some very 'marker' long string with marker".Remove().To(2, "marker").From(The.Beginning);
            transformed.Should().Be("marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().To(3, "mark").From(The.Beginning);
            transformed.Should().Be("markable words");
        }

        [TestMethod]
        public void RemoveToOccurrenceOfMarkerFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().To(0, "marker").From(The.End);
            transformed.Should().Be("marker");

            transformed = "Some very long string with marker and another marker".Remove().To(1, "marker").From(The.End);
            transformed.Should().Be("marker");

            transformed = "Some very 'marker' long string with marker".Remove().To(2, "marker").From(The.End);
            transformed.Should().Be("marker' long string with marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().To(3, "mark").From(The.End);
            transformed.Should().Be("marker and markers and markable words");
        }

        #endregion

        #region Remove Starting From

        [TestMethod]
        public void RemoveStartingCharacterFromBeginnigInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginnigInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginnig()
        {
            string transformed = "Some very long string".Remove().Starting(0).From(The.Beginning);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(1).From(The.Beginning);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(7).From(The.Beginning);
            transformed.Should().Be("Some v");

            transformed = "Some very long string".Remove().Starting(100).From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(0).From(The.End);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(1).From(The.End);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(7).From(The.End);
            transformed.Should().Be("string");

            transformed = "Some very long string".Remove().Starting(100).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        #endregion

        #region Remove Starting From To

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.Beginning).To(6);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.End).To(6);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.Beginning).To(14);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.End).To(14);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacter()
        {
            string transformed = NothingShouldBeChanged.Remove().Starting(0).From(The.Beginning).To(0);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = "Some very long string".Remove().Starting(0).From(The.Beginning).To(1);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(1);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(100);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(5).From(The.Beginning).To(100);
            transformed.Should().Be("Some");

            transformed = "Some very long string".Remove().Starting(7).From(The.Beginning).To(11);
            transformed.Should().Be("Some vlong string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacter()
        {
            string transformed = "Some very long string".Remove().Starting(0).From(The.End).To(0);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(0).From(The.End).To(1);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(1).From(The.End).To(1);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(1).From(The.End).To(100);
            transformed.Should().Be("Some very long strin");

            transformed = "Some very long string".Remove().Starting(5).From(The.End).To(100);
            transformed.Should().Be("Some very long s");

            transformed = "Some very long string".Remove().Starting(7).From(The.End).To(11);
            transformed.Should().Be("Some very string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(0);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(100).From(The.Beginning).To(1);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(100).From(The.Beginning).To(5);
            transformed.Should().Be("Some");

            transformed = "Some very long string".Remove().Starting(13).From(The.Beginning).To(6);
            transformed.Should().Be("Some g string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(100).From(The.End).To(1);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(100).From(The.End).To(5);
            transformed.Should().Be("very long string");

            transformed = "Some very long string".Remove().Starting(13).From(The.End).To(6);
            transformed.Should().Be("Some  long string");

            transformed = "Some very long string".Remove().Starting(13).From(The.End).To(13);
            transformed.Should().Be("Some verg string");
        }

        #endregion

        #region Remove Starting From To From

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromBeginningInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.Beginning).To(6).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromEndInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.Beginning).To(6).From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromBeginningInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.End).To(6).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromEndInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.End).To(6).From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.Beginning).To(14).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.Beginning).To(14).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.End).To(14).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.End).To(14).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromBeginning()
        {
            string transformed = NothingShouldBeChanged.Remove().Starting(0).From(The.Beginning).To(0).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = "Some very long string".Remove().Starting(0).From(The.Beginning).To(1).From(The.Beginning);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(1).From(The.Beginning);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(100).From(The.Beginning);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(5).From(The.Beginning).To(100).From(The.Beginning);
            transformed.Should().Be("Some");

            transformed = "Some very long string".Remove().Starting(7).From(The.Beginning).To(11).From(The.Beginning);
            transformed.Should().Be("Some vlong string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromEnd()
        {
            string transformed = "Entire string will be removed".Remove().Starting(0).From(The.Beginning).To(0).From(The.End);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(0).From(The.Beginning).To(1).From(The.End);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(1).From(The.End);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(100).From(The.End);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(6).From(The.Beginning).To(100).From(The.End);
            transformed.Should().Be("very long string");

            transformed = "Some very long string".Remove().Starting(7).From(The.Beginning).To(11).From(The.End);
            transformed.Should().Be("Some vong string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(0).From(The.End).To(0).From(The.Beginning);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(0).From(The.End).To(1).From(The.Beginning);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(1).From(The.End).To(1).From(The.Beginning);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(1).From(The.End).To(100).From(The.Beginning);
            transformed.Should().Be("Some very long strin");

            transformed = "Some very long string".Remove().Starting(5).From(The.End).To(100).From(The.Beginning);
            transformed.Should().Be("Some very long s");

            transformed = "Some very long string".Remove().Starting(7).From(The.End).To(11).From(The.Beginning);
            transformed.Should().Be("Some very string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove().Starting(0).From(The.End).To(0).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = "Some very long string".Remove().Starting(0).From(The.End).To(1).From(The.End);
            transformed.Should().Be("Some very long strin");

            transformed = "Some very long string".Remove().Starting(1).From(The.End).To(1).From(The.End);
            transformed.Should().Be("Some very long strin");

            transformed = "Some very long string".Remove().Starting(1).From(The.End).To(100).From(The.End);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(5).From(The.End).To(100).From(The.End);
            transformed.Should().Be("ring");

            transformed = "Some very long string".Remove().Starting(7).From(The.End).To(11).From(The.End);
            transformed.Should().Be("Some very string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromBeginningInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(0).From(The.Beginning);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(100).From(The.Beginning).To(1).From(The.Beginning);
            transformed.Should().Be(String.Empty);

            transformed = "Some very long string".Remove().Starting(100).From(The.Beginning).To(5).From(The.Beginning);
            transformed.Should().Be("Some");

            transformed = "Some very long string".Remove().Starting(13).From(The.Beginning).To(6).From(The.Beginning);
            transformed.Should().Be("Some g string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromEndInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(100).From(The.Beginning).To(1).From(The.End);
            transformed.Should().Be("Some very long strin");

            transformed = "Some very long string".Remove().Starting(100).From(The.Beginning).To(5).From(The.End);
            transformed.Should().Be("Some very long s");

            transformed = "Some very long string".Remove().Starting(13).From(The.Beginning).To(12).From(The.End);
            transformed.Should().Be("Some veryg string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromBeginningInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(100).From(The.End).To(1).From(The.Beginning);
            transformed.Should().Be("ome very long string");

            transformed = "Some very long string".Remove().Starting(100).From(The.End).To(5).From(The.Beginning);
            transformed.Should().Be("very long string");

            transformed = "Some very long string".Remove().Starting(13).From(The.End).To(6).From(The.Beginning);
            transformed.Should().Be("Some  long string");

            transformed = "Some very long string".Remove().Starting(13).From(The.End).To(13).From(The.Beginning);
            transformed.Should().Be("Some verg string");
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromEndInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(13).From(The.End).To(6).From(The.End);
            transformed.Should().Be("Some vertring");

            transformed = "Some very long string".Remove().Starting(13).From(The.End).To(13).From(The.End);
            transformed.Should().Be("Some ver long string");
        }

        #endregion

        #region Remove Starting From To Occurrence

        [TestMethod]
        public void RemoveStartingFromToOccurrence()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(3, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting From To Occurrence From

        [TestMethod]
        public void RemoveStartingFromToOccurrenceFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(3, "marker").From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Next

        [TestMethod]
        public void RemoveNext()
        {
            string transformed = "Some very long string".Remove().Starting(1).Next(3);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting From Next

        [TestMethod]
        public void RemoveFromNext()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).Next(3);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Previous

        [TestMethod]
        public void RemovePrevious()
        {
            string transformed = "Some very long string".Remove().Starting(1).Previous(3);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting From Previous

        [TestMethod]
        public void RemoveFromPrevious()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).Previous(3);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence

        [TestMethod]
        public void RemoveFromOccurrence()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence From

        [TestMethod]
        public void RemoveFromOccurrenceFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence To

        [TestMethod]
        public void RemoveFromOccurrenceTo()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(2);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence To From

        [TestMethod]
        public void RemoveFromOccurrenceToFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(2).From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence From To

        [TestMethod]
        public void RemoveFromOccurrenceFromTo()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(2);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence From To From

        [TestMethod]
        public void RemoveFromOccurrenceFromToFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(2).From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence To Occurrence

        [TestMethod]
        public void RemoveFromOccurrenceToOccurrence()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(2, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence To Occurrence From

        [TestMethod]
        public void RemoveFromOccurrenceToOccurrenceFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence From To Occurrence

        [TestMethod]
        public void RemoveFromOccurrenceFromToOccurrence()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(2, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence From To Occurrence From

        [TestMethod]
        public void RemoveFromOccurrenceFromToOccurrenceFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting To Occurrence Position

        [TestMethod]
        public void RemoveStartingAtToStartOfMarker()
        {
            string transformed = "Some very long string".Remove().Starting(1).To(The.StartOf, 2, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting To Occurrence Position From

        [TestMethod]
        public void RemoveStartingAtToStartOfMarkerFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1).To(The.StartOf, 2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting From To Occurrence Position

        [TestMethod]
        public void RemoveStartingAtFromBeginningToStartOfMarker()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(The.StartOf, 2, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting From To Occurrence Position From

        [TestMethod]
        public void RemoveStartingAtFromBeginningToStartOfMarkerFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(The.StartOf, 2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence To Occurrence Position

        [TestMethod]
        public void RemoveStartingOfMarkerToStartOfMarker()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(The.StartOf, 2, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence To Occurrence Position From

        [TestMethod]
        public void RemoveStartingOfMarkerToStartOfMarkerFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(The.StartOf, 2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence From To Occurrence Position

        [TestMethod]
        public void RemoveStartingOfMarkerFromBeginningToStartOfMarker()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(The.StartOf, 2, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence From To Occurrence Position From

        [TestMethod]
        public void RemoveStartingOfMarkerFromBeginningToStartOfMarkerFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(The.StartOf, 2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        #endregion
    }
}
