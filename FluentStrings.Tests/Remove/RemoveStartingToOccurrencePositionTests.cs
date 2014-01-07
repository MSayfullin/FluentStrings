using System;
using System.Collections;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveStartingToOccurrencePositionTests
    {
        #region Remove Starting To Occurrence Position

        private class RemoveStartingToOccurrencePositionDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, The.StartOf, null).Returns(null),
                new TestCaseData(null, The.EndOf, null).Returns(null),
                new TestCaseData(null, The.StartOf, String.Empty).Returns(null),
                new TestCaseData(null, The.EndOf, String.Empty).Returns(null),
                new TestCaseData(null, The.StartOf, Const.SampleMarker).Returns(null),
                new TestCaseData(null, The.EndOf, Const.SampleMarker).Returns(null),
                new TestCaseData(String.Empty, The.StartOf, null).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, null).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, String.Empty).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, String.Empty).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, Const.SampleMarker).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, Const.SampleMarker).Returns(String.Empty),
                new TestCaseData(Const.SampleString, The.StartOf, null).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, null).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, String.Empty).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, String.Empty).Returns(Const.SampleString),
                new TestCaseData("Some string", The.StartOf, Const.SampleMarker).Returns("Som"),
                new TestCaseData("Some string", The.EndOf, Const.SampleMarker).Returns("Som"),
                new TestCaseData(Const.SampleString, The.Beginning, String.Empty).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.End, String.Empty).Throws(typeof(ArgumentOutOfRangeException))
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingToOccurrencePositionDataCases))]
        public string RemoveStartingToOccurrencePositionExtremeCases(string source, The toPosition, string toMarker)
        {
            return source.Remove().Starting(position: 3).To(toPosition, 1, of: toMarker);
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionToOccurrencePositionOfMarker()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).To(The.StartOf, 2, Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterToNegativeOccurrencePositionOfMarker()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).To(The.EndOf, -2, Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthToOccurrencePositionOfMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(250).To(The.StartOf, 2, Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterToZeroOccurrencePositionOfMarker()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).To(The.StartOf, 0, "marker");
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterToOccurrencePositionOfMarker()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).To(The.StartOf, 1, "marker");
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).To(The.EndOf, 3, "mark");
            transformed.Should().Be("Some able words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).To(The.StartOf, 2, "marker");
            transformed.Should().Be("Some very marker");
        }

        #endregion

        #region Remove Starting To Occurrence Position From

        private class RemoveStartingToOccurrencePositionFromDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, The.StartOf, null, The.Beginning).Returns(null),
                new TestCaseData(null, The.EndOf, null, The.Beginning).Returns(null),
                new TestCaseData(null, The.StartOf, null, The.End).Returns(null),
                new TestCaseData(null, The.EndOf, null, The.End).Returns(null),
                new TestCaseData(null, The.StartOf, String.Empty, The.Beginning).Returns(null),
                new TestCaseData(null, The.EndOf, String.Empty, The.Beginning).Returns(null),
                new TestCaseData(null, The.StartOf, String.Empty, The.End).Returns(null),
                new TestCaseData(null, The.EndOf, String.Empty, The.End).Returns(null),
                new TestCaseData(null, The.StartOf, Const.SampleMarker, The.Beginning).Returns(null),
                new TestCaseData(null, The.EndOf, Const.SampleMarker, The.Beginning).Returns(null),
                new TestCaseData(null, The.StartOf, Const.SampleMarker, The.End).Returns(null),
                new TestCaseData(null, The.EndOf, Const.SampleMarker, The.End).Returns(null),
                new TestCaseData(String.Empty, The.StartOf, null, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, null, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, null, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, null, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, String.Empty, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, String.Empty, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, String.Empty, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, String.Empty, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, Const.SampleMarker, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, Const.SampleMarker, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, Const.SampleMarker, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, Const.SampleMarker, The.End).Returns(String.Empty),
                new TestCaseData(Const.SampleString, The.StartOf, null, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, null, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, null, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, null, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, String.Empty, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, String.Empty, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, String.Empty, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, String.Empty, The.End).Returns(Const.SampleString),
                new TestCaseData("Some string", The.StartOf, Const.SampleMarker, The.Beginning).Returns("Som"),
                new TestCaseData("Some string", The.EndOf, Const.SampleMarker, The.Beginning).Returns("Som"),
                new TestCaseData("Some string", The.StartOf, Const.SampleMarker, The.End).Returns("Som"),
                new TestCaseData("Some string", The.EndOf, Const.SampleMarker, The.End).Returns("Som"),
                new TestCaseData(Const.SampleString, The.Beginning, Const.SampleMarker, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.End, Const.SampleMarker, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, Const.SampleMarker, The.StartOf).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.EndOf, Const.SampleMarker, The.EndOf).Throws(typeof(ArgumentOutOfRangeException))
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingToOccurrencePositionFromDataCases))]
        public string RemoveStartingToOccurrencePositionFromExtremeCases(string source, The toPosition, string toMarker, The toFrom)
        {
            return source.Remove().Starting(position: 3).To(toPosition, 1, of: toMarker).From(toFrom);
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionToOccurrencePositionOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).To(The.EndOf, 2, Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionToOccurrencePositionOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).To(The.StartOf, 2, Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterToNegativeOccurrencePositionOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).To(The.StartOf, -2, Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterToNegativeOccurrencePositionOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).To(The.EndOf, -2, Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthToOccurrencePositionOfMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(250).To(The.StartOf, 2, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthToOccurrencePositionOfMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(250).To(The.StartOf, 2, Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterToZeroOccurrencePositionOfMarkerFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).To(The.StartOf, 0, "marker").From(The.Beginning);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterToZeroOccurrencePositionOfMarkerFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).To(The.EndOf, 0, "marker").From(The.End);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterToOccurrencePositionOfMarkerFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).To(The.StartOf, 1, "marker").From(The.Beginning);
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).To(The.EndOf, 3, "mark").From(The.Beginning);
            transformed.Should().Be("Some able words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).To(The.StartOf, 2, "marker").From(The.Beginning);
            transformed.Should().Be("Some very marker");
        }

        [Test]
        public void RemoveStartingCharacterToOccurrencePositionOfMarkerFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).To(The.StartOf, 1, "marker").From(The.End);
            transformed.Should().Be("marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).To(The.EndOf, 3, "mark").From(The.End);
            transformed.Should().Be("Some er and markers and markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).To(The.EndOf, 1, "marker").From(The.End);
            transformed.Should().Be("Some very ");
        }

        #endregion

        #region Remove Starting To Occurrence Position Ignoring Case

        [TestCaseSource(typeof(RemoveStartingToOccurrencePositionDataCases))]
        public string RemoveStartingToOccurrencePositionIgnoringCaseExtremeCases(string source, The toPosition, string toMarker)
        {
            return source.Remove().Starting(position: 3).To(toPosition, 3, of: toMarker).IgnoringCase();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionToOccurrencePositionOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).To(The.StartOf, 2, Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterToNegativeOccurrencePositionOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).To(The.StartOf, -2, Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthToOccurrencePositionOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(250).To(The.EndOf, 2, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterToZeroOccurrencePositionOfMarkerIgnoringCase()
        {
            string transformed = "Some very long string with marker and another MARKER".Remove().Starting(1).To(The.StartOf, 0, "marker").IgnoringCase();
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterToOccurrencePositionOfMarkerIgnoringCase()
        {
            string transformed = "Some very long string with maRKer and another marker".Remove().Starting(0).To(The.StartOf, 1, "MARker").IgnoringCase();
            transformed.Should().Be("maRKer and another marker");

            transformed = "Some very long string with mARKer and marKERs and Markable words".Remove().Starting(5).To(The.EndOf, 3, "mARk").IgnoringCase();
            transformed.Should().Be("Some able words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).To(The.StartOf, 2, "MARKER").IgnoringCase();
            transformed.Should().Be("Some very marker");
        }

        #endregion

        #region Remove Starting To Occurrence Position Ignoring Case From

        [TestCaseSource(typeof(RemoveStartingToOccurrencePositionFromDataCases))]
        public string RemoveStartingToOccurrencePositionIgnoringCaseFromExtremeCases(string source, The toPosition, string toMarker, The toFrom)
        {
            return source.Remove().Starting(position: 3).To(toPosition, 2, of: toMarker).IgnoringCase().From(toFrom);
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionToOccurrencePositionOfMarkerIgnoringCaseFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).To(The.StartOf, 2, Const.SampleMarker).IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionToOccurrencePositionOfMarkerIgnoringCaseFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).To(The.StartOf, 2, Const.SampleMarker).IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterToNegativeOccurrencePositionOfMarkerIgnoringCaseFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).To(The.EndOf, -2, Const.SampleMarker).IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterToNegativeOccurrencePositionOfMarkerIgnoringCaseFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).To(The.EndOf, -2, Const.SampleMarker).IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthToOccurrencePositionOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(250).To(The.StartOf, 2, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthToOccurrencePositionOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(250).To(The.EndOf, 2, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterToZeroOccurrencePositionOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string with marker and another MARKER".Remove().Starting(1).To(The.EndOf, 0, "marker").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterToZeroOccurrencePositionOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string with marker and another MARKER".Remove().Starting(1).To(The.StartOf, 0, "marker").IgnoringCase().From(The.End);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterToOccurrencePositionOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string with maRKer and another marker".Remove().Starting(0).To(The.StartOf, 1, "MARker").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("maRKer and another marker");

            transformed = "Some very long string with mARKer and marKERs and Markable words".Remove().Starting(5).To(The.EndOf, 3, "mARk").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some able words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).To(The.StartOf, 2, "MARKER").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very marker");
        }

        [Test]
        public void RemoveStartingCharacterToOccurrencePositionOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string with maRKer and another marker".Remove().Starting(0).To(The.StartOf, 1, "MARker").IgnoringCase().From(The.End);
            transformed.Should().Be("marker");

            transformed = "Some very long string with mARKer and marKERs and Markable words".Remove().Starting(5).To(The.EndOf, 3, "mARk").IgnoringCase().From(The.End);
            transformed.Should().Be("Some er and marKERs and Markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).To(The.StartOf, 2, "MARKER").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very marker' long string with marker");
        }

        #endregion

        #region Remove Starting From To Occurrence Position

        private class RemoveStartingFromToOccurrencePositionDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, The.Beginning, The.StartOf, null).Returns(null),
                new TestCaseData(null, The.Beginning, The.EndOf, null).Returns(null),
                new TestCaseData(null, The.End, The.StartOf, null).Returns(null),
                new TestCaseData(null, The.End, The.EndOf, null).Returns(null),
                new TestCaseData(null, The.Beginning, The.StartOf, String.Empty).Returns(null),
                new TestCaseData(null, The.Beginning, The.EndOf, String.Empty).Returns(null),
                new TestCaseData(null, The.End, The.StartOf, String.Empty).Returns(null),
                new TestCaseData(null, The.End, The.EndOf, String.Empty).Returns(null),
                new TestCaseData(null, The.Beginning, The.StartOf, Const.SampleMarker).Returns(null),
                new TestCaseData(null, The.Beginning, The.EndOf, Const.SampleMarker).Returns(null),
                new TestCaseData(null, The.End, The.StartOf, Const.SampleMarker).Returns(null),
                new TestCaseData(null, The.End, The.EndOf, Const.SampleMarker).Returns(null),
                new TestCaseData(String.Empty, The.Beginning, The.StartOf, null).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.EndOf, null).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.StartOf, null).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.EndOf, null).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.StartOf, String.Empty).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.EndOf, String.Empty).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.StartOf, String.Empty).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.EndOf, String.Empty).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.StartOf, Const.SampleMarker).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.EndOf, Const.SampleMarker).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.StartOf, Const.SampleMarker).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.EndOf, Const.SampleMarker).Returns(String.Empty),
                new TestCaseData(Const.SampleString, The.Beginning, The.StartOf, null).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.Beginning, The.EndOf, null).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, The.StartOf, null).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, The.EndOf, null).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.Beginning, The.StartOf, String.Empty).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.Beginning, The.EndOf, String.Empty).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, The.StartOf, String.Empty).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, The.EndOf, String.Empty).Returns(Const.SampleString),
                new TestCaseData("Some string", The.Beginning, The.StartOf, Const.SampleMarker).Returns("So"),
                new TestCaseData("Some string", The.Beginning, The.EndOf, Const.SampleMarker).Returns("So"),
                new TestCaseData("Some string", The.End, The.StartOf, Const.SampleMarker).Returns("ng"),
                new TestCaseData("Some string", The.End, The.EndOf, Const.SampleMarker).Returns("ng"),
                new TestCaseData(Const.SampleString, The.End, The.Beginning, String.Empty).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.Beginning, The.End, String.Empty).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.EndOf, The.Beginning, String.Empty).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, The.End, String.Empty).Throws(typeof(ArgumentOutOfRangeException))
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingFromToOccurrencePositionDataCases))]
        public string RemoveStartingFromToOccurrencePositionExtremeCases(string source, The startingFrom, The toPosition, string toMarker)
        {
            return source.Remove().Starting(position: 2).From(startingFrom).To(toPosition, 1, of: toMarker);
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromBeginningToOccurrencePositionOfMarker()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.Beginning).To(The.StartOf, 2, Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromEndToOccurrencePositionOfMarker()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.End).To(The.EndOf, 2, Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToNegativeOccurrencePositionOfMarker()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.Beginning).To(The.StartOf, -2, Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromEndToNegativeOccurrencePositionOfMarker()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.End).To(The.StartOf, -2, Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromBeginningToOccurrencePositionOfMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.Beginning).To(The.EndOf, 2, Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromEndToOccurrencePositionOfMarker()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.End).To(The.StartOf, 2, Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToZeroOccurrencePositionOfMarker()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.Beginning).To(The.StartOf, 0, "marker");
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToZeroOccurrencePositionOfMarker()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.End).To(The.EndOf, 0, "marker");
            transformed.Should().Be("r");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToOccurrencePositionOfMarker()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.Beginning).To(The.StartOf, 1, "marker");
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.Beginning).To(The.EndOf, 3, "mark");
            transformed.Should().Be("Some able words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.Beginning).To(The.StartOf, 2, "marker");
            transformed.Should().Be("Some very marker");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToOccurrencePositionOfMarker()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.End).To(The.StartOf, 1, "marker");
            transformed.Should().Be("Some very long string with ");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.End).To(The.StartOf, 3, "mark");
            transformed.Should().Be("Some very long string with marker and markers and words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.End).To(The.StartOf, 2, "marker");
            transformed.Should().Be("Some very 'marker' long string marker");
        }

        #endregion

        #region Remove Starting From To Occurrence Position From

        private class RemoveStartingFromToOccurrencePositionFromDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, The.Beginning, The.StartOf, null, The.Beginning).Returns(null),
                new TestCaseData(null, The.Beginning, The.EndOf, null, The.Beginning).Returns(null),
                new TestCaseData(null, The.Beginning, The.StartOf, null, The.End).Returns(null),
                new TestCaseData(null, The.Beginning, The.EndOf, null, The.End).Returns(null),
                new TestCaseData(null, The.End, The.StartOf, null, The.Beginning).Returns(null),
                new TestCaseData(null, The.End, The.EndOf, null, The.Beginning).Returns(null),
                new TestCaseData(null, The.End, The.StartOf, null, The.End).Returns(null),
                new TestCaseData(null, The.End, The.EndOf, null, The.End).Returns(null),
                new TestCaseData(null, The.Beginning, The.StartOf, String.Empty, The.Beginning).Returns(null),
                new TestCaseData(null, The.Beginning, The.EndOf, String.Empty, The.Beginning).Returns(null),
                new TestCaseData(null, The.Beginning, The.StartOf, String.Empty, The.End).Returns(null),
                new TestCaseData(null, The.Beginning, The.EndOf, String.Empty, The.End).Returns(null),
                new TestCaseData(null, The.End, The.StartOf, String.Empty, The.Beginning).Returns(null),
                new TestCaseData(null, The.End, The.EndOf, String.Empty, The.Beginning).Returns(null),
                new TestCaseData(null, The.End, The.StartOf, String.Empty, The.End).Returns(null),
                new TestCaseData(null, The.End, The.EndOf, String.Empty, The.End).Returns(null),
                new TestCaseData(null, The.Beginning, The.StartOf, Const.SampleMarker, The.Beginning).Returns(null),
                new TestCaseData(null, The.Beginning, The.EndOf, Const.SampleMarker, The.Beginning).Returns(null),
                new TestCaseData(null, The.Beginning, The.StartOf, Const.SampleMarker, The.End).Returns(null),
                new TestCaseData(null, The.Beginning, The.EndOf, Const.SampleMarker, The.End).Returns(null),
                new TestCaseData(null, The.End, The.StartOf, Const.SampleMarker, The.Beginning).Returns(null),
                new TestCaseData(null, The.End, The.EndOf, Const.SampleMarker, The.Beginning).Returns(null),
                new TestCaseData(null, The.End, The.StartOf, Const.SampleMarker, The.End).Returns(null),
                new TestCaseData(null, The.End, The.EndOf, Const.SampleMarker, The.End).Returns(null),
                new TestCaseData(String.Empty, The.Beginning, The.StartOf, null, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.EndOf, null, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.StartOf, null, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.EndOf, null, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.StartOf, null, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.EndOf, null, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.StartOf, null, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.EndOf, null, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.StartOf, String.Empty, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.EndOf, String.Empty, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.StartOf, String.Empty, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.EndOf, String.Empty, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.StartOf, String.Empty, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.EndOf, String.Empty, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.StartOf, String.Empty, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.EndOf, String.Empty, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.StartOf, Const.SampleMarker, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.EndOf, Const.SampleMarker, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.StartOf, Const.SampleMarker, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.Beginning, The.EndOf, Const.SampleMarker, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.StartOf, Const.SampleMarker, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.EndOf, Const.SampleMarker, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.StartOf, Const.SampleMarker, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.End, The.EndOf, Const.SampleMarker, The.End).Returns(String.Empty),
                new TestCaseData(Const.SampleString, The.Beginning, The.StartOf, null, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.Beginning, The.EndOf, null, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.Beginning, The.StartOf, null, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.Beginning, The.EndOf, null, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, The.StartOf, null, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, The.EndOf, null, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, The.StartOf, null, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, The.EndOf, null, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.Beginning, The.StartOf, String.Empty, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.Beginning, The.EndOf, String.Empty, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.Beginning, The.StartOf, String.Empty, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.Beginning, The.EndOf, String.Empty, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, The.StartOf, String.Empty, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, The.EndOf, String.Empty, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, The.StartOf, String.Empty, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.End, The.EndOf, String.Empty, The.End).Returns(Const.SampleString),
                new TestCaseData("Some string", The.Beginning, The.StartOf, Const.SampleMarker, The.Beginning).Returns("So"),
                new TestCaseData("Some string", The.Beginning, The.EndOf, Const.SampleMarker, The.Beginning).Returns("So"),
                new TestCaseData("Some string", The.Beginning, The.StartOf, Const.SampleMarker, The.End).Returns("So"),
                new TestCaseData("Some string", The.Beginning, The.EndOf, Const.SampleMarker, The.End).Returns("So"),
                new TestCaseData("Some string", The.End, The.StartOf, Const.SampleMarker, The.Beginning).Returns("ng"),
                new TestCaseData("Some string", The.End, The.EndOf, Const.SampleMarker, The.Beginning).Returns("ng"),
                new TestCaseData("Some string", The.End, The.StartOf, Const.SampleMarker, The.End).Returns("ng"),
                new TestCaseData("Some string", The.End, The.EndOf, Const.SampleMarker, The.End).Returns("ng"),
                new TestCaseData(Const.SampleString, The.EndOf, The.StartOf, Const.SampleMarker, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, The.EndOf, Const.SampleMarker, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.End, The.Beginning, Const.SampleMarker, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.Beginning, The.End, Const.SampleMarker, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.End, The.EndOf, Const.SampleMarker, The.EndOf).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.Beginning, The.StartOf, Const.SampleMarker, The.StartOf).Throws(typeof(ArgumentOutOfRangeException))
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingFromToOccurrencePositionFromDataCases))]
        public string RemoveStartingFromToOccurrencePositionFromExtremeCases(string source, The startingFrom, The toPosition, string toMarker, The toFrom)
        {
            return source.Remove().Starting(position: 2).From(startingFrom).To(toPosition, 3, of: toMarker).From(toFrom);
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromBeginningToOccurrencePositionOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.Beginning).To(The.StartOf, 2, Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromBeginningToOccurrencePositionOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.Beginning).To(The.EndOf, 2, Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromEndToOccurrencePositionOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.End).To(The.StartOf, 2, Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromEndToOccurrencePositionOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.End).To(The.StartOf, 2, Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToNegativeOccurrencePositionOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.Beginning).To(The.EndOf, -2, Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToNegativeOccurrencePositionOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.Beginning).To(The.StartOf, -2, Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromEndToNegativeOccurrencePositionOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.End).To(The.EndOf, -2, Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromEndToNegativeOccurrencePositionOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.End).To(The.StartOf, -2, Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromBeginningToOccurrencePositionOfMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.Beginning).To(The.EndOf, 2, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromBeginningToOccurrencePositionOfMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.Beginning).To(The.StartOf, 2, Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromEndToOccurrencePositionOfMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.End).To(The.EndOf, 2, Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromEndToOccurrencePositionOfMarkerFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.End).To(The.EndOf, 2, Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToZeroOccurrencePositionOfMarkerFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.Beginning).To(The.EndOf, 0, "marker").From(The.Beginning);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToZeroOccurrencePositionOfMarkerFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.Beginning).To(The.StartOf, 0, "marker").From(The.End);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToZeroOccurrencePositionOfMarkerFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.End).To(The.EndOf, 0, "marker").From(The.Beginning);
            transformed.Should().Be("r");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToZeroOccurrencePositionOfMarkerFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.End).To(The.StartOf, 0, "marker").From(The.End);
            transformed.Should().Be("r");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToOccurrencePositionOfMarkerFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.Beginning).To(The.StartOf, 1, "marker").From(The.Beginning);
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.Beginning).To(The.EndOf, 3, "mark").From(The.Beginning);
            transformed.Should().Be("Some able words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.Beginning).To(The.StartOf, 2, "marker").From(The.Beginning);
            transformed.Should().Be("Some very marker");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToOccurrencePositionOfMarkerFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.Beginning).To(The.StartOf, 1, "marker").From(The.End);
            transformed.Should().Be("marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.Beginning).To(The.EndOf, 3, "mark").From(The.End);
            transformed.Should().Be("Some er and markers and markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.Beginning).To(The.StartOf, 2, "marker").From(The.End);
            transformed.Should().Be("Some very marker' long string with marker");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToOccurrencePositionOfMarkerFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.End).To(The.StartOf, 1, "marker").From(The.Beginning);
            transformed.Should().Be("Some very long string with ");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.End).To(The.StartOf, 3, "mark").From(The.Beginning);
            transformed.Should().Be("Some very long string with marker and markers and words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.End).To(The.StartOf, 2, "marker").From(The.Beginning);
            transformed.Should().Be("Some very 'marker' long string marker");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToOccurrencePositionOfMarkerFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.End).To(The.StartOf, 1, "marker").From(The.End);
            transformed.Should().Be("Some very long string with marker and another ");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.End).To(The.EndOf, 3, "mark").From(The.End);
            transformed.Should().Be("Some very long string with markwords");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.End).To(The.StartOf, 2, "marker").From(The.End);
            transformed.Should().Be("Some very 'ith marker");
        }

        #endregion

        #region Remove Starting From To Occurrence Position Ignoring Case

        [TestCaseSource(typeof(RemoveStartingFromToOccurrencePositionDataCases))]
        public string RemoveStartingFromToOccurrencePositionIgnoringCaseExtremeCases(string source, The startingFrom, The toPosition, string toMarker)
        {
            return source.Remove().Starting(position: 2).From(startingFrom).To(toPosition, 1, of: toMarker).IgnoringCase();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromBeginningToOccurrencePositionOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.Beginning).To(The.StartOf, 2, Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromEndToOccurrencePositionOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.End).To(The.EndOf, 2, Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToNegativeOccurrencePositionOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.Beginning).To(The.StartOf, -2, Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromEndToNegativeOccurrencePositionOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.End).To(The.EndOf, -2, Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromBeginningToOccurrencePositionOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.Beginning).To(The.EndOf, 2, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromEndToOccurrencePositionOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.End).To(The.StartOf, 2, Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToZeroOccurrencePositionOfMarkerIgnoringCase()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.Beginning).To(The.EndOf, 0, "MARKER").IgnoringCase();
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToZeroOccurrencePositionOfMarkerIgnoringCase()
        {
            string transformed = "Some very long string with MARKER and another marker".Remove().Starting(1).From(The.End).To(The.StartOf, 0, "marker").IgnoringCase();
            transformed.Should().Be("r");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToOccurrencePositionOfMarkerIgnoringCase()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.Beginning).To(The.StartOf, 1, "mARKEr").IgnoringCase();
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.Beginning).To(The.EndOf, 3, "MArk").IgnoringCase();
            transformed.Should().Be("Some able words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.Beginning).To(The.StartOf, 2, "MaRkEr").IgnoringCase();
            transformed.Should().Be("Some very marker");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToOccurrencePositionOfMarkerIgnoringCase()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.End).To(The.StartOf, 1, "mArKeR").IgnoringCase();
            transformed.Should().Be("Some very long string with ");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.End).To(The.EndOf, 3, "MARK").IgnoringCase();
            transformed.Should().Be("Some very long string with marker and markers and markwords");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.End).To(The.StartOf, 2, "MARker").IgnoringCase();
            transformed.Should().Be("Some very 'marker' long string marker");
        }

        #endregion

        #region Remove Starting From To Occurrence Position Ignoring Case From

        [TestCaseSource(typeof(RemoveStartingFromToOccurrencePositionFromDataCases))]
        public string RemoveStartingFromToOccurrencePositionIgnoringCaseFromExtremeCases(string source, The startingFrom, The toPosition, string toMarker, The toFrom)
        {
            return source.Remove().Starting(position: 2).From(startingFrom).To(toPosition, 2, of: toMarker).IgnoringCase().From(toFrom);
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromBeginningToOccurrencePositionOfMarkerIgnoringCaseFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.Beginning).To(The.StartOf, 2, Const.SampleMarker).IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromBeginningToOccurrencePositionOfMarkerIgnoringCaseFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.Beginning).To(The.EndOf, 2, Const.SampleMarker).IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromEndToOccurrencePositionOfMarkerIgnoringCaseFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.End).To(The.StartOf, 2, Const.SampleMarker).IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingNegativeCharacterPositionFromEndToOccurrencePositionOfMarkerIgnoringCaseFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(-4).From(The.End).To(The.StartOf, 2, Const.SampleMarker).IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToNegativeOccurrencePositionOfMarkerIgnoringCaseFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.Beginning).To(The.EndOf, -2, Const.SampleMarker).IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToNegativeOccurrencePositionOfMarkerIgnoringCaseFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.Beginning).To(The.StartOf, -2, Const.SampleMarker).IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromEndToNegativeOccurrencePositionOfMarkerIgnoringCaseFromBeginning()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.End).To(The.EndOf, -2, Const.SampleMarker).IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterFromEndToNegativeOccurrencePositionOfMarkerIgnoringCaseFromEnd()
        {
            Action action = () => Const.SampleString.Remove().Starting(3).From(The.End).To(The.EndOf, -2, Const.SampleMarker).IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromBeginningToOccurrencePositionOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.Beginning).To(The.StartOf, 2, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromBeginningToOccurrencePositionOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.Beginning).To(The.EndOf, 2, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromEndToOccurrencePositionOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.End).To(The.StartOf, 2, Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterExceedingLengthFromEndToOccurrencePositionOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Remove().Starting(250).From(The.End).To(The.StartOf, 2, Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToZeroOccurrencePositionOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.Beginning).To(The.EndOf, 0, "maRKer").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToZeroOccurrencePositionOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.Beginning).To(The.StartOf, 0, "mArKeR").IgnoringCase().From(The.End);
            transformed.Should().Be("S");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToZeroOccurrencePositionOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.End).To(The.EndOf, 0, "mUrKEr").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("r");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToZeroOccurrencePositionOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(1).From(The.End).To(The.EndOf, 0, "marker").IgnoringCase().From(The.End);
            transformed.Should().Be("r");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToOccurrencePositionOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.Beginning).To(The.StartOf, 1, "mARKer").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("marker and another marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.Beginning).To(The.EndOf, 3, "MARK").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some able words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.Beginning).To(The.StartOf, 2, "markER").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very marker");
        }

        [Test]
        public void RemoveStartingCharacterFromBeginningToOccurrencePositionOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.Beginning).To(The.StartOf, 1, "marKEr").IgnoringCase().From(The.End);
            transformed.Should().Be("marker");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.Beginning).To(The.EndOf, 3, "mARk").IgnoringCase().From(The.End);
            transformed.Should().Be("Some er and markers and markable words");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.Beginning).To(The.StartOf, 2, "MArkER").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very marker' long string with marker");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToOccurrencePositionOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.End).To(The.StartOf, 1, "maRKer").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long string with ");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.End).To(The.EndOf, 3, "mARK").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very long string with marker and markers and markwords");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.End).To(The.StartOf, 2, "MARKER").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some very 'marker' long string marker");
        }

        [Test]
        public void RemoveStartingCharacterFromEndToOccurrencePositionOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = "Some very long string with marker and another marker".Remove().Starting(0).From(The.End).To(The.StartOf, 1, "MARKER").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very long string with marker and another ");

            transformed = "Some very long string with marker and markers and markable words".Remove().Starting(5).From(The.End).To(The.EndOf, 3, "maRk").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very long string with markwords");

            transformed = "Some very 'marker' long string with marker".Remove().Starting(10).From(The.End).To(The.StartOf, 2, "maRKer").IgnoringCase().From(The.End);
            transformed.Should().Be("Some very 'ith marker");
        }

        #endregion
    }
}
