using System;
using System.Collections;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveStartingOccurrenceToTests
    {
        #region Remove Starting Occurrence To

        private class RemoveStartingOccurrenceToDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, 2, null, 1).Returns(null),
                new TestCaseData(null, 2, String.Empty, 2).Returns(null),
                new TestCaseData(null, 3, Const.SampleMarker, 2).Returns(null),
                new TestCaseData(String.Empty, 2, null, 2).Returns(String.Empty),
                new TestCaseData(String.Empty, 2, String.Empty, 4).Returns(String.Empty),
                new TestCaseData(String.Empty, 1, Const.SampleMarker, 2).Returns(String.Empty),
                new TestCaseData(Const.SampleString, 2, null, 2).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, 1, String.Empty, 2).Returns(Const.SampleString),
                new TestCaseData("Some string", 3, Const.SampleMarker, 2).Returns("me string"),
                new TestCaseData("Some string", 0, "string", 2).Returns("me string"),
                new TestCaseData("Some string", 1, "string", 250).Returns("Some "),
                new TestCaseData("Some string", 10, "string", 250).Returns(String.Empty),
                new TestCaseData("Some string", 10, "string", 9).Returns("ng"),
                new TestCaseData(Const.SampleString, -1, Const.SampleString, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, Const.SampleString, -2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, String.Empty, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, String.Empty, -2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData("Some string", 1, "string", 3).Returns("Somestring"),
                new TestCaseData("Some string with many strings", 2, "string", 22).Returns("Some string with many strings"),
                new TestCaseData("Some string with many strings", 1, "string", 12).Returns("Some with many strings")
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingOccurrenceToDataCases))]
        public string RemoveStartingOccurrenceToExtremeCases(string source, int occurrence, string startingMarker, int positionIndex)
        {
            return source.Remove().Starting(occurrence, of: startingMarker).To(positionIndex);
        }

        #endregion

        #region Remove Starting Occurrence To From

        private class RemoveStartingOccurrenceToFromDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, 2, null, 4, The.Beginning).Returns(null),
                new TestCaseData(null, 2, null, 2, The.End).Returns(null),
                new TestCaseData(null, 2, String.Empty, 4, The.Beginning).Returns(null),
                new TestCaseData(null, 2, String.Empty, 4, The.End).Returns(null),
                new TestCaseData(null, 2, Const.SampleMarker, 4, The.Beginning).Returns(null),
                new TestCaseData(null, 2, Const.SampleMarker, 4, The.End).Returns(null),
                new TestCaseData(String.Empty, 3, null, 4, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, 3, null, 2, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, 3, String.Empty, 1, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, 3, String.Empty, 4, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, 3, Const.SampleMarker, 1, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, 3, Const.SampleMarker, 4, The.End).Returns(String.Empty),
                new TestCaseData(Const.SampleString, 1, null, 4, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, 1, null, 4, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, 1, String.Empty, 4, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, 1, String.Empty, 4, The.End).Returns(Const.SampleString),
                new TestCaseData("Some string", 3, Const.SampleMarker, 7, The.Beginning).Returns("ring"),
                new TestCaseData("Some string", 3, Const.SampleMarker, 7, The.End).Returns("Some"),
                new TestCaseData("Some string", 0, "string", 2, The.Beginning).Returns("me string"),
                new TestCaseData("Some string", 0, "string", 2, The.End).Returns("Some stri"),
                new TestCaseData("Some string", 1, "string", 250, The.Beginning).Returns("Some "),
                new TestCaseData("Some string", 1, "string", 250, The.End).Returns("string"),
                new TestCaseData("Some string", 10, "string", 250, The.Beginning).Returns(String.Empty),
                new TestCaseData("Some string", 10, "string", 250, The.End).Returns(String.Empty),
                new TestCaseData("Some string", 10, "string", 9, The.Beginning).Returns("ng"),
                new TestCaseData("Some string", 10, "string", 9, The.End).Returns("So"),
                new TestCaseData(Const.SampleString, 5, Const.SampleMarker, 4, The.StartOf).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 5, Const.SampleMarker, 4, The.EndOf).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, Const.SampleString, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, Const.SampleString, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, Const.SampleString, -2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, Const.SampleString, -2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, String.Empty, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, String.Empty, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, String.Empty, -2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, String.Empty, -2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData("Some string", 1, "string", 3, The.Beginning).Returns("Somestring"),
                new TestCaseData("Some string", 1, "string", 7, The.End).Returns("Somestring"),
                new TestCaseData("Some string with many strings", 2, "string", 22, The.Beginning).Returns("Some string with many strings"),
                new TestCaseData("Some string with many strings", 1, "string", 12, The.Beginning).Returns("Some with many strings"),
                new TestCaseData("Some string with many strings", 1, "string", 16, The.End).Returns("Some with many strings")
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingOccurrenceToFromDataCases))]
        public string RemoveStartingOccurrenceToFromExtremeCases(string source, int occurrence, string startingMarker, int positionIndex, The toFrom)
        {
            return source.Remove().Starting(occurrence, of: startingMarker).To(positionIndex).From(toFrom);
        }

        #endregion

        #region Remove Starting Occurrence From To

        private class RemoveStartingOccurrenceFromToDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, 2, null, The.Beginning, 4).Returns(null),
                new TestCaseData(null, 2, null, The.End, 3).Returns(null),
                new TestCaseData(null, 2, String.Empty, The.Beginning, 3).Returns(null),
                new TestCaseData(null, 2, String.Empty, The.End, 3).Returns(null),
                new TestCaseData(null, 2, Const.SampleMarker, The.Beginning, 3).Returns(null),
                new TestCaseData(null, 2, Const.SampleMarker, The.End, 3).Returns(null),
                new TestCaseData(String.Empty, 4, null, The.Beginning, 3).Returns(String.Empty),
                new TestCaseData(String.Empty, 4, null, The.End, 3).Returns(String.Empty),
                new TestCaseData(String.Empty, 4, String.Empty, The.Beginning, 3).Returns(String.Empty),
                new TestCaseData(String.Empty, 4, String.Empty, The.End, 3).Returns(String.Empty),
                new TestCaseData(String.Empty, 4, Const.SampleMarker, The.Beginning, 3).Returns(String.Empty),
                new TestCaseData(String.Empty, 4, Const.SampleMarker, The.End, 3).Returns(String.Empty),
                new TestCaseData(Const.SampleString, 1, null, The.Beginning, 3).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, 1, null, The.End, 3).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, 1, String.Empty, The.Beginning, 3).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, 1, String.Empty, The.End, 3).Returns(Const.SampleString),
                new TestCaseData("Some string", 2, Const.SampleMarker, The.Beginning, 5).Returns("string"),
                new TestCaseData("Some string", 2, Const.SampleMarker, The.End, 5).Returns("string"),
                new TestCaseData("Some string", 3, Const.SampleMarker, The.Beginning, 2).Returns("me string"),
                new TestCaseData("Some string", 3, Const.SampleMarker, The.End, 2).Returns("me string"),
                new TestCaseData("Some string", 0, "string", The.Beginning, 2).Returns("me string"),
                new TestCaseData("Some string", 0, "string", The.End, 2).Returns("me string"),
                new TestCaseData("Some string", 1, "string", The.Beginning, 250).Returns("Some "),
                new TestCaseData("Some string", 1, "string", The.End, 250).Returns("Some "),
                new TestCaseData("Some string", 10, "string", The.Beginning, 250).Returns(String.Empty),
                new TestCaseData("Some string", 10, "string", The.End, 250).Returns(String.Empty),
                new TestCaseData("Some string", 10, "string", The.Beginning, 9).Returns("ng"),
                new TestCaseData("Some string", 10, "string", The.End, 9).Returns("ng"),
                new TestCaseData(Const.SampleString, 2, Const.SampleMarker, The.StartOf, 3).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 2, Const.SampleMarker, The.EndOf, 3).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, Const.SampleString, The.Beginning, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, Const.SampleString, The.End, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, Const.SampleString, The.Beginning, -2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, Const.SampleString, The.End, -2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, String.Empty, The.Beginning, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, String.Empty, The.End, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, String.Empty, The.Beginning, -2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, String.Empty, The.End, -2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData("Some string", 1, "string", The.Beginning, 3).Returns("Somestring"),
                new TestCaseData("Some string", 1, "string", The.End, 3).Returns("Somestring"),
                new TestCaseData("Some string with many strings", 2, "string", The.Beginning, 22).Returns("Some string with many strings"),
                new TestCaseData("Some string with many strings", 1, "string", The.End, 22).Returns("Some string with many strings"),
                new TestCaseData("Some string with many strings", 1, "string", The.Beginning, 12).Returns("Some with many strings"),
                new TestCaseData("Some string with many strings", 2, "string", The.End, 12).Returns("Some with many strings")
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingOccurrenceFromToDataCases))]
        public string RemoveStartingOccurrenceFromToExtremeCases(string source, int occurrence, string startingMarker, The startingFrom, int positionIndex)
        {
            return source.Remove().Starting(occurrence, of: startingMarker).From(startingFrom).To(positionIndex);
        }

        #endregion

        #region Remove Starting Occurrence From To From

        private class RemoveStartingOccurrenceFromToFromDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, 2, null, The.Beginning, 2, The.Beginning).Returns(null),
                new TestCaseData(null, 2, null, The.Beginning, 2, The.End).Returns(null),
                new TestCaseData(null, 2, null, The.End, 3, The.Beginning).Returns(null),
                new TestCaseData(null, 2, null, The.End, 3, The.End).Returns(null),
                new TestCaseData(null, 2, String.Empty, The.Beginning, 1, The.Beginning).Returns(null),
                new TestCaseData(null, 2, String.Empty, The.Beginning, 1, The.End).Returns(null),
                new TestCaseData(null, 2, String.Empty, The.End, 2, The.Beginning).Returns(null),
                new TestCaseData(null, 2, String.Empty, The.End, 2, The.End).Returns(null),
                new TestCaseData(null, 2, Const.SampleMarker, The.Beginning, 5, The.Beginning).Returns(null),
                new TestCaseData(null, 2, Const.SampleMarker, The.Beginning, 5, The.End).Returns(null),
                new TestCaseData(null, 2, Const.SampleMarker, The.End, 1, The.Beginning).Returns(null),
                new TestCaseData(null, 2, Const.SampleMarker, The.End, 1, The.End).Returns(null),
                new TestCaseData(String.Empty, 1, null, The.Beginning, 2, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, 1, null, The.Beginning, 2, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, 1, null, The.End, 2, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, 1, null, The.End, 2, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, 1, String.Empty, The.Beginning, 1, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, 1, String.Empty, The.Beginning, 1, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, 1, String.Empty, The.End, 1, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, 1, String.Empty, The.End, 1, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, 1, Const.SampleMarker, The.Beginning, 2, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, 1, Const.SampleMarker, The.Beginning, 2, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, 1, Const.SampleMarker, The.End, 2, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, 1, Const.SampleMarker, The.End, 2, The.End).Returns(String.Empty),
                new TestCaseData(Const.SampleString, 3, null, The.Beginning, 4, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, 3, null, The.Beginning, 4, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, 3, null, The.End, 4, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, 3, null, The.End, 4, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, 3, String.Empty, The.Beginning, 4, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, 3, String.Empty, The.Beginning, 4, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, 3, String.Empty, The.End, 4, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, 3, String.Empty, The.End, 4, The.End).Returns(Const.SampleString),
                new TestCaseData("Some string", 4, Const.SampleMarker, The.Beginning, 4, The.Beginning).Returns(" string"),
                new TestCaseData("Some string", 4, Const.SampleMarker, The.Beginning, 4, The.End).Returns("Some st"),
                new TestCaseData("Some string", 4, Const.SampleMarker, The.End, 4, The.Beginning).Returns(" string"),
                new TestCaseData("Some string", 4, Const.SampleMarker, The.End, 4, The.End).Returns("Some st"),
                new TestCaseData("Some string", 3, Const.SampleMarker, The.Beginning, 2, The.Beginning).Returns("me string"),
                new TestCaseData("Some string", 3, Const.SampleMarker, The.Beginning, 2, The.End).Returns("Some stri"),
                new TestCaseData("Some string", 3, Const.SampleMarker, The.End, 2, The.Beginning).Returns("me string"),
                new TestCaseData("Some string", 3, Const.SampleMarker, The.End, 2, The.End).Returns("Some stri"),
                new TestCaseData("Some string", 0, "string", The.Beginning, 2, The.Beginning).Returns("me string"),
                new TestCaseData("Some string", 0, "string", The.Beginning, 2, The.End).Returns("Some stri"),
                new TestCaseData("Some string", 0, "string", The.End, 2, The.Beginning).Returns("me string"),
                new TestCaseData("Some string", 0, "string", The.End, 2, The.End).Returns("Some stri"),
                new TestCaseData("Some string", 1, "string", The.Beginning, 250, The.Beginning).Returns("Some "),
                new TestCaseData("Some string", 1, "string", The.Beginning, 250, The.End).Returns("string"),
                new TestCaseData("Some string", 1, "string", The.End, 250, The.Beginning).Returns("Some "),
                new TestCaseData("Some string", 1, "string", The.End, 250, The.End).Returns("string"),
                new TestCaseData("Some string", 10, "string", The.Beginning, 250, The.Beginning).Returns(String.Empty),
                new TestCaseData("Some string", 10, "string", The.Beginning, 250, The.End).Returns(String.Empty),
                new TestCaseData("Some string", 10, "string", The.End, 250, The.Beginning).Returns(String.Empty),
                new TestCaseData("Some string", 10, "string", The.End, 250, The.End).Returns(String.Empty),
                new TestCaseData("Some string", 10, "string", The.Beginning, 9, The.Beginning).Returns("ng"),
                new TestCaseData("Some string", 10, "string", The.Beginning, 9, The.End).Returns("So"),
                new TestCaseData("Some string", 10, "string", The.End, 9, The.Beginning).Returns("ng"),
                new TestCaseData("Some string", 10, "string", The.End, 9, The.End).Returns("So"),
                new TestCaseData(Const.SampleString, 2, Const.SampleMarker, The.Beginning, 1, The.StartOf).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 2, Const.SampleMarker, The.End, 1, The.EndOf).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 2, Const.SampleMarker, The.StartOf, 1, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 2, Const.SampleMarker, The.EndOf, 1, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 2, Const.SampleMarker, The.StartOf, 1, The.StartOf).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 2, Const.SampleMarker, The.EndOf, 1, The.EndOf).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, Const.SampleString, The.Beginning, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, Const.SampleString, The.Beginning, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, Const.SampleString, The.End, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, Const.SampleString, The.End, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, Const.SampleString, The.Beginning, -2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, Const.SampleString, The.Beginning, -2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, Const.SampleString, The.End, -2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, Const.SampleString, The.End, -2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, String.Empty, The.Beginning, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, String.Empty, The.Beginning, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, String.Empty, The.End, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, -1, String.Empty, The.End, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, String.Empty, The.Beginning, -2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, String.Empty, The.Beginning, -2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, String.Empty, The.End, -2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, 1, String.Empty, The.End, -2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData("Some string", 1, "string", The.Beginning, 3, The.Beginning).Returns("Somestring"),
                new TestCaseData("Some string", 1, "string", The.Beginning, 7, The.End).Returns("Somestring"),
                new TestCaseData("Some string", 1, "string", The.End, 3, The.Beginning).Returns("Somestring"),
                new TestCaseData("Some string", 1, "string", The.End, 7, The.End).Returns("Somestring"),
                new TestCaseData("Some string with many strings", 2, "string", The.Beginning, 22, The.Beginning).Returns("Some string with many strings"),
                new TestCaseData("Some string with many strings", 2, "string", The.Beginning, 6, The.End).Returns("Some string with many strings"),
                new TestCaseData("Some string with many strings", 1, "string", The.End, 22, The.Beginning).Returns("Some string with many strings"),
                new TestCaseData("Some string with many strings", 1, "string", The.End, 6, The.End).Returns("Some string with many strings"),
                new TestCaseData("Some string with many strings", 1, "string", The.Beginning, 12, The.Beginning).Returns("Some with many strings"),
                new TestCaseData("Some string with many strings", 1, "string", The.Beginning, 16, The.End).Returns("Some with many strings"),
                new TestCaseData("Some string with many strings", 2, "string", The.End, 12, The.Beginning).Returns("Some with many strings"),
                new TestCaseData("Some string with many strings", 2, "string", The.End, 16, The.End).Returns("Some with many strings")
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingOccurrenceFromToFromDataCases))]
        public string RemoveStartingOccurrenceFromToFromExtremeCases(string source, int occurrence, string startingMarker, The startingFrom, int positionIndex, The toFrom)
        {
            return source.Remove().Starting(occurrence, of: startingMarker).From(startingFrom).To(positionIndex).From(toFrom);
        }

        #endregion

        #region Remove Starting Occurrence Ignoring Case To

        [TestCaseSource(typeof(RemoveStartingOccurrenceToDataCases))]
        public string RemoveStartingOccurrenceIgnoringCaseToExtremeCases(string source, int occurrence, string startingMarker, int positionIndex)
        {
            return source.Remove().Starting(occurrence, of: startingMarker).IgnoringCase().To(positionIndex);
        }

        #endregion

        #region Remove Starting Occurrence Ignoring Case To From

        [TestCaseSource(typeof(RemoveStartingOccurrenceToFromDataCases))]
        public string RemoveStartingOccurrenceIgnoringCaseToFromExtremeCases(string source, int occurrence, string startingMarker, int positionIndex, The toFrom)
        {
            return source.Remove().Starting(occurrence, of: startingMarker).IgnoringCase().To(positionIndex).From(toFrom);
        }

        #endregion

        #region Remove Starting Occurrence Ignoring Case From To

        [TestCaseSource(typeof(RemoveStartingOccurrenceFromToDataCases))]
        public string RemoveStartingOccurrenceIgnoringCaseFromToExtremeCases(string source, int occurrence, string startingMarker, The startingFrom, int positionIndex)
        {
            return source.Remove().Starting(occurrence, of: startingMarker).IgnoringCase().From(startingFrom).To(positionIndex);
        }

        #endregion

        #region Remove Starting Occurrence Ignoring Case From To From

        [TestCaseSource(typeof(RemoveStartingOccurrenceFromToFromDataCases))]
        public string RemoveStartingOccurrenceIgnoringCaseFromToFromExtremeCases(string source, int occurrence, string startingMarker, The startingFrom, int positionIndex, The toFrom)
        {
            return source.Remove().Starting(occurrence, of: startingMarker).IgnoringCase().From(startingFrom).To(positionIndex).From(toFrom);
        }

        #endregion
    }
}
