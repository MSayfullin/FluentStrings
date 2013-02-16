using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveNextPreviousTests
    {
        #region Remove Starting Next

        [TestMethod]
        public void RemoveNext()
        {
            string transformed = "Some very long string".Remove().Starting(1).Next(3);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting From Next

        [TestMethod]
        public void RemoveFromNext()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).Next(3);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting Previous

        [TestMethod]
        public void RemovePrevious()
        {
            string transformed = "Some very long string".Remove().Starting(1).Previous(3);
            transformed.Should().Be("");
        }

        #endregion

        #region Remove Starting From Previous

        [TestMethod]
        public void RemoveFromPrevious()
        {
            string transformed = "Some very long string".Remove().Starting(1).From(The.Beginning).Previous(3);
            transformed.Should().Be("");
        }

        #endregion
    }
}
