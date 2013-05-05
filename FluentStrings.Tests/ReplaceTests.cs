using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class ReplaceTests
    {
        [TestMethod]
        public void EmptyReplaceAll()
        {
            string transformed = "Some very long string".ReplaceAll("very");
            transformed.Should().Be("Some  long string");
        }

        [TestMethod]
        public void ReplaceAllWith()
        {
            string transformed = "Some very long string".ReplaceAll("very").With("not very");
            transformed.Should().Be("Some not very long string");
        }

        [TestMethod]
        public void ReplaceAllWithIgnoringCase()
        {
            string transformed = "Some vERy long string".ReplaceAll("VerY").With("not very").IgnoringCase();
            transformed.Should().Be("Some not very long string");
        }

        [TestMethod]
        public void ReplaceAllNonExistingValuesWithIgnoringCase()
        {
            string transformed = "Some vERy long string".ReplaceAll("nonexisting word").With("test").IgnoringCase();
            transformed.Should().Be("Some vERy long string");
        }
    }
}
