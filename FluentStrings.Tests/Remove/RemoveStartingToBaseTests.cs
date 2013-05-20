using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveStartingToBaseTests
    {
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
