using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveStartingToTests
    {
        #region Remove Starting

        [TestMethod]
        public void RemoveStartingPositionInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingPositionInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingZeroPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingFirstPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 1);
            transformed.Should().Be("S");
        }

        [TestMethod]
        public void RemoveStartingPosition()
        {
            string transformed = "Some very long string".Remove().Starting(position: 7);
            transformed.Should().Be("Some ve");
        }

        [TestMethod]
        public void RemoveStartingExactPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingExceedingPosition()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove Starting From

        [TestMethod]
        public void RemoveStartingPositionFromBeginnigInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(position: 3).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingPositionFromBeginnigInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingPositionFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(position: 5).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingNegativePositionFromBeginnig()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(position: -1).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromBeginnig()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingZeroPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: 0).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingFirstPositionFromBeginnig()
        {
            string transformed = "Some very long string".Remove().Starting(position: 1).From(The.Beginning);
            transformed.Should().Be("S");
        }

        [TestMethod]
        public void RemoveStartingFirstPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 1).From(The.End);
            transformed.Should().Be("g");
        }

        [TestMethod]
        public void RemoveStartingPositionFromBeginnig()
        {
            string transformed = "Some very long string".Remove().Starting(position: 7).From(The.Beginning);
            transformed.Should().Be("Some ve");
        }

        [TestMethod]
        public void RemoveStartingPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(position: 7).From(The.End);
            transformed.Should().Be(" string");
        }

        [TestMethod]
        public void RemoveStartingExactPositionFromBeginnig()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingExactPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingExceedingPositionFromBeginnig()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingExceedingPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(position: Const.SampleString.Length + 100).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove To

        [TestMethod]
        public void RemoveToPositionInNullString()
        {
            string transformed = Const.NullString.Remove().To(position: 3);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToPositionInEmptyString()
        {
            string transformed = String.Empty.Remove().To(position: 5);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().To(position: -1).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToZeroPosition()
        {
            string transformed = Const.SampleString.Remove().To(position: 0);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstPosition()
        {
            string transformed = "Some very long string".Remove().To(position: 1);
            transformed.Should().Be("ome very long string");
        }

        [TestMethod]
        public void RemoveToPosition()
        {
            string transformed = "Some very long string".Remove().To(position: 7);
            transformed.Should().Be("ry long string");
        }

        [TestMethod]
        public void RemoveToExactPosition()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToExceedingPosition()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length + 100);
            transformed.Should().Be(String.Empty);
        }

        #endregion

        #region Remove To From

        [TestMethod]
        public void RemoveToPositionFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(position: 3).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToPositionFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(position: 3).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToPositionFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(position: 5).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToPositionFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(position: 5).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToNegativePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().To(position: -1).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().To(position: -1).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToZeroPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(position: 0).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToZeroPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(position: 0).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(position: 1).From(The.Beginning);
            transformed.Should().Be("ome very long string");
        }

        [TestMethod]
        public void RemoveToFirstPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().To(position: 1).From(The.End);
            transformed.Should().Be("Some very long strin");
        }

        [TestMethod]
        public void RemoveToPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(position: 7).From(The.Beginning);
            transformed.Should().Be("ry long string");
        }

        [TestMethod]
        public void RemoveToPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().To(position: 7).From(The.End);
            transformed.Should().Be("Some very long");
        }

        [TestMethod]
        public void RemoveToExactPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToExactPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToExceedingPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length + 100).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToExceedingPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length + 100).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        #endregion

        #region Remove Starting To

        [TestMethod]
        public void RemoveStartingCharacterToCharacterInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3).To(6);
            transformed.Should().Be(Const.NullString);
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
            string transformed = Const.SampleString.Remove().Starting(0).To(0);
            transformed.Should().Be(Const.SampleString);

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
            string transformed = Const.NullString.Remove().Starting(1).To(3, null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(1).To(2, String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(1).To(2, "marker");
            transformed.Should().Be(Const.NullString);
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
            string transformed = Const.NullString.Remove().To(3, null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, "marker");
            transformed.Should().Be(Const.NullString);
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
            string transformed = Const.NullString.Remove().Starting(1).To(3, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfNullMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(1).To(3, null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(1).To(2, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(1).To(2, String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(1).To(2, "marker").From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterToOccurrenceOfMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(1).To(2, "marker").From(The.End);
            transformed.Should().Be(Const.NullString);
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
            string transformed = Const.NullString.Remove().To(3, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(3, null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, "marker").From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, "marker").From(The.End);
            transformed.Should().Be(Const.NullString);
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

        #region Remove Starting From To

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3).From(The.Beginning).To(6);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3).From(The.End).To(6);
            transformed.Should().Be(Const.NullString);
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
            string transformed = Const.SampleString.Remove().Starting(0).From(The.Beginning).To(0);
            transformed.Should().Be(Const.SampleString);

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
            string transformed = Const.NullString.Remove().Starting(3).From(The.Beginning).To(6).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromBeginningToCharacterFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3).From(The.Beginning).To(6).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3).From(The.End).To(6).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingCharacterFromEndToCharacterFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3).From(The.End).To(6).From(The.End);
            transformed.Should().Be(Const.NullString);
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
            string transformed = Const.SampleString.Remove().Starting(0).From(The.Beginning).To(0).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);

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
            string transformed = Const.SampleString.Remove().Starting(0).From(The.End).To(0).From(The.End);
            transformed.Should().Be(Const.SampleString);

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
