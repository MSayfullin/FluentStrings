using System;
using dokas.FluentStrings;
using FluentAssertions;
using NUnit.Framework;

namespace StringTransformerTests
{
    [TestFixture]
    public class RemoveTests
    {
        #region Constants

        private const string NullString = null;
        private const string NothingShouldBeChanged = "Nothing should be changed";

        #endregion

        #region Remove

        [Test]
        public void RemoveTextFromNullString()
        {
            string transformed = NullString.Remove("bla");
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullText()
        {
            string transformed = NothingShouldBeChanged.Remove(null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveNullTextFromNullString()
        {
            string transformed = NullString.Remove(null);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveEmptyText()
        {
            string transformed = NothingShouldBeChanged.Remove(String.Empty);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveText()
        {
            string transformed = "TEST string will be removed".Remove("TEST");
            transformed.Should().Be(" string will be removed");

            transformed = "TEST string will be removed from both sides TEST".Remove("TEST");
            transformed.Should().Be(" string will be removed from both sides ");
        }

        #endregion

        #region Remove From

        [Test]
        public void RemoveTextFromBeginingOfNullString()
        {
            string transformed = NullString.Remove("bla").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveTextFromEndOfNullString()
        {
            string transformed = NullString.Remove("bla").From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullTextFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveNullTextFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveNullTextFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullTextFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveEmptyTextFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(String.Empty).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveEmptyTextFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(String.Empty).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveTextFromBegining()
        {
            string transformed = "TEST string will be removed".Remove("TEST").From(The.Beginning);
            transformed.Should().Be(" string will be removed");

            transformed = "TEST <- string will be removed, not this -> TEST".Remove("TEST").From(The.Beginning);
            transformed.Should().Be(" <- string will be removed, not this -> TEST");

            transformed = "Some additional string |TEST| string will be removed".Remove("TEST").From(The.Beginning);
            transformed.Should().Be("Some additional string || string will be removed");
        }

        [Test]
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

        [Test]
        public void RemoveFromNullString()
        {
            string transformed = NullString.Remove();
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveFromEmptyString()
        {
            string transformed = String.Empty.Remove();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void Remove()
        {
            string transformed = "Some string".Remove();
            transformed.Should().Be(String.Empty);
        }

        #endregion

        #region Remove Before

        [Test]
        public void RemoveNullBeforeNullMarkerFromNullString()
        {
            string transformed = NullString.Remove(null).Before(null);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullBeforeMarkerFromNullString()
        {
            string transformed = NullString.Remove(null).Before("marker");
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveTextBeforeMarkerFromNullString()
        {
            string transformed = NullString.Remove("something").Before("marker");
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullBeforeNullMarker()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveNullBeforeMarker()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before("marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).Before("marker");
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
        public void RemoveTextBeforeNonExistingMarker()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").Before("marker");
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveTextBeforeMarker()
        {
            string transformed = "This string will be removed -> TEST and this -> TEST also because 'marker' is here. And this TEST will be left".Remove("TEST").Before("marker");
            transformed.Should().Be("This string will be removed ->  and this ->  also because 'marker' is here. And this TEST will be left");
        }

        #endregion

        #region Remove Before From

        [Test]
        public void RemoveNullBeforeNullMarkerFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).Before(null).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullBeforeNullMarkerFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).Before(null).From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullBeforeMarkerFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).Before("marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullBeforeMarkerFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).Before("marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveTextBeforeMarkerFromBeginingOfNullString()
        {
            string transformed = NullString.Remove("something").Before("marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveTextBeforeMarkerFromEndOfNullString()
        {
            string transformed = NullString.Remove("something").Before("marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullBeforeNullMarkerFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(null).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveNullBeforeNullMarkerFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(null).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveNullBeforeMarkerFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before("marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).Before("marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
        public void RemoveNullBeforeMarkerFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before("marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).Before("marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
        public void RemoveTextBeforeNonExistingMarkerFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").Before("marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveTextBeforeNonExistingMarkerFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").Before("marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveTextBeforeMarkerFromBegining()
        {
            string transformed = "This string will be removed -> TEST and this -> TEST also because 'marker' is here. And this TEST will be left".Remove("TEST").Before("marker").From(The.Beginning);
            transformed.Should().Be("This string will be removed ->  and this ->  also because 'marker' is here. And this TEST will be left");
        }

        [Test]
        public void RemoveTextBeforeMarkerFromEnd()
        {
            string transformed = "This string will NOT be removed -> TEST and this also -> TEST also because 'marker' is here. And this TEST will NOT be left".Remove("TEST").Before("marker").From(The.End);
            transformed.Should().Be("This string will NOT be removed -> TEST and this also -> TEST also because 'marker' is here. And this  will NOT be left");

            transformed = "This string will be left -> TEST because 'marker' is here. And this TEST and this TEST and even this TEST will be removed".Remove("TEST").Before("marker").From(The.End);
            transformed.Should().Be("This string will be left -> TEST because 'marker' is here. And this  and this  and even this  will be removed");
        }

        #endregion

        #region Remove Before Occurrence

        [Test]
        public void RemoveNullBeforeNullMarkerOccurrenceFromNullString()
        {
            string transformed = NullString.Remove(null).Before(3, null);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).Before(1, null);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullBeforeMarkerOccurrenceFromNullString()
        {
            string transformed = NullString.Remove(null).Before(4, "marker");
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).Before(0, "marker");
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveTextBeforeMarkerOccurrenceFromNullString()
        {
            string transformed = NullString.Remove("something").Before(2, "marker");
            transformed.Should().Be(NullString);

            transformed = NullString.Remove("something").Before(4, "marker");
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullBeforeNullMarkerOccurrence()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(2, null);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).Before(0, null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveNullBeforeMarkerOccurrence()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(1, "marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).Before(7, "marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).Before(1, "marker");
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
        public void RemoveTextBeforeNonExistingMarkerOccurrence()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").Before(3, "marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove("TEST").Before(1, "marker");
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
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

        [Test]
        public void RemoveNullBeforeNullMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).Before(3, null).From(The.Beginning);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).Before(1, null).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullBeforeNullMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).Before(3, null).From(The.End);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).Before(1, null).From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullBeforeMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).Before(4, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).Before(0, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullBeforeMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).Before(4, "marker").From(The.End);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).Before(0, "marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveTextBeforeMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = NullString.Remove("something").Before(2, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove("something").Before(4, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveTextBeforeMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Remove("something").Before(2, "marker").From(The.End);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove("something").Before(4, "marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullBeforeNullMarkerOccurrenceFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(2, null).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).Before(0, null).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveNullBeforeNullMarkerOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(2, null).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).Before(0, null).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveNullBeforeMarkerOccurrenceFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(1, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).Before(7, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).Before(1, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
        public void RemoveNullBeforeMarkerOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).Before(1, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).Before(7, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).Before(1, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
        public void RemoveTextBeforeNonExistingMarkerOccurrenceFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").Before(3, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);  

            transformed = NothingShouldBeChanged + "even if marker is here".Remove("TEST").Before(1, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
        public void RemoveTextBeforeNonExistingMarkerOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").Before(3, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove("TEST").Before(1, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
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

        [Test]
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

        [Test]
        public void RemoveNullAfterNullMarkerFromNullString()
        {
            string transformed = NullString.Remove(null).After(null);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullAfterMarkerFromNullString()
        {
            string transformed = NullString.Remove(null).After("marker");
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveTextAfterMarkerFromNullString()
        {
            string transformed = NullString.Remove("something").After("marker");
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullAfterNullMarker()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveNullAfterMarker()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After("marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).After("marker");
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
        public void RemoveTextAfterNonExistingMarker()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").After("marker");
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveTextAfterMarker()
        {
            string transformed = "This string will be left -> TEST and this -> TEST also because 'marker' is here. And this TEST will be removed".Remove("TEST").After("marker");
            transformed.Should().Be("This string will be left -> TEST and this -> TEST also because 'marker' is here. And this  will be removed");

            transformed = "This string will be left -> TEST and this -> TEST also because 'marker' is here. And this TEST will be removed with this TEST one".Remove("TEST").After("marker");
            transformed.Should().Be("This string will be left -> TEST and this -> TEST also because 'marker' is here. And this  will be removed with this  one");
        }

        #endregion

        #region Remove After From

        [Test]
        public void RemoveNullAfterNullMarkerFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).After(null).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullAfterNullMarkerFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).After(null).From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullAfterMarkerFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).After("marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullAfterMarkerFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).After("marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveTextAfterMarkerFromBeginingOfNullString()
        {
            string transformed = NullString.Remove("something").After("marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveTextAfterMarkerFromEndOfNullString()
        {
            string transformed = NullString.Remove("something").After("marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullAfterNullMarkerFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(null).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveNullAfterNullMarkerFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(null).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveNullAfterMarkerFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After("marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).After("marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
        public void RemoveNullAfterMarkerFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After("marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).After("marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
        public void RemoveTextAfterNonExistingMarkerFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").After("marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveTextAfterNonExistingMarkerFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").After("marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveTextAfterMarkerFromBegining()
        {
            string transformed = "This string will be left -> TEST and this -> TEST also because 'marker' is here. And this TEST will be removed".Remove("TEST").After("marker").From(The.Beginning);
            transformed.Should().Be("This string will be left -> TEST and this -> TEST also because 'marker' is here. And this  will be removed");

            transformed = "This string will be left -> TEST and this -> TEST also because 'marker' is here. And this TEST will be removed with this TEST one".Remove("TEST").After("marker").From(The.Beginning);
            transformed.Should().Be("This string will be left -> TEST and this -> TEST also because 'marker' is here. And this  will be removed with this  one");
        }

        [Test]
        public void RemoveTextAfterMarkerFromEnd()
        {
            string transformed = "This string will be removed -> TEST and this also -> TEST because 'marker' is here. And this TEST will be left".Remove("TEST").After("marker").From(The.End);
            transformed.Should().Be("This string will be removed ->  and this also ->  because 'marker' is here. And this TEST will be left");

            transformed = "This string will be removed -> TEST because 'marker' is here. And this TEST and this TEST and even this TEST will be left".Remove("TEST").After("marker").From(The.End);
            transformed.Should().Be("This string will be removed ->  because 'marker' is here. And this TEST and this TEST and even this TEST will be left");
        }

        #endregion

        #region Remove After Occurrence

        [Test]
        public void RemoveNullAfterNullMarkerOccurrenceFromNullString()
        {
            string transformed = NullString.Remove(null).After(3, null);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).After(1, null);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullAfterMarkerOccurrenceFromNullString()
        {
            string transformed = NullString.Remove(null).After(4, "marker");
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).After(0, "marker");
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveTextAfterMarkerOccurrenceFromNullString()
        {
            string transformed = NullString.Remove("something").After(2, "marker");
            transformed.Should().Be(NullString);

            transformed = NullString.Remove("something").After(4, "marker");
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullAfterNullMarkerOccurrence()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(2, null);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).After(0, null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveNullAfterMarkerOccurrence()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(1, "marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).After(7, "marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).After(1, "marker");
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
        public void RemoveTextAfterNonExistingMarkerOccurrence()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").After(3, "marker");
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove("TEST").After(1, "marker");
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
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

        [Test]
        public void RemoveNullAfterNullMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).After(3, null).From(The.Beginning);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).After(1, null).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullAfterNullMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).After(3, null).From(The.End);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).After(1, null).From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullAfterMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = NullString.Remove(null).After(4, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).After(0, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullAfterMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Remove(null).After(4, "marker").From(The.End);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove(null).After(0, "marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveTextAfterMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = NullString.Remove("something").After(2, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove("something").After(4, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveTextAfterMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Remove("something").After(2, "marker").From(The.End);
            transformed.Should().Be(NullString);

            transformed = NullString.Remove("something").After(4, "marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveNullAfterNullMarkerOccurrenceFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(2, null).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).After(0, null).From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveNullAfterNullMarkerOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(2, null).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).After(0, null).From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [Test]
        public void RemoveNullAfterMarkerOccurrenceFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(1, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).After(7, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).After(1, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
        public void RemoveNullAfterMarkerOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove(null).After(1, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged.Remove(null).After(7, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove(null).After(1, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
        public void RemoveTextAfterNonExistingMarkerOccurrenceFromBegining()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").After(3, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove("TEST").After(1, "marker").From(The.Beginning);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
        public void RemoveTextAfterNonExistingMarkerOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Remove("TEST").After(3, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged);

            transformed = NothingShouldBeChanged + "even if marker is here".Remove("TEST").After(1, "marker").From(The.End);
            transformed.Should().Be(NothingShouldBeChanged + "even if marker is here");
        }

        [Test]
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

        [Test]
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

        [Test]
        public void RemoveVowelsFromNullString()
        {
            string transformed = NullString.RemoveVowels();
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveVowelsFromEmptyString()
        {
            string transformed = String.Empty.RemoveVowels();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveVowels()
        {
            string transformed = "Vowels will be removed from this string".RemoveVowels();
            transformed.Should().Be("Vwls wll b rmvd frm ths strng");
        }

        #endregion

        #region Remove Chars

        [Test]
        public void RemoveSelectedChars()
        {
            string transformed = "Some very long string".RemoveChars('e', 'l', 'g');
            transformed.Should().Be("Som vry on strin");
        }

        [Test]
        public void RemoveChars()
        {
            string transformed = "Some very long string".RemoveChars(3);
            transformed.Should().Be("e very long string");
        }

        [Test]
        public void RemoveCharsFromBeginning()
        {
            string transformed = "Some very long string".RemoveChars(7).From(The.Beginning);
            transformed.Should().Be("ry long string");
        }

        [Test]
        public void RemoveCharsFromEnd()
        {
            string transformed = "Some very long string".RemoveChars(5).From(The.End);
            transformed.Should().Be("Some very long s");
        }

        #endregion

        #region Remove Starting

        [Test]
        public void RemoveStartingCharacterInNullString()
        {
            string transformed = NullString.Remove().Starting(3);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5);
            transformed.Should().Be(String.Empty);
        }

        [Test]
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

        [Test]
        public void RemoveToCharacterInNullString()
        {
            string transformed = NullString.Remove().To(3);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveToCharacterInEmptyString()
        {
            string transformed = String.Empty.Remove().To(5);
            transformed.Should().Be(String.Empty);
        }

        [Test]
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

        [Test]
        public void RemoveToCharacterFromBeginningInNullString()
        {
            string transformed = NullString.Remove().To(3).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveToCharacterFromEndInNullString()
        {
            string transformed = NullString.Remove().To(3).From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveToCharacterFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(5).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToCharacterFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(5).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
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

        [Test]
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

        [Test]
        public void RemoveStartingCharacterToCharacterInNullString()
        {
            string transformed = NullString.Remove().Starting(3).To(6);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterToCharacterInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).To(14);
            transformed.Should().Be(String.Empty);
        }

        [Test]
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

        [Test]
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

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfNullMarkerInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(3, null);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(2, String.Empty);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfMarkerInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(2, "marker");
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfNullMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(3, null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(2, String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(2, "marker");
            transformed.Should().Be(String.Empty);
        }

        [Test]
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

        [Test]
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

        [Test]
        public void RemoveToOccurrenceOfNullMarkerInNullString()
        {
            string transformed = NullString.Remove().To(3, null);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = NullString.Remove().To(2, String.Empty);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfMarkerInNullString()
        {
            string transformed = NullString.Remove().To(2, "marker");
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfNullMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(3, null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, "marker");
            transformed.Should().Be(String.Empty);
        }

        [Test]
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

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfNullMarkerFromBeginningInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(3, null).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfNullMarkerFromEndInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(3, null).From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(2, String.Empty).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(2, String.Empty).From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfMarkerFromBeginningInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(2, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfMarkerFromEndInNullString()
        {
            string transformed = NullString.Remove().Starting(1).To(2, "marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfNullMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(3, null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfNullMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(3, null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(2, String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(2, String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(2, "marker").From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(2, "marker").From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
        public void RemoveToOccurrenceOfNullMarkerFromBeginningInNullString()
        {
            string transformed = NullString.Remove().To(3, null).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfNullMarkerFromEndInNullString()
        {
            string transformed = NullString.Remove().To(3, null).From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = NullString.Remove().To(2, String.Empty).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = NullString.Remove().To(2, String.Empty).From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfMarkerFromBeginningInNullString()
        {
            string transformed = NullString.Remove().To(2, "marker").From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfMarkerFromEndInNullString()
        {
            string transformed = NullString.Remove().To(2, "marker").From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfNullMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(3, null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfNullMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(3, null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1).To(2, String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, "marker").From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, "marker").From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
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

        [Test]
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

        [Test]
        public void RemoveStartingCharacterFromBeginnigInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterFromEndInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterFromBeginnigInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingCharacterFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
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

        [Test]
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

        [Test]
        public void RemoveStartingCharacterFromBeginningToCharacterInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.Beginning).To(6);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterFromEndToCharacterInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.End).To(6);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToCharacterInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.Beginning).To(14);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingCharacterFromEndToCharacterInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.End).To(14);
            transformed.Should().Be(String.Empty);
        }

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
        public void RemoveStartingCharacterFromBeginningToCharacterFromBeginningInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.Beginning).To(6).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToCharacterFromEndInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.Beginning).To(6).From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterFromEndToCharacterFromBeginningInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.End).To(6).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterFromEndToCharacterFromEndInNullString()
        {
            string transformed = NullString.Remove().Starting(3).From(The.End).To(6).From(The.End);
            transformed.Should().Be(NullString);
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToCharacterFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.Beginning).To(14).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToCharacterFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.Beginning).To(14).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingCharacterFromEndToCharacterFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.End).To(14).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingCharacterFromEndToCharacterFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(5).From(The.End).To(14).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
        public void RemoveStartingCharacterFromBeginningToCharacterFromEndInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(100).From(The.Beginning).To(1).From(The.End);
            transformed.Should().Be("Some very long strin");

            transformed = "Some very long string".Remove().Starting(100).From(The.Beginning).To(5).From(The.End);
            transformed.Should().Be("Some very long s");

            transformed = "Some very long string".Remove().Starting(13).From(The.Beginning).To(12).From(The.End);
            transformed.Should().Be("Some veryg string");
        }

        [Test]
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

        [Test]
        public void RemoveStartingCharacterFromEndToCharacterFromEndInReverse()
        {
            string transformed = "Some very long string".Remove().Starting(13).From(The.End).To(6).From(The.End);
            transformed.Should().Be("Some vertring");

            transformed = "Some very long string".Remove().Starting(13).From(The.End).To(13).From(The.End);
            transformed.Should().Be("Some ver long string");
        }

        #endregion

        #region Remove Starting From To Occurrence

        [Test]
        public void RemoveStartingFromToOccurrence()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(3, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting From To Occurrence From

        [Test]
        public void RemoveStartingFromToOccurrenceFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(3, "marker").From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Next

        [Test]
        public void RemoveNext()
        {
            string transformed = "Some very long string".Remove().Starting(1).Next(3);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting From Next

        [Test]
        public void RemoveFromNext()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).Next(3);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Previous

        [Test]
        public void RemovePrevious()
        {
            string transformed = "Some very long string".Remove().Starting(1).Previous(3);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting From Previous

        [Test]
        public void RemoveFromPrevious()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).Previous(3);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence

        [Test]
        public void RemoveFromOccurrence()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence From

        [Test]
        public void RemoveFromOccurrenceFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence To

        [Test]
        public void RemoveFromOccurrenceTo()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(2);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence To From

        [Test]
        public void RemoveFromOccurrenceToFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(2).From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence From To

        [Test]
        public void RemoveFromOccurrenceFromTo()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(2);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence From To From

        [Test]
        public void RemoveFromOccurrenceFromToFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(2).From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence To Occurrence

        [Test]
        public void RemoveFromOccurrenceToOccurrence()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(2, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence To Occurrence From

        [Test]
        public void RemoveFromOccurrenceToOccurrenceFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence From To Occurrence

        [Test]
        public void RemoveFromOccurrenceFromToOccurrence()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(2, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence From To Occurrence From

        [Test]
        public void RemoveFromOccurrenceFromToOccurrenceFrom()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting To Occurrence Position

        [Test]
        public void RemoveStartingAtToStartOfMarker()
        {
            string transformed = "Some very long string".Remove().Starting(1).To(The.StartOf, 2, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting To Occurrence Position From

        [Test]
        public void RemoveStartingAtToStartOfMarkerFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1).To(The.StartOf, 2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting From To Occurrence Position

        [Test]
        public void RemoveStartingAtFromBeginningToStartOfMarker()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(The.StartOf, 2, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting From To Occurrence Position From

        [Test]
        public void RemoveStartingAtFromBeginningToStartOfMarkerFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).To(The.StartOf, 2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence To Occurrence Position

        [Test]
        public void RemoveStartingOfMarkerToStartOfMarker()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(The.StartOf, 2, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence To Occurrence Position From

        [Test]
        public void RemoveStartingOfMarkerToStartOfMarkerFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").To(The.StartOf, 2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence From To Occurrence Position

        [Test]
        public void RemoveStartingOfMarkerFromBeginningToStartOfMarker()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(The.StartOf, 2, "marker");
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Occurrence From To Occurrence Position From

        [Test]
        public void RemoveStartingOfMarkerFromBeginningToStartOfMarkerFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1, "marker").From(The.Beginning).To(The.StartOf, 2, "marker").From(The.End);
            transformed.Should().Be("");
        }

        #endregion
    }
}
