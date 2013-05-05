using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class TruncateTests
    {
        #region Truncate To

        [TestMethod]
        public void TruncateToOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void TruncateToOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void TruncateWhiteSpacesTo()
        {
            string transformed = "                     ".TruncateTo(8);
            transformed.Should().HaveLength(8);
            transformed.Should().Be("        ");
        }

        [TestMethod]
        public void TruncateTo()
        {
            string transformed = "Some very long string".TruncateTo(8);
            transformed.Should().HaveLength(8);
            transformed.Should().Be("Some ver");
        }

        #endregion

        #region Truncate To With

        [TestMethod]
        public void TruncateToWithNullOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3).With(null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void TruncateToWithEmptyStringOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3).With(String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void TruncateToWithOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3).With(" etc.");
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void TruncateToWithNullOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).With(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void TruncateToWithEmptyStringOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).With(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void TruncateToWithOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).With(" etc.");
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void TruncateToWithNull()
        {
            string transformed = "Some very long string".TruncateTo(9).With(null);
            transformed.Should().HaveLength(9);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void TruncateToWithEmptyString()
        {
            string transformed = "Some very long string".TruncateTo(9).With(String.Empty);
            transformed.Should().HaveLength(9);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void TruncateWhiteSpacesToWith()
        {
            string transformed = "                     ".TruncateTo(11).With(" etc.");
            transformed.Should().HaveLength(11);
            transformed.Should().Be("       etc.");
        }

        [TestMethod]
        public void TruncateToWithWhiteSpaces()
        {
            string transformed = "Some very long string".TruncateTo(11).With("   ");
            transformed.Should().HaveLength(11);
            transformed.Should().Be("Some ver   ");
        }

        [TestMethod]
        public void TruncateToWith()
        {
            string transformed = "Some very long string".TruncateTo(11).With(" etc.");
            transformed.Should().HaveLength(11);
            transformed.Should().Be("Some v etc.");
        }

        #endregion

        #region Truncate To With Ellipsis

        [TestMethod]
        public void TruncateToWithEllipsisOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3).WithEllipsis();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void TruncateToWithEllipsisOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).WithEllipsis();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void TruncateWhiteSpacesToWithEllipsis()
        {
            string transformed = "                     ".TruncateTo(11).WithEllipsis();
            transformed.Should().HaveLength(11);
            transformed.Should().Be("        ...");
        }

        [TestMethod]
        public void TruncateToWithEllipsisTrimming()
        {
            string transformed = "Some very long string".TruncateTo(13).WithEllipsis();
            transformed.Should().HaveLength(12);
            transformed.Should().Be("Some very...");
        }

        [TestMethod]
        public void TruncateToWithEllipsis()
        {
            string transformed = "Some very long string".TruncateTo(11).WithEllipsis();
            transformed.Should().HaveLength(11);
            transformed.Should().Be("Some ver...");
        }

        #endregion

        #region Truncate To From

        [TestMethod]
        public void TruncateToFromBeginningOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void TruncateToFromEndOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void TruncateToFromBeginningOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void TruncateToFromEndOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void TruncateWhiteSpacesToFromBeginning()
        {
            string transformed = "                     ".TruncateTo(9).From(The.Beginning);
            transformed.Should().HaveLength(9);
            transformed.Should().Be("         ");
        }

        [TestMethod]
        public void TruncateWhiteSpacesToFromEnd()
        {
            string transformed = "                     ".TruncateTo(11).From(The.End);
            transformed.Should().HaveLength(11);
            transformed.Should().Be("           ");
        }

        [TestMethod]
        public void TruncateToFromBeginning()
        {
            string transformed = "Some very long string".TruncateTo(9).From(The.Beginning);
            transformed.Should().HaveLength(9);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void TruncateToFromEnd()
        {
            string transformed = "Some very long string".TruncateTo(11).From(The.End);
            transformed.Should().HaveLength(11);
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void TruncateToFromBeginningMoreThanAvailable()
        {
            string transformed = Const.SampleString.TruncateTo(100).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }
        
        [TestMethod]
        public void TruncateToFromEndMoreThanAvailable()
        {
            string transformed = Const.SampleString.TruncateTo(100).From (The.End);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion
    }
}
