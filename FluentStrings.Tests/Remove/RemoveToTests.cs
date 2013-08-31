using System;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveToTests
    {
        #region Remove To

        [Test]
        public void RemoveToPositionInNullString()
        {
            string transformed = Const.NullString.Remove().To(position: 3);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToPositionInEmptyString()
        {
            string transformed = String.Empty.Remove().To(position: 5);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().To(position: -1).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToZeroPosition()
        {
            string transformed = Const.SampleString.Remove().To(position: 0);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstPosition()
        {
            string transformed = "Some very long string".Remove().To(position: 1);
            transformed.Should().Be("ome very long string");
        }

        [Test]
        public void RemoveToPosition()
        {
            string transformed = "Some very long string".Remove().To(position: 7);
            transformed.Should().Be("ry long string");
        }

        [Test]
        public void RemoveToExactPosition()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToExceedingPosition()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length + 100);
            transformed.Should().Be(String.Empty);
        }

        #endregion

        #region Remove To From

        [Test]
        public void RemoveToPositionFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(position: 3).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToPositionFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(position: 3).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToPositionFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(position: 5).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToPositionFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(position: 5).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToNegativePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().To(position: -1).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().To(position: -1).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToZeroPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(position: 0).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToZeroPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(position: 0).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(position: 1).From(The.Beginning);
            transformed.Should().Be("ome very long string");
        }

        [Test]
        public void RemoveToFirstPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().To(position: 1).From(The.End);
            transformed.Should().Be("Some very long strin");
        }

        [Test]
        public void RemoveToPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(position: 7).From(The.Beginning);
            transformed.Should().Be("ry long string");
        }

        [Test]
        public void RemoveToPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().To(position: 7).From(The.End);
            transformed.Should().Be("Some very long");
        }

        [Test]
        public void RemoveToExactPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToExactPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToExceedingPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length + 100).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToExceedingPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length + 100).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        #endregion
    }
}
