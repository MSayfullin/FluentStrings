using System;
using System.Collections;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class RemoveStartingOccurrencePositionToTests
    {
        #region Remove Starting Occurrence Position To

        private class RemoveStartingOccurrencePositionToDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, The.StartOf, 1, null, 2).Returns(null),
                new TestCaseData(null, The.EndOf, 2, null, 2).Returns(null),
                new TestCaseData(null, The.StartOf, 1, String.Empty, 3).Returns(null),
                new TestCaseData(null, The.EndOf, 2, String.Empty, 2).Returns(null),
                new TestCaseData(null, The.StartOf, 3, Const.SampleMarker, 1).Returns(null),
                new TestCaseData(null, The.EndOf, 2, Const.SampleMarker, 2).Returns(null),
                new TestCaseData(String.Empty, The.StartOf, 1, null, 2).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 1, null, 2).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 2, String.Empty, 2).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 2, String.Empty, 2).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 2, Const.SampleMarker, 2).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 2, Const.SampleMarker, 2).Returns(String.Empty),
                new TestCaseData(Const.SampleString, The.StartOf, 2, null, 2).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 2, null, 2).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, 2, String.Empty, 2).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 2, String.Empty, 2).Returns(Const.SampleString),
                new TestCaseData("Some string", The.StartOf, 2, Const.SampleMarker, 2).Returns("me string"),
                new TestCaseData("Some string", The.EndOf, 1, Const.SampleMarker, 2).Returns("me string"),
                new TestCaseData("Some string", The.StartOf, 0, "string", 2).Returns("me string"),
                new TestCaseData("Some string", The.StartOf, 1, "string", 0).Returns("Sstring"),
                new TestCaseData("Some string", The.EndOf, 10, "string", 250).Returns(String.Empty),
                new TestCaseData("Some string", The.StartOf, 10, "string", 9).Returns("ng"),
                new TestCaseData(Const.SampleString, The.Beginning, 2, Const.SampleMarker, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.End, 2, Const.SampleMarker, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, Const.SampleMarker, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.EndOf, 2, Const.SampleMarker, -2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, String.Empty, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, -2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData("Some long string with another string marker", The.StartOf, 1, "string", 22).Returns("Some long another string marker"),
                new TestCaseData("Some long string with another string marker", The.StartOf, 2, "string", 9).Returns("Some long string marker"),
                new TestCaseData("Some long string with another string marker", The.EndOf, 2, "string", 8).Returns("Some long marker")
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingOccurrencePositionToDataCases))]
        public string RemoveStartingOccurrencePositionToExtremeCases(string source, The startingPosition, int occurrence, string startingMarker, int positionIndex)
        {
            return source.Remove().Starting(startingPosition, occurrence, of: startingMarker).To(positionIndex);
        }

        #endregion

        #region Remove Starting Occurrence Position To From

        private class RemoveStartingOccurrencePositionToFromDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, The.StartOf, 2, null, 2, The.Beginning).Returns(null),
                new TestCaseData(null, The.EndOf, 2, null, 2, The.Beginning).Returns(null),
                new TestCaseData(null, The.StartOf, 2, null, 4, The.End).Returns(null),
                new TestCaseData(null, The.EndOf, 1, null, 2, The.End).Returns(null),
                new TestCaseData(null, The.StartOf, 2, String.Empty, 2, The.Beginning).Returns(null),
                new TestCaseData(null, The.EndOf, 2, String.Empty, 2, The.Beginning).Returns(null),
                new TestCaseData(null, The.StartOf, 2, String.Empty, 2, The.End).Returns(null),
                new TestCaseData(null, The.EndOf, 3, String.Empty, 2, The.End).Returns(null),
                new TestCaseData(null, The.StartOf, 2, Const.SampleMarker, 1, The.Beginning).Returns(null),
                new TestCaseData(null, The.EndOf, 2, Const.SampleMarker, 2, The.Beginning).Returns(null),
                new TestCaseData(null, The.StartOf, 2, Const.SampleMarker, 2, The.End).Returns(null),
                new TestCaseData(null, The.EndOf, 1, Const.SampleMarker, 2, The.End).Returns(null),
                new TestCaseData(String.Empty, The.StartOf, 2, null, 3, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 2, null, 2, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 2, null, 4, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 2, null, 2, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 2, String.Empty, 2, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 3, String.Empty, 2, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 2, String.Empty, 2, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 2, String.Empty, 2, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 3, Const.SampleMarker, 2, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 2, Const.SampleMarker, 2, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 2, Const.SampleMarker, 2, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 2, Const.SampleMarker, 2, The.End).Returns(String.Empty),
                new TestCaseData(Const.SampleString, The.StartOf, 3, null, 2, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 2, null, 2, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, 2, null, 2, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 4, null, 2, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, 2, String.Empty, 5, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 2, String.Empty, 2, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, 3, String.Empty, 2, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 2, String.Empty, 2, The.End).Returns(Const.SampleString),
                new TestCaseData("Some string", The.StartOf, 2, Const.SampleMarker, 2, The.Beginning).Returns("me string"),
                new TestCaseData("Some string", The.EndOf, 1, Const.SampleMarker, 3, The.Beginning).Returns("e string"),
                new TestCaseData("Some string", The.StartOf, 3, Const.SampleMarker, 4, The.End).Returns("tring"),
                new TestCaseData("Some string", The.EndOf, 2, Const.SampleMarker, 2, The.End).Returns("ing"),
                new TestCaseData("Some string", The.StartOf, 0, "string", 2, The.Beginning).Returns("me string"),
                new TestCaseData("Some string", The.StartOf, 1, "string", 0, The.Beginning).Returns("Sstring"),
                new TestCaseData("Some string", The.EndOf, 10, "string", 250, The.Beginning).Returns(String.Empty),
                new TestCaseData("Some string", The.StartOf, 10, "string", 9, The.Beginning).Returns("ng"),
                new TestCaseData(Const.SampleString, The.Beginning, 2, Const.SampleMarker, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.End, 2, Const.SampleMarker, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, Const.SampleMarker, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.EndOf, 2, Const.SampleMarker, -2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, String.Empty, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, -2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, 2, The.StartOf).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, 2, The.EndOf).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData("Some string", The.StartOf, 0, "string", 2, The.End).Returns("ing"),
                new TestCaseData("Some string", The.StartOf, 1, "string", 0, The.End).Returns("Some g"),
                new TestCaseData(Const.SampleString, The.EndOf, 10, "string", 250, The.End).Returns(Const.SampleString),
                new TestCaseData("Some string", The.StartOf, 10, "string", 9, The.End).Returns("ome string"),
                new TestCaseData(Const.SampleString, The.Beginning, 2, Const.SampleMarker, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.End, 2, Const.SampleMarker, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, Const.SampleMarker, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.EndOf, 2, Const.SampleMarker, -2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, String.Empty, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, -2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData("Some long string with another string marker", The.StartOf, 1, "string", 22, The.Beginning).Returns("Some long another string marker"),
                new TestCaseData("Some long string with another string marker", The.StartOf, 2, "string", 9, The.Beginning).Returns("Some long string marker"),
                new TestCaseData("Some long string with another string marker", The.EndOf, 2, "string", 8, The.Beginning).Returns("Some long marker"),
                new TestCaseData("Some long string with another string marker", The.StartOf, 1, "string", 12, The.End).Returns("Some long string marker"),
                new TestCaseData("Some long string with another string marker", The.StartOf, 2, "string", 21, The.End).Returns("Some long string with string marker"),
                new TestCaseData("Some long string with another string marker", The.EndOf, 2, "string", 14, The.End).Returns("Some long string with another marker")
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingOccurrencePositionToFromDataCases))]
        public string RemoveStartingOccurrencePositionToFromExtremeCases(string source, The startingPosition, int occurrence, string startingMarker, int positionIndex, The toFrom)
        {
            return source.Remove().Starting(startingPosition, occurrence, of: startingMarker).To(positionIndex).From(toFrom);
        }

        #endregion

        #region Remove Starting Occurrence Position From To

        private class RemoveStartingOccurrencePositionFromToDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, The.StartOf, 3, null, The.Beginning, 1).Returns(null),
                new TestCaseData(null, The.EndOf, 3, null, The.Beginning, 3).Returns(null),
                new TestCaseData(null, The.StartOf, 2, null, The.End, 2).Returns(null),
                new TestCaseData(null, The.EndOf, 3, null, The.End, 3).Returns(null),
                new TestCaseData(null, The.StartOf, 1, String.Empty, The.Beginning, 3).Returns(null),
                new TestCaseData(null, The.EndOf, 3, String.Empty, The.Beginning, 3).Returns(null),
                new TestCaseData(null, The.StartOf, 1, String.Empty, The.End, 3).Returns(null),
                new TestCaseData(null, The.EndOf, 3, String.Empty, The.End, 2).Returns(null),
                new TestCaseData(null, The.StartOf, 2, Const.SampleMarker, The.Beginning, 3).Returns(null),
                new TestCaseData(null, The.EndOf, 3, Const.SampleMarker, The.Beginning, 3).Returns(null),
                new TestCaseData(null, The.StartOf, 4, Const.SampleMarker, The.End, 1).Returns(null),
                new TestCaseData(null, The.EndOf, 3, Const.SampleMarker, The.End, 3).Returns(null),
                new TestCaseData(String.Empty, The.StartOf, 5, null, The.Beginning, 3).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 2, null, The.Beginning, 3).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 3, null, The.End, 2).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 1, null, The.End, 3).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 3, String.Empty, The.Beginning, 3).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 2, String.Empty, The.Beginning, 3).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 3, String.Empty, The.End, 3).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 3, String.Empty, The.End, 2).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 4, Const.SampleMarker, The.Beginning, 3).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 3, Const.SampleMarker, The.Beginning, 1).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 2, Const.SampleMarker, The.End, 3).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 3, Const.SampleMarker, The.End, 4).Returns(String.Empty),
                new TestCaseData(Const.SampleString, The.StartOf, 3, null, The.Beginning, 3).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 1, null, The.Beginning, 3).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, 3, null, The.End, 3).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 3, null, The.End, 3).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, The.Beginning, 3).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 3, String.Empty, The.Beginning, 3).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, The.End, 2).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 3, String.Empty, The.End, 3).Returns(Const.SampleString),
                new TestCaseData("Some string", The.StartOf, 2, Const.SampleMarker, The.Beginning, 1).Returns("ome string"),
                new TestCaseData("Some string", The.EndOf, 3, Const.SampleMarker, The.Beginning, 3).Returns("e string"),
                new TestCaseData("Some string", The.StartOf, 1, Const.SampleMarker, The.End, 2).Returns("me string"),
                new TestCaseData("Some string", The.EndOf, 3, Const.SampleMarker, The.End, 3).Returns("e string"),
                new TestCaseData("Some string", The.StartOf, 0, "string", The.Beginning, 2).Returns("me string"),
                new TestCaseData("Some string", The.StartOf, 1, "string", The.Beginning, 0).Returns("Sstring"),
                new TestCaseData("Some string", The.EndOf, 10, "string", The.Beginning, 250).Returns(String.Empty),
                new TestCaseData("Some string", The.StartOf, 10, "string", The.Beginning, 9).Returns("ng"),
                new TestCaseData(Const.SampleString, The.Beginning, 2, Const.SampleMarker, The.Beginning, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.End, 2, Const.SampleMarker, The.Beginning, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, Const.SampleMarker, The.Beginning, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.EndOf, 2, Const.SampleMarker, The.Beginning, -2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, String.Empty, The.Beginning, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, The.Beginning, -2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, The.StartOf, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, The.EndOf, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData("Some string", The.StartOf, 0, "string", The.End, 2).Returns("me string"),
                new TestCaseData("Some string", The.StartOf, 1, "string", The.End, 0).Returns("Sstring"),
                new TestCaseData("Some string", The.EndOf, 10, "string", The.End, 250).Returns(String.Empty),
                new TestCaseData("Some string", The.StartOf, 10, "string", The.End, 9).Returns("ng"),
                new TestCaseData(Const.SampleString, The.Beginning, 2, Const.SampleMarker, The.End, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.End, 2, Const.SampleMarker, The.End, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, Const.SampleMarker, The.End, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.EndOf, 2, Const.SampleMarker, The.End, -2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, String.Empty, The.End, 2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, The.End, -2).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData("Some long string with another string marker", The.StartOf, 1, "string", The.Beginning, 22).Returns("Some long another string marker"),
                new TestCaseData("Some long string with another string marker", The.StartOf, 2, "string", The.Beginning, 9).Returns("Some long string marker"),
                new TestCaseData("Some long string with another string marker", The.EndOf, 2, "string", The.Beginning, 8).Returns("Some long marker"),
                new TestCaseData("Some long string with another string marker", The.StartOf, 1, "string", The.End, 9).Returns("Some long string marker"),
                new TestCaseData("Some long string with another string marker", The.StartOf, 2, "string", The.End, 22).Returns("Some long another string marker"),
                new TestCaseData("Some long string with another string marker", The.EndOf, 1, "string", The.End, 8).Returns("Some long marker")
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingOccurrencePositionFromToDataCases))]
        public string RemoveStartingOccurrencePositionFromToExtremeCases(string source, The startingPosition, int occurrence, string startingMarker, The startingFrom, int positionIndex)
        {
            return source.Remove().Starting(startingPosition, occurrence, of: startingMarker).From(startingFrom).To(positionIndex);
        }

        #endregion

        #region Remove Starting Occurrence Position From To From

        private class RemoveStartingOccurrencePositionFromToFromDataCases : IEnumerable
        {
            private readonly TestCaseData[] testCaseData = new[]
            {
                new TestCaseData(null, The.StartOf, 1, null, The.Beginning, 1, The.Beginning).Returns(null),
                new TestCaseData(null, The.EndOf, 1, null, The.Beginning, 1, The.Beginning).Returns(null),
                new TestCaseData(null, The.StartOf, 3, null, The.Beginning, 1, The.End).Returns(null),
                new TestCaseData(null, The.EndOf, 2, null, The.Beginning, 1, The.End).Returns(null),
                new TestCaseData(null, The.StartOf, 1, null, The.End, 2, The.Beginning).Returns(null),
                new TestCaseData(null, The.EndOf, 1, null, The.End, 1, The.Beginning).Returns(null),
                new TestCaseData(null, The.StartOf, 2, null, The.End, 3, The.End).Returns(null),
                new TestCaseData(null, The.EndOf, 1, null, The.End, 1, The.End).Returns(null),
                new TestCaseData(null, The.StartOf, 3, String.Empty, The.Beginning, 1, The.Beginning).Returns(null),
                new TestCaseData(null, The.EndOf, 1, String.Empty, The.Beginning, 2, The.Beginning).Returns(null),
                new TestCaseData(null, The.StartOf, 1, String.Empty, The.Beginning, 1, The.End).Returns(null),
                new TestCaseData(null, The.EndOf, 3, String.Empty, The.Beginning, 2, The.End).Returns(null),
                new TestCaseData(null, The.StartOf, 1, String.Empty, The.End, 3, The.Beginning).Returns(null),
                new TestCaseData(null, The.EndOf, 2, String.Empty, The.End, 1, The.Beginning).Returns(null),
                new TestCaseData(null, The.StartOf, 3, String.Empty, The.End, 1, The.End).Returns(null),
                new TestCaseData(null, The.EndOf, 1, String.Empty, The.End, 1, The.End).Returns(null),
                new TestCaseData(null, The.StartOf, 1, Const.SampleMarker, The.Beginning, 1, The.Beginning).Returns(null),
                new TestCaseData(null, The.EndOf, 1, Const.SampleMarker, The.Beginning, 1, The.Beginning).Returns(null),
                new TestCaseData(null, The.StartOf, 2, Const.SampleMarker, The.Beginning, 1, The.End).Returns(null),
                new TestCaseData(null, The.EndOf, 1, Const.SampleMarker, The.Beginning, 1, The.End).Returns(null),
                new TestCaseData(null, The.StartOf, 3, Const.SampleMarker, The.End, 1, The.Beginning).Returns(null),
                new TestCaseData(null, The.EndOf, 1, Const.SampleMarker, The.End, 1, The.Beginning).Returns(null),
                new TestCaseData(null, The.StartOf, 1, Const.SampleMarker, The.End, 3, The.End).Returns(null),
                new TestCaseData(null, The.EndOf, 2, Const.SampleMarker, The.End, 2, The.End).Returns(null),
                new TestCaseData(String.Empty, The.StartOf, 1, null, The.Beginning, 1, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 1, null, The.Beginning, 1, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 1, null, The.Beginning, 3, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 1, null, The.Beginning, 1, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 1, null, The.End, 2, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 1, null, The.End, 1, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 2, null, The.End, 1, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 1, null, The.End, 1, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 3, String.Empty, The.Beginning, 1, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 1, String.Empty, The.Beginning, 1, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 2, String.Empty, The.Beginning, 2, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 1, String.Empty, The.Beginning, 1, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 1, String.Empty, The.End, 1, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 1, String.Empty, The.End, 1, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 3, String.Empty, The.End, 1, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 1, String.Empty, The.End, 2, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 1, Const.SampleMarker, The.Beginning, 1, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 2, Const.SampleMarker, The.Beginning, 1, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 1, Const.SampleMarker, The.Beginning, 1, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 1, Const.SampleMarker, The.Beginning, 1, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 2, Const.SampleMarker, The.End, 1, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 1, Const.SampleMarker, The.End, 3, The.Beginning).Returns(String.Empty),
                new TestCaseData(String.Empty, The.StartOf, 3, Const.SampleMarker, The.End, 1, The.End).Returns(String.Empty),
                new TestCaseData(String.Empty, The.EndOf, 1, Const.SampleMarker, The.End, 1, The.End).Returns(String.Empty),
                new TestCaseData(Const.SampleString, The.StartOf, 1, null, The.Beginning, 1, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 3, null, The.Beginning, 1, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, 2, null, The.Beginning, 2, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 1, null, The.Beginning, 1, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, 1, null, The.End, 1, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 1, null, The.End, 1, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, 2, null, The.End, 1, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 1, null, The.End, 1, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, The.Beginning, 2, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 1, String.Empty, The.Beginning, 1, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, 3, String.Empty, The.Beginning, 4, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 1, String.Empty, The.Beginning, 1, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, 3, String.Empty, The.End, 1, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 1, String.Empty, The.End, 2, The.Beginning).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.StartOf, 4, String.Empty, The.End, 1, The.End).Returns(Const.SampleString),
                new TestCaseData(Const.SampleString, The.EndOf, 1, String.Empty, The.End, 1, The.End).Returns(Const.SampleString),
                new TestCaseData("Some string", The.StartOf, 2, Const.SampleMarker, The.Beginning, 2, The.Beginning).Returns("me string"),
                new TestCaseData("Some string", The.EndOf, 1, Const.SampleMarker, The.Beginning, 1, The.Beginning).Returns("ome string"),
                new TestCaseData("Some string", The.StartOf, 1, Const.SampleMarker, The.Beginning, 1, The.End).Returns("ng"),
                new TestCaseData("Some string", The.EndOf, 1, Const.SampleMarker, The.Beginning, 2, The.End).Returns("ing"),
                new TestCaseData("Some string", The.StartOf, 2, Const.SampleMarker, The.End, 4, The.Beginning).Returns(" string"),
                new TestCaseData("Some string", The.EndOf, 1, Const.SampleMarker, The.End, 1, The.Beginning).Returns("ome string"),
                new TestCaseData("Some string", The.StartOf, 1, Const.SampleMarker, The.End, 3, The.End).Returns("ring"),
                new TestCaseData("Some string", The.EndOf, 1, Const.SampleMarker, The.End, 1, The.End).Returns("ng"),
                new TestCaseData("Some string", The.StartOf, 0, "string", The.Beginning, 2, The.Beginning).Returns("me string"),
                new TestCaseData("Some string", The.StartOf, 1, "string", The.Beginning, 0, The.Beginning).Returns("Sstring"),
                new TestCaseData("Some string", The.EndOf, 10, "string", The.Beginning, 250, The.Beginning).Returns(String.Empty),
                new TestCaseData("Some string", The.StartOf, 10, "string", The.Beginning, 9, The.Beginning).Returns("ng"),
                new TestCaseData(Const.SampleString, The.Beginning, 2, Const.SampleMarker, The.Beginning, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.End, 2, Const.SampleMarker, The.Beginning, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, Const.SampleMarker, The.Beginning, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.EndOf, 2, Const.SampleMarker, The.Beginning, -2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, String.Empty, The.Beginning, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, The.Beginning, -2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, The.StartOf, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, The.EndOf, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData("Some string", The.StartOf, 0, "string", The.End, 2, The.Beginning).Returns("me string"),
                new TestCaseData("Some string", The.StartOf, 1, "string", The.End, 0, The.Beginning).Returns("Sstring"),
                new TestCaseData("Some string", The.EndOf, 10, "string", The.End, 250, The.Beginning).Returns(String.Empty),
                new TestCaseData("Some string", The.StartOf, 10, "string", The.End, 9, The.Beginning).Returns("ng"),
                new TestCaseData(Const.SampleString, The.Beginning, 2, Const.SampleMarker, The.End, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.End, 2, Const.SampleMarker, The.End, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, Const.SampleMarker, The.End, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.EndOf, 2, Const.SampleMarker, The.End, -2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, String.Empty, The.End, 2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, The.End, -2, The.Beginning).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData("Some string", The.StartOf, 0, "string", The.Beginning, 2, The.End).Returns("ing"),
                new TestCaseData("Some string", The.StartOf, 1, "string", The.Beginning, 0, The.End).Returns("Some g"),
                new TestCaseData(Const.SampleString, The.EndOf, 10, "string", The.Beginning, 250, The.End).Returns(Const.SampleString),
                new TestCaseData("Some string", The.StartOf, 10, "string", The.Beginning, 9, The.End).Returns("ome string"),
                new TestCaseData(Const.SampleString, The.Beginning, 2, Const.SampleMarker, The.Beginning, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.End, 2, Const.SampleMarker, The.Beginning, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, Const.SampleMarker, The.Beginning, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.EndOf, 2, Const.SampleMarker, The.Beginning, -2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, String.Empty, The.Beginning, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, The.Beginning, -2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, The.StartOf, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, The.EndOf, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData("Some string", The.StartOf, 0, "string", The.End, 2, The.End).Returns("ing"),
                new TestCaseData("Some string", The.StartOf, 1, "string", The.End, 0, The.End).Returns("Some g"),
                new TestCaseData(Const.SampleString, The.EndOf, 10, "string", The.End, 250, The.End).Returns(Const.SampleString),
                new TestCaseData("Some string", The.StartOf, 10, "string", The.End, 9, The.End).Returns("ome string"),
                new TestCaseData(Const.SampleString, The.Beginning, 2, Const.SampleMarker, The.End, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.End, 2, Const.SampleMarker, The.End, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, Const.SampleMarker, The.End, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.EndOf, 2, Const.SampleMarker, The.End, -2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, -1, String.Empty, The.End, 2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData(Const.SampleString, The.StartOf, 1, String.Empty, The.End, -2, The.End).Throws(typeof(ArgumentOutOfRangeException)),
                new TestCaseData("Some long string with another string marker", The.StartOf, 1, "string", The.Beginning, 22, The.Beginning).Returns("Some long another string marker"),
                new TestCaseData("Some long string with another string marker", The.StartOf, 2, "string", The.Beginning, 9, The.Beginning).Returns("Some long string marker"),
                new TestCaseData("Some long string with another string marker", The.EndOf, 2, "string", The.Beginning, 8, The.Beginning).Returns("Some long marker"),
                new TestCaseData("Some long string with another string marker", The.StartOf, 1, "string", The.End, 9, The.Beginning).Returns("Some long string marker"),
                new TestCaseData("Some long string with another string marker", The.StartOf, 2, "string", The.End, 22, The.Beginning).Returns("Some long another string marker"),
                new TestCaseData("Some long string with another string marker", The.EndOf, 1, "string", The.End, 8, The.Beginning).Returns("Some long marker"),
                new TestCaseData("Some long string with another string marker", The.StartOf, 1, "string", The.Beginning, 20, The.End).Returns("Some long another string marker"),
                new TestCaseData("Some long string with another string marker", The.StartOf, 2, "string", The.Beginning, 9, The.End).Returns("Some long string with another ing marker"),
                new TestCaseData("Some long string with another string marker", The.EndOf, 2, "string", The.Beginning, 8, The.End).Returns("Some long string with another strin marker"),
                new TestCaseData("Some long string with another string marker", The.StartOf, 1, "string", The.End, 9, The.End).Returns("Some long string with another ing marker"),
                new TestCaseData("Some long string with another string marker", The.StartOf, 2, "string", The.End, 20, The.End).Returns("Some long another string marker"),
                new TestCaseData("Some long string with another string marker", The.EndOf, 1, "string", The.End, 8, The.End).Returns("Some long string with another strin marker")
            };

            public IEnumerator GetEnumerator()
            {
                return testCaseData.GetEnumerator();
            }
        }

        [TestCaseSource(typeof(RemoveStartingOccurrencePositionFromToFromDataCases))]
        public string RemoveStartingOccurrencePositionFromToFromExtremeCases(string source, The startingPosition, int occurrence, string startingMarker, The startingFrom, int positionIndex, The toFrom)
        {
            return source.Remove().Starting(startingPosition, occurrence, of: startingMarker).From(startingFrom).To(positionIndex).From(toFrom);
        }

        #endregion

        #region Remove Starting Occurrence Position Ignoring Case To

        [TestCaseSource(typeof(RemoveStartingOccurrencePositionToDataCases))]
        [TestCase("SOME LONG STRING WITH ANOTHER STRING MARKER", The.StartOf, 1, "string", 22, Result = "SOME LONG ANOTHER STRING MARKER")]
        [TestCase("Some long string with another STRING marker", The.StartOf, 2, "stRiNg", 9, Result = "Some long STRING marker")]
        [TestCase("Some long string with another string marker", The.EndOf, 2, "STRING", 8, Result = "Some long marker")]
        public string RemoveStartingOccurrencePositionIgnoringCaseToExtremeCases(string source, The startingPosition, int occurrence, string startingMarker, int positionIndex)
        {
            return source.Remove().Starting(startingPosition, occurrence, of: startingMarker).IgnoringCase().To(positionIndex);
        }

        #endregion

        #region Remove Starting Occurrence Position Ignoring Case To From

        [TestCaseSource(typeof(RemoveStartingOccurrencePositionToFromDataCases))]
        [TestCase("Some long string with another string marker", The.StartOf, 1, "STRING", 22, The.Beginning, Result = "Some long another string marker")]
        [TestCase("Some long string with another string marker", The.StartOf, 2, "stRING", 9, The.Beginning, Result = "Some long string marker")]
        [TestCase("Some long string with another string marker", The.EndOf, 2, "STRIng", 8, The.Beginning, Result = "Some long marker")]
        [TestCase("Some long string with another string marker", The.StartOf, 1, "StRiNg", 12, The.End, Result = "Some long string marker")]
        [TestCase("SOME LONG STRING WITH ANOTHER STRING MARKER", The.StartOf, 2, "string", 21, The.End, Result = "SOME LONG STRING WITH STRING MARKER")]
        [TestCase("Some long STRING with another STRING marker", The.EndOf, 2, "string", 14, The.End, Result = "Some long STRING with another marker")]
        public string RemoveStartingOccurrencePositionIgnoringCaseToFromExtremeCases(string source, The startingPosition, int occurrence, string startingMarker, int positionIndex, The toFrom)
        {
            return source.Remove().Starting(startingPosition, occurrence, of: startingMarker).IgnoringCase().To(positionIndex).From(toFrom);
        }

        #endregion

        #region Remove Starting Occurrence Position Ignoring Case From To

        [TestCaseSource(typeof(RemoveStartingOccurrencePositionFromToDataCases))]
        [TestCase("SOME LONG STRING WITH ANOTHER STRING MARKER", The.StartOf, 1, "string", The.Beginning, 22, Result = "SOME LONG ANOTHER STRING MARKER")]
        [TestCase("Some long string with another string marker", The.StartOf, 2, "stRING", The.Beginning, 9, Result = "Some long string marker")]
        [TestCase("Some long string with another string marker", The.EndOf, 2, "STRIng", The.Beginning, 8, Result = "Some long marker")]
        [TestCase("Some long string with another string marker", The.StartOf, 1, "STRING", The.End, 9, Result = "Some long string marker")]
        [TestCase("Some long string with another string marker", The.StartOf, 2, "sTrInG", The.End, 22, Result = "Some long another string marker")]
        [TestCase("Some long sTRing with another STRING marker", The.EndOf, 1, "string", The.End, 8, Result = "Some long marker")]
        public string RemoveStartingOccurrencePositionIgnoringCaseFromToExtremeCases(string source, The startingPosition, int occurrence, string startingMarker, The startingFrom, int positionIndex)
        {
            return source.Remove().Starting(startingPosition, occurrence, of: startingMarker).IgnoringCase().From(startingFrom).To(positionIndex);
        }

        #endregion

        #region Remove Starting Occurrence Position Ignoring Case From To From

        [TestCaseSource(typeof(RemoveStartingOccurrencePositionFromToFromDataCases))]
        [TestCase("Some long string with another string marker", The.StartOf, 1, "STRING", The.Beginning, 22, The.Beginning, Result = "Some long another string marker")]
        [TestCase("Some long string with another string marker", The.StartOf, 2, "STRing", The.Beginning, 9, The.Beginning, Result = "Some long string marker")]
        [TestCase("Some long string with another string marker", The.EndOf, 2, "stRING", The.Beginning, 8, The.Beginning, Result = "Some long marker")]
        [TestCase("Some long string with another string marker", The.StartOf, 1, "STrIng", The.End, 9, The.Beginning, Result = "Some long string marker")]
        [TestCase("SOME LONG STRING WITH ANOTHER STRING MARKER", The.StartOf, 2, "string", The.End, 22, The.Beginning, Result = "SOME LONG ANOTHER STRING MARKER")]
        [TestCase("Some long STRING with another STRING marker", The.EndOf, 1, "string", The.End, 8, The.Beginning, Result = "Some long marker")]
        [TestCase("Some long string with another STRING marker", The.StartOf, 1, "string", The.Beginning, 20, The.End, Result = "Some long another STRING marker")]
        [TestCase("Some long STRIng with another string marker", The.StartOf, 2, "stRINg", The.Beginning, 9, The.End, Result = "Some long STRIng with another ing marker")]
        [TestCase("Some long STRING with another string marker", The.EndOf, 2, "sTrInG", The.Beginning, 8, The.End, Result = "Some long STRING with another strin marker")]
        [TestCase("Some long stRING with another STRING marker", The.StartOf, 1, "sTRing", The.End, 9, The.End, Result = "Some long stRING with another ING marker")]
        [TestCase("Some long string with another string marker", The.StartOf, 2, "STRING", The.End, 20, The.End, Result = "Some long another string marker")]
        [TestCase("SOME LONG STRING WITH ANOTHER STRING MARKER", The.EndOf, 1, "string", The.End, 8, The.End, Result = "SOME LONG STRING WITH ANOTHER STRIN MARKER")]
        public string RemoveStartingOccurrencePositionIgnoringCaseFromToFromExtremeCases(string source, The startingPosition, int occurrence, string startingMarker, The startingFrom, int positionIndex, The toFrom)
        {
            return source.Remove().Starting(startingPosition, occurrence, of: startingMarker).IgnoringCase().From(startingFrom).To(positionIndex).From(toFrom);
        }

        #endregion
    }
}
