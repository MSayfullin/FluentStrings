using System;
using dokas.FluentStrings;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveBeforeAfterTests
    {
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
