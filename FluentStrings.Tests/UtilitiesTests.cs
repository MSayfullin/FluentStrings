using System;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class UtilitiesTests
    {
        #region Is Empty

        [Test]
        public void IsNullStringEmpty()
        {
            bool isEmpty = Const.NullString.IsEmpty();
            isEmpty.Should().Be(true);
        }

        [Test]
        public void IsEmptyStringEmpty()
        {
            bool isEmpty = String.Empty.IsEmpty();
            isEmpty.Should().Be(true);
        }

        [Test]
        public void IsWhiteSpaceStringEmpty()
        {
            bool isEmpty = "  ".IsEmpty();
            isEmpty.Should().Be(false);
        }

        [Test]
        public void IsStringEmpty()
        {
            bool isEmpty = Const.SampleString.IsEmpty();
            isEmpty.Should().Be(false);
        }

        #endregion

        #region Is Empty Or White Space

        [Test]
        public void IsNullStringEmptyOrWhiteSpace()
        {
            bool isEmptyOrWhiteSpace = Const.NullString.IsEmpty().OrWhiteSpace();
            isEmptyOrWhiteSpace.Should().Be(true);
        }

        [Test]
        public void IsEmptyStringEmptyOrWhiteSpace()
        {
            bool isEmptyOrWhiteSpace = String.Empty.IsEmpty().OrWhiteSpace();
            isEmptyOrWhiteSpace.Should().Be(true);
        }

        [Test]
        public void IsWhiteSpaceStringEmptyOrWhiteSpace()
        {
            bool isEmptyOrWhiteSpace = "  ".IsEmpty().OrWhiteSpace();
            isEmptyOrWhiteSpace.Should().Be(true);
        }

        [Test]
        public void IsStringEmptyOrWhiteSpace()
        {
            bool isEmptyOrWhiteSpace = Const.SampleString.IsEmpty().OrWhiteSpace();
            isEmptyOrWhiteSpace.Should().Be(false);
        }

        #endregion

        #region Format

        [Test]
        public void FormatNullString()
        {
            var formated = Const.NullString.f(Const.SampleString);
            formated.Should().Be(null);
        }

        [Test]
        public void FormatEmptyString()
        {
            var formated = String.Empty.f(Const.SampleString);
            formated.Should().Be(String.Empty);
        }

        [Test]
        public void FormatEmptyTemplate()
        {
            var formated = Const.SampleString.f(Const.SampleValue);
            formated.Should().Be(Const.SampleString);
        }

        [Test]
        public void FormatNullStringWithNullValue()
        {
            var formated = Const.NullString.f(null);
            formated.Should().Be(null);
        }

        [Test]
        public void FormatEmptyStringWithNullValue()
        {
            var formated = String.Empty.f(null);
            formated.Should().Be(String.Empty);
        }

        [Test]
        public void FormatEmptyTemplateWithNullValue()
        {
            var formated = Const.SampleString.f(null);
            formated.Should().Be(Const.SampleString);
        }

        [Test]
        public void FormatNullStringWithEmptyValue()
        {
            var formated = Const.NullString.f(String.Empty);
            formated.Should().Be(null);
        }

        [Test]
        public void FormatEmptyStringWithEmptyValue()
        {
            var formated = String.Empty.f(String.Empty);
            formated.Should().Be(String.Empty);
        }

        [Test]
        public void FormatEmptyTemplateWithEmptyValue()
        {
            var formated = Const.SampleString.f(String.Empty);
            formated.Should().Be(Const.SampleString);
        }

        [Test]
        public void FormatOneValueWithNoValues()
        {
            Action action = () => "{0}".f();
            action.ShouldThrow<FormatException>();
        }

        [Test]
        public void FormatOneValueWithNull()
        {
            var formated = "{0}".f(null);
            formated.Should().Be(String.Empty);
        }

        [Test]
        public void FormatOneValueWithEmptyValue()
        {
            var formated = "{0}".f(String.Empty);
            formated.Should().Be(String.Empty);
        }

        [Test]
        public void FormatOneValue()
        {
            var formated = "{0}".f(Const.SampleValue);
            formated.Should().Be(Const.SampleValue);
        }

        [Test]
        public void FormatThreeValueWithNoValues()
        {
            Action action = () => "{0} some string {1} some string {2}".f();
            action.ShouldThrow<FormatException>();
        }

        [Test]
        public void FormatThreeValueWithInsufficientValues()
        {
            Action action = () => "{0} some string {1} some string {2}".f("TEST1", "TEST2");
            action.ShouldThrow<FormatException>();
        }

        [Test]
        public void FormatThreeValue()
        {
            var formated = "{0} some string {1} some string {2}".f("TEST1", "TEST2", "TEST3");
            formated.Should().Be("TEST1 some string TEST2 some string TEST3");
        }

        #endregion

        #region Indexes Of Value

        [Test]
        public void IndexesOfMarkerInNullString()
        {
            var indexes = Const.NullString.IndexesOf("marker");
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerInNullString()
        {
            var indexes = Const.NullString.IndexesOf(null);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerInNullString()
        {
            var indexes = Const.NullString.IndexesOf(String.Empty);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfMarkerInEmptyString()
        {
            var indexes = String.Empty.IndexesOf("marker");
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerInEmptyString()
        {
            var indexes = String.Empty.IndexesOf(null);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerInEmptyString()
        {
            var indexes = String.Empty.IndexesOf(String.Empty);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarker()
        {
            var indexes = Const.SampleString.IndexesOf(null);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarker()
        {
            var indexes = Const.SampleString.IndexesOf(String.Empty);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfMarkerAtBeginning()
        {
            var indexes = "marker with another text marker and another texts marker marker".IndexesOf("marker");
            indexes.Should().ContainInOrder(0, 25, 50, 57);
        }

        [Test]
        public void IndexesOfMarker()
        {
            var indexes = "Some text marker another texts marker marker".IndexesOf("marker");
            indexes.Should().ContainInOrder(10, 31, 38);
        }

        [Test]
        public void IndexesOfMarkerCaseSensitive()
        {
            var indexes = "Some text marker another texts Marker marker".IndexesOf("marker");
            indexes.Should().ContainInOrder(10, 38);
        }

        #endregion

        #region Indexes Of Value From

        [Test]
        public void IndexesOfMarkerFromEndOf()
        {
            Action action = () => Const.SampleString.IndexesOf("marker").From(The.EndOf).First();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void IndexesOfMarkerInNullStringFromBeginning()
        {
            var indexes = Const.NullString.IndexesOf("marker").From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfMarkerInNullStringFromEnd()
        {
            var indexes = Const.NullString.IndexesOf("marker").From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerInNullStringFromBeginning()
        {
            var indexes = Const.NullString.IndexesOf(null).From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerInNullStringFromEnd()
        {
            var indexes = Const.NullString.IndexesOf(null).From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerInNullStringFromBeginning()
        {
            var indexes = Const.NullString.IndexesOf(String.Empty).From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerInNullStringFromEnd()
        {
            var indexes = Const.NullString.IndexesOf(String.Empty).From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfMarkerInEmptyStringFromBeginning()
        {
            var indexes = String.Empty.IndexesOf("marker").From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfMarkerInEmptyStringFromEnd()
        {
            var indexes = String.Empty.IndexesOf("marker").From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerInEmptyStringFromBeginning()
        {
            var indexes = String.Empty.IndexesOf(null).From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerInEmptyStringFromEnd()
        {
            var indexes = String.Empty.IndexesOf(null).From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerInEmptyStringFromBeginning()
        {
            var indexes = String.Empty.IndexesOf(String.Empty).From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerInEmptyStringFromEnd()
        {
            var indexes = String.Empty.IndexesOf(String.Empty).From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerFromBeginning()
        {
            var indexes = Const.SampleString.IndexesOf(null).From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerFromEnd()
        {
            var indexes = Const.SampleString.IndexesOf(null).From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerFromBeginning()
        {
            var indexes = Const.SampleString.IndexesOf(String.Empty).From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerFromEnd()
        {
            var indexes = Const.SampleString.IndexesOf(String.Empty).From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfMarkerAtBeginningFromBeginning()
        {
            var indexes = "marker with another text marker and another texts marker marker".IndexesOf("marker").From(The.Beginning);
            indexes.Should().ContainInOrder(0, 25, 50, 57);
        }

        [Test]
        public void IndexesOfMarkerAtBeginningFromEnd()
        {
            var indexes = "marker with another text marker and another texts marker marker".IndexesOf("marker").From(The.End);
            indexes.Should().ContainInOrder(57, 50, 25, 0);
        }

        [Test]
        public void IndexesOfMarkerFromBeginning()
        {
            var indexes = "Some text marker another texts marker marker".IndexesOf("marker").From(The.Beginning);
            indexes.Should().ContainInOrder(10, 31, 38);
        }

        [Test]
        public void IndexesOfMarkerFromEnd()
        {
            var indexes = "Some text marker another texts marker marker".IndexesOf("marker").From(The.End);
            indexes.Should().ContainInOrder(38, 31, 10);
        }

        [Test]
        public void IndexesOfMarkerCaseSensitiveFromBeginning()
        {
            var indexes = "Some text marker another texts Marker marker".IndexesOf("marker").From(The.Beginning);
            indexes.Should().ContainInOrder(10, 38);
        }

        [Test]
        public void IndexesOfMarkerCaseSensitiveFromEnd()
        {
            var indexes = "Some text marker another texts Marker marker".IndexesOf("marker").From(The.End);
            indexes.Should().ContainInOrder(38, 10);
        }

        #endregion

        #region Indexes Of Value Ignoring Case

        [Test]
        public void IndexesOfMarkerInNullStringIgnoringCase()
        {
            var indexes = Const.NullString.IndexesOf("marker").IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerInNullStringIgnoringCase()
        {
            var indexes = Const.NullString.IndexesOf(null).IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerInNullStringIgnoringCase()
        {
            var indexes = Const.NullString.IndexesOf(String.Empty).IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfMarkerInEmptyStringIgnoringCase()
        {
            var indexes = String.Empty.IndexesOf("marker").IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerInEmptyStringIgnoringCase()
        {
            var indexes = String.Empty.IndexesOf(null).IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerInEmptyStringIgnoringCase()
        {
            var indexes = String.Empty.IndexesOf(String.Empty).IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerIgnoringCase()
        {
            var indexes = Const.SampleString.IndexesOf(null).IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerIgnoringCase()
        {
            var indexes = Const.SampleString.IndexesOf(String.Empty).IgnoringCase();
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfMarkerAtBeginningIgnoringCase()
        {
            var indexes = "Marker with another text maRKer and another texts marker markeR".IndexesOf("marker").IgnoringCase();
            indexes.Should().ContainInOrder(0, 25, 50, 57);
        }

        [Test]
        public void IndexesOfMarkerIgnoringCase()
        {
            var indexes = "Some text marker another texts MarKer marker".IndexesOf("marker").IgnoringCase();
            indexes.Should().ContainInOrder(10, 31, 38);

            indexes = "Some text marker another texts MarKer marker".IndexesOf("mArkEr").IgnoringCase();
            indexes.Should().ContainInOrder(10, 31, 38);
        }

        #endregion

        #region Indexes Of Value Ignoring Case From

        [Test]
        public void IndexesOfMarkerIgnoringCaseFromStartOf()
        {
            Action action = () => Const.SampleString.IndexesOf("marker").IgnoringCase().From(The.StartOf).First();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void IndexesOfMarkerInNullStringIgnoringCaseFromBeginning()
        {
            var indexes = Const.NullString.IndexesOf("marker").IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfMarkerInNullStringIgnoringCaseFromEnd()
        {
            var indexes = Const.NullString.IndexesOf("marker").IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerInNullStringIgnoringCaseFromBeginning()
        {
            var indexes = Const.NullString.IndexesOf(null).IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerInNullStringIgnoringCaseFromEnd()
        {
            var indexes = Const.NullString.IndexesOf(null).IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerInNullStringIgnoringCaseFromBeginning()
        {
            var indexes = Const.NullString.IndexesOf(String.Empty).IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerInNullStringIgnoringCaseFromEnd()
        {
            var indexes = Const.NullString.IndexesOf(String.Empty).IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfMarkerInEmptyStringIgnoringCaseFromBeginning()
        {
            var indexes = String.Empty.IndexesOf("marker").IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfMarkerInEmptyStringIgnoringCaseFromEnd()
        {
            var indexes = String.Empty.IndexesOf("marker").IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerInEmptyStringIgnoringCaseFromBeginning()
        {
            var indexes = String.Empty.IndexesOf(null).IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerInEmptyStringIgnoringCaseFromEnd()
        {
            var indexes = String.Empty.IndexesOf(null).IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerInEmptyStringIgnoringCaseFromBeginning()
        {
            var indexes = String.Empty.IndexesOf(String.Empty).IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerInEmptyStringIgnoringCaseFromEnd()
        {
            var indexes = String.Empty.IndexesOf(String.Empty).IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerIgnoringCaseFromBeginning()
        {
            var indexes = Const.SampleString.IndexesOf(null).IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfNullMarkerIgnoringCaseFromEnd()
        {
            var indexes = Const.SampleString.IndexesOf(null).IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            var indexes = Const.SampleString.IndexesOf(String.Empty).IgnoringCase().From(The.Beginning);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfEmptyMarkerIgnoringCaseFromEnd()
        {
            var indexes = Const.SampleString.IndexesOf(String.Empty).IgnoringCase().From(The.End);
            indexes.Should().BeEmpty();
        }

        [Test]
        public void IndexesOfMarkerAtBeginningIgnorignCaseFromBeginning()
        {
            var indexes = "Marker with another text maRKer and another texts marker markeR".IndexesOf("marker").IgnoringCase().From(The.Beginning);
            indexes.Should().ContainInOrder(0, 25, 50, 57);
        }

        [Test]
        public void IndexesOfMarkerAtBeginningIgnorignCaseFromEnd()
        {
            var indexes = "Marker with another text maRKer and another texts marker markeR".IndexesOf("mArker").IgnoringCase().From(The.End);
            indexes.Should().ContainInOrder(57, 50, 25, 0);
        }

        [Test]
        public void IndexesOfMarkerIgnoringCaseFromBeginning()
        {
            var indexes = "Some text mARKer another texts markER MArker".IndexesOf("maRker").IgnoringCase().From(The.Beginning);
            indexes.Should().ContainInOrder(10, 31, 38);
        }

        [Test]
        public void IndexesOfMarkerIgnoringCaseFromEnd()
        {
            var indexes = "Some text markEr another texts marker MARKER".IndexesOf("marKer").IgnoringCase().From(The.End);
            indexes.Should().ContainInOrder(38, 31, 10);
        }

        #endregion
    }
}
