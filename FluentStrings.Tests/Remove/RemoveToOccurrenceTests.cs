using System;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveToOccurrenceTests
    {
        #region Remove To Occurrence

        [Test]
        public void RemoveToOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().To(1, of: null);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, of: String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, of: Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().To(3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().To(1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().To(1, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToNegativeOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().To(-1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToZeroOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().To(0, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToOccurrence()
        {
            string transformed = "Some very long long string".Remove().To(1, of: "long");
            transformed.Should().Be("long long string");
        }

        [Test]
        public void RemoveToOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(1, of: "Some");
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().To(1, of: "string");
            transformed.Should().Be("string");
        }

        [Test]
        public void RemoveToOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(2, of: "Long");
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveToOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(2, of: "very");
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToOccurrenceHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(3, of: "very");
            transformed.Should().Be("very very long string at the end");
        }

        [Test]
        public void RemoveToExceedingOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().To(5, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        #endregion

        #region Remove To Occurrence From

        [Test]
        public void RemoveToOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(1, of: null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(3, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToNegativeOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(-1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToNegativeOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(-1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToZeroOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(0, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToZeroOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(0, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(1, of: "long").From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveToOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().To(1, of: "very").From(The.End);
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(1, of: "Some").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(1, of: "Some").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().To(1, of: "string").From(The.Beginning);
            transformed.Should().Be("string");
        }

        [Test]
        public void RemoveToOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().To(1, of: "string").From(The.End);
            transformed.Should().Be("string");
        }

        [Test]
        public void RemoveToOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(2, of: "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveToOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(2, of: "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [Test]
        public void RemoveToOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(2, of: "very").From(The.Beginning);
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(2, of: "very").From(The.End);
            transformed.Should().Be("very very long string");
        }

        [Test]
        public void RemoveToOccurrenceFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(3, of: "very").From(The.Beginning);
            transformed.Should().Be("very very long string at the end");
        }

        [Test]
        public void RemoveToOccurrenceFromEndHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(3, of: "very").From(The.End);
            transformed.Should().Be("very long string with very very long string at the end");
        }

        [Test]
        public void RemoveToExceedingOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(5, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToExceedingOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(5, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        #endregion

        #region Remove To Occurrence Ignoring Case

        [Test]
        public void RemoveToOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(1, of: null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().To(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(1, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToNegativeOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().To(-1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToZeroOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very very long string".Remove().To(0, of: "very").IgnoringCase();
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().To(1, of: "lOnG").IgnoringCase();
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(1, of: "SOME").IgnoringCase();
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(1, of: "string").IgnoringCase();
            transformed.Should().Be("STRING");
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().To(2, of: "VERY").IgnoringCase();
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with VERY very long string at the end".Remove().To(3, of: "vERy").IgnoringCase();
            transformed.Should().Be("VERY very long string at the end");
        }

        [Test]
        public void RemoveToExceedingOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very VERY long string".Remove().To(5, of: "VerY").IgnoringCase();
            transformed.Should().Be("Some very VERY long string");
        }

        #endregion

        #region Remove To Occurrence Ignoring Case From

        [Test]
        public void RemoveToOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToNegativeOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(-1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToNegativeOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(-1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToZeroOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(0, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToZeroOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(0, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(1, of: "LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().To(1, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(1, of: "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("SOME VERY LONG STRING");
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().To(1, of: "Some").IgnoringCase().From(The.End);
            transformed.Should().Be("SOmE very long string");
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().To(1, of: "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("sTRINg");
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().To(1, of: "string").IgnoringCase().From(The.End);
            transformed.Should().Be("STRING");
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(2, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("VERY long string");
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(2, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("VERY VERY long string");
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().To(3, of: "vERy").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("very VERY long string at the end");
        }

        [Test]
        public void RemoveToOccurrenceIgnoringCaseFromEndHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().To(3, of: "vERy").IgnoringCase().From(The.End);
            transformed.Should().Be("VERY long string with very VERY long string at the end");
        }

        [Test]
        public void RemoveToExceedingOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very VeRy long string".Remove().To(5, of: "VERY").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VeRy long string");
        }

        [Test]
        public void RemoveToExceedingOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very VeRy long string".Remove().To(5, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very VeRy long string");
        }

        #endregion
    }
}
