using System;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveTests
    {
        #region Full Remove

        [Test]
        public void RemoveFromNullString()
        {
            string transformed = Const.NullString.Remove();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveFromEmptyString()
        {
            string transformed = String.Empty.Remove();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void Remove()
        {
            string transformed = "Some string".Remove();
            transformed.Should().Be(String.Empty);
        }

        #endregion

        #region Remove

        [Test]
        public void RemoveTextFromNullString()
        {
            string transformed = Const.NullString.Remove("smth");
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveNullFromNullString()
        {
            string transformed = Const.NullString.Remove(null);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyStringFromNullString()
        {
            string transformed = Const.NullString.Remove(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveNullFromEmptyString()
        {
            string transformed = String.Empty.Remove(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveEmptyStringFromEmptyString()
        {
            string transformed = String.Empty.Remove(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveTextFromEmptyString()
        {
            string transformed = String.Empty.Remove("smth");
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveNullText()
        {
            string transformed = Const.SampleString.Remove(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveEmptyText()
        {
            string transformed = Const.SampleString.Remove(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNonExistingText()
        {
            string transformed = Const.SampleString.Remove(Const.SampleValue);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveWholeString()
        {
            string transformed = Const.SampleString.Remove(Const.SampleString);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveText()
        {
            string transformed = "TEST string will be removed".Remove("TEST");
            transformed.Should().Be(" string will be removed");

            transformed = "string will be removed ->TEST".Remove("TEST");
            transformed.Should().Be("string will be removed ->");
        }

        [Test]
        public void RemoveTextCaseSensitive()
        {
            string transformed = "tEsT string will be removed".Remove("tEsT");
            transformed.Should().Be(" string will be removed");

            transformed = "string will be removed ->TesT and this will be left TEST".Remove("TesT");
            transformed.Should().Be("string will be removed -> and this will be left TEST");

            transformed = "TEST string will be NOT be removed from string TEST".Remove("test");
            transformed.Should().Be("TEST string will be NOT be removed from string TEST");
        }

        [Test]
        public void RemoveTextWithMultipleValues()
        {
            string transformed = "string will be removed ->TEST and this will be left TEST".Remove("TEST");
            transformed.Should().Be("string will be removed -> and this will be left TEST");

            transformed = "TEST string will be removed only from left side TEST".Remove("TEST");
            transformed.Should().Be(" string will be removed only from left side TEST");
        }

        #endregion

        #region Remove From

        [Test]
        public void RemoveNullFromBeginningOfNullString()
        {
            string transformed = Const.NullString.Remove(null).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveNullFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(null).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyStringFromBeginningOfNullString()
        {
            string transformed = Const.NullString.Remove(String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyStringFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveTextFromBeginningOfNullString()
        {
            string transformed = Const.NullString.Remove(Const.SampleValue).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveTextFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(Const.SampleValue).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveNullFromBeginningOfEmptyString()
        {
            string transformed = String.Empty.Remove(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveNullFromEndOfEmptyString()
        {
            string transformed = String.Empty.Remove(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveEmptyStringFromBeginningOfEmptyString()
        {
            string transformed = String.Empty.Remove(String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyStringFromEndOfEmptyString()
        {
            string transformed = String.Empty.Remove(String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveTextFromBeginningOfEmptyString()
        {
            string transformed = String.Empty.Remove(Const.SampleValue).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveTextFromEndOfEmptyString()
        {
            string transformed = String.Empty.Remove(Const.SampleValue).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNullFromEnd()
        {
            string transformed = Const.SampleString.Remove(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveEmptyStringFromBeginning()
        {
            string transformed = Const.SampleString.Remove(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveEmptyStringFromEnd()
        {
            string transformed = Const.SampleString.Remove(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNonExistingTextFromBeginning()
        {
            string transformed = Const.SampleString.Remove(Const.SampleValue).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNonExistingTextFromEnd()
        {
            string transformed = Const.SampleString.Remove(Const.SampleValue).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveWholeStringFromBeginning()
        {
            string transformed = Const.SampleString.Remove(Const.SampleString).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveWholeStringFromEnd()
        {
            string transformed = Const.SampleString.Remove(Const.SampleString).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveTextFromBeginning()
        {
            string transformed = "TEST string will be removed".Remove("TEST").From(The.Beginning);
            transformed.Should().Be(" string will be removed");

            transformed = "TEST <- string will be removed, not this -> TEST".Remove("TEST").From(The.Beginning);
            transformed.Should().Be(" <- string will be removed, not this -> TEST");

            transformed = "Some additional string |TEST| string will be removed".Remove("TEST").From(The.Beginning);
            transformed.Should().Be("Some additional string || string will be removed");
        }

        [Test]
        public void RemoveTextCaseSensitiveFromBeginning()
        {
            string transformed = "teST string will be removed".Remove("teST").From(The.Beginning);
            transformed.Should().Be(" string will be removed");

            transformed = "test <- string will be removed, not this -> test".Remove("test").From(The.Beginning);
            transformed.Should().Be(" <- string will be removed, not this -> test");

            transformed = "Some additional TEST which will be ignored string |TeSt| string will be removed".Remove("TeSt").From(The.Beginning);
            transformed.Should().Be("Some additional TEST which will be ignored string || string will be removed");
        }

        [Test]
        public void RemoveTextFromEnd()
        {
            string transformed = "string will be removed -> TEST".Remove("TEST").From(The.End);
            transformed.Should().Be("string will be removed -> ");

            transformed = "TEST <- this string will be left, but this will be removed -> TEST".Remove("TEST").From(The.End);
            transformed.Should().Be("TEST <- this string will be left, but this will be removed -> ");

            transformed = "string will be removed -> |TEST| some additional string".Remove("TEST").From(The.End);
            transformed.Should().Be("string will be removed -> || some additional string");
        }

        [Test]
        public void RemoveTextCaseSensitiveFromEnd()
        {
            string transformed = "string will be removed -> TesT".Remove("TesT").From(The.End);
            transformed.Should().Be("string will be removed -> ");

            transformed = "test <- this string will be left, but this will be removed -> test".Remove("test").From(The.End);
            transformed.Should().Be("test <- this string will be left, but this will be removed -> ");

            transformed = "string will be removed -> |tEsT| some additional string".Remove("tEsT").From(The.End);
            transformed.Should().Be("string will be removed -> || some additional string");
        }

        #endregion

        #region Remove Ignoring Case

        [Test]
        public void RemoveNullFromNullStringIgnoringCase()
        {
            string transformed = Const.NullString.Remove(null).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyStringFromNullStringIgnoringCase()
        {
            string transformed = Const.NullString.Remove(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveTextFromNullStringIgnoringCase()
        {
            string transformed = Const.NullString.Remove(Const.SampleValue).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveNullFromEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveEmptyStringFromEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveTextFromEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove(Const.SampleValue).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveEmptyStringIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNonExistingTextIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(Const.SampleValue).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveTextIgnoringCase()
        {
            string transformed = "TEST string will be removed".Remove("TeSt").IgnoringCase();
            transformed.Should().Be(" string will be removed");

            transformed = "string will be removed ->tEST".Remove("tEsT").IgnoringCase();
            transformed.Should().Be("string will be removed ->");
        }

        [Test]
        public void RemoveTextIgnoringCaseWithMultipleValues()
        {
            string transformed = "string will be removed ->TEST and this will be left TEST".Remove("TEST").IgnoringCase();
            transformed.Should().Be("string will be removed -> and this will be left TEST");

            transformed = "TesT string will be removed only from left side TEST".Remove("TEST").IgnoringCase();
            transformed.Should().Be(" string will be removed only from left side TEST");
        }

        #endregion

        #region Remove Ignoring Case From

        [Test]
        public void RemoveNullFromBeginningOfNullStringIgnoringCase()
        {
            string transformed = Const.NullString.Remove(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveNullFromEndOfNullStringIgnoringCase()
        {
            string transformed = Const.NullString.Remove(null).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyStringFromBeginningOfNullStringIgnoringCase()
        {
            string transformed = Const.NullString.Remove(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyStringFromEndOfNullStringIgnoringCase()
        {
            string transformed = Const.NullString.Remove(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveTextFromBeginningOfNullStringIgnoringCase()
        {
            string transformed = Const.NullString.Remove(Const.SampleValue).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveTextFromEndOfNullStringIgnoringCase()
        {
            string transformed = Const.NullString.Remove(Const.SampleValue).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveNullFromBeginningOfEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveNullFromEndOfEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove(null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveEmptyStringFromBeginningOfEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyStringFromEndOfEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveTextFromBeginningOfEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove(Const.SampleValue).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveTextFromEndOfEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove(Const.SampleValue).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveNullFromBeginningIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNullFromEndIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveEmptyStringFromBeginningIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveEmptyStringFromEndIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNonExistingTextFromBeginningIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(Const.SampleValue).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNonExistingTextFromEndIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(Const.SampleValue).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveTextFromBeginningIgnoringCase()
        {
            string transformed = "TEST string will be removed".Remove("TeSt").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" string will be removed");

            transformed = "string will be removed ->tEST".Remove("tEsT").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("string will be removed ->");
        }

        [Test]
        public void RemoveTextFromBeginningIgnoringCaseWithMultipleValues()
        {
            string transformed = "string will be removed ->TEST and this will be left TEST".Remove("TEST").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("string will be removed -> and this will be left TEST");

            transformed = "TesT string will be removed only from left side TEST".Remove("TEST").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" string will be removed only from left side TEST");
        }

        [Test]
        public void RemoveTextFromEndIgnoringCase()
        {
            string transformed = "string will be removed -> TEST".Remove("tESt").IgnoringCase().From(The.End);
            transformed.Should().Be("string will be removed -> ");
        }

        [Test]
        public void RemoveTextFromEndIgnoringCaseWithMultipleValues()
        {
            string transformed = "TEST <- this string will be left, but this will be removed -> TEST".Remove("test").IgnoringCase().From(The.End);
            transformed.Should().Be("TEST <- this string will be left, but this will be removed -> ");

            transformed = "string will be removed -> |TesT| some additional string".Remove("TEST").IgnoringCase().From(The.End);
            transformed.Should().Be("string will be removed -> || some additional string");
        }

        #endregion

        #region Remove Values

        [Test]
        public void RemoveNullValuesFromNullString()
        {
            string transformed = Const.NullString.Remove(2, null);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyValuesFromNullString()
        {
            string transformed = Const.NullString.Remove(2, String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveValuesFromNullString()
        {
            string transformed = Const.NullString.Remove(2, Const.SampleValue);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveNullValuesFromEmptyString()
        {
            string transformed = String.Empty.Remove(2, null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveEmptyValuesFromEmptyString()
        {
            string transformed = String.Empty.Remove(2, String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveValuesFromEmptyString()
        {
            string transformed = String.Empty.Remove(2, Const.SampleValue);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveNullValues()
        {
            string transformed = Const.SampleString.Remove(2, null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveEmptyValues()
        {
            string transformed = Const.SampleString.Remove(2, String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNonExistingValues()
        {
            string transformed = Const.SampleString.Remove(2, "smth");
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNegativeQuantityValues()
        {
            Action action = () => Const.SampleString.Remove(-1, "smth").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveZeroValues()
        {
            string transformed = Const.SampleString.Remove(0, "smth");
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveOneValue()
        {
            string transformed = "TEST string will be removed".Remove(1, "TEST");
            transformed.Should().Be(" string will be removed");

            transformed = "string will be removed ->TEST".Remove(1, "TEST");
            transformed.Should().Be("string will be removed ->");
        }

        [Test]
        public void RemoveTwoValues()
        {
            string transformed = "string will be removed ->TEST and this will be removed also TEST".Remove(2, "TEST");
            transformed.Should().Be("string will be removed -> and this will be removed also ");
        }

        [Test]
        public void RemoveThreeValuesFromStringWithFourValues()
        {
            string transformed = "TEST only three TEST strings will be removed from TEST string TEST".Remove(3, "TEST");
            transformed.Should().Be(" only three  strings will be removed from  string TEST");
        }

        [Test]
        public void RemoveOneValueCaseSensitive()
        {
            string transformed = "TEsT string will be removed".Remove(1, "TEsT");
            transformed.Should().Be(" string will be removed");

            transformed = "string will be removed ->Test".Remove(1, "Test");
            transformed.Should().Be("string will be removed ->");
        }

        [Test]
        public void RemoveThreeValuesCaseSensitiveFromStringWithFourValues()
        {
            string transformed = "TesT only three TesT strings will be removed from TesT string TesT".Remove(3, "TesT");
            transformed.Should().Be(" only three  strings will be removed from  string TesT");
        }

        #endregion

        #region Remove Values From

        [Test]
        public void RemoveNullValuesFromBeginningOfNullString()
        {
            string transformed = Const.NullString.Remove(2, null).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveNullValuesFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(2, null).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyValuesFromBeginningOfNullString()
        {
            string transformed = Const.NullString.Remove(2, String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyValuesFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(2, String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveValuesFromBeginningOfNullString()
        {
            string transformed = Const.NullString.Remove(2, Const.SampleValue).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveValuesFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(2, Const.SampleValue).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveNullValuesFromBeginningOfEmptyString()
        {
            string transformed = String.Empty.Remove(2, null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveNullValuesFromEndOfEmptyString()
        {
            string transformed = String.Empty.Remove(2, null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveEmptyValuesFromBeginningOfEmptyString()
        {
            string transformed = String.Empty.Remove(2, String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyValuesFromEndOfEmptyString()
        {
            string transformed = String.Empty.Remove(2, String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveValuesFromBeginningOfEmptyString()
        {
            string transformed = String.Empty.Remove(2, Const.SampleValue).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveValuesFromEndOfEmptyString()
        {
            string transformed = String.Empty.Remove(2, Const.SampleValue).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveNullValuesFromBeginning()
        {
            string transformed = Const.SampleString.Remove(2, null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNullValuesFromEnd()
        {
            string transformed = Const.SampleString.Remove(2, null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveEmptyValuesFromBeginning()
        {
            string transformed = Const.SampleString.Remove(2, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveEmptyValuesFromEnd()
        {
            string transformed = Const.SampleString.Remove(2, String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNonExistingValuesFromBeginning()
        {
            string transformed = Const.SampleString.Remove(2, "smth").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNonExistingValuesFromEnd()
        {
            string transformed = Const.SampleString.Remove(2, "smth").From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNegativeQuantityValuesFromBeginning()
        {
            Action action = () => "TEST string will be removed".Remove(-1, "TEST").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveZeroValuesFromBeginning()
        {
            string transformed = "TEST string will be removed".Remove(0, "TEST").From(The.Beginning);
            transformed.Should().Be("TEST string will be removed");

            transformed = "TEST <- both strings will be removed -> TEST".Remove(0, "TEST").From(The.Beginning);
            transformed.Should().Be("TEST <- both strings will be removed -> TEST");
        }

        [Test]
        public void RemoveValuesFromBeginning()
        {
            string transformed = "TEST string will be removed".Remove(1, "TEST").From(The.Beginning);
            transformed.Should().Be(" string will be removed");

            transformed = "TEST <- both strings will be removed -> TEST".Remove(2, "TEST").From(The.Beginning);
            transformed.Should().Be(" <- both strings will be removed -> ");

            transformed = "Some additional string |TEST| string will be removed".Remove(1, "TEST").From(The.Beginning);
            transformed.Should().Be("Some additional string || string will be removed");
        }

        [Test]
        public void RemoveManyValuesFromBeginning()
        {
            string transformed = "TEST <- both strings will be removed -> TEST, but this TEST will be left".Remove(2, "TEST").From(The.Beginning);
            transformed.Should().Be(" <- both strings will be removed -> , but this TEST will be left");

            transformed = "these will be removed -> TEST, TEST, TEST, TEST and these will survive TEST, TEST, TEST".Remove(4, "TEST").From(The.Beginning);
            transformed.Should().Be("these will be removed -> , , ,  and these will survive TEST, TEST, TEST");
        }

        [Test]
        public void RemoveValuesCaseSensitiveFromBeginning()
        {
            string transformed = "teST string will be removed".Remove(1, "teST").From(The.Beginning);
            transformed.Should().Be(" string will be removed");

            transformed = "test <- string will be removed, not this -> test".Remove(1, "test").From(The.Beginning);
            transformed.Should().Be(" <- string will be removed, not this -> test");

            transformed = "Some additional TEST which will be ignored string |TeSt| string will be removed".Remove(1, "TeSt").From(The.Beginning);
            transformed.Should().Be("Some additional TEST which will be ignored string || string will be removed");
        }

        [Test]
        public void RemoveNegativeQuantityValuesFromEnd()
        {
            Action action = () => "TEST string will be removed".Remove(-1, "TEST").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveZeroValuesFromEnd()
        {
            string transformed = "string will be removed -> TEST".Remove(0, "TEST").From(The.End);
            transformed.Should().Be("string will be removed -> TEST");

            transformed = "TEST <- again both strings will be removed -> TEST".Remove(0, "TEST").From(The.End);
            transformed.Should().Be("TEST <- again both strings will be removed -> TEST");
        }

        [Test]
        public void RemoveValuesFromEnd()
        {
            string transformed = "string will be removed -> TEST".Remove(1, "TEST").From(The.End);
            transformed.Should().Be("string will be removed -> ");

            transformed = "TEST <- again both strings will be removed -> TEST".Remove(2, "TEST").From(The.End);
            transformed.Should().Be(" <- again both strings will be removed -> ");

            transformed = "string will be removed -> |TEST| some additional string".Remove(1, "TEST").From(The.End);
            transformed.Should().Be("string will be removed -> || some additional string");
        }

        [Test]
        public void RemoveManyValuesFromEnd()
        {
            string transformed = "this TEST will be left, but TEST <- both strings will be removed -> TEST".Remove(2, "TEST").From(The.End);
            transformed.Should().Be("this TEST will be left, but  <- both strings will be removed -> ");

            transformed = "these will survive TEST, TEST, TEST, but these will be removed -> TEST, TEST, TEST, TEST".Remove(4, "TEST").From(The.End);
            transformed.Should().Be("these will survive TEST, TEST, TEST, but these will be removed -> , , , ");
        }

        [Test]
        public void RemoveValuesCaseSensitiveFromEnd()
        {
            string transformed = "string will be removed -> TesT".Remove(1, "TesT").From(The.End);
            transformed.Should().Be("string will be removed -> ");

            transformed = "test <- this string will be left, but this will be removed -> test".Remove(1, "test").From(The.End);
            transformed.Should().Be("test <- this string will be left, but this will be removed -> ");

            transformed = "string will be removed -> |tEsT| some additional string".Remove(1, "tEsT").From(The.End);
            transformed.Should().Be("string will be removed -> || some additional string");
        }

        #endregion

        #region Remove Values Ignoring Case

        [Test]
        public void RemoveNullValuesIgnoringCaseFromNullString()
        {
            string transformed = Const.NullString.Remove(3, null).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyValuesIgnoringCaseFromNullString()
        {
            string transformed = Const.NullString.Remove(3, String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveValuesIgnoringCaseFromNullString()
        {
            string transformed = Const.NullString.Remove(3, Const.SampleValue).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveNullValuesIgnoringCaseFromEmptyString()
        {
            string transformed = String.Empty.Remove(3, null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveEmptyValuesIgnoringCaseFromEmptyString()
        {
            string transformed = String.Empty.Remove(3, String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveValuesIgnoringCaseFromEmptyString()
        {
            string transformed = String.Empty.Remove(3, Const.SampleValue).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveNullValuesIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(3, null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveEmptyValuesIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(3, String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNonExistingValuesIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(3, "smth").IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNegativeQuantityValuesIgnoringCase()
        {
            Action action = () => Const.SampleString.Remove(-1, "TEST").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveZeroValuesIgnoringCase()
        {
            string transformed = Const.SampleString.Remove(0, "TEST").IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveOneValueIgnoringCase()
        {
            string transformed = "TEST string will be removed".Remove(1, "TeSt").IgnoringCase();
            transformed.Should().Be(" string will be removed");

            transformed = "string will be removed ->tEST".Remove(1, "tEsT").IgnoringCase();
            transformed.Should().Be("string will be removed ->");

            transformed = "string will be removed ->TEST and this will be left TEST".Remove(1, "TEST").IgnoringCase();
            transformed.Should().Be("string will be removed -> and this will be left TEST");
        }

        [Test]
        public void RemoveTwoValuesIgnoringCase()
        {
            string transformed = "TesT string will be removed from both sides TEST".Remove(2, "TEST").IgnoringCase();
            transformed.Should().Be(" string will be removed from both sides ");
        }

        [Test]
        public void RemoveThreeValuesIgnoringCaseFromStringWithFourValues()
        {
            string transformed = "TEST only three TeSt strings will be removed from test string TesT".Remove(3, "TesT").IgnoringCase();
            transformed.Should().Be(" only three  strings will be removed from  string TesT");
        }

        #endregion

        #region Remove Values Ignoring Case From

        [Test]
        public void RemoveNullValuesIgnoringCaseFromBeginningOfNullString()
        {
            string transformed = Const.NullString.Remove(2, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveNullValuesIgnoringCaseFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(2, null).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyValuesIgnoringCaseFromBeginningOfNullString()
        {
            string transformed = Const.NullString.Remove(2, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyValuesIgnoringCaseFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(2, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveValuesIgnoringCaseFromBeginningOfNullString()
        {
            string transformed = Const.NullString.Remove(2, Const.SampleValue).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveValuesIgnoringCaseFromEndOfNullString()
        {
            string transformed = Const.NullString.Remove(2, Const.SampleValue).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveNullValuesIgnoringCaseFromBeginningOfEmptyString()
        {
            string transformed = String.Empty.Remove(2, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveNullValuesIgnoringCaseFromEndOfEmptyString()
        {
            string transformed = String.Empty.Remove(2, null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveEmptyValuesIgnoringCaseFromBeginningOfEmptyString()
        {
            string transformed = String.Empty.Remove(2, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveEmptyValuesIgnoringCaseFromEndOfEmptyString()
        {
            string transformed = String.Empty.Remove(2, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveValuesIgnoringCaseFromBeginningOfEmptyString()
        {
            string transformed = String.Empty.Remove(2, Const.SampleValue).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveValuesIgnoringCaseFromEndOfEmptyString()
        {
            string transformed = String.Empty.Remove(2, Const.SampleValue).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveNullValuesIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove(2, null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNullValuesIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove(2, null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveEmptyValuesIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove(2, String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveEmptyValuesIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove(2, String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNonExistingValuesIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove(2, "smth").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNonExistingValuesIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove(2, "smth").IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveNegativeQuantityValuesIgnoringCaseFromBeginning()
        {
            Action action = () => "TEST string will be removed".Remove(-1, "TEST").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveNegativeQuantityValuesIgnoringCaseFromEnd()
        {
            Action action = () => "TEST string will be removed".Remove(-1, "TEST").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveZeroValuesIgnoringCaseFromBeginning()
        {
            string transformed = "TEST string will be removed".Remove(0, "TEST").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("TEST string will be removed");

            transformed = "TEST <- both strings will be removed -> TEST".Remove(0, "TEST").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("TEST <- both strings will be removed -> TEST");
        }

        [Test]
        public void RemoveZeroValuesIgnoringCaseFromEnd()
        {
            string transformed = "string will be removed -> TEST".Remove(0, "TEST").IgnoringCase().From(The.End);
            transformed.Should().Be("string will be removed -> TEST");

            transformed = "TEST <- again both strings will be removed -> TEST".Remove(0, "TEST").IgnoringCase().From(The.End);
            transformed.Should().Be("TEST <- again both strings will be removed -> TEST");
        }

        [Test]
        public void RemoveOneValueIgnoringCaseFromBeginning()
        {
            string transformed = "TEST string will be removed".Remove(1, "TeSt").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" string will be removed");

            transformed = "string will be removed ->tEST".Remove(1, "tEsT").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("string will be removed ->");

            transformed = "string will be removed ->TEST and this will be left TEST".Remove(1, "TEST").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("string will be removed -> and this will be left TEST");
        }

        [Test]
        public void RemoveTwoValuesFromBeginningIgnoringCase()
        {
            string transformed = "TesT string will be removed from both sides TEST".Remove(2, "TEST").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" string will be removed from both sides ");
        }

        [Test]
        public void RemoveFiveValuesIgnoringCaseFromBeginningOfStringWithTwoValues()
        {
            string transformed = "TesT string will be removed from both sides TEST".Remove(5, "TEST").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(" string will be removed from both sides ");
        }

        [Test]
        public void RemoveValuesIgnoringCaseFromEnd()
        {
            string transformed = "string will be removed -> TEST".Remove(1, "tESt").IgnoringCase().From(The.End);
            transformed.Should().Be("string will be removed -> ");

            transformed = "TEST <- this string will be left, but this will be removed -> TEST".Remove(1, "test").IgnoringCase().From(The.End);
            transformed.Should().Be("TEST <- this string will be left, but this will be removed -> ");
        }

        [Test]
        public void RemoveTwoValuesIgnoringCaseFromEndOfStringWithOneValue()
        {
            string transformed = "string will be removed -> |TesT| some additional string".Remove(2, "TEST").IgnoringCase().From(The.End);
            transformed.Should().Be("string will be removed -> || some additional string");
        }

        #endregion

        #region Remove All

        [Test]
        public void RemoveAllNullValuesFromNullString()
        {
            string transformed = Const.NullString.RemoveAll(null);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveAllEmptyValuesFromNullString()
        {
            string transformed = Const.NullString.RemoveAll(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveAllValuesFromNullString()
        {
            string transformed = Const.NullString.RemoveAll(Const.SampleValue);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveAllNullValuesFromEmptyString()
        {
            string transformed = String.Empty.RemoveAll(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveAllEmptyValuesFromEmptyString()
        {
            string transformed = String.Empty.RemoveAll(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveAllValuesFromEmptyString()
        {
            string transformed = String.Empty.RemoveAll(Const.SampleValue);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveAllNullValues()
        {
            string transformed = Const.SampleString.RemoveAll(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveAllEmptyValues()
        {
            string transformed = Const.SampleString.RemoveAll(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveAllNonExistingValues()
        {
            string transformed = Const.SampleString.RemoveAll("smth");
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveAllValues()
        {
            string transformed = "TEST string will be removed".RemoveAll("TEST");
            transformed.Should().Be(" string will be removed");

            transformed = "TEST string will be removed from both sides TEST".RemoveAll("TEST");
            transformed.Should().Be(" string will be removed from both sides ");
        }

        [Test]
        public void RemoveAllValuesCaseSensitive()
        {
            string transformed = "TeSt string will be removed from both sides TeSt".RemoveAll("TeSt");
            transformed.Should().Be(" string will be removed from both sides ");

            transformed = "TEST string will NOT be removed from both sides TEST".RemoveAll("TeSt");
            transformed.Should().Be("TEST string will NOT be removed from both sides TEST");
        }

        #endregion

        #region Remove All Ignoring Case

        [Test]
        public void RemoveAllNullValuesIgnoringCaseFromNullString()
        {
            string transformed = Const.NullString.RemoveAll(null).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveAllEmptyValuesIgnoringCaseFromNullString()
        {
            string transformed = Const.NullString.RemoveAll(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveAllValuesIgnoringCaseFromNullString()
        {
            string transformed = Const.NullString.RemoveAll(Const.SampleValue).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveAllNullValuesIgnoringCaseFromEmptyString()
        {
            string transformed = String.Empty.RemoveAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveAllEmptyValuesIgnoringCaseFromEmptyString()
        {
            string transformed = String.Empty.RemoveAll(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveAllValuesIgnoringCaseFromEmptyString()
        {
            string transformed = String.Empty.RemoveAll(Const.SampleValue).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveAllNullValuesIgnoringCase()
        {
            string transformed = Const.SampleString.RemoveAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveAllEmptyValuesIgnoringCase()
        {
            string transformed = Const.SampleString.RemoveAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveAllNonExistingValuesIgnoringCase()
        {
            string transformed = Const.SampleString.RemoveAll("smth").IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveAllTextIgnoringCase()
        {
            string transformed = "TEST string will be removed".RemoveAll("TeSt").IgnoringCase();
            transformed.Should().Be(" string will be removed");

            transformed = "TEST string will be removed from both sides TEST".RemoveAll("tESt").IgnoringCase();
            transformed.Should().Be(" string will be removed from both sides ");

            transformed = "TEST string will be TEST removed from test the whole string TEST".RemoveAll("tESt").IgnoringCase();
            transformed.Should().Be(" string will be  removed from  the whole string ");
        }

        #endregion
    }
}
