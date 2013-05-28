using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveStartingOccurrenceTests
    {
        #region Remove Starting Occurrence

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(1, of: null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(2, of: String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(2, of: Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1, of: String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(2, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().Starting(1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(1, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingNegativeOccurrenceIndex()
        {
            Action action = () => "Some very very long string".Remove().Starting(-1, of: "very").ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingZeroOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().Starting(0, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingOccurrence()
        {
            string transformed = "Some very long long string".Remove().Starting(1, of: " long");
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(1, of: "Some");
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1, of: "string");
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(2, of: "Long");
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(2, of: "very");
            transformed.Should().Be("Some very ");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().Starting(3, of: "very");
            transformed.Should().Be("Some very very long string with ");
        }

        [TestMethod]
        public void RemoveStartingExceedingOccurrenceIndex()
        {
            string transformed = "Some very very long string".Remove().Starting(5, of: "very");
            transformed.Should().Be("Some very very long string");
        }

        #endregion

        #region Remove Starting Occurrence From

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(1, of: null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingNegativeOccurrenceIndexFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(-1, of: "very").From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingNegativeOccurrenceIndexFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(-1, of: "very").From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingZeroOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().Starting(0, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingZeroOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().Starting(0, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(1, of: " long").From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1, of: " very").From(The.End);
            transformed.Should().Be("Some");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(1, of: "Some").From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(1, of: "Some").From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1, of: "string").From(The.Beginning);
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1, of: "string").From(The.End);
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(2, of: "Long").From(The.Beginning);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long long string".Remove().Starting(2, of: "Long").From(The.End);
            transformed.Should().Be("Some very long long string");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(2, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very ");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting(2, of: "very").From(The.End);
            transformed.Should().Be("Some ");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().Starting(3, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string with ");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceFromEndHavingManyOccurrences()
        {
            string transformed = "Some very very long string with very very long string at the end".Remove().Starting(3, of: "very").From(The.End);
            transformed.Should().Be("Some very ");
        }

        [TestMethod]
        public void RemoveStartingExceedingOccurrenceIndexFromBeginning()
        {
            string transformed = "Some very very long string".Remove().Starting(5, of: "very").From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingExceedingOccurrenceIndexFromEnd()
        {
            string transformed = "Some very very long string".Remove().Starting(5, of: "very").From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        #endregion

        #region Remove Starting Occurrence Ignoring Case

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(1, of: null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().Starting(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(1, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingNegativeOccurrenceIndexIgnoringCase()
        {
            Action action = () => "Some very very long string".Remove().Starting(-1, of: "very").IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingZeroOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very very long string".Remove().Starting(0, of: "very").IgnoringCase();
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().Starting(1, of: " lOnG").IgnoringCase();
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(1, of: "SOME").IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(1, of: "string").IgnoringCase();
            transformed.Should().Be("SOME VERY LONG ");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().Starting(2, of: "VERY").IgnoringCase();
            transformed.Should().Be("Some vErY ");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with VERY very long string at the end".Remove().Starting(3, of: "vERy").IgnoringCase();
            transformed.Should().Be("Some very VERY long string with ");
        }

        [TestMethod]
        public void RemoveStartingExceedingOccurrenceIndexIgnoringCase()
        {
            string transformed = "Some very VERY long string".Remove().Starting(5, of: "VerY").IgnoringCase();
            transformed.Should().Be("Some very VERY long string");
        }

        #endregion

        #region Remove Starting Occurrence Ignoring Case From

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(1, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(1, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveStartingNegativeOccurrenceIndexIgnoringCaseFromBeginning()
        {
            Action action = () => "Some very very long string".Remove().Starting(-1, of: "very").IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingNegativeOccurrenceIndexIgnoringCaseFromEnd()
        {
            Action action = () => "Some very very long string".Remove().Starting(-1, of: "very").IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveStartingZeroOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very very long string".Remove().Starting(0, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingZeroOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very very long string".Remove().Starting(0, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very very long string");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(1, of: " LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(1, of: " VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting(1, of: "Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().Starting(1, of: "Some").IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().Starting(1, of: "StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().Starting(1, of: "string").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very long ");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(2, of: "very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some VERY ");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting(2, of: "very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some ");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseFromBeginningHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().Starting(3, of: "vERy").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VERY long string with ");
        }

        [TestMethod]
        public void RemoveStartingOccurrenceIgnoringCaseFromEndHavingManyOccurrences()
        {
            string transformed = "Some very VERY long string with very VERY long string at the end".Remove().Starting(3, of: "vERy").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very ");
        }

        [TestMethod]
        public void RemoveStartingExceedingOccurrenceIndexIgnoringCaseFromBeginning()
        {
            string transformed = "Some very VeRy long string".Remove().Starting(5, of: "VERY").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very VeRy long string");
        }

        [TestMethod]
        public void RemoveStartingExceedingOccurrenceIndexIgnoringCaseFromEnd()
        {
            string transformed = "Some very VeRy long string".Remove().Starting(5, of: "VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very VeRy long string");
        }

        #endregion
    }
}
