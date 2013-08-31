using System;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class TruncateTests
    {
        #region Truncate To

        [Test]
        public void TruncateToOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void TruncateToOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void TruncateWhiteSpacesTo()
        {
            string transformed = "                     ".TruncateTo(8);
            transformed.Should().HaveLength(8);
            transformed.Should().Be("        ");
        }

        [Test]
        public void TruncateTo()
        {
            string transformed = "Some very long string".TruncateTo(8);
            transformed.Should().HaveLength(8);
            transformed.Should().Be("Some ver");
        }

        #endregion

        #region Truncate To With

        [Test]
        public void TruncateToWithNullOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3).With(null);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void TruncateToWithEmptyStringOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3).With(String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void TruncateToWithOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3).With(" etc.");
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void TruncateToWithNullOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).With(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void TruncateToWithEmptyStringOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).With(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void TruncateToWithOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).With(" etc.");
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void TruncateToWithNull()
        {
            string transformed = "Some very long string".TruncateTo(9).With(null);
            transformed.Should().HaveLength(9);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void TruncateToWithEmptyString()
        {
            string transformed = "Some very long string".TruncateTo(9).With(String.Empty);
            transformed.Should().HaveLength(9);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void TruncateWhiteSpacesToWith()
        {
            string transformed = "                     ".TruncateTo(11).With(" etc.");
            transformed.Should().HaveLength(11);
            transformed.Should().Be("       etc.");
        }

        [Test]
        public void TruncateToWithWhiteSpaces()
        {
            string transformed = "Some very long string".TruncateTo(11).With("   ");
            transformed.Should().HaveLength(11);
            transformed.Should().Be("Some ver   ");
        }

        [Test]
        public void TruncateToWith()
        {
            string transformed = "Some very long string".TruncateTo(11).With(" etc.");
            transformed.Should().HaveLength(11);
            transformed.Should().Be("Some v etc.");
        }

        #endregion

        #region Truncate To With Ellipsis

        [Test]
        public void TruncateToWithEllipsisOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3).WithEllipsis();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void TruncateToWithEllipsisOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).WithEllipsis();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void TruncateWhiteSpacesToWithEllipsis()
        {
            string transformed = "                     ".TruncateTo(11).WithEllipsis();
            transformed.Should().HaveLength(11);
            transformed.Should().Be("        ...");
        }

        [Test]
        public void TruncateToWithEllipsisTrimming()
        {
            string transformed = "Some very long string".TruncateTo(13).WithEllipsis();
            transformed.Should().HaveLength(12);
            transformed.Should().Be("Some very...");
        }

        [Test]
        public void TruncateToWithEllipsis()
        {
            string transformed = "Some very long string".TruncateTo(11).WithEllipsis();
            transformed.Should().HaveLength(11);
            transformed.Should().Be("Some ver...");
        }

        #endregion

        #region Truncate To From

        [Test]
        public void TruncateToFromBeginningOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void TruncateToFromEndOfNullString()
        {
            string transformed = Const.NullString.TruncateTo(3).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void TruncateToFromBeginningOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void TruncateToFromEndOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void TruncateWhiteSpacesToFromBeginning()
        {
            string transformed = "                     ".TruncateTo(9).From(The.Beginning);
            transformed.Should().HaveLength(9);
            transformed.Should().Be("         ");
        }

        [Test]
        public void TruncateWhiteSpacesToFromEnd()
        {
            string transformed = "                     ".TruncateTo(11).From(The.End);
            transformed.Should().HaveLength(11);
            transformed.Should().Be("           ");
        }

        [Test]
        public void TruncateToFromBeginning()
        {
            string transformed = "Some very long string".TruncateTo(9).From(The.Beginning);
            transformed.Should().HaveLength(9);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void TruncateToFromEnd()
        {
            string transformed = "Some very long string".TruncateTo(11).From(The.End);
            transformed.Should().HaveLength(11);
            transformed.Should().Be("long string");
        }

        [Test]
        public void TruncateToFromBeginningMoreThanAvailable()
        {
            string transformed = Const.SampleString.TruncateTo(100).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }
        
        [Test]
        public void TruncateToFromEndMoreThanAvailable()
        {
            string transformed = Const.SampleString.TruncateTo(100).From (The.End);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion
    }
}
