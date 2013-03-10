using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dokas.FluentStrings.Tests
{
    [TestClass]
    public class InsertTests
    {
        #region Insert

        [TestMethod]
        public void InsertNullIntoNullString()
        {
            string transformed = Const.NullString.Insert(null);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertNullIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertNull()
        {
            string transformed = Const.SampleString.Insert(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyText()
        {
            string transformed = Const.SampleString.Insert(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertText()
        {
            string transformed = "<-- TEST string will be inserted here".Insert("TEST");
            transformed.Should().Be("TEST<-- TEST string will be inserted here");
        }

        #endregion

        #region Insert To

        [TestMethod]
        public void InsertNullToTheBeginningOfNullString()
        {
            string transformed = Const.NullString.Insert(null).To(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextToTheBeginningOfNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).To(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextToTheBeginningOfNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).To(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertNullToTheBeginningOfEmptyString()
        {
            string transformed = String.Empty.Insert(null).To(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextToTheBeginningOfEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).To(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextToTheBeginningOfEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).To(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertNullToTheBeginning()
        {
            string transformed = Const.SampleString.Insert(null).To(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextToTheBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).To(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullToTheEndOfNullString()
        {
            string transformed = Const.NullString.Insert(null).To(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextToTheEndOfNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).To(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextToTheEndOfNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).To(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertNullToTheEndOfEmptyString()
        {
            string transformed = String.Empty.Insert(null).To(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextToTheEndOfEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).To(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextToTheEndOfEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).To(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertNullToTheEnd()
        {
            string transformed = Const.SampleString.Insert(null).To(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextToTheEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).To(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextToBeginning()
        {
            string transformed = "<-- TEST string will be inserted here".Insert("TEST").To(The.Beginning);
            transformed.Should().Be("TEST<-- TEST string will be inserted here");
        }

        [TestMethod]
        public void InsertTextToEnd()
        {
            string transformed = "TEST string will be inserted here -->".Insert("TEST").To(The.End);
            transformed.Should().Be("TEST string will be inserted here -->TEST");
        }

        #endregion

        #region Insert At

        [TestMethod]
        public void InsertNullAtPositionInNullString()
        {
            string transformed = Const.NullString.Insert(null).At(position: 2);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAtPositionInNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).At(position: 2);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAtPositionInNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).At(position: 2);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAtPositionInEmptyString()
        {
            string transformed = String.Empty.Insert(null).At(position: 2);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAtPositionInEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).At(position: 2);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAtPositionInEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).At(position: 2);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAtPosition()
        {
            string transformed = Const.SampleString.Insert(null).At(position: 2);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAtPosition()
        {
            string transformed = Const.SampleString.Insert(String.Empty).At(position: 2);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAtZeroPosition()
        {
            string transformed = "<-- TEST string will be inserted here".Insert("TEST").At(position: 0);
            transformed.Should().Be("TEST<-- TEST string will be inserted here");
        }

        [TestMethod]
        public void InsertTextAtFirstPosition()
        {
            string transformed = "!<-- TEST string will be inserted here".Insert("TEST").At(position: 1);
            transformed.Should().Be("!TEST<-- TEST string will be inserted here");
        }

        [TestMethod]
        public void InsertTextAt()
        {
            string transformed = "!!! <-- TEST string will be inserted here".Insert("TEST").At(position: 4);
            transformed.Should().Be("!!! TEST<-- TEST string will be inserted here");
        }

        #endregion

        #region Insert At From

        [TestMethod]
        public void InsertNullAtPositionInNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).At(position: 2).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAtPositionInNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).At(position: 2).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAtPositionInNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).At(position: 2).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAtPositionInEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).At(position: 2).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAtPositionInEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).At(position: 2).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAtPositionInEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).At(position: 2).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAtPositionFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).At(position: 2).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAtPositionFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).At(position: 2).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAtPositionInNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).At(position: 2).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAtPositionInNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).At(position: 2).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAtPositionInNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).At(position: 2).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAtPositionInEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).At(position: 2).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAtPositionInEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).At(position: 2).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAtPositionInEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).At(position: 2).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAtPositionFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).At(position: 2).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAtPositionFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).At(position: 2).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAtPositionFromBeginning()
        {
            string transformed = "!!! <-- TEST string will be inserted here".Insert("TEST").At(position: 4).From(The.Beginning);
            transformed.Should().Be("!!! TEST<-- TEST string will be inserted here");
        }

        [TestMethod]
        public void InsertTextAtPositionFromEnd()
        {
            string transformed = "TEST string will be inserted here --> !!!".Insert("TEST").At(position: 4).From(The.End);
            transformed.Should().Be("TEST string will be inserted here -->TEST !!!");
        }

        #endregion

        #region Insert Before

        [TestMethod]
        public void InsertNullBeforeNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(null);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(null);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(String.Empty);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeNullMarker()
        {
            string transformed = Const.SampleString.Insert(null).Before(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(null).Before(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeMarker()
        {
            string transformed = Const.SampleString.Insert(null).Before(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeNullMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeNullMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBefore()
        {
            string transformed = "TEST string will be inserted here -->_marker".Insert("TEST").Before("_marker");
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker");
        }

        [TestMethod]
        public void InsertTextBeforeMultipleTimes()
        {
            string transformed = "TEST string will be inserted here -->_marker TEST string will be inserted here -->_marker".Insert("TEST").Before("_marker");
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker TEST string will be inserted here -->TEST_marker");
        }

        [TestMethod]
        public void InsertTextBeforeCaseSensitive()
        {
            string transformed = "TEST string will NOT be inserted here -->_marker".Insert("TEST").Before("_maRKer");
            transformed.Should().Be("TEST string will NOT be inserted here -->_marker");
        }

        [TestMethod]
        public void InsertTextBeforeCaseSensitiveMultipleTimes()
        {
            string transformed = "TEST string will be inserted here -->_Marker, but will NOT be inserted here -->_marker".Insert("TEST").Before("_Marker");
            transformed.Should().Be("TEST string will be inserted here -->TEST_Marker, but will NOT be inserted here -->_marker");
        }

        #endregion

        #region Insert Before Occurrence

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(1, of: null);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(2, of: String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(3, of: Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(2, of: null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(1, of: String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(1, of: Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(2, of: null);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(1, of: String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(1, of: Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(2, of: null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(5, of: String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(5, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(1, of: null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(1, of: String.Empty);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(2, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfNullMarker()
        {
            string transformed = Const.SampleString.Insert(null).Before(1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(null).Before(2, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfMarker()
        {
            string transformed = Const.SampleString.Insert(null).Before(1, of: Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfNullMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(2, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeNegativeOccurrenceOfMarker()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).Before(-1, of: Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void InsertTextBeforeZeroOccurrenceOfMarker()
        {
            string transformed = "Some long long string with marker".Insert("TEST").Before(0, of: "marker");
            transformed.Should().Be("Some long long string with marker");
        }

        [TestMethod]
        public void InsertTextBeforeNonExistingOccurrence()
        {
            string transformed = Const.SampleString.Insert("TEST").Before(1, of: "_marker");
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrence()
        {
            string transformed = "TEST string will be inserted here -->_marker But not here --X_marker".Insert("TEST").Before(1, of: "_marker");
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker But not here --X_marker");
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceCaseSensitive()
        {
            string transformed = "This _Marker will be passed by and TEST string will be inserted here -->_marker But not here --X_marker".Insert("TEST").Before(1, of: "_marker");
            transformed.Should().Be("This _Marker will be passed by and TEST string will be inserted here -->TEST_marker But not here --X_marker");
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceInLongerstring()
        {
            string transformed = "_marker Some Another Text _marker _marker And again text _marker TEST string will be inserted here -->_marker But not here --X_marker".Insert("TEST").Before(5, of: "_marker");
            transformed.Should().Be("_marker Some Another Text _marker _marker And again text _marker TEST string will be inserted here -->TEST_marker But not here --X_marker");
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceWithMarkerAtBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted before that _marker".Insert("TEST").Before(1, of: "_marker");
            transformed.Should().Be("TEST_marker<-- TEST string will be inserted before that _marker");
        }

        #endregion

        #region Insert Before Occurrence From

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(1, of: null).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(3, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(2, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(1, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(2, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(1, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(2, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(5, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(5, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(3, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(1, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(1, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeNegativeOccurrenceOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).Before(-1, of: Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void InsertTextBeforeZeroOccurrenceOfMarkerFromBeginning()
        {
            string transformed = "Some long long string with marker".Insert("TEST").Before(0, of: "marker").From(The.Beginning);
            transformed.Should().Be("Some long long string with marker");
        }

        [TestMethod]
        public void InsertTextBeforeNonExistingOccurrenceFromBeginning()
        {
            string transformed = Const.SampleString.Insert("TEST").Before(1, of: "_marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(1, of: null).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(2, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(3, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(2, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(1, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(2, of: null).From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(1, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(2, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(5, of: String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(5, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(3, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(1, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(1, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeNegativeOccurrenceOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).Before(-1, of: Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void InsertTextBeforeZeroOccurrenceOfMarkerFromEnd()
        {
            string transformed = "Some long long string with marker".Insert("TEST").Before(0, of: "marker").From(The.End);
            transformed.Should().Be("Some long long string with marker");
        }

        [TestMethod]
        public void InsertTextBeforeNonExistingOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Insert("TEST").Before(1, of: "_marker").From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceFromBeginning()
        {
            string transformed = "_marker TEST string will be inserted here -->_marker But not here --X_marker".Insert("TEST").Before(2, of: "_marker").From(The.Beginning);
            transformed.Should().Be("_marker TEST string will be inserted here -->TEST_marker But not here --X_marker");
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "This _marKer will be passed by and _marker TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before(2, of: "_marker").From(The.Beginning);
            transformed.Should().Be("This _marKer will be passed by and _marker TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceFromEnd()
        {
            string transformed = "_marker TEST string will be inserted here -->_marker But not here --X_marker".Insert("TEST").Before(2, of: "_marker").From(The.End);
            transformed.Should().Be("_marker TEST string will be inserted here -->TEST_marker But not here --X_marker");
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceFromEndCaseSensitive()
        {
            string transformed = "_marker TEST string will be inserted here -->_marker, but not here --X_marker and not here --X_MarkER".Insert("TEST").Before(2, of: "_marker").From(The.End);
            transformed.Should().Be("_marker TEST string will be inserted here -->TEST_marker, but not here --X_marker and not here --X_MarkER");
        }

        #endregion

        #region Insert After

        [TestMethod]
        public void InsertNullAfterNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(null);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(null);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(String.Empty);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterNullMarker()
        {
            string transformed = Const.SampleString.Insert(null).After(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(null).After(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterMarker()
        {
            string transformed = Const.SampleString.Insert(null).After(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterNullMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterNullMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfter()
        {
            string transformed = "marker marker marker_<-- TEST string will be inserted here".Insert("TEST").After("marker_");
            transformed.Should().Be("marker marker marker_TEST<-- TEST string will be inserted here");
        }

        [TestMethod]
        public void InsertTextAfterCaseSensitive()
        {
            string transformed = "TEST string will NOT be inserted after _marker".Insert("TEST").After("_maRKer");
            transformed.Should().Be("TEST string will NOT be inserted after _marker");
        }

        #endregion

        #region Insert After Occurrence

        [TestMethod]
        public void InsertNullTextAfterOccurrenceInNullString()
        {
            string transformed = Const.NullString.Insert(null).After(3, String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterNullOccurrenceInNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void InsertNullTextAfterNullOccurrenceInNullString()
        {
            string transformed = Const.NullString.Insert(null).After(1, null);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceInNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(3, String.Empty);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void InsertNullTextAfterOccurrence()
        {
            string transformed = Const.SampleString.Insert(null).After(3, String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterNullOccurrence()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullTextAfterNullOccurrence()
        {
            string transformed = Const.SampleString.Insert(null).After(3, null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrence()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(1, String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterNonExistingOccurrence()
        {
            string transformed = Const.SampleString.Insert("TEST").After(2, "_bla");
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterOccurrence()
        {
            string transformed = "bla_ bla bla bla_<-- TEST string will be inserted here. bla_X-- But not here".Insert("TEST").After(2, of: "bla_");
            transformed.Should().Be("bla_ bla bla bla_TEST<-- TEST string will be inserted here. bla_X-- But not here");

            transformed = "bla_ bla Some other bla_ text bla_ bla bla_<-- TEST string will be inserted here. bla_X-- But not here".Insert("TEST").After(4, of: "bla_");
            transformed.Should().Be("bla_ bla Some other bla_ text bla_ bla bla_TEST<-- TEST string will be inserted here. bla_X-- But not here");
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceWithMarkerAtBeginning()
        {
            string transformed = "bla_<-- TEST string will be inserted after that _bla".Insert("TEST").After(1, of: "bla_");
            transformed.Should().Be("bla_TEST<-- TEST string will be inserted after that _bla");

            transformed = "bla_ Some other text bla_<-- TEST string will be inserted here But not here --X_bla".Insert("TEST").After(2, of: "bla_");
            transformed.Should().Be("bla_ Some other text bla_TEST<-- TEST string will be inserted here But not here --X_bla");
        }

        #endregion

        #region Insert After Occurrence From

        [TestMethod]
        public void InsertNullTextAfterOccurrenceFromBeginningOfNullString()
        {
            string transformed = Const.NullString.Insert(null).After(1, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void InsertNullTextAfterOccurrenceFromEndOfNullString()
        {
            string transformed = Const.NullString.Insert(null).After(3, String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterNullOccurrenceFromBeginningOfNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(4, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterNullOccurrenceFromEndOfNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(1, null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void InsertNullTextAfterNullOccurrenceFromBeginningOfNullString()
        {
            string transformed = Const.NullString.Insert(null).After(2, null).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void InsertNullTextAfterNullOccurrenceFromEndOfNullString()
        {
            string transformed = Const.NullString.Insert(null).After(3, null).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceFromBeginningOfNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(6, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceFromEndOfNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, String.Empty).From(The.End);
            transformed.Should().Be(Const.NullString);
        }

        [TestMethod]
        public void InsertNullTextAfterOccurrenceFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(3, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullTextAfterOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(2, String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterNullOccurrenceFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(3, null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterNullOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(1, null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullTextAfterNullOccurrenceFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(3, null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullTextAfterNullOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(2, null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(3, String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceFromBeginning()
        {
            string transformed = "bla_ bla bla bla_<-- TEST string will be inserted here. bla_X-- But not here".Insert("TEST").After(2, of: "bla_").From(The.Beginning);
            transformed.Should().Be("bla_ bla bla bla_TEST<-- TEST string will be inserted here. bla_X-- But not here");
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceFromEnd()
        {
            string transformed = "bla_ bla bla bla_<-- TEST string will be inserted here. bla_X-- But not here".Insert("TEST").After(2, of: "bla_").From(The.End);
            transformed.Should().Be("bla_ bla bla bla_TEST<-- TEST string will be inserted here. bla_X-- But not here");
        }

        #endregion
    }
}
