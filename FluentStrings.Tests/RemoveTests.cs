using System;
using dokas.FluentStrings;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringTransformerTests
{
    [TestClass()]
    public class RemoveTests
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

        #region Remove

        [TestMethod()]
        public void RemoveTextFromNullString()
        {
            string transformed = NullString.Remove("bla");
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void RemoveNullText()
        {
            string transformed = NothingShouldBeChanged.Remove(null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void RemoveNullTextFromNullString()
        {
            string transformed = NullString.Remove(null);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void RemoveEmptyText()
        {
            string transformed = NothingShouldBeChanged.Remove(String.Empty);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void RemoveText()
        {
            string transformed = "TEST string will be removed".Remove("TEST");
            transformed.Should().Be(" string will be removed");

            transformed = "TEST string will be removed from both sides TEST".Remove("TEST");
            transformed.Should().Be(" string will be removed from both sides ");
        }

        #endregion
    }
}
