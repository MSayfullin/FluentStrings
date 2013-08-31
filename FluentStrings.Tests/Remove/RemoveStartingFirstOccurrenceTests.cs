using System;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveStartingFirstOccurrenceTests
    {
        #region Remove Starting First Occurrence

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(null);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().Starting(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingFirstOccurrence()
        {
            string transformed = "Some very long string".Remove().Starting(" long");
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting("Some");
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting("string");
            transformed.Should().Be("Some very long ");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceCaseSensitive()
        {
            string transformed = "Some very long string".Remove().Starting("Long");
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting("very");
            transformed.Should().Be("Some ");
        }

        [Test]
        public void RemoveStartingFirstAbsentOccurrence()
        {
            string transformed = Const.SampleString.Remove().Starting(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove Starting First Occurrence From

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(" long").From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(" very").From(The.End);
            transformed.Should().Be("Some");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting("Some").From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting("Some").From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting("string").From(The.Beginning);
            transformed.Should().Be("Some very long ");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().Starting("string").From(The.End);
            transformed.Should().Be("Some very long ");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long string".Remove().Starting("Long").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long string".Remove().Starting("Long").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting("very").From(The.Beginning);
            transformed.Should().Be("Some ");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().Starting("very").From(The.End);
            transformed.Should().Be("Some very ");
        }

        [Test]
        public void RemoveStartingFirstAbsentOccurrenceFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingFirstAbsentOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove Starting First Occurrence Ignoring Case

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().Starting(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().Starting(" lOnG").IgnoringCase();
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().Starting("SOME").IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting("string").IgnoringCase();
            transformed.Should().Be("SOME VERY LONG ");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().Starting("very").IgnoringCase();
            transformed.Should().Be("Some ");
        }

        [Test]
        public void RemoveStartingFirstAbsentOccurrenceIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove Starting First Occurrence Ignoring Case From

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().Starting(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().Starting(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().Starting(" LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().Starting(" VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("Some");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().Starting("Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().Starting("Some").IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().Starting("StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long ");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().Starting("string").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very long ");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting("very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some ");
        }

        [Test]
        public void RemoveStartingFirstOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().Starting("very").IgnoringCase().From(The.End);
            transformed.Should().Be("Some VERY ");
        }

        [Test]
        public void RemoveStartingFirstAbsentOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingFirstAbsentOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion
    }
}
