using System;
using System.Collections;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveStartingToOccurrenceTests
    {
        #region Remove Starting To Occurrence

        private class RemoveStartingToOccurrenceDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, null).Returns(null),
                new TestCaseData(null, String.Empty).Returns(null),
                new TestCaseData(null, Const.SampleMarker).Returns(null),
                new TestCaseData(String.Empty, null).Returns(String.Empty),
                new TestCaseData(String.Empty, String.Empty).Returns(String.Empty),
                new TestCaseData(String.Empty, Const.SampleMarker).Returns(String.Empty),
                new TestCaseData(Const.SampleString, null).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, String.Empty).Returns(Const.SampleString),
                new TestCaseData("Some string", Const.SampleMarker).Returns("So").SetDescription("Remove to absent marker")
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingToOccurrenceDataCases))]
        public string RemoveStartingToOccurrenceExtremeCases(string source, string toMarker)
        {
            return source.Remove().Starting(position: 2).To(1, of: toMarker);
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionToOccurrenceOfMarker()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).To(2, Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterToNegativeOccurrenceOfMarker()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).To(-2, Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthToOccurrenceOfMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(250).To(2, Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterToZeroOccurrenceOfMarker()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).To(0, "marker");
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfMarker()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).To(1, "marker");
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).To(3, "mark");
            transformed.Should().Be("Some markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).To(2, "marker");
            transformed.Should().Be("Some very marker");
        }

        #endregion

        #region Remove Starting To Occurrence From

        private class RemoveStartingToOccurrenceFromDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, null, The.Beginning).Returns(null),
                new TestCaseData(null, null, The.End).Returns(null),
                new TestCaseData(null, String.Empty, The.Beginning).Returns(null),
                new TestCaseData(null, String.Empty, The.End).Returns(null),
                new TestCaseData(null, Const.SampleMarker, The.Beginning).Returns(null),
                new TestCaseData(null, Const.SampleMarker, The.End).Returns(null),
                new TestCaseData(String.Empty, null, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, null, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, String.Empty, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, String.Empty, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, Const.SampleMarker, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, Const.SampleMarker, The.End).Returns(String.Empty),
                new TestCaseData(Const.SampleString, null, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, null, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, String.Empty, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, String.Empty, The.End).Returns(Const.SampleString),
                new TestCaseData("Some string", Const.SampleMarker, The.Beginning).Returns("Som").SetDescription("Remove to absent marker from the beginning"),
                new TestCaseData("Some string", Const.SampleMarker, The.End).Returns("Som").SetDescription("Remove to absent marker from the end"),
                new TestCaseData(Const.SampleString, Const.SampleMarker, The.StartOf).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, Const.SampleMarker, The.EndOf).Throws(typeof(ArgumentOutOfRangeException))
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingToOccurrenceFromDataCases))]
        public string RemoveStartingToOccurrenceFromExtremeCases(string source, string toMarker, The toFrom)
        {
            return source.Remove().Starting(position: 3).To(2, of: toMarker).From(toFrom);
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionToOccurrenceOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).To(2, Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionToOccurrenceOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).To(2, Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterToNegativeOccurrenceOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).To(-2, Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterToNegativeOccurrenceOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).To(-2, Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthToOccurrenceOfMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(250).To(2, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthToOccurrenceOfMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(250).To(2, Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterToZeroOccurrenceOfMarkerFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).To(0, "marker").From(The.Beginning);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterToZeroOccurrenceOfMarkerFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).To(0, "marker").From(The.End);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfMarkerFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).To(1, "marker").From(The.Beginning);
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).To(3, "mark").From(The.Beginning);
            transformed.Should().Be("Some markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).To(2, "marker").From(The.Beginning);
            transformed.Should().Be("Some very marker");
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfMarkerFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).To(1, "marker").From(The.End);
            transformed.Should().Be("marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).To(3, "mark").From(The.End);
            transformed.Should().Be("Some marker and markers and markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).To(1, "marker").From(The.End);
            transformed.Should().Be("Some very marker");
        }

        #endregion

        #region Remove Starting To Occurrence Ignoring Case

        [TestCaseSource(typeof(RemoveStartingToOccurrenceDataCases))]
        public string RemoveStartingToOccurrenceIgnoringCaseExtremeCases(string source, string toMarker)
        {
            return source.Remove().Starting(position: 2).To(1, of: toMarker).IgnoringCase();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionToOccurrenceOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).To(2, Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterToNegativeOccurrenceOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).To(-2, Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthToOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(250).To(2, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterToZeroOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = "Some very long string with marker and another MARKER".Remove().Starting(1).To(0, "marker").IgnoringCase();
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = "Some very long string with maRKer and another marker".Remove().Starting(0).To(1, "MARker").IgnoringCase();
            transformed.Should().Be("maRKer and another marker");

            transformed = "Some very long string with mARKer and marKERs and Markable words".Remove().Starting(5).To(3, "mARk").IgnoringCase();
            transformed.Should().Be("Some Markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).To(2, "MARKER").IgnoringCase();
            transformed.Should().Be("Some very marker");
        }

        #endregion

        #region Remove Starting To Occurrence Ignoring Case From

        [TestCaseSource(typeof(RemoveStartingToOccurrenceFromDataCases))]
        public string RemoveStartingToOccurrenceIgnoringCaseFromExtremeCases(string source, string toMarker, The toFrom)
        {
            return source.Remove().Starting(position: 3).To(2, of: toMarker).IgnoringCase().From(toFrom);
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionToOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).To(2, Const.SampleMarker).IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionToOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).To(2, Const.SampleMarker).IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterToNegativeOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).To(-2, Const.SampleMarker).IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterToNegativeOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).To(-2, Const.SampleMarker).IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthToOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(250).To(2, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthToOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(250).To(2, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterToZeroOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string with marker and another MARKER".Remove().Starting(1).To(0, "marker").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterToZeroOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string with marker and another MARKER".Remove().Starting(1).To(0, "marker").IgnoringCase().From(The.End);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string with maRKer and another marker".Remove().Starting(0).To(1, "MARker").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("maRKer and another marker");

            transformed = "Some very long string with mARKer and marKERs and Markable words".Remove().Starting(5).To(3, "mARk").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some Markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).To(2, "MARKER").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very marker");
        }

        [Test]
        public void RemoveStartingCharacterToOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string with maRKer and another marker".Remove().Starting(0).To(1, "MARker").IgnoringCase().From(The.End);
            transformed.Should().Be("marker");

            transformed = "Some very long string with mARKer and marKERs and Markable words".Remove().Starting(5).To(3, "mARk").IgnoringCase().From(The.End);
            transformed.Should().Be("Some mARKer and marKERs and Markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).To(2, "MARKER").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very marker' long string with marker");
        }

        #endregion

        #region Remove Starting From To Occurrence

        private class RemoveStartingFromToOccurrenceDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, The.Beginning, null).Returns(null),
                new TestCaseData(null, The.End, null).Returns(null),
                new TestCaseData(null, The.Beginning, String.Empty).Returns(null),
                new TestCaseData(null, The.End, String.Empty).Returns(null),
                new TestCaseData(null, The.Beginning, Const.SampleMarker).Returns(null),
                new TestCaseData(null, The.End, Const.SampleMarker).Returns(null),
                new TestCaseData(String.Empty, The.Beginning, null).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, null).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, String.Empty).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, String.Empty).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, Const.SampleMarker).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, Const.SampleMarker).Returns(String.Empty),
                new TestCaseData(Const.SampleString, The.Beginning, null).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, null).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.Beginning, String.Empty).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, String.Empty).Returns(Const.SampleString),
                new TestCaseData("Some string", The.Beginning, Const.SampleMarker).Returns("Som"),
                new TestCaseData("Some string", The.End, Const.SampleMarker).Returns("ing")
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingFromToOccurrenceDataCases))]
        public string RemoveStartingFromToOccurrenceExtremeCases(string source, The startingFrom, string toMarker)
        {
            return source.Remove().Starting(position: 3).From(startingFrom).To(3, of: toMarker);
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromBeginningToOccurrenceOfMarker()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.Beginning).To(2, Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromEndToOccurrenceOfMarker()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.End).To(2, Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToNegativeOccurrenceOfMarker()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.Beginning).To(-2, Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromEndToNegativeOccurrenceOfMarker()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.End).To(-2, Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromBeginningToOccurrenceOfMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.Beginning).To(2, Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromEndToOccurrenceOfMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.End).To(2, Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToZeroOccurrenceOfMarker()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.Beginning).To(0, "marker");
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToZeroOccurrenceOfMarker()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.End).To(0, "marker");
            transformed.Should().Be("r");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToOccurrenceOfMarker()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.Beginning).To(1, "marker");
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.Beginning).To(3, "mark");
            transformed.Should().Be("Some markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.Beginning).To(2, "marker");
            transformed.Should().Be("Some very marker");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToOccurrenceOfMarker()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.End).To(1, "marker");
            transformed.Should().Be("Some very long string with ");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.End).To(3, "mark");
            transformed.Should().Be("Some very long string with marker and markers and words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.End).To(2, "marker");
            transformed.Should().Be("Some very 'marker' long string marker");
        }

        #endregion

        #region Remove Starting From To Occurrence From

        private class RemoveStartingFromToOccurrenceFromDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, The.Beginning, null, The.Beginning).Returns(null),
                new TestCaseData(null, The.Beginning, null, The.End).Returns(null),
                new TestCaseData(null, The.End, null, The.Beginning).Returns(null),
                new TestCaseData(null, The.End, null, The.End).Returns(null),
                new TestCaseData(null, The.Beginning, String.Empty, The.Beginning).Returns(null),
                new TestCaseData(null, The.Beginning, String.Empty, The.End).Returns(null),
                new TestCaseData(null, The.End, String.Empty, The.Beginning).Returns(null),
                new TestCaseData(null, The.End, String.Empty, The.End).Returns(null),
                new TestCaseData(null, The.Beginning, Const.SampleMarker, The.Beginning).Returns(null),
                new TestCaseData(null, The.Beginning, Const.SampleMarker, The.End).Returns(null),
                new TestCaseData(null, The.End, Const.SampleMarker, The.Beginning).Returns(null),
                new TestCaseData(null, The.End, Const.SampleMarker, The.End).Returns(null),
                new TestCaseData(String.Empty, The.Beginning, null, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, null, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, null, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, null, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, String.Empty, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, String.Empty, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, String.Empty, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, String.Empty, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, Const.SampleMarker, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, Const.SampleMarker, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, Const.SampleMarker, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, Const.SampleMarker, The.End).Returns(String.Empty),
                new TestCaseData(Const.SampleString, The.Beginning, null, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.Beginning, null, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, null, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, null, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.Beginning, String.Empty, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.Beginning, String.Empty, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, String.Empty, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, String.Empty, The.End).Returns(Const.SampleString),
                new TestCaseData("Some string", The.Beginning, Const.SampleMarker, The.Beginning).Returns("Som"),
                new TestCaseData("Some string", The.Beginning, Const.SampleMarker, The.End).Returns("Som"),
                new TestCaseData("Some string", The.End, Const.SampleMarker, The.Beginning).Returns("ing"),
                new TestCaseData("Some string", The.End, Const.SampleMarker, The.End).Returns("ing")
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingFromToOccurrenceFromDataCases))]
        public string RemoveStartingFromToOccurrenceFromExtremeCases(string source, The startingFrom, string toMarker, The toFrom)
        {
            return source.Remove().Starting(position: 3).From(startingFrom).To(2, of: toMarker).From(toFrom);
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromBeginningToOccurrenceOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.Beginning).To(2, Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromBeginningToOccurrenceOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.Beginning).To(2, Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromEndToOccurrenceOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.End).To(2, Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromEndToOccurrenceOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.End).To(2, Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToNegativeOccurrenceOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.Beginning).To(-2, Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToNegativeOccurrenceOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.Beginning).To(-2, Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromEndToNegativeOccurrenceOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.End).To(-2, Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromEndToNegativeOccurrenceOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.End).To(-2, Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromBeginningToOccurrenceOfMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.Beginning).To(2, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromBeginningToOccurrenceOfMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.Beginning).To(2, Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromEndToOccurrenceOfMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.End).To(2, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromEndToOccurrenceOfMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.End).To(2, Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToZeroOccurrenceOfMarkerFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.Beginning).To(0, "marker").From(The.Beginning);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToZeroOccurrenceOfMarkerFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.Beginning).To(0, "marker").From(The.End);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToZeroOccurrenceOfMarkerFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.End).To(0, "marker").From(The.Beginning);
            transformed.Should().Be("r");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToZeroOccurrenceOfMarkerFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.End).To(0, "marker").From(The.End);
            transformed.Should().Be("r");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToOccurrenceOfMarkerFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.Beginning).To(1, "marker").From(The.Beginning);
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.Beginning).To(3, "mark").From(The.Beginning);
            transformed.Should().Be("Some markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.Beginning).To(2, "marker").From(The.Beginning);
            transformed.Should().Be("Some very marker");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToOccurrenceOfMarkerFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.Beginning).To(1, "marker").From(The.End);
            transformed.Should().Be("marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.Beginning).To(3, "mark").From(The.End);
            transformed.Should().Be("Some marker and markers and markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.Beginning).To(2, "marker").From(The.End);
            transformed.Should().Be("Some very marker' long string with marker");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToOccurrenceOfMarkerFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.End).To(1, "marker").From(The.Beginning);
            transformed.Should().Be("Some very long string with ");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.End).To(3, "mark").From(The.Beginning);
            transformed.Should().Be("Some very long string with marker and markers and words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.End).To(2, "marker").From(The.Beginning);
            transformed.Should().Be("Some very 'marker' long string marker");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToOccurrenceOfMarkerFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.End).To(1, "marker").From(The.End);
            transformed.Should().Be("Some very long string with marker and another ");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.End).To(3, "mark").From(The.End);
            transformed.Should().Be("Some very long string with words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.End).To(2, "marker").From(The.End);
            transformed.Should().Be("Some very 'ith marker");
        }

        #endregion

        #region Remove Starting From To Occurrence Ignoring Case

        [TestCaseSource(typeof(RemoveStartingFromToOccurrenceDataCases))]
        public string RemoveStartingFromToOccurrenceIgnoringCaseExtremeCases(string source, The startingFrom, string toMarker)
        {
            return source.Remove().Starting(position: 3).From(startingFrom).To(1, of: toMarker).IgnoringCase();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromBeginningToOccurrenceOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.Beginning).To(2, Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromEndToOccurrenceOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.End).To(2, Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToNegativeOccurrenceOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.Beginning).To(-2, Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromEndToNegativeOccurrenceOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.End).To(-2, Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromBeginningToOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.Beginning).To(2, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromEndToOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.End).To(2, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToZeroOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.Beginning).To(0, "MARKER").IgnoringCase();
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToZeroOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = "Some very long string with MARKER and another marker".Remove().Starting(1).From(The.End).To(0, "marker").IgnoringCase();
            transformed.Should().Be("r");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.Beginning).To(1, "mARKEr").IgnoringCase();
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.Beginning).To(3, "MArk").IgnoringCase();
            transformed.Should().Be("Some markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.Beginning).To(2, "MaRkEr").IgnoringCase();
            transformed.Should().Be("Some very marker");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.End).To(1, "mArKeR").IgnoringCase();
            transformed.Should().Be("Some very long string with ");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.End).To(3, "MARK").IgnoringCase();
            transformed.Should().Be("Some very long string with marker and markers and words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.End).To(2, "MARker").IgnoringCase();
            transformed.Should().Be("Some very 'marker' long string marker");
        }

        #endregion

        #region Remove Starting From To Occurrence Ignoring Case From

        [TestCaseSource(typeof(RemoveStartingFromToOccurrenceFromDataCases))]
        public string RemoveStartingFromToOccurrenceIgnoringCaseFromExtremeCases(string source, The startingFrom, string toMarker, The toFrom)
        {
            return source.Remove().Starting(position: 3).From(startingFrom).To(2, of: toMarker).IgnoringCase().From(toFrom);
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromBeginningToOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.Beginning).To(2, Const.SampleMarker).IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromBeginningToOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.Beginning).To(2, Const.SampleMarker).IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromEndToOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.End).To(2, Const.SampleMarker).IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromEndToOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.End).To(2, Const.SampleMarker).IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToNegativeOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.Beginning).To(-2, Const.SampleMarker).IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToNegativeOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.Beginning).To(-2, Const.SampleMarker).IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromEndToNegativeOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.End).To(-2, Const.SampleMarker).IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromEndToNegativeOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.End).To(-2, Const.SampleMarker).IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromBeginningToOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.Beginning).To(2, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromBeginningToOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.Beginning).To(2, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromEndToOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.End).To(2, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromEndToOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.End).To(2, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToZeroOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.Beginning).To(0, "maRKer").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToZeroOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.Beginning).To(0, "mArKeR").IgnoringCase().From(The.End);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToZeroOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.End).To(0, "mUrKEr").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("r");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToZeroOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.End).To(0, "marker").IgnoringCase().From(The.End);
            transformed.Should().Be("r");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.Beginning).To(1, "mARKer").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.Beginning).To(3, "MARK").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.Beginning).To(2, "markER").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very marker");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.Beginning).To(1, "marKEr").IgnoringCase().From(The.End);
            transformed.Should().Be("marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.Beginning).To(3, "mARk").IgnoringCase().From(The.End);
            transformed.Should().Be("Some marker and markers and markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.Beginning).To(2, "MArkER").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very marker' long string with marker");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.End).To(1, "maRKer").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long string with ");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.End).To(3, "mARK").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long string with marker and markers and words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.End).To(2, "MARKER").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very 'marker' long string marker");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.End).To(1, "MARKER").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very long string with marker and another ");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.End).To(3, "maRk").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very long string with words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.End).To(2, "maRKer").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very 'ith marker");
        }

        #endregion
    }
}
