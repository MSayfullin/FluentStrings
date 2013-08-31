using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveCharsTests
    {
        #region Remove Vowels

        [Test]
        public void RemoveVowelsFromNullString()
        {
            string transformed = Const.NullString.RemoveVowels();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveVowelsFromEmptyString()
        {
            string transformed = String.Empty.RemoveVowels();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveVowelsForEnglishCulture()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en");

            string transformed = "Vowels will be removed from this string".RemoveVowels();
            transformed.Should().Be("Vwls wll b rmvd frm ths strng");
        }

        [Test]
        public void RemoveVowelsForRussianCulture()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ru");

            string transformed = "Очень длинная строка с русскими буквами, ё".RemoveVowels();
            transformed.Should().Be("чнь длнн стрк с рсскм бквм, ");
        }

        #endregion

        #region Remove Vowels For

        [Test]
        public void RemoveVowelsFromNullStringForEn()
        {
            string transformed = Const.NullString.RemoveVowels().For("en");
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveVowelsFromEmptyStringForRu()
        {
            string transformed = String.Empty.RemoveVowels().For("ru");
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveVowelsForEmptyCulture()
        {
            string transformed = Const.SampleString.RemoveVowels().For("");
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveVowelsForNonExistingCulture()
        {
            string transformed = Const.SampleString.RemoveVowels().For("no_culture");
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveVowelsForEnglishCultureExplicit()
        {
            string transformed = "Vowels will be removed from this string".RemoveVowels().For("en");
            transformed.Should().Be("Vwls wll b rmvd frm ths strng");
        }

        [Test]
        public void RemoveVowelsForRussianCultureExplicit()
        {
            string transformed = "Очень длинная строка с русскими буквами, ё".RemoveVowels().For("ru");
            transformed.Should().Be("чнь длнн стрк с рсскм бквм, ");
        }

        #endregion

        #region Remove Chars

        [Test]
        public void RemoveNoChars()
        {
            string transformed = Const.SampleString.RemoveChars();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveSelectedCharsFromNullString()
        {
            string transformed = Const.NullString.RemoveChars('e', 'l', 'g');
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveSelectedCharsFromEmptyString()
        {
            string transformed = String.Empty.RemoveChars('e', 'l', 'g');
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveSelectedChars()
        {
            string transformed = "Some very long string".RemoveChars('e', 'l', 'g');
            transformed.Should().Be("Som vry on strin");
        }

        [Test]
        public void RemoveSelectedRussianChars()
        {
            string transformed = "Очень длинная строка с русскими буквами, ё".RemoveChars('ь', 'н', 'с', 'ё');
            transformed.Should().Be("Оче длиая трока  рукими буквами, ");
        }

        #endregion

        #region Remove Chars Ignoring Case

        [Test]
        public void RemoveNoCharsIgnoringCase()
        {
            string transformed = Const.SampleString.RemoveChars().IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveSelectedCharsFromNullStringIgnoringCase()
        {
            string transformed = Const.NullString.RemoveChars('e', 'L', 'g').IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveSelectedCharsFromEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.RemoveChars('e', 'L', 'g').IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveSelectedCharsIgnoringCase()
        {
            string transformed = "Some very long string".RemoveChars('e', 'L', 'g').IgnoringCase();
            transformed.Should().Be("Som vry on strin");
        }

        [Test]
        public void RemoveSelectedRussianCharsIgnoringCase()
        {
            string transformed = "Очень длинная строка с русскими буквами, ё".RemoveChars('ь', 'Н', 'с', 'Ё').IgnoringCase();
            transformed.Should().Be("Оче длиая трока  рукими буквами, ");
        }

        #endregion

        #region Remove Chars By Quantity

        [Test]
        public void RemoveCharsFromNullString()
        {
            string transformed = Const.NullString.RemoveChars(5);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveCharsFromEmptyString()
        {
            string transformed = String.Empty.RemoveChars(5);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveChars()
        {
            string transformed = "Some very long string".RemoveChars(3);
            transformed.Should().Be("e very long string");
        }

        [Test]
        public void RemoveTooManyChars()
        {
            string transformed = "Some very long string".RemoveChars(30);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveZeroChars()
        {
            string transformed = Const.SampleString.RemoveChars(0);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNegativeQuantityOfChars()
        {
            Action action = () => "Some very long string".RemoveChars(-1).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        #endregion

        #region Remove Chars By Quantity From Beginning

        [Test]
        public void RemoveCharsFromBeginningOfNullString()
        {
            string transformed = Const.NullString.RemoveChars(5).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveCharsFromBeginningOfEmptyString()
        {
            string transformed = String.Empty.RemoveChars(5).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveCharsFromBeginning()
        {
            string transformed = "Some very long string".RemoveChars(7).From(The.Beginning);
            transformed.Should().Be("ry long string");
        }

        [Test]
        public void RemoveTooManyCharsFromBeginning()
        {
            string transformed = "Some very long string".RemoveChars(30).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveZeroCharsFromBeginning()
        {
            string transformed = Const.SampleString.RemoveChars(0).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNegativeQuantityOfCharsFromBeginning()
        {
            Action action = () => "Some very long string".RemoveChars(-1).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        #endregion

        #region Remove Chars By Quantity From End

        [Test]
        public void RemoveCharsFromEndOfNullString()
        {
            string transformed = Const.NullString.RemoveChars(5).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveCharsFromEndOfEmptyString()
        {
            string transformed = String.Empty.RemoveChars(5).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveCharsFromEnd()
        {
            string transformed = "Some very long string".RemoveChars(5).From(The.End);
            transformed.Should().Be("Some very long s");
        }

        [Test]
        public void RemoveTooManyCharsFromEnd()
        {
            string transformed = "Some very long string".RemoveChars(30).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveZeroCharsFromEnd()
        {
            string transformed = Const.SampleString.RemoveChars(0).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNegativeQuantityOfCharsFromEnd()
        {
            Action action = () => "Some very long string".RemoveChars(-1).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        #endregion
    }
}
