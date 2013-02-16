using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class UtilitiesTests
    {
        #region Is Empty

        [TestMethod]
        public void IsNullStringEmpty()
        {
            bool isEmpty = Const.NullString.IsEmpty();
            isEmpty.Should().Be(true);
        }

        [TestMethod]
        public void IsEmptyStringEmpty()
        {
            bool isEmpty = String.Empty.IsEmpty();
            isEmpty.Should().Be(true);
        }

        [TestMethod]
        public void IsWhiteSpaceStringEmpty()
        {
            bool isEmpty = "  ".IsEmpty();
            isEmpty.Should().Be(false);
        }

        [TestMethod]
        public void IsStringEmpty()
        {
            bool isEmpty = Const.SampleString.IsEmpty();
            isEmpty.Should().Be(false);
        }

        #endregion

        #region Is Empty Or White Space

        [TestMethod]
        public void IsNullStringEmptyOrWhiteSpace()
        {
            bool isEmptyOrWhiteSpace = Const.NullString.IsEmpty().OrWhiteSpace();
            isEmptyOrWhiteSpace.Should().Be(true);
        }

        [TestMethod]
        public void IsEmptyStringEmptyOrWhiteSpace()
        {
            bool isEmptyOrWhiteSpace = String.Empty.IsEmpty().OrWhiteSpace();
            isEmptyOrWhiteSpace.Should().Be(true);
        }

        [TestMethod]
        public void IsWhiteSpaceStringEmptyOrWhiteSpace()
        {
            bool isEmptyOrWhiteSpace = "  ".IsEmpty().OrWhiteSpace();
            isEmptyOrWhiteSpace.Should().Be(true);
        }

        [TestMethod]
        public void IsStringEmptyOrWhiteSpace()
        {
            bool isEmptyOrWhiteSpace = Const.SampleString.IsEmpty().OrWhiteSpace();
            isEmptyOrWhiteSpace.Should().Be(false);
        }

        #endregion
    }
}
