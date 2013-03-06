using System;
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

        #region Indexes Of

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

        #region Indexes Of Ignoring Case

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
        public void IndexesOfMarkerIgnoringCase()
        {
            var indexes = "Some text marker another texts MarKer marker".IndexesOf("marker").IgnoringCase();
            indexes.Should().ContainInOrder(10, 31, 38);

            indexes = "Some text marker another texts MarKer marker".IndexesOf("mArkEr").IgnoringCase();
            indexes.Should().ContainInOrder(10, 31, 38);
        }

        #endregion
    }
}
