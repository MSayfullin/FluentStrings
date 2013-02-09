using System;
using dokas.FluentStrings;
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
        public void RemoveSelectedChars()
        {
            string transformed = "Some very long string".RemoveChars('e', 'l', 'g');
            transformed.Should().Be("Som vry on strin");
        }

        [TestMethod]
        public void RemoveChars()
        {
            string transformed = "Some very long string".RemoveChars(3);
            transformed.Should().Be("e very long string");
        }

        [TestMethod]
        public void RemoveCharsFromBeginning()
        {
            string transformed = "Some very long string".RemoveChars(7).From(The.Beginning);
            transformed.Should().Be("ry long string");
        }

        [TestMethod]
        public void RemoveCharsFromEnd()
        {
            string transformed = "Some very long string".RemoveChars(5).From(The.End);
            transformed.Should().Be("Some very long s");
        }

        #endregion
    }
}
