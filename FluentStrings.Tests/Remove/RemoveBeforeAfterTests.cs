using System;
using dokas.FluentStrings;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveBeforeAfterTests
    {
        #region Remove Before

        [TestMethod]
        public void RemoveNullBeforeNullMarkerFromNullString()
        {
            string transformed = Const.NullString.Remove(null).Before(null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerFromNullString()
        {
            string transformed = Const.NullString.Remove(null).Before("marker");
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerFromNullString()
        {
            string transformed = Const.NullString.Remove("something").Before("marker");
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarker()
        {
            string transformed = Const.SampleString.Remove(null).Before(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarker()
        {
            string transformed = Const.SampleString.Remove(null).Before("marker");
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove(null).Before("marker");
            transformed.Should().Be(Const.SampleString + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextBeforeNonExistingMarker()
        {
            string transformed = Const.SampleString.Remove("TEST").Before("marker");
            transformed.Should().Be(Const.SampleString);
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
            string transformed = Const.NullString.Remove(null).Before(null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarkerFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(null).Before(null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerFromBeginingOfNullString()
        {
            string transformed = Const.NullString.Remove(null).Before("marker").From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(null).Before("marker").From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerFromBeginingOfNullString()
        {
            string transformed = Const.NullString.Remove("something").Before("marker").From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove("something").Before("marker").From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarkerFromBegining()
        {
            string transformed = Const.SampleString.Remove(null).Before(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove(null).Before(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerFromBegining()
        {
            string transformed = Const.SampleString.Remove(null).Before("marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove(null).Before("marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString + "even if marker is here");
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove(null).Before("marker").From(The.End);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove(null).Before("marker").From(The.End);
            transformed.Should().Be(Const.SampleString + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextBeforeNonExistingMarkerFromBegining()
        {
            string transformed = Const.SampleString.Remove("TEST").Before("marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveTextBeforeNonExistingMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove("TEST").Before("marker").From(The.End);
            transformed.Should().Be(Const.SampleString);
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
            string transformed = Const.NullString.Remove(null).Before(3, null);
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove(null).Before(1, null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerOccurrenceFromNullString()
        {
            string transformed = Const.NullString.Remove(null).Before(4, "marker");
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove(null).Before(0, "marker");
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerOccurrenceFromNullString()
        {
            string transformed = Const.NullString.Remove("something").Before(2, "marker");
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove("something").Before(4, "marker");
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarkerOccurrence()
        {
            string transformed = Const.SampleString.Remove(null).Before(2, null);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString.Remove(null).Before(0, null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerOccurrence()
        {
            string transformed = Const.SampleString.Remove(null).Before(1, "marker");
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString.Remove(null).Before(7, "marker");
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove(null).Before(1, "marker");
            transformed.Should().Be(Const.SampleString + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextBeforeNonExistingMarkerOccurrence()
        {
            string transformed = Const.SampleString.Remove("TEST").Before(3, "marker");
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove("TEST").Before(1, "marker");
            transformed.Should().Be(Const.SampleString + "even if marker is here");
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
            string transformed = Const.NullString.Remove(null).Before(3, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove(null).Before(1, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(null).Before(3, null).From(The.End);
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove(null).Before(1, null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = Const.NullString.Remove(null).Before(4, "marker").From(The.Beginning);
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove(null).Before(0, "marker").From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(null).Before(4, "marker").From(The.End);
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove(null).Before(0, "marker").From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = Const.NullString.Remove("something").Before(2, "marker").From(The.Beginning);
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove("something").Before(4, "marker").From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveTextBeforeMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove("something").Before(2, "marker").From(The.End);
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove("something").Before(4, "marker").From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarkerOccurrenceFromBegining()
        {
            string transformed = Const.SampleString.Remove(null).Before(2, null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString.Remove(null).Before(0, null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullBeforeNullMarkerOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Remove(null).Before(2, null).From(The.End);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString.Remove(null).Before(0, null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerOccurrenceFromBegining()
        {
            string transformed = Const.SampleString.Remove(null).Before(1, "marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString.Remove(null).Before(7, "marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove(null).Before(1, "marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString + "even if marker is here");
        }

        [TestMethod]
        public void RemoveNullBeforeMarkerOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Remove(null).Before(1, "marker").From(The.End);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString.Remove(null).Before(7, "marker").From(The.End);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove(null).Before(1, "marker").From(The.End);
            transformed.Should().Be(Const.SampleString + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextBeforeNonExistingMarkerOccurrenceFromBegining()
        {
            string transformed = Const.SampleString.Remove("TEST").Before(3, "marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);  

            transformed = Const.SampleString + "even if marker is here".Remove("TEST").Before(1, "marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextBeforeNonExistingMarkerOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Remove("TEST").Before(3, "marker").From(The.End);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove("TEST").Before(1, "marker").From(The.End);
            transformed.Should().Be(Const.SampleString + "even if marker is here");
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
            string transformed = Const.NullString.Remove(null).After(null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerFromNullString()
        {
            string transformed = Const.NullString.Remove(null).After("marker");
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveTextAfterMarkerFromNullString()
        {
            string transformed = Const.NullString.Remove("something").After("marker");
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarker()
        {
            string transformed = Const.SampleString.Remove(null).After(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullAfterMarker()
        {
            string transformed = Const.SampleString.Remove(null).After("marker");
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove(null).After("marker");
            transformed.Should().Be(Const.SampleString + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextAfterNonExistingMarker()
        {
            string transformed = Const.SampleString.Remove("TEST").After("marker");
            transformed.Should().Be(Const.SampleString);
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
            string transformed = Const.NullString.Remove(null).After(null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarkerFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(null).After(null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerFromBeginingOfNullString()
        {
            string transformed = Const.NullString.Remove(null).After("marker").From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(null).After("marker").From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveTextAfterMarkerFromBeginingOfNullString()
        {
            string transformed = Const.NullString.Remove("something").After("marker").From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveTextAfterMarkerFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove("something").After("marker").From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarkerFromBegining()
        {
            string transformed = Const.SampleString.Remove(null).After(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove(null).After(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerFromBegining()
        {
            string transformed = Const.SampleString.Remove(null).After("marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove(null).After("marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString + "even if marker is here");
        }

        [TestMethod]
        public void RemoveNullAfterMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove(null).After("marker").From(The.End);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove(null).After("marker").From(The.End);
            transformed.Should().Be(Const.SampleString + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextAfterNonExistingMarkerFromBegining()
        {
            string transformed = Const.SampleString.Remove("TEST").After("marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveTextAfterNonExistingMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove("TEST").After("marker").From(The.End);
            transformed.Should().Be(Const.SampleString);
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
            string transformed = Const.NullString.Remove(null).After(3, null);
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove(null).After(1, null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerOccurrenceFromNullString()
        {
            string transformed = Const.NullString.Remove(null).After(4, "marker");
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove(null).After(0, "marker");
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveTextAfterMarkerOccurrenceFromNullString()
        {
            string transformed = Const.NullString.Remove("something").After(2, "marker");
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove("something").After(4, "marker");
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarkerOccurrence()
        {
            string transformed = Const.SampleString.Remove(null).After(2, null);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString.Remove(null).After(0, null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerOccurrence()
        {
            string transformed = Const.SampleString.Remove(null).After(1, "marker");
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString.Remove(null).After(7, "marker");
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove(null).After(1, "marker");
            transformed.Should().Be(Const.SampleString + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextAfterNonExistingMarkerOccurrence()
        {
            string transformed = Const.SampleString.Remove("TEST").After(3, "marker");
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove("TEST").After(1, "marker");
            transformed.Should().Be(Const.SampleString + "even if marker is here");
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
            string transformed = Const.NullString.Remove(null).After(3, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove(null).After(1, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(null).After(3, null).From(The.End);
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove(null).After(1, null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = Const.NullString.Remove(null).After(4, "marker").From(The.Beginning);
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove(null).After(0, "marker").From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(null).After(4, "marker").From(The.End);
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove(null).After(0, "marker").From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveTextAfterMarkerOccurrenceFromBeginingOfNullString()
        {
            string transformed = Const.NullString.Remove("something").After(2, "marker").From(The.Beginning);
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove("something").After(4, "marker").From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveTextAfterMarkerOccurrenceFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove("something").After(2, "marker").From(The.End);
            transformed.Should().Be(Const.NullString);

            transformed = Const.NullString.Remove("something").After(4, "marker").From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarkerOccurrenceFromBegining()
        {
            string transformed = Const.SampleString.Remove(null).After(2, null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString.Remove(null).After(0, null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullAfterNullMarkerOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Remove(null).After(2, null).From(The.End);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString.Remove(null).After(0, null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveNullAfterMarkerOccurrenceFromBegining()
        {
            string transformed = Const.SampleString.Remove(null).After(1, "marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString.Remove(null).After(7, "marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove(null).After(1, "marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString + "even if marker is here");
        }

        [TestMethod]
        public void RemoveNullAfterMarkerOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Remove(null).After(1, "marker").From(The.End);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString.Remove(null).After(7, "marker").From(The.End);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove(null).After(1, "marker").From(The.End);
            transformed.Should().Be(Const.SampleString + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextAfterNonExistingMarkerOccurrenceFromBegining()
        {
            string transformed = Const.SampleString.Remove("TEST").After(3, "marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove("TEST").After(1, "marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString + "even if marker is here");
        }

        [TestMethod]
        public void RemoveTextAfterNonExistingMarkerOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Remove("TEST").After(3, "marker").From(The.End);
            transformed.Should().Be(Const.SampleString);

            transformed = Const.SampleString + "even if marker is here".Remove("TEST").After(1, "marker").From(The.End);
            transformed.Should().Be(Const.SampleString + "even if marker is here");
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
    }
}
