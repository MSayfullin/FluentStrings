using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveToTests
    {
        #region Remove To

        [TestMethod]
        public void RemoveToPositionInNullString()
        {
            string transformed = Const.NullString.Remove().To(position: 3);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToPositionInEmptyString()
        {
            string transformed = String.Empty.Remove().To(position: 5);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToNegativePosition()
        {
            Action action = () => Const.SampleString.Remove().To(position: -1).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToZeroPosition()
        {
            string transformed = Const.SampleString.Remove().To(position: 0);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstPosition()
        {
            string transformed = "Some very long string".Remove().To(position: 1);
            transformed.Should().Be("ome very long string");
        }

        [TestMethod]
        public void RemoveToPosition()
        {
            string transformed = "Some very long string".Remove().To(position: 7);
            transformed.Should().Be("ry long string");
        }

        [TestMethod]
        public void RemoveToExactPosition()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToExceedingPosition()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length + 100);
            transformed.Should().Be(String.Empty);
        }

        #endregion

        #region Remove To From

        [TestMethod]
        public void RemoveToPositionFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(position: 3).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToPositionFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(position: 3).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToPositionFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(position: 5).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToPositionFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(position: 5).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToNegativePositionFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().To(position: -1).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToNegativePositionFromEnd()
        {
            Action action = () => Const.SampleString.Remove().To(position: -1).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToZeroPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(position: 0).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToZeroPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(position: 0).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(position: 1).From(The.Beginning);
            transformed.Should().Be("ome very long string");
        }

        [TestMethod]
        public void RemoveToFirstPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().To(position: 1).From(The.End);
            transformed.Should().Be("Some very long strin");
        }

        [TestMethod]
        public void RemoveToPositionFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(position: 7).From(The.Beginning);
            transformed.Should().Be("ry long string");
        }

        [TestMethod]
        public void RemoveToPositionFromEnd()
        {
            string transformed = "Some very long string".Remove().To(position: 7).From(The.End);
            transformed.Should().Be("Some very long");
        }

        [TestMethod]
        public void RemoveToExactPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToExactPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToExceedingPositionFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length + 100).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToExceedingPositionFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(position: Const.SampleString.Length + 100).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        #endregion
    }
}
