using System;
using System.Globalization;
using System.Threading;
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
        public void RemoveVowelsForEnglishCulture()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en");

            string transformed = "Vowels will be removed from this string".RemoveVowels();
            transformed.Should().Be("Vwls wll b rmvd frm ths strng");
        }

        [TestMethod]
        public void RemoveVowelsForRussianCulture()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ru");

            string transformed = "Очень длинная строка с русскими буквами, ё".RemoveVowels();
            transformed.Should().Be("чнь длнн стрк с рсскм бквм, ");
        }

        #endregion

        #region Remove Vowels For

        [TestMethod]
        public void RemoveVowelsFromNullStringForEn()
        {
            string transformed = Const.NullString.RemoveVowels().For("en");
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveVowelsFromEmptyStringForRu()
        {
            string transformed = String.Empty.RemoveVowels().For("ru");
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveVowelsForEmptyCulture()
        {
            string transformed = Const.SampleString.RemoveVowels().For("");
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveVowelsForNonExistingCulture()
        {
            string transformed = Const.SampleString.RemoveVowels().For("no_culture");
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveVowelsForEnglishCultureExplicit()
        {
            string transformed = "Vowels will be removed from this string".RemoveVowels().For("en");
            transformed.Should().Be("Vwls wll b rmvd frm ths strng");
        }

        [TestMethod]
        public void RemoveVowelsForRussianCultureExplicit()
        {
            string transformed = "Очень длинная строка с русскими буквами, ё".RemoveVowels().For("ru");
            transformed.Should().Be("чнь длнн стрк с рсскм бквм, ");
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

        #region Remove Chars Ignoring Case

        [TestMethod]
        public void RemoveNoCharsIgnoringCase()
        {
            string transformed = Const.SampleString.RemoveChars().IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveSelectedCharsFromNullStringIgnoringCase()
        {
            string transformed = Const.NullString.RemoveChars('e', 'L', 'g').IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveSelectedCharsFromEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.RemoveChars('e', 'L', 'g').IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveSelectedCharsIgnoringCase()
        {
            string transformed = "Some very long string".RemoveChars('e', 'L', 'g').IgnoringCase();
            transformed.Should().Be("Som vry on strin");
        }

        [TestMethod]
        public void RemoveSelectedRussianCharsIgnoringCase()
        {
            string transformed = "Очень длинная строка с русскими буквами, ё".RemoveChars('ь', 'Н', 'с', 'Ё').IgnoringCase();
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
        }

        #endregion
    }
}
