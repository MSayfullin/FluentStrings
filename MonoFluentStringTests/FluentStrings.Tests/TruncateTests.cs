using System;
using dokas.FluentStrings;
using FluentAssertions;
using NUnit.Framework;

namespace StringTransformerTests
{
    [TestFixture]
    public class TruncateTests
    {
        #region Constants

        private const string NullString = null;
        private const string NothingShouldBeChanged = "Nothing should be changed";

        #endregion

        #region TruncateTo

        [Test]
        public void TruncateToOfNullString ()
        {
            string transformed = NullString.TruncateTo (3);
            transformed.Should ().Be (NullString);
        }

        [Test]
        public void TruncateToOfEmptyString ()
        {
            string transformed = String.Empty.TruncateTo (5);
            transformed.Should ().Be (String.Empty);
        }

        [Test]
        public void TruncateTo ()
        {
            string transformed = "Some very long string".TruncateTo (8);
            transformed.Should ().Be ("Some ver");
        }

        #endregion

        #region TruncateTo From

        [Test]
        public void TruncateToFromBeginningOfNullString ()
        {
            string transformed = NullString.TruncateTo (3).From (The.Beginning);
            transformed.Should ().Be (NullString);
        }

        [Test]
        public void TruncateToFromEndOfNullString ()
        {
            string transformed = NullString.TruncateTo (3).From (The.End);
            transformed.Should ().Be (NullString);
        }

        [Test]
        public void TruncateToFromBeginningOfEmptyString ()
        {
            string transformed = String.Empty.TruncateTo (5).From (The.Beginning);
            transformed.Should ().Be (String.Empty);
        }

        [Test]
        public void TruncateToFromEndOfEmptyString ()
        {
            string transformed = String.Empty.TruncateTo (5).From (The.End);
            transformed.Should ().Be (String.Empty);
        }

        [Test]
        public void TruncateToFromBeginning ()
        {
            string transformed = "Some very long string".TruncateTo (9).From (The.Beginning);
            transformed.Should ().Be ("Some very");
        }

        [Test]
        public void TruncateToFromEnd ()
        {
            string transformed = "Some very long string".TruncateTo (11).From (The.End);
            transformed.Should ().Be ("long string");
        }
        
        [Test]
        public void TruncateToFromEndMoreThanLength ()
        {
            string transformed = "short string".TruncateTo (100).From (The.End);
            transformed.Should().Be("");
        }

        #endregion
    }
}
