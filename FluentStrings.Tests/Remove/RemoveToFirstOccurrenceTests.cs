using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class RemoveToFirstOccurrenceTests
    {
        #region Remove To First Occurrence

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullInNullString()
        {
            string transformed = Const.NullString.Remove().To(null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerInNullString()
        {
            string transformed = Const.NullString.Remove().To(String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceInNullString()
        {
            string transformed = Const.NullString.Remove().To(Const.SampleMarker);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullInEmptyString()
        {
            string transformed = String.Empty.Remove().To(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerInEmptyString()
        {
            string transformed = String.Empty.Remove().To(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceInEmptyString()
        {
            string transformed = String.Empty.Remove().To(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNull()
        {
            string transformed = Const.SampleString.Remove().To(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Remove().To(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrence()
        {
            string transformed = "Some very long string".Remove().To("long");
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceAtBeginning()
        {
            string transformed = "Some very long string".Remove().To("Some");
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceAtEnd()
        {
            string transformed = "Some very long string".Remove().To("string");
            transformed.Should().Be("string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceCaseSensitive()
        {
            string transformed = "Some very long string".Remove().To("Long");
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To("very");
            transformed.Should().Be("very very long string");
        }

        [TestMethod]
        public void RemoveToFirstAbsentOccurrence()
        {
            string transformed = Const.SampleString.Remove().To(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove To First Occurrence From

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromStartOf()
        {
            Action action = () => Const.SampleString.Remove().To(Const.SampleMarker).From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromEndOf()
        {
            Action action = () => Const.SampleString.Remove().To(Const.SampleMarker).From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromBeginning()
        {
            string transformed = "Some very long string".Remove().To("long").From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromEnd()
        {
            string transformed = "Some very long string".Remove().To("very").From(The.End);
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromBeginningAtBeginning()
        {
            string transformed = "Some very long string".Remove().To("Some").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromEndAtBeginning()
        {
            string transformed = "Some very long string".Remove().To("Some").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromBeginningAtEnd()
        {
            string transformed = "Some very long string".Remove().To("string").From(The.Beginning);
            transformed.Should().Be("string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromEndAtEnd()
        {
            string transformed = "Some very long string".Remove().To("string").From(The.End);
            transformed.Should().Be("string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "Some very long string".Remove().To("Long").From(The.Beginning);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromEndCaseSensitive()
        {
            string transformed = "Some very long string".Remove().To("Long").From(The.End);
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To("very").From(The.Beginning);
            transformed.Should().Be("very very long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceFromEndHavingTwoOccurrences()
        {
            string transformed = "Some very very long string".Remove().To("very").From(The.End);
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToFirstAbsentOccurrenceFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstAbsentOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove To First Occurrence Ignoring Case

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(null).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseInNullString()
        {
            string transformed = Const.NullString.Remove().To(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseInEmptyString()
        {
            string transformed = String.Empty.Remove().To(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceInEmptyStringIgnoringCase()
        {
            string transformed = String.Empty.Remove().To(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCase()
        {
            string transformed = "Some very long string".Remove().To("lOnG").IgnoringCase();
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseAtBeginning()
        {
            string transformed = "Some very long string".Remove().To("SOME").IgnoringCase();
            transformed.Should().Be("Some very long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseAtEnd()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To("string").IgnoringCase();
            transformed.Should().Be("STRING");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseHavingTwoOccurrences()
        {
            string transformed = "Some vErY very long string".Remove().To("very").IgnoringCase();
            transformed.Should().Be("vErY very long string");
        }

        [TestMethod]
        public void RemoveToFirstAbsentOccurrenceIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().To(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion

        #region Remove To First Occurrence Ignoring Case From

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseFromBeginningInNullString()
        {
            string transformed = Const.NullString.Remove().To(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseFromEndInNullString()
        {
            string transformed = Const.NullString.Remove().To(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseFromBeginningInEmptyString()
        {
            string transformed = String.Empty.Remove().To(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseFromEndInEmptyString()
        {
            string transformed = String.Empty.Remove().To(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfNullIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseFromStartOf()
        {
            Action action = () => Const.SampleString.Remove().To(Const.SampleMarker).IgnoringCase().From(The.StartOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseFromEndOf()
        {
            Action action = () => Const.SampleString.Remove().To(Const.SampleMarker).IgnoringCase().From(The.EndOf).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string".Remove().To("LoNg").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string".Remove().To("VERY").IgnoringCase().From(The.End);
            transformed.Should().Be("very long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseFromBeginningAtBeginning()
        {
            string transformed = "SOME VERY LONG STRING".Remove().To("Some").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("SOME VERY LONG STRING");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseFromEndAtBeginning()
        {
            string transformed = "SOmE very long string".Remove().To("Some").IgnoringCase().From(The.End);
            transformed.Should().Be("SOmE very long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseFromBeginningAtEnd()
        {
            string transformed = "Some very long sTRINg".Remove().To("StrinG").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("sTRINg");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseFromEndAtEnd()
        {
            string transformed = "Some very long STRING".Remove().To("string").IgnoringCase().From(The.End);
            transformed.Should().Be("STRING");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseFromBeginningHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To("very").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("VERY VERY long string");
        }

        [TestMethod]
        public void RemoveToFirstOccurrenceIgnoringCaseFromEndHavingTwoOccurrences()
        {
            string transformed = "Some VERY VERY long string".Remove().To("very").IgnoringCase().From(The.End);
            transformed.Should().Be("VERY long string");
        }

        [TestMethod]
        public void RemoveToFirstAbsentOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().To(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void RemoveToFirstAbsentOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().To(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        #endregion
    }
}
