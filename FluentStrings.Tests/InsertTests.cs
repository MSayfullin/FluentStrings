using System;
using FluentAssertions;
using NUnit.Framework;

namespace dokas.FluentStrings.Tests
{
    [TestFixture]
    public class InsertTests
    {
        #region Insert

        [Test]
        public void InsertNullIntoNullString()
        {
            string transformed = Const.NullString.Insert(null);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertNullIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertNull()
        {
            string transformed = Const.SampleString.Insert(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyText()
        {
            string transformed = Const.SampleString.Insert(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertText()
        {
            string transformed = "<-- TEST string will be inserted here".Insert("TEST");
            transformed.Should().Be("TEST<-- TEST string will be inserted here");
        }

        #endregion

        #region Insert To

        [Test]
        public void InsertNullToTheBeginningOfNullString()
        {
            string transformed = Const.NullString.Insert(null).To(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextToTheBeginningOfNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).To(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextToTheBeginningOfNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).To(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertNullToTheBeginningOfEmptyString()
        {
            string transformed = String.Empty.Insert(null).To(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextToTheBeginningOfEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).To(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextToTheBeginningOfEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).To(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertNullToTheBeginning()
        {
            string transformed = Const.SampleString.Insert(null).To(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextToTheBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).To(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullToTheEndOfNullString()
        {
            string transformed = Const.NullString.Insert(null).To(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextToTheEndOfNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).To(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextToTheEndOfNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).To(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertNullToTheEndOfEmptyString()
        {
            string transformed = String.Empty.Insert(null).To(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextToTheEndOfEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).To(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextToTheEndOfEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).To(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertNullToTheEnd()
        {
            string transformed = Const.SampleString.Insert(null).To(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextToTheEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).To(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextToBeginning()
        {
            string transformed = "<-- TEST string will be inserted here".Insert("TEST").To(The.Beginning);
            transformed.Should().Be("TEST<-- TEST string will be inserted here");
        }

        [Test]
        public void InsertTextToEnd()
        {
            string transformed = "TEST string will be inserted here -->".Insert("TEST").To(The.End);
            transformed.Should().Be("TEST string will be inserted here -->TEST");
        }

        #endregion

        #region Insert At

        [Test]
        public void InsertNullAtPositionInNullString()
        {
            string transformed = Const.NullString.Insert(null).At(position: 2);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAtPositionInNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).At(position: 2);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAtPositionInNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).At(position: 2);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAtPositionInEmptyString()
        {
            string transformed = String.Empty.Insert(null).At(position: 2);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAtPositionInEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).At(position: 2);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAtPositionInEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).At(position: 2);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAtPosition()
        {
            string transformed = Const.SampleString.Insert(null).At(position: 2);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAtPosition()
        {
            string transformed = Const.SampleString.Insert(String.Empty).At(position: 2);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAtNegativePosition()
        {
            Action action = ()=> "<-- TEST string will be inserted here".Insert("TEST").At(position: -1).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void InsertTextAtZeroPosition()
        {
            string transformed = "<-- TEST string will be inserted here".Insert("TEST").At(position: 0);
            transformed.Should().Be("TEST<-- TEST string will be inserted here");
        }

        [Test]
        public void InsertTextAtFirstPosition()
        {
            string transformed = "!<-- TEST string will be inserted here".Insert("TEST").At(position: 1);
            transformed.Should().Be("!TEST<-- TEST string will be inserted here");
        }

        [Test]
        public void InsertTextAt()
        {
            string transformed = "!!! <-- TEST string will be inserted here".Insert("TEST").At(position: 4);
            transformed.Should().Be("!!! TEST<-- TEST string will be inserted here");
        }

        #endregion

        #region Insert At From

        [Test]
        public void InsertNullAtPositionInNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).At(position: 2).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAtPositionInNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).At(position: 2).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAtPositionInNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).At(position: 2).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAtPositionInEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).At(position: 2).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAtPositionInEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).At(position: 2).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAtPositionInEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).At(position: 2).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAtPositionFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).At(position: 2).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAtPositionFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).At(position: 2).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAtPositionInNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).At(position: 2).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAtPositionInNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).At(position: 2).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAtPositionInNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).At(position: 2).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAtPositionInEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).At(position: 2).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAtPositionInEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).At(position: 2).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAtPositionInEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).At(position: 2).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAtPositionFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).At(position: 2).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAtPositionFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).At(position: 2).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAtNegativePositionFromBeginning()
        {
            Action action = () => "<-- TEST string will be inserted here".Insert("TEST").At(position: -1).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void InsertTextAtNegativePositionFromEnd()
        {
            Action action = () => "<-- TEST string will be inserted here".Insert("TEST").At(position: -1).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void InsertTextAtZeroPositionFromBeginning()
        {
            string transformed = "<-- TEST string will be inserted here".Insert("TEST").At(position: 0).From(The.Beginning);
            transformed.Should().Be("TEST<-- TEST string will be inserted here");
        }

        [Test]
        public void InsertTextAtZeroPositionFromEnd()
        {
            string transformed = "TEST string will be inserted here -->".Insert("TEST").At(position: 0).From(The.End);
            transformed.Should().Be("TEST string will be inserted here -->TEST");
        }

        [Test]
        public void InsertTextAtFirstPositionFromBeginning()
        {
            string transformed = "!<-- TEST string will be inserted here".Insert("TEST").At(position: 1).From(The.Beginning);
            transformed.Should().Be("!TEST<-- TEST string will be inserted here");
        }

        [Test]
        public void InsertTextAtFirstPositionFromEnd()
        {
            string transformed = "TEST string will be inserted here -->!".Insert("TEST").At(position: 1).From(The.End);
            transformed.Should().Be("TEST string will be inserted here -->TEST!");
        }

        [Test]
        public void InsertTextAtPositionFromBeginning()
        {
            string transformed = "!!! <-- TEST string will be inserted here".Insert("TEST").At(position: 4).From(The.Beginning);
            transformed.Should().Be("!!! TEST<-- TEST string will be inserted here");
        }

        [Test]
        public void InsertTextAtPositionFromEnd()
        {
            string transformed = "TEST string will be inserted here --> !!!".Insert("TEST").At(position: 4).From(The.End);
            transformed.Should().Be("TEST string will be inserted here -->TEST !!!");
        }

        #endregion

        #region Insert Before All

        [Test]
        public void InsertNullBeforeAllNullMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).BeforeAll(null);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeAllEmptyMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).BeforeAll(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeAllMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeAllNullMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).BeforeAll(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeAllEmptyMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).BeforeAll(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeAllMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeAllNullMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).BeforeAll(null);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeAllEmptyMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).BeforeAll(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeAllMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeAllNullMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).BeforeAll(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeAllEmptyMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).BeforeAll(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeAllMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeAllNullMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).BeforeAll(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeAllEmptyMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).BeforeAll(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeAllMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeAllNullMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).BeforeAll(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeAllEmptyMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).BeforeAll(String.Empty);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeAllMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeAllNullMarkers()
        {
            string transformed = Const.SampleString.Insert(null).BeforeAll(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeAllEmptyMarkers()
        {
            string transformed = Const.SampleString.Insert(null).BeforeAll(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeAllMarkers()
        {
            string transformed = Const.SampleString.Insert(null).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeAllNullMarkers()
        {
            string transformed = Const.SampleString.Insert(String.Empty).BeforeAll(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeAllEmptyMarkers()
        {
            string transformed = Const.SampleString.Insert(String.Empty).BeforeAll(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeAllMarkers()
        {
            string transformed = Const.SampleString.Insert(String.Empty).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeAllNullMarkers()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).BeforeAll(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeAllEmptyMarkers()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).BeforeAll(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeAllNonExistingMarkers()
        {
            string transformed = "Some long long string".Insert("TEST").BeforeAll("marker");
            transformed.Should().Be("Some long long string");
        }

        [Test]
        public void InsertTextBeforeAll()
        {
            string transformed = "TEST string will be inserted here -->_marker".Insert("TEST").BeforeAll("_marker");
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker");
        }

        [Test]
        public void InsertTextBeforeAllMultipleTimes()
        {
            string transformed = "TEST string will be inserted here -->_marker TEST string will be inserted here -->_marker".Insert("TEST").BeforeAll("_marker");
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker TEST string will be inserted here -->TEST_marker");
        }

        [Test]
        public void InsertTextBeforeAllCaseSensitive()
        {
            string transformed = "TEST string will NOT be inserted here -->_marker".Insert("TEST").BeforeAll("_maRKer");
            transformed.Should().Be("TEST string will NOT be inserted here -->_marker");
        }

        [Test]
        public void InsertTextBeforeAllCaseSensitiveMultipleTimes()
        {
            string transformed = "TEST string will be inserted here -->_Marker, but will NOT be inserted here -->_marker".Insert("TEST").BeforeAll("_Marker");
            transformed.Should().Be("TEST string will be inserted here -->TEST_Marker, but will NOT be inserted here -->_marker");
        }

        #endregion

        #region Insert Before All Ignoring Case

        [Test]
        public void InsertNullBeforeAllNullMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeAllEmptyMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeAllMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeAllNullMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeAllEmptyMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeAllMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeAllNullMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeAllEmptyMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeAllMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeAllNullMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeAllEmptyMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeAllMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeAllNullMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeAllEmptyMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeAllMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeAllNullMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeAllEmptyMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeAllMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeAllNullMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeAllEmptyMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeAllMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeAllNullMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeAllEmptyMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeAllMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeAllNullMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeAllEmptyMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeAllMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeAllNonExistingMarkersIgnoringCase()
        {
            string transformed = "Some long long string".Insert("TEST").BeforeAll("marker").IgnoringCase();
            transformed.Should().Be("Some long long string");
        }

        [Test]
        public void InsertTextBeforeAllIgnoringCase()
        {
            string transformed = "TEST string will be inserted here -->_maRKEr".Insert("TEST").BeforeAll("_marker").IgnoringCase();
            transformed.Should().Be("TEST string will be inserted here -->TEST_maRKEr");
        }

        [Test]
        public void InsertTextBeforeAllIgnoringCaseMultipleTimes()
        {
            string transformed = "TEST string will be inserted here -->_marker TEST string will be inserted here -->_marker".Insert("TEST").BeforeAll("_MARKER").IgnoringCase();
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker TEST string will be inserted here -->TEST_marker");
        }

        #endregion

        #region Insert Before

        [Test]
        public void InsertNullBeforeNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(null);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(null);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(String.Empty);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeNullMarker()
        {
            string transformed = Const.SampleString.Insert(null).Before(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(null).Before(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeMarker()
        {
            string transformed = Const.SampleString.Insert(null).Before(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNullMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNonExistingMarker()
        {
            string transformed = "Some long long string".Insert("TEST").Before("marker");
            transformed.Should().Be("Some long long string");
        }

        [Test]
        public void InsertTextBefore()
        {
            string transformed = "TEST string will be inserted here -->_marker".Insert("TEST").Before("_marker");
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker");
        }

        [Test]
        public void InsertTextBeforeMultipleTimes()
        {
            string transformed = "TEST string will be inserted here -->_marker but NOT here --X_marker".Insert("TEST").Before("_marker");
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker but NOT here --X_marker");
        }

        [Test]
        public void InsertTextBeforeCaseSensitive()
        {
            string transformed = "TEST string will NOT be inserted here -->_marker".Insert("TEST").Before("_maRKer");
            transformed.Should().Be("TEST string will NOT be inserted here -->_marker");
        }

        [Test]
        public void InsertTextBeforeCaseSensitiveMultipleTimes()
        {
            string transformed = "This _marker will be passed by and TEST string will be inserted here -->_Marker, but will NOT be inserted here -->_Marker".Insert("TEST").Before("_Marker");
            transformed.Should().Be("This _marker will be passed by and TEST string will be inserted here -->TEST_Marker, but will NOT be inserted here -->_Marker");
        }

        #endregion

        #region Insert Before From

        [Test]
        public void InsertNullBeforeNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(null).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(null).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(null).From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNonExistingMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert("TEST").Before("_marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNonExistingMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert("TEST").Before("_marker").From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeFromBeginning()
        {
            string transformed = "TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before("_marker").From(The.Beginning);
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [Test]
        public void InsertTextBeforeFromBeginningCaseSensitive()
        {
            string transformed = "This _marKer will be passed by and TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before("_marker").From(The.Beginning);
            transformed.Should().Be("This _marKer will be passed by and TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [Test]
        public void InsertTextBeforeFromEnd()
        {
            string transformed = "_marker TEST string will be inserted here -->_marker".Insert("TEST").Before("_marker").From(The.End);
            transformed.Should().Be("_marker TEST string will be inserted here -->TEST_marker");
        }

        [Test]
        public void InsertTextBeforeFromEndCaseSensitive()
        {
            string transformed = "_marker TEST string will be inserted here -->_marker, but not here --X_MarkER".Insert("TEST").Before("_marker").From(The.End);
            transformed.Should().Be("_marker TEST string will be inserted here -->TEST_marker, but not here --X_MarkER");
        }

        [Test]
        public void InsertTextBeforeWithMarkerAtBeginningFromBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted before that _marker".Insert("TEST").Before("_marker").From(The.Beginning);
            transformed.Should().Be("TEST_marker<-- TEST string will be inserted before that _marker");
        }

        #endregion

        #region Insert Before Ignoring Case

        [Test]
        public void InsertNullBeforeNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(null).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(null).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).Before(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNonExistingMarkerIgnoringCase()
        {
            string transformed = "Some long long string".Insert("TEST").Before("marker").IgnoringCase();
            transformed.Should().Be("Some long long string");
        }

        [Test]
        public void InsertTextBeforeIgnoringCase()
        {
            string transformed = "TEST string will be inserted here -->_marker".Insert("TEST").Before("_mArkEr").IgnoringCase();
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker");
        }

        [Test]
        public void InsertTextBeforeIgnoringCaseMultipleTimes()
        {
            string transformed = "TEST string will be inserted here -->_MARKer but NOT here --X_marker".Insert("TEST").Before("_markER").IgnoringCase();
            transformed.Should().Be("TEST string will be inserted here -->TEST_MARKer but NOT here --X_marker");
        }

        #endregion

        #region Insert Before Ignoring Case From

        [Test]
        public void InsertNullBeforeNullMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeNullMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(null).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeNullMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeNullMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeNullMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeNullMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeNullMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeNullMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeNullMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeNullMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeNullMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNullMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNullMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNonExistingMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert("TEST").Before("_marker").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNonExistingMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert("TEST").Before("_marker").IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeIgnoringCaseFromBeginning()
        {
            string transformed = "TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before("_MARKER").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [Test]
        public void InsertTextBeforeIgnoringCaseFromEnd()
        {
            string transformed = "_marker TEST string will be inserted here -->_MARKER".Insert("TEST").Before("_marker").IgnoringCase().From(The.End);
            transformed.Should().Be("_marker TEST string will be inserted here -->TEST_MARKER");
        }

        [Test]
        public void InsertTextBeforeWithMarkerAtBeginningIgnoringCaseFromBeginning()
        {
            string transformed = "_mARKEr<-- TEST string will be inserted before that _marker".Insert("TEST").Before("_marker").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("TEST_mARKEr<-- TEST string will be inserted before that _marker");
        }

        #endregion

        #region Insert Before Occurrence

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(1, of: null);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(2, of: String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(3, of: Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(2, of: null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(1, of: String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(1, of: Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(2, of: null);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(1, of: String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(1, of: Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(2, of: null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(5, of: String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(5, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(1, of: null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(1, of: String.Empty);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(2, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarker()
        {
            string transformed = Const.SampleString.Insert(null).Before(1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(null).Before(2, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarker()
        {
            string transformed = Const.SampleString.Insert(null).Before(1, of: Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(1, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(2, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNegativeOccurrenceOfMarker()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).Before(-1, of: Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void InsertTextBeforeZeroOccurrenceOfMarker()
        {
            string transformed = "Some long long string with marker".Insert("TEST").Before(0, of: "marker");
            transformed.Should().Be("Some long long string with marker");
        }

        [Test]
        public void InsertTextBeforeNonExistingMarkerOccurrence()
        {
            string transformed = Const.SampleString.Insert("TEST").Before(1, of: "_marker");
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrence()
        {
            string transformed = "TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before(1, of: "_marker");
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [Test]
        public void InsertTextBeforeOccurrenceCaseSensitive()
        {
            string transformed = "This _Marker will be passed by and TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before(1, of: "_marker");
            transformed.Should().Be("This _Marker will be passed by and TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [Test]
        public void InsertTextBeforeOccurrenceInLongerstring()
        {
            string transformed = "_marker Some Another Text _marker _marker And again text _marker TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before(5, of: "_marker");
            transformed.Should().Be("_marker Some Another Text _marker _marker And again text _marker TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [Test]
        public void InsertTextBeforeOccurrenceWithMarkerAtBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted before that _marker".Insert("TEST").Before(1, of: "_marker");
            transformed.Should().Be("TEST_marker<-- TEST string will be inserted before that _marker");
        }

        #endregion

        #region Insert Before Occurrence Ignoring Case

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNegativeOccurrenceOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).Before(-1, of: Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void InsertTextBeforeZeroOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = "Some long long string with marker".Insert("TEST").Before(0, of: "marKER").IgnoringCase();
            transformed.Should().Be("Some long long string with marker");
        }

        [Test]
        public void InsertTextBeforeNonExistingMarkerOccurrenceIgnoringCase()
        {
            string transformed = Const.SampleString.Insert("TEST").Before(1, of: "_marker").IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceIgnoringCase()
        {
            string transformed = "TEST string will be inserted here -->_MARKER, but not here --X_marker".Insert("TEST").Before(1, of: "_marker").IgnoringCase();
            transformed.Should().Be("TEST string will be inserted here -->TEST_MARKER, but not here --X_marker");
        }

        [Test]
        public void InsertTextBeforeOccurrenceIgnoringCaseInLongerstring()
        {
            string transformed = "_MARKER Some Another Text _marker _MARKER And again text _marker TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before(5, of: "_maRKer").IgnoringCase();
            transformed.Should().Be("_MARKER Some Another Text _marker _MARKER And again text _marker TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [Test]
        public void InsertTextBeforeOccurrenceWithMarkerIgnoringCaseAtBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted before that _marker".Insert("TEST").Before(1, of: "_MARKER").IgnoringCase();
            transformed.Should().Be("TEST_marker<-- TEST string will be inserted before that _marker");
        }

        #endregion

        #region Insert Before Occurrence From

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(1, of: null).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(3, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(2, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(1, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(2, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(1, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(2, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(5, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(5, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(3, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(1, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(1, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(1, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(1, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNegativeOccurrenceOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).Before(-1, of: Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void InsertTextBeforeZeroOccurrenceOfMarkerFromBeginning()
        {
            string transformed = "Some long long string with marker".Insert("TEST").Before(0, of: "marker").From(The.Beginning);
            transformed.Should().Be("Some long long string with marker");
        }

        [Test]
        public void InsertTextBeforeNonExistingMarkerOccurrenceFromBeginning()
        {
            string transformed = Const.SampleString.Insert("TEST").Before(1, of: "_marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(1, of: null).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(2, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(3, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(2, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(1, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(2, of: null).From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(1, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(2, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(5, of: String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(5, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(3, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(1, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(1, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(1, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(1, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNegativeOccurrenceOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).Before(-1, of: Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void InsertTextBeforeZeroOccurrenceOfMarkerFromEnd()
        {
            string transformed = "Some long long string with marker".Insert("TEST").Before(0, of: "marker").From(The.End);
            transformed.Should().Be("Some long long string with marker");
        }

        [Test]
        public void InsertTextBeforeNonExistingMarkerOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Insert("TEST").Before(1, of: "_marker").From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceFromBeginning()
        {
            string transformed = "_marker TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before(2, of: "_marker").From(The.Beginning);
            transformed.Should().Be("_marker TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [Test]
        public void InsertTextBeforeOccurrenceFromBeginningCaseSensitive()
        {
            string transformed = "This _marKer will be passed by and _marker TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before(2, of: "_marker").From(The.Beginning);
            transformed.Should().Be("This _marKer will be passed by and _marker TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [Test]
        public void InsertTextBeforeOccurrenceFromEnd()
        {
            string transformed = "_marker TEST string will be inserted here -->_marker But not here --X_marker".Insert("TEST").Before(2, of: "_marker").From(The.End);
            transformed.Should().Be("_marker TEST string will be inserted here -->TEST_marker But not here --X_marker");
        }

        [Test]
        public void InsertTextBeforeOccurrenceFromEndCaseSensitive()
        {
            string transformed = "_marker TEST string will be inserted here -->_marker, but not here --X_marker and not here --X_MarkER".Insert("TEST").Before(2, of: "_marker").From(The.End);
            transformed.Should().Be("_marker TEST string will be inserted here -->TEST_marker, but not here --X_marker and not here --X_MarkER");
        }

        [Test]
        public void InsertTextBeforeOccurrenceWithMarkerAtBeginningFromBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted before that _marker".Insert("TEST").Before(1, of: "_marker").From(The.Beginning);
            transformed.Should().Be("TEST_marker<-- TEST string will be inserted before that _marker");
        }

        #endregion

        #region Insert Before Occurrence Ignoring Case From

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(3, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(3, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(3, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(3, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(3, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(3, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(3, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(3, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(3, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(3, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(3, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(3, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(3, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(3, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(3, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(3, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(3, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(3, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(3, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(3, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(3, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(3, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(3, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(3, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(3, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfNullMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(3, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(3, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(3, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullBeforeOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(3, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(3, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(3, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(3, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(3, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(3, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfNullMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(3, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(3, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(3, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNegativeOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).Before(-1, of: Const.SampleMarker).IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void InsertTextBeforeZeroOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = "Some long long string with marker".Insert("TEST").Before(0, of: "marker").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some long long string with marker");
        }

        [Test]
        public void InsertTextBeforeNonExistingMarkerOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert("TEST").Before(1, of: "_marker").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeNegativeOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).Before(-1, of: Const.SampleMarker).IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void InsertTextBeforeZeroOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = "Some long long string with marker".Insert("TEST").Before(0, of: "marker").IgnoringCase().From(The.End);
            transformed.Should().Be("Some long long string with marker");
        }

        [Test]
        public void InsertTextBeforeNonExistingMarkerOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert("TEST").Before(1, of: "_marker").IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextBeforeOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "_MARKER TEST string will be inserted here -->_mARKEr, but not here --X_marker".Insert("TEST").Before(2, of: "_marker").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("_MARKER TEST string will be inserted here -->TEST_mARKEr, but not here --X_marker");
        }

        [Test]
        public void InsertTextBeforeOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "_marker TEST string will be inserted here -->_marker But not here --X_maRKer".Insert("TEST").Before(2, of: "_MArker").IgnoringCase().From(The.End);
            transformed.Should().Be("_marker TEST string will be inserted here -->TEST_marker But not here --X_maRKer");
        }

        [Test]
        public void InsertTextBeforeOccurrenceWithMarkerIgnoringCaseAtBeginningFromBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted before that _marker".Insert("TEST").Before(1, of: "_MARKER").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("TEST_marker<-- TEST string will be inserted before that _marker");
        }

        #endregion

        #region Insert After All

        [Test]
        public void InsertNullAfterAllNullMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).AfterAll(null);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterAllEmptyMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).AfterAll(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterAllMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).AfterAll(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterAllNullMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).AfterAll(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterAllEmptyMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).AfterAll(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterAllMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).AfterAll(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterAllNullMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).AfterAll(null);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterAllEmptyMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).AfterAll(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterAllMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).AfterAll(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterAllNullMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).AfterAll(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterAllEmptyMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).AfterAll(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterAllMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).AfterAll(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterAllNullMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).AfterAll(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterAllEmptyMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).AfterAll(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterAllMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).AfterAll(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterAllNullMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).AfterAll(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterAllEmptyMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).AfterAll(String.Empty);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterAllMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).AfterAll(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterAllNullMarkers()
        {
            string transformed = Const.SampleString.Insert(null).AfterAll(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterAllEmptyMarkers()
        {
            string transformed = Const.SampleString.Insert(null).AfterAll(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterAllMarkers()
        {
            string transformed = Const.SampleString.Insert(null).AfterAll(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterAllNullMarkers()
        {
            string transformed = Const.SampleString.Insert(String.Empty).AfterAll(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterAllEmptyMarkers()
        {
            string transformed = Const.SampleString.Insert(String.Empty).AfterAll(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterAllMarkers()
        {
            string transformed = Const.SampleString.Insert(String.Empty).AfterAll(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterAllNullMarkers()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).AfterAll(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterAllEmptyMarkers()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).AfterAll(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterAllNonExistingMarkers()
        {
            string transformed = "Some long long string".Insert("value").AfterAll("marker");
            transformed.Should().Be("Some long long string");
        }

        [Test]
        public void InsertTextAfterAll()
        {
            string transformed = "marker marker marker_<-- TEST string will be inserted here".Insert("TEST").AfterAll("marker_");
            transformed.Should().Be("marker marker marker_TEST<-- TEST string will be inserted here");
        }

        [Test]
        public void InsertTextAfterAllCaseSensitive()
        {
            string transformed = "TEST string will NOT be inserted after _marker".Insert("TEST").AfterAll("_maRKer");
            transformed.Should().Be("TEST string will NOT be inserted after _marker");
        }

        [Test]
        public void InsertTextAfterAllMultipleTimes()
        {
            string transformed = "marker_ marker marker_<-- TEST string will be inserted here".Insert("TEST").AfterAll("marker_");
            transformed.Should().Be("marker_TEST marker marker_TEST<-- TEST string will be inserted here");
        }

        [Test]
        public void InsertTextAfterAllMultipleTimesCaseSensitive()
        {
            string transformed = "Marker_ marker_ marker Marker_ marker_<-- TEST string will be inserted here".Insert("TEST").AfterAll("marker_");
            transformed.Should().Be("Marker_ marker_TEST marker Marker_ marker_TEST<-- TEST string will be inserted here");
        }

        #endregion

        #region Insert After All Ignoring Case

        [Test]
        public void InsertNullAfterAllNullMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).AfterAll(null).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterAllEmptyMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterAllMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterAllNullMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).AfterAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterAllEmptyMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterAllMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterAllNullMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).AfterAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterAllEmptyMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterAllMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterAllNullMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).AfterAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterAllEmptyMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterAllMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterAllNullMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).AfterAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterAllEmptyMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterAllMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterAllNullMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).AfterAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterAllEmptyMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterAllMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterAllNullMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).AfterAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterAllEmptyMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterAllMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterAllNullMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).AfterAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterAllEmptyMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterAllMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterAllNullMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).AfterAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterAllEmptyMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterAllNonExistingMarkersIgnoringCase()
        {
            string transformed = "Some long long string".Insert("value").AfterAll("MARKER").IgnoringCase();
            transformed.Should().Be("Some long long string");
        }

        [Test]
        public void InsertTextAfterAllIgnoringCase()
        {
            string transformed = "marker marker marker_<-- TEST string will be inserted here".Insert("TEST").AfterAll("MARKER_").IgnoringCase();
            transformed.Should().Be("marker marker marker_TEST<-- TEST string will be inserted here");
        }

        [Test]
        public void InsertTextAfterAllIgnoringCaseMultipleTimes()
        {
            string transformed = "marker_ marker marker_<-- TEST string will be inserted here".Insert("TEST").AfterAll("MARker_").IgnoringCase();
            transformed.Should().Be("marker_TEST marker marker_TEST<-- TEST string will be inserted here");
        }

        #endregion

        #region Insert After

        [Test]
        public void InsertNullAfterNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(null);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(null);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(String.Empty);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterNullMarker()
        {
            string transformed = Const.SampleString.Insert(null).After(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(null).After(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterMarker()
        {
            string transformed = Const.SampleString.Insert(null).After(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNullMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNonExistingMarker()
        {
            string transformed = "Some long long string".Insert("value").After("marker");
            transformed.Should().Be("Some long long string");
        }

        [Test]
        public void InsertTextAfter()
        {
            string transformed = "marker marker marker_<-- TEST string will be inserted here".Insert("TEST").After("marker_");
            transformed.Should().Be("marker marker marker_TEST<-- TEST string will be inserted here");
        }

        [Test]
        public void InsertTextAfterCaseSensitive()
        {
            string transformed = "TEST string will NOT be inserted after _marker".Insert("TEST").After("_maRKer");
            transformed.Should().Be("TEST string will NOT be inserted after _marker");
        }

        [Test]
        public void InsertTextAfterMultipleTimes()
        {
            string transformed = "marker_<-- TEST string will be inserted ONLY here despite these marker_ marker".Insert("TEST").After("marker_");
            transformed.Should().Be("marker_TEST<-- TEST string will be inserted ONLY here despite these marker_ marker");
        }

        [Test]
        public void InsertTextAfterMultipleTimesCaseSensitive()
        {
            string transformed = "Marker_ marker_<-- TEST string will be inserted ONLY here despite this MARKER_".Insert("TEST").After("marker_");
            transformed.Should().Be("Marker_ marker_TEST<-- TEST string will be inserted ONLY here despite this MARKER_");
        }

        #endregion

        #region Insert After From

        [Test]
        public void InsertNullAfterNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).After(null).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).After(null).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).After(String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).After(String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).After(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).After(Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(null).From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).After(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).After(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).After(String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).After(String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).After(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).After(Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).After(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).After(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).After(String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).After(String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).After(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).After(Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNonExistingMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert("TEST").After("_marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNonExistingMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert("TEST").After("_marker").From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterFromBeginning()
        {
            string transformed = "TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After("_marker").From(The.Beginning);
            transformed.Should().Be("TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [Test]
        public void InsertTextAfterFromEnd()
        {
            string transformed = "TEST string will NOT be inserted after this --X_marker, but after this -->_marker".Insert("TEST").After("_marker").From(The.End);
            transformed.Should().Be("TEST string will NOT be inserted after this --X_marker, but after this -->_markerTEST");
        }

        [Test]
        public void InsertTextAfterCaseSensitiveFromBeginning()
        {
            string transformed = "This _Marker will be passed by and TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After("_marker").From(The.Beginning);
            transformed.Should().Be("This _Marker will be passed by and TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [Test]
        public void InsertTextAfterCaseSensitiveFromEnd()
        {
            string transformed = "TEST string will NOT be inserted after this --X_marker, but after this -->_marker, but this _Marker will be passed by".Insert("TEST").After("_marker").From(The.End);
            transformed.Should().Be("TEST string will NOT be inserted after this --X_marker, but after this -->_markerTEST, but this _Marker will be passed by");
        }

        [Test]
        public void InsertTextAfterWithMarkerAtBeginningFromBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted after that _marker".Insert("TEST").After("_marker").From(The.Beginning);
            transformed.Should().Be("_markerTEST<-- TEST string will be inserted after that _marker");
        }

        #endregion

        #region Insert After Ignoring Case

        [Test]
        public void InsertNullAfterNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(null).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(null).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).After(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).After(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNonExistingMarkerIgnoringCase()
        {
            string transformed = "Some long long string".Insert("value").After("marker").IgnoringCase();
            transformed.Should().Be("Some long long string");
        }

        [Test]
        public void InsertTextAfterIgnoringCase()
        {
            string transformed = "marker marker MARKER_<-- TEST string will be inserted here".Insert("TEST").After("marker_").IgnoringCase();
            transformed.Should().Be("marker marker MARKER_TEST<-- TEST string will be inserted here");
        }

        [Test]
        public void InsertTextAfterIgnoringCaseMultipleTimes()
        {
            string transformed = "mArKer_<-- TEST string will be inserted ONLY here despite these MARKER_ marker".Insert("TEST").After("marker_").IgnoringCase();
            transformed.Should().Be("mArKer_TEST<-- TEST string will be inserted ONLY here despite these MARKER_ marker");
        }

        #endregion

        #region Insert After Ignoring Case From

        [Test]
        public void InsertNullAfterNullMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).After(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterNullMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).After(null).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).After(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).After(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).After(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).After(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterNullMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterNullMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterNullMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).After(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterNullMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).After(null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).After(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).After(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).After(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).After(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).After(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).After(null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).After(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).After(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).After(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).After(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterNullMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterNullMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterNullMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterNullMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterNullMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNullMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNullMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNonExistingMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert("TEST").After("_marker").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNonExistingMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert("TEST").After("_marker").IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterIgnoringCaseFromBeginning()
        {
            string transformed = "TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After("_marker").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [Test]
        public void InsertTextAfterIgnoringCaseFromEnd()
        {
            string transformed = "TEST string will NOT be inserted after this --X_MARKER, but after this -->_marker".Insert("TEST").After("_Marker").IgnoringCase().From(The.End);
            transformed.Should().Be("TEST string will NOT be inserted after this --X_MARKER, but after this -->_markerTEST");
        }

        [Test]
        public void InsertTextAfterWithMarkerIgnoringCaseAtBeginningFromBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted after that _marker".Insert("TEST").After("_MArkER").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("_markerTEST<-- TEST string will be inserted after that _marker");
        }

        #endregion

        #region Insert After Occurrence

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(3, of: null);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(3, of: String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(3, of: Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(3, of: String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(3, of: Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(3, of: null);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(3, of: String.Empty);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(3, of: Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(3, of: String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(3, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(3, of: String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(3, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(3, of: String.Empty);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(3, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarker()
        {
            string transformed = Const.SampleString.Insert(null).After(3, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(null).After(3, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarker()
        {
            string transformed = Const.SampleString.Insert(null).After(3, of: Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(3, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(3, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(3, of: Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(3, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(3, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNegativeOccurrenceOfMarker()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).After(-1, of: Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void InsertTextAfterZeroOccurrenceOfMarker()
        {
            string transformed = "Some long long string with marker".Insert("TEST").After(0, of: "marker");
            transformed.Should().Be("Some long long string with marker");
        }

        [Test]
        public void InsertTextAfterNonExistingMarkerOccurrence()
        {
            string transformed = Const.SampleString.Insert("TEST").After(1, of: "_marker");
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrence()
        {
            string transformed = "TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After(1, of: "_marker");
            transformed.Should().Be("TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [Test]
        public void InsertTextAfterOccurrenceCaseSensitive()
        {
            string transformed = "This _Marker will be passed by and TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After(1, of: "_marker");
            transformed.Should().Be("This _Marker will be passed by and TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [Test]
        public void InsertTextAfterOccurrenceInLongerstring()
        {
            string transformed = "_marker Some Another Text _marker _marker And again text _marker TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After(5, of: "_marker");
            transformed.Should().Be("_marker Some Another Text _marker _marker And again text _marker TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [Test]
        public void InsertTextAfterOccurrenceWithMarkerAtBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted after that _marker".Insert("TEST").After(1, of: "_marker");
            transformed.Should().Be("_markerTEST<-- TEST string will be inserted after that _marker");
        }

        #endregion

        #region Insert After Occurrence Ignoring Case

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(3, of: null).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(3, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(3, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(3, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(3, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(3, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).After(3, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(3, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(3, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNegativeOccurrenceOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).After(-1, of: Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void InsertTextAfterZeroOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = "Some long long string with marker".Insert("TEST").After(0, of: "MARKER").IgnoringCase();
            transformed.Should().Be("Some long long string with marker");
        }

        [Test]
        public void InsertTextAfterNonExistingMarkerOccurrenceIgnoringCase()
        {
            string transformed = Const.SampleString.Insert("TEST").After(1, of: "_marKER").IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrenceIgnoringCase()
        {
            string transformed = "TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After(1, of: "_MARKER").IgnoringCase();
            transformed.Should().Be("TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [Test]
        public void InsertTextAfterOccurrenceIgnoringCaseInLongerstring()
        {
            string transformed = "_MARKER Some Another Text _maRKER _marker And again text _mArKeR TEST string will be inserted after this -->_maRKer, but not after this --X_marker"
                .Insert("TEST").After(5, of: "_marker").IgnoringCase();
            transformed.Should().Be("_MARKER Some Another Text _maRKER _marker And again text _mArKeR TEST string will be inserted after this -->_maRKerTEST, but not after this --X_marker");
        }

        [Test]
        public void InsertTextAfterOccurrenceIgnoringCaseWithMarkerAtBeginning()
        {
            string transformed = "_MARKer<-- TEST string will be inserted after that _marker".Insert("TEST").After(1, of: "_maRKER").IgnoringCase();
            transformed.Should().Be("_MARKerTEST<-- TEST string will be inserted after that _marker");
        }

        #endregion

        #region Insert After Occurrence From

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: null).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: null).From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).After(2, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(2, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNegativeOccurrenceOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).After(-1, of: Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void InsertTextAfterNegativeOccurrenceOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).After(-1, of: Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void InsertTextAfterZeroOccurrenceOfMarkerFromBeginning()
        {
            string transformed = "Some long long string with marker".Insert("TEST").After(0, of: "marker").From(The.Beginning);
            transformed.Should().Be("Some long long string with marker");
        }

        [Test]
        public void InsertTextAfterZeroOccurrenceOfMarkerFromEnd()
        {
            string transformed = "Some long long string with marker".Insert("TEST").After(0, of: "marker").From(The.End);
            transformed.Should().Be("Some long long string with marker");
        }

        [Test]
        public void InsertTextAfterNonExistingMarkerOccurrenceFromBeginning()
        {
            string transformed = Const.SampleString.Insert("TEST").After(1, of: "_marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNonExistingMarkerOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Insert("TEST").After(1, of: "_marker").From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrenceFromBeginning()
        {
            string transformed = "TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After(1, of: "_marker").From(The.Beginning);
            transformed.Should().Be("TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [Test]
        public void InsertTextAfterOccurrenceFromEnd()
        {
            string transformed = "TEST string will NOT be inserted after this --X_marker, but after this -->_marker".Insert("TEST").After(1, of: "_marker").From(The.End);
            transformed.Should().Be("TEST string will NOT be inserted after this --X_marker, but after this -->_markerTEST");
        }

        [Test]
        public void InsertTextAfterOccurrenceCaseSensitiveFromBeginning()
        {
            string transformed = "This _Marker will be passed by and TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After(1, of: "_marker").From(The.Beginning);
            transformed.Should().Be("This _Marker will be passed by and TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [Test]
        public void InsertTextAfterOccurrenceCaseSensitiveFromEnd()
        {
            string transformed = "TEST string will NOT be inserted after this --X_marker, but after this -->_marker, but this _Marker will be passed by".Insert("TEST").After(1, of: "_marker").From(The.End);
            transformed.Should().Be("TEST string will NOT be inserted after this --X_marker, but after this -->_markerTEST, but this _Marker will be passed by");
        }

        [Test]
        public void InsertTextAfterOccurrenceWithMarkerAtBeginningFromBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted after that _marker".Insert("TEST").After(1, of: "_marker").From(The.Beginning);
            transformed.Should().Be("_markerTEST<-- TEST string will be inserted after that _marker");
        }

        #endregion

        #region Insert After Occurrence Ignoring Case From

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfMarkerIgnoringCaseIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfMarkerIgnoringCaseIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(null);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).After(2, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).After(2, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).After(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).After(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).After(2, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).After(2, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfMarkerIgnoringCaseIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfMarkerIgnoringCaseIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfNullMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertNullAfterOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: Const.SampleMarker).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: Const.SampleMarker).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(2, of: null).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfNullMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(2, of: null).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(2, of: String.Empty).IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(2, of: String.Empty).IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNegativeOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).After(-1, of: Const.SampleMarker).IgnoringCase().From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void InsertTextAfterNegativeOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).After(-1, of: Const.SampleMarker).IgnoringCase().From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void InsertTextAfterZeroOccurrenceOfMarkerIgnoringCaseFromBeginning()
        {
            string transformed = "Some long long string with marker".Insert("TEST").After(0, of: "marker").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("Some long long string with marker");
        }

        [Test]
        public void InsertTextAfterZeroOccurrenceOfMarkerIgnoringCaseFromEnd()
        {
            string transformed = "Some long long string with marker".Insert("TEST").After(0, of: "marker").IgnoringCase().From(The.End);
            transformed.Should().Be("Some long long string with marker");
        }

        [Test]
        public void InsertTextAfterNonExistingMarkerOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = Const.SampleString.Insert("TEST").After(1, of: "_marker").IgnoringCase().From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterNonExistingMarkerOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = Const.SampleString.Insert("TEST").After(1, of: "_marker").IgnoringCase().From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [Test]
        public void InsertTextAfterOccurrenceIgnoringCaseFromBeginning()
        {
            string transformed = "TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After(1, of: "_MARKER").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [Test]
        public void InsertTextAfterOccurrenceIgnoringCaseFromEnd()
        {
            string transformed = "TEST string will NOT be inserted after this --X_marKER, but after this -->_MARKer".Insert("TEST").After(1, of: "_maRKer").IgnoringCase().From(The.End);
            transformed.Should().Be("TEST string will NOT be inserted after this --X_marKER, but after this -->_MARKerTEST");
        }

        [Test]
        public void InsertTextAfterOccurrenceWithMarkerIgnoringCaseAtBeginningFromBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted after that _marker".Insert("TEST").After(1, of: "_MARKER").IgnoringCase().From(The.Beginning);
            transformed.Should().Be("_markerTEST<-- TEST string will be inserted after that _marker");
        }

        #endregion
    }
}
