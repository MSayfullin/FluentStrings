using System;
using dokas.FluentStrings;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringTransformerTests
{
    [TestClass()]
    public class TruncateTests
    {
        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Constants

        private const string NullString = null;
        private const string NothingShouldBeChanged = "Nothing should be changed";

        #endregion

        #region TruncateTo

        [TestMethod()]
        public void TruncateToOfNullString()
        {
            string transformed = NullString.TruncateTo(3);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void TruncateToOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod()]
        public void TruncateTo()
        {
            string transformed = "Some very long string".TruncateTo(8);
            transformed.Should().Be("Some ver");
        }

        #endregion

        #region TruncateTo From

        [TestMethod()]
        public void TruncateToFromBeginningOfNullString()
        {
            string transformed = NullString.TruncateTo(3).From(The.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void TruncateToFromEndOfNullString()
        {
            string transformed = NullString.TruncateTo(3).From(The.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void TruncateToFromBeginningOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod()]
        public void TruncateToFromEndOfEmptyString()
        {
            string transformed = String.Empty.TruncateTo(5).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod()]
        public void TruncateToFromBeginning()
        {
            string transformed = "Some very long string".TruncateTo(9).From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [TestMethod()]
        public void TruncateToFromEnd()
        {
            string transformed = "Some very long string".TruncateTo(11).From(The.End);
            transformed.Should().Be("long string");
        }

        #endregion
    }
}
