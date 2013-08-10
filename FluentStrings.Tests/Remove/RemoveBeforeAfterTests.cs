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
    }
}
