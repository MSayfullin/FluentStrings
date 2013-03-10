using System;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class UtilitiesTests
    {
        #region Is Empty

        [TestMethod]
        public void IsNullStringEmpty()
        {
            bool isEmpty = Const.NullString.IsEmpty();
            isEmpty.Should().Be(true);
        }

        [TestMethod]
        public void IsEmptyStringEmpty()
        {
            bool isEmpty = String.Empty.IsEmpty();
            isEmpty.Should().Be(true);
        }

        [TestMethod]
        public void IsWhiteSpaceStringEmpty()
        {
            bool isEmpty = "  ".IsEmpty();
            isEmpty.Should().Be(false);
        }

        [TestMethod]
        public void IsStringEmpty()
        {
            bool isEmpty = Const.SampleString.IsEmpty();
            isEmpty.Should().Be(false);
        }

        #endregion

        #region Is Empty Or White Space

        [TestMethod]
        public void IsNullStringEmptyOrWhiteSpace()
        {
            bool isEmptyOrWhiteSpace = Const.NullString.IsEmpty().OrWhiteSpace();
            isEmptyOrWhiteSpace.Should().Be(true);
        }

        [TestMethod]
        public void IsEmptyStringEmptyOrWhiteSpace()
        {
            bool isEmptyOrWhiteSpace = String.Empty.IsEmpty().OrWhiteSpace();
            isEmptyOrWhiteSpace.Should().Be(true);
        }

        [TestMethod]
        public void IsWhiteSpaceStringEmptyOrWhiteSpace()
        {
            bool isEmptyOrWhiteSpace = "  ".IsEmpty().OrWhiteSpace();
            isEmptyOrWhiteSpace.Should().Be(true);
        }

        [TestMethod]
        public void IsStringEmptyOrWhiteSpace()
        {
            bool isEmptyOrWhiteSpace = Const.SampleString.IsEmpty().OrWhiteSpace();
            isEmptyOrWhiteSpace.Should().Be(false);
        }

        #endregion

        #region Indexes Of Value

        [TestMethod]
        public void IndexesOfMarkerInNullString()
        {
            var indexes = Const.NullString.IndexesOf("marker");
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerInNullString()
        {
            var indexes = Const.NullString.IndexesOf(null);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerInNullString()
        {
            var indexes = Const.NullString.IndexesOf(String.Empty);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfMarkerInEmptyString()
        {
            var indexes = String.Empty.IndexesOf("marker");
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerInEmptyString()
        {
            var indexes = String.Empty.IndexesOf(null);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerInEmptyString()
        {
            var indexes = String.Empty.IndexesOf(String.Empty);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarker()
        {
            var indexes = Const.SampleString.IndexesOf(null);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarker()
        {
            var indexes = Const.SampleString.IndexesOf(String.Empty);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfMarkerAtBeginning()
        {
            var indexes = "marker with another text marker and another texts marker marker".IndexesOf("marker");
            indexes.Should().ContainInOrder(0, 25, 50, 57);
        }

        [TestMethod]
        public void IndexesOfMarker()
        {
            var indexes = "Some text marker another texts marker marker".IndexesOf("marker");
            indexes.Should().ContainInOrder(10, 31, 38);
        }

        [TestMethod]
        public void IndexesOfMarkerCaseSensitive()
        {
            var indexes = "Some text marker another texts Marker marker".IndexesOf("marker");
            indexes.Should().ContainInOrder(10, 38);
        }

        #endregion

        #region Indexes Of Value From

        [TestMethod]
        public void IndexesOfMarkerFromEndOf()
        {
            Action action = () => Const.SampleString.IndexesOf("marker").From(The.EndOf).First();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void IndexesOfMarkerInNullStringFromBeginning()
        {
            var indexes = Const.NullString.IndexesOf("marker").From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfMarkerInNullStringFromEnd()
        {
            var indexes = Const.NullString.IndexesOf("marker").From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerInNullStringFromBeginning()
        {
            var indexes = Const.NullString.IndexesOf(null).From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerInNullStringFromEnd()
        {
            var indexes = Const.NullString.IndexesOf(null).From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerInNullStringFromBeginning()
        {
            var indexes = Const.NullString.IndexesOf(String.Empty).From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerInNullStringFromEnd()
        {
            var indexes = Const.NullString.IndexesOf(String.Empty).From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfMarkerInEmptyStringFromBeginning()
        {
            var indexes = String.Empty.IndexesOf("marker").From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfMarkerInEmptyStringFromEnd()
        {
            var indexes = String.Empty.IndexesOf("marker").From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerInEmptyStringFromBeginning()
        {
            var indexes = String.Empty.IndexesOf(null).From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerInEmptyStringFromEnd()
        {
            var indexes = String.Empty.IndexesOf(null).From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerInEmptyStringFromBeginning()
        {
            var indexes = String.Empty.IndexesOf(String.Empty).From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerInEmptyStringFromEnd()
        {
            var indexes = String.Empty.IndexesOf(String.Empty).From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerFromBeginning()
        {
            var indexes = Const.SampleString.IndexesOf(null).From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerFromEnd()
        {
            var indexes = Const.SampleString.IndexesOf(null).From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerFromBeginning()
        {
            var indexes = Const.SampleString.IndexesOf(String.Empty).From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerFromEnd()
        {
            var indexes = Const.SampleString.IndexesOf(String.Empty).From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfMarkerAtBeginningFromBeginning()
        {
            var indexes = "marker with another text marker and another texts marker marker".IndexesOf("marker").From(The.Beginning);
            indexes.Should().ContainInOrder(0, 25, 50, 57);
        }

        [TestMethod]
        public void IndexesOfMarkerAtBeginningFromEnd()
        {
            var indexes = "marker with another text marker and another texts marker marker".IndexesOf("marker").From(The.End);
            indexes.Should().ContainInOrder(57, 50, 25, 0);
        }

        [TestMethod]
        public void IndexesOfMarkerFromBeginning()
        {
            var indexes = "Some text marker another texts marker marker".IndexesOf("marker").From(The.Beginning);
            indexes.Should().ContainInOrder(10, 31, 38);
        }

        [TestMethod]
        public void IndexesOfMarkerFromEnd()
        {
            var indexes = "Some text marker another texts marker marker".IndexesOf("marker").From(The.End);
            indexes.Should().ContainInOrder(38, 31, 10);
        }

        [TestMethod]
        public void IndexesOfMarkerCaseSensitiveFromBeginning()
        {
            var indexes = "Some text marker another texts Marker marker".IndexesOf("marker").From(The.Beginning);
            indexes.Should().ContainInOrder(10, 38);
        }

        [TestMethod]
        public void IndexesOfMarkerCaseSensitiveFromEnd()
        {
            var indexes = "Some text marker another texts Marker marker".IndexesOf("marker").From(The.End);
            indexes.Should().ContainInOrder(38, 10);
        }

        #endregion

        #region Indexes Of Value Ignoring Case

        [TestMethod]
        public void IndexesOfMarkerInNullStringIgnoringCase()
        {
            var indexes = Const.NullString.IndexesOf("marker").IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerInNullStringIgnoringCase()
        {
            var indexes = Const.NullString.IndexesOf(null).IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerInNullStringIgnoringCase()
        {
            var indexes = Const.NullString.IndexesOf(String.Empty).IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfMarkerInEmptyStringIgnoringCase()
        {
            var indexes = String.Empty.IndexesOf("marker").IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerInEmptyStringIgnoringCase()
        {
            var indexes = String.Empty.IndexesOf(null).IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerInEmptyStringIgnoringCase()
        {
            var indexes = String.Empty.IndexesOf(String.Empty).IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerIgnoringCase()
        {
            var indexes = Const.SampleString.IndexesOf(null).IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerIgnoringCase()
        {
            var indexes = Const.SampleString.IndexesOf(String.Empty).IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfMarkerAtBeginningIgnoringCase()
        {
            var indexes = "Marker with another text maRKer and another texts marker markeR".IndexesOf("marker").IgnoringCase();
            indexes.Should().ContainInOrder(0, 25, 50, 57);
        }

        [TestMethod]
        public void IndexesOfMarkerIgnoringCase()
        {
            var indexes = "Some text marker another texts MarKer marker".IndexesOf("marker").IgnoringCase();
            indexes.Should().ContainInOrder(10, 31, 38);

            indexes = "Some text marker another texts MarKer marker".IndexesOf("mArkEr").IgnoringCase();
            indexes.Should().ContainInOrder(10, 31, 38);
        }

        #endregion

        #region Indexes Of Value Ignoring Case From

        [TestMethod]
        public void IndexesOfMarkerIgnoringCaseFromStartOf()
        {
            Action action = () => Const.SampleString.IndexesOf("marker").IgnoringCase().From(The.StartOf).First();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void IndexesOfMarkerInNullStringIgnoringCaseFromBeginning()
        {
            var indexes = Const.NullString.IndexesOf("marker").IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfMarkerInNullStringIgnoringCaseFromEnd()
        {
            var indexes = Const.NullString.IndexesOf("marker").IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerInNullStringIgnoringCaseFromBeginning()
        {
            var indexes = Const.NullString.IndexesOf(null).IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerInNullStringIgnoringCaseFromEnd()
        {
            var indexes = Const.NullString.IndexesOf(null).IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerInNullStringIgnoringCaseFromBeginning()
        {
            var indexes = Const.NullString.IndexesOf(String.Empty).IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerInNullStringIgnoringCaseFromEnd()
        {
            var indexes = Const.NullString.IndexesOf(String.Empty).IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfMarkerInEmptyStringIgnoringCaseFromBeginning()
        {
            var indexes = String.Empty.IndexesOf("marker").IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfMarkerInEmptyStringIgnoringCaseFromEnd()
        {
            var indexes = String.Empty.IndexesOf("marker").IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerInEmptyStringIgnoringCaseFromBeginning()
        {
            var indexes = String.Empty.IndexesOf(null).IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerInEmptyStringIgnoringCaseFromEnd()
        {
            var indexes = String.Empty.IndexesOf(null).IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerInEmptyStringIgnoringCaseFromBeginning()
        {
            var indexes = String.Empty.IndexesOf(String.Empty).IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerInEmptyStringIgnoringCaseFromEnd()
        {
            var indexes = String.Empty.IndexesOf(String.Empty).IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerIgnoringCaseFromBeginning()
        {
            var indexes = Const.SampleString.IndexesOf(null).IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfNullMarkerIgnoringCaseFromEnd()
        {
            var indexes = Const.SampleString.IndexesOf(null).IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            var indexes = Const.SampleString.IndexesOf(String.Empty).IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfEmptyMarkerIgnoringCaseFromEnd()
        {
            var indexes = Const.SampleString.IndexesOf(String.Empty).IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [TestMethod]
        public void IndexesOfMarkerAtBeginningIgnorignCaseFromBeginning()
        {
            var indexes = "Marker with another text maRKer and another texts marker markeR".IndexesOf("marker").IgnoringCase().From(The.Beginning);
            indexes.Should().ContainInOrder(0, 25, 50, 57);
        }

        [TestMethod]
        public void IndexesOfMarkerAtBeginningIgnorignCaseFromEnd()
        {
            var indexes = "Marker with another text maRKer and another texts marker markeR".IndexesOf("mArker").IgnoringCase().From(The.End);
            indexes.Should().ContainInOrder(57, 50, 25, 0);
        }

        [TestMethod]
        public void IndexesOfMarkerIgnoringCaseFromBeginning()
        {
            var indexes = "Some text mARKer another texts markER MArker".IndexesOf("maRker").IgnoringCase().From(The.Beginning);
            indexes.Should().ContainInOrder(10, 31, 38);
        }

        [TestMethod]
        public void IndexesOfMarkerIgnoringCaseFromEnd()
        {
            var indexes = "Some text markEr another texts marker MARKER".IndexesOf("marKer").IgnoringCase().From(The.End);
            indexes.Should().ContainInOrder(38, 31, 10);
        }

        #endregion
    }
}
