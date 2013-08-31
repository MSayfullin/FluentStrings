using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class ReplaceTests
    {
        [Test]
        public void EmptyReplaceAll()
        {
            string transformed = "Some very long string".ReplaceAll("very");
            transformed.Should().Be("Some  long string");
        }

        [Test]
        public void ReplaceAllWith()
        {
            string transformed = "Some very long string".ReplaceAll("very").With("not very");
            transformed.Should().Be("Some not very long string");
        }

        [Test]
        public void ReplaceAllWithIgnoringCase()
        {
            string transformed = "Some vERy long string".ReplaceAll("VerY").With("not very").IgnoringCase();
            transformed.Should().Be("Some not very long string");
        }

        [Test]
        public void ReplaceAllNonExistingValuesWithIgnoringCase()
        {
            string transformed = "Some vERy long string".ReplaceAll("nonexisting word").With("test").IgnoringCase();
            transformed.Should().Be("Some vERy long string");
        }
    }
}
