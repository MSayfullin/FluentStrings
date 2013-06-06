using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveToOccurrenceTests
    {
        #region Remove To Occurrence

        [TestMethod]
        public void RemoveToOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().To(1, of: null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, of: String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, of: Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().To(3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().To(1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().To(1, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToNegativeOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().To(-1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToZeroOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().To(0, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToOccurrence()
        {
            string transformed = "Some very long long string".Remove().To(1, of: "long");
            transformed.Should().Be("long long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(1, of: "Some");
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().To(1, of: "string");
            transformed.Should().Be("string");
        }

        [TestMethod]
        public void RemoveToOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(2, of: "Long");
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(2, of: "very");
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(3, of: "very");
            transformed.Should().Be("very very long string at the end");
        }

        [TestMethod]
        public void RemoveToExceedingOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().To(5, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        #endregion

        #region Remove To Occurrence From

        [TestMethod]
        public void RemoveToOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(1, of: null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(3, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToNegativeOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(-1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToNegativeOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(-1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToZeroOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(0, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToZeroOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(0, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(1, of: "long").From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().To(1, of: "very").From(The.End);
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(1, of: "Some").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(1, of: "Some").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().To(1, of: "string").From(The.Beginning);
            transformed.Should().Be("string");
        }

        [TestMethod]
        public void RemoveToOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().To(1, of: "string").From(The.End);
            transformed.Should().Be("string");
        }

        [TestMethod]
        public void RemoveToOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(2, of: "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().To(2, of: "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(2, of: "very").From(The.Beginning);
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To(2, of: "very").From(The.End);
            transformed.Should().Be("very very long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(3, of: "very").From(The.Beginning);
            transformed.Should().Be("very very long string at the end");
        }

        [TestMethod]
        public void RemoveToOccurrenceFromEndHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().To(3, of: "very").From(The.End);
            transformed.Should().Be("very long string with very very long string at the end");
        }

        [TestMethod]
        public void RemoveToExceedingOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(5, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToExceedingOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(5, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        #endregion

        #region Remove To Occurrence Ignoring Case

        [TestMethod]
        public void RemoveToOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(1, of: null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().To(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(1, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToNegativeOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().To(-1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToZeroOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very very long string".Remove().To(0, of: "very").IgnoringCase();
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().To(1, of: "lOnG").IgnoringCase();
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().To(1, of: "SOME").IgnoringCase();
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(1, of: "string").IgnoringCase();
            transformed.Should().Be("STRING");
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().To(2, of: "VERY").IgnoringCase();
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with VERY very long string at the end".Remove().To(3, of: "vERy").IgnoringCase();
            transformed.Should().Be("VERY very long string at the end");
        }

        [TestMethod]
        public void RemoveToExceedingOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very VERY long string".Remove().To(5, of: "VerY").IgnoringCase();
            transformed.Should().Be("Some very VERY long string");
        }

        #endregion

        #region Remove To Occurrence Ignoring Case From

        [TestMethod]
        public void RemoveToOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToNegativeOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().To(-1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToNegativeOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().To(-1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToZeroOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very very long string".Remove().To(0, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToZeroOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very very long string".Remove().To(0, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().To(1, of: "LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().To(1, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To(1, of: "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("SOME VERY LONG STRING");
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().To(1, of: "Some").IgnoringCase().From(The.End);
            transformed.Should().Be("SOmE very long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().To(1, of: "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("sTRINg");
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().To(1, of: "string").IgnoringCase().From(The.End);
            transformed.Should().Be("STRING");
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(2, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("VERY long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To(2, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("VERY VERY long string");
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().To(3, of: "vERy").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("very VERY long string at the end");
        }

        [TestMethod]
        public void RemoveToOccurrenceIgnoringCaseFromEndHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().To(3, of: "vERy").IgnoringCase().From(The.End);
            transformed.Should().Be("VERY long string with very VERY long string at the end");
        }

        [TestMethod]
        public void RemoveToExceedingOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very VeRy long string".Remove().To(5, of: "VERY").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VeRy long string");
        }

        [TestMethod]
        public void RemoveToExceedingOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very VeRy long string".Remove().To(5, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very VeRy long string");
        }

        #endregion
    }
}
