using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveCharsTests
    {
        #region Remove Vowels

        [TestMethod]
        public void RemoveVowelsFromNullString()
        {
            string transformed = Const.NullString.RemoveVowels();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveVowelsFromEmptyString()
        {
            string transformed = String.Empty.RemoveVowels();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveVowels()
        {
            string transformed = "Vowels will be removed from this string".RemoveVowels();
            transformed.Should().Be("Vwls wll b rmvd frm ths strng");
        }

        #endregion

        #region Remove Chars

        [TestMethod]
        public void RemoveNoChars()
        {
            string transformed = Const.SampleString.RemoveChars();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveSelectedCharsFromNullString()
        {
            string transformed = Const.NullString.RemoveChars('e', 'l', 'g');
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveSelectedCharsFromEmptyString()
        {
            string transformed = String.Empty.RemoveChars('e', 'l', 'g');
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveSelectedChars()
        {
            string transformed = "Some very long string".RemoveChars('e', 'l', 'g');
            transformed.Should().Be("Som vry on strin");
        }

        [TestMethod]
        public void RemoveSelectedRussianChars()
        {
            string transformed = "Очень длинная строка с русскими буквами, ё".RemoveChars('ь', 'н', 'с', 'ё');
            transformed.Should().Be("Оче длиая трока  рукими буквами, ");
        }

        #endregion

        #region Remove Chars By Quantity

        [TestMethod]
        public void RemoveCharsFromNullString()
        {
            string transformed = Const.NullString.RemoveChars(5);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveCharsFromEmptyString()
        {
            string transformed = String.Empty.RemoveChars(5);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveChars()
        {
            string transformed = "Some very long string".RemoveChars(3);
            transformed.Should().Be("e very long string");
        }

        [TestMethod]
        public void RemoveTooManyChars()
        {
            string transformed = "Some very long string".RemoveChars(30);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveZeroChars()
        {
            string transformed = Const.SampleString.RemoveChars(0);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveNegativeQuantityOfChars()
        {
            string transformed = "Some very long string".RemoveChars(-1);
            transformed.Should().Be(String.Empty);
        }

        #endregion

        #region Remove Chars By Quantity From Beginning

        [TestMethod]
        public void RemoveCharsFromBeginningOfNullString()
        {
            string transformed = Const.NullString.RemoveChars(5).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveCharsFromBeginningOfEmptyString()
        {
            string transformed = String.Empty.RemoveChars(5).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveCharsFromBeginning()
        {
            string transformed = "Some very long string".RemoveChars(7).From(The.Beginning);
            transformed.Should().Be("ry long string");
        }

        [TestMethod]
        public void RemoveTooManyCharsFromBeginning()
        {
            string transformed = "Some very long string".RemoveChars(30).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveZeroCharsFromBeginning()
        {
            string transformed = Const.SampleString.RemoveChars(0).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveNegativeQuantityOfCharsFromBeginning()
        {
            string transformed = "Some very long string".RemoveChars(-1).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        #endregion

        #region Remove Chars By Quantity From End

        [TestMethod]
        public void RemoveCharsFromEndOfNullString()
        {
            string transformed = Const.NullString.RemoveChars(5).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveCharsFromEndOfEmptyString()
        {
            string transformed = String.Empty.RemoveChars(5).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveCharsFromEnd()
        {
            string transformed = "Some very long string".RemoveChars(5).From(The.End);
            transformed.Should().Be("Some very long s");
        }

        [TestMethod]
        public void RemoveTooManyCharsFromEnd()
        {
            string transformed = "Some very long string".RemoveChars(30).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveZeroCharsFromEnd()
        {
            string transformed = Const.SampleString.RemoveChars(0).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveNegativeQuantityOfCharsFromEnd()
        {
            string transformed = "Some very long string".RemoveChars(-1).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        #endregion
    }
}
