using System;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveToFirstOccurrenceTests
    {
        #region Remove To First Occurrence

        [Test]
        public void RemoveToFirstOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().To(null);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().To(String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().To(Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().To(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().To(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().To(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().To(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstOccurrence()
        {
            string transformed = "Some very long string".Remove().To("long");
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().To("Some");
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().To("string");
            transformed.Should().Be("string");
        }

        [Test]
        public void RemoveToFirstOccurrenceCaseSensitive()
        {
            string transformed = "Some very long string".Remove().To("Long");
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To("very");
            transformed.Should().Be("very very long string");
        }

        [Test]
        public void RemoveToFirstAbsentOccurrence()
        {
            string transformed = Const.SampleString.Remove().To(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove To First Occurrence From

        [Test]
        public void RemoveToFirstOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstOccurrenceFromStartOf()
        {
            Action action = () => Const.SampleString.Remove().To(Const.SampleMarker).From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToFirstOccurrenceFromEndOf()
        {
            Action action = () => Const.SampleString.Remove().To(Const.SampleMarker).From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToFirstOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().To("long").From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().To("very").From(The.End);
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().To("Some").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().To("Some").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().To("string").From(The.Beginning);
            transformed.Should().Be("string");
        }

        [Test]
        public void RemoveToFirstOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().To("string").From(The.End);
            transformed.Should().Be("string");
        }

        [Test]
        public void RemoveToFirstOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long string".Remove().To("Long").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long string".Remove().To("Long").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To("very").From(The.Beginning);
            transformed.Should().Be("very very long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To("very").From(The.End);
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToFirstAbsentOccurrenceFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstAbsentOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove To First Occurrence Ignoring Case

        [Test]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().To(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().To("lOnG").IgnoringCase();
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().To("SOME").IgnoringCase();
            transformed.Should().Be("Some very long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To("string").IgnoringCase();
            transformed.Should().Be("STRING");
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().To("very").IgnoringCase();
            transformed.Should().Be("vErY very long string");
        }

        [Test]
        public void RemoveToFirstAbsentOccurrenceIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove To First Occurrence Ignoring Case From

        [Test]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseFromStartOf()
        {
            Action action = () => Const.SampleString.Remove().To(Const.SampleMarker).IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseFromEndOf()
        {
            Action action = () => Const.SampleString.Remove().To(Const.SampleMarker).IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().To("LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().To("VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("very long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To("Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("SOME VERY LONG STRING");
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().To("Some").IgnoringCase().From(The.End);
            transformed.Should().Be("SOmE very long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().To("StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("sTRINg");
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().To("string").IgnoringCase().From(The.End);
            transformed.Should().Be("STRING");
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To("very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("VERY VERY long string");
        }

        [Test]
        public void RemoveToFirstOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To("very").IgnoringCase().From(The.End);
            transformed.Should().Be("VERY long string");
        }

        [Test]
        public void RemoveToFirstAbsentOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveToFirstAbsentOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion
    }
}
