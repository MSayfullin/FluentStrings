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

        #region Insert Before All

        [TestMethod]
        public void InsertNullBeforeAllNullMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).BeforeAll(null);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeAllEmptyMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).BeforeAll(String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeAllMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllNullMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).BeforeAll(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllEmptyMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).BeforeAll(String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeAllNullMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).BeforeAll(null);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeAllEmptyMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).BeforeAll(String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeAllMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeAllNullMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).BeforeAll(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeAllEmptyMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).BeforeAll(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeAllMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllNullMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).BeforeAll(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllEmptyMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).BeforeAll(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeAllNullMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).BeforeAll(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeAllEmptyMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).BeforeAll(String.Empty);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeAllMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeAllNullMarkers()
        {
            string transformed = Const.SampleString.Insert(null).BeforeAll(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeAllEmptyMarkers()
        {
            string transformed = Const.SampleString.Insert(null).BeforeAll(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeAllMarkers()
        {
            string transformed = Const.SampleString.Insert(null).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllNullMarkers()
        {
            string transformed = Const.SampleString.Insert(String.Empty).BeforeAll(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllEmptyMarkers()
        {
            string transformed = Const.SampleString.Insert(String.Empty).BeforeAll(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllMarkers()
        {
            string transformed = Const.SampleString.Insert(String.Empty).BeforeAll(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeAllNullMarkers()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).BeforeAll(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeAllEmptyMarkers()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).BeforeAll(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeAllNonExistingMarkers()
        {
            string transformed = "Some long long string".Insert("TEST").BeforeAll("marker");
            transformed.Should().Be("Some long long string");
        }

        [TestMethod]
        public void InsertTextBeforeAll()
        {
            string transformed = "TEST string will be inserted here -->_marker".Insert("TEST").BeforeAll("_marker");
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker");
        }

        [TestMethod]
        public void InsertTextBeforeAllMultipleTimes()
        {
            string transformed = "TEST string will be inserted here -->_marker TEST string will be inserted here -->_marker".Insert("TEST").BeforeAll("_marker");
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker TEST string will be inserted here -->TEST_marker");
        }

        [TestMethod]
        public void InsertTextBeforeAllCaseSensitive()
        {
            string transformed = "TEST string will NOT be inserted here -->_marker".Insert("TEST").BeforeAll("_maRKer");
            transformed.Should().Be("TEST string will NOT be inserted here -->_marker");
        }

        [TestMethod]
        public void InsertTextBeforeAllCaseSensitiveMultipleTimes()
        {
            string transformed = "TEST string will be inserted here -->_Marker, but will NOT be inserted here -->_marker".Insert("TEST").BeforeAll("_Marker");
            transformed.Should().Be("TEST string will be inserted here -->TEST_Marker, but will NOT be inserted here -->_marker");
        }

        #endregion

        #region Insert Before All Ignoring Case

        [TestMethod]
        public void InsertNullBeforeAllNullMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeAllEmptyMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeAllMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllNullMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllEmptyMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeAllNullMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeAllEmptyMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeAllMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeAllNullMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeAllEmptyMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeAllMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllNullMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllEmptyMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeAllNullMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeAllEmptyMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeAllMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeAllNullMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeAllEmptyMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeAllMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllNullMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllEmptyMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeAllMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeAllNullMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).BeforeAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeAllEmptyMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).BeforeAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeAllMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).BeforeAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeAllNonExistingMarkersIgnoringCase()
        {
            string transformed = "Some long long string".Insert("TEST").BeforeAll("marker").IgnoringCase();
            transformed.Should().Be("Some long long string");
        }

        [TestMethod]
        public void InsertTextBeforeAllIgnoringCase()
        {
            string transformed = "TEST string will be inserted here -->_maRKEr".Insert("TEST").BeforeAll("_marker").IgnoringCase();
            transformed.Should().Be("TEST string will be inserted here -->TEST_maRKEr");
        }

        [TestMethod]
        public void InsertTextBeforeAllIgnoringCaseMultipleTimes()
        {
            string transformed = "TEST string will be inserted here -->_marker TEST string will be inserted here -->_marker".Insert("TEST").BeforeAll("_MARKER").IgnoringCase();
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker TEST string will be inserted here -->TEST_marker");
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
        public void InsertTextBeforeNonExistingMarker()
        {
            string transformed = "Some long long string".Insert("TEST").Before("marker");
            transformed.Should().Be("Some long long string");
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
            string transformed = "TEST string will be inserted here -->_marker but NOT here --X_marker".Insert("TEST").Before("_marker");
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker but NOT here --X_marker");
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
            string transformed = "This _marker will be passed by and TEST string will be inserted here -->_Marker, but will NOT be inserted here -->_Marker".Insert("TEST").Before("_Marker");
            transformed.Should().Be("This _marker will be passed by and TEST string will be inserted here -->TEST_Marker, but will NOT be inserted here -->_Marker");
        }

        #endregion

        #region Insert Before From

        [TestMethod]
        public void InsertNullBeforeNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(null).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(null).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(null).From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeNonExistingFromBeginning()
        {
            string transformed = Const.SampleString.Insert("TEST").Before("_marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeNonExistingFromEnd()
        {
            string transformed = Const.SampleString.Insert("TEST").Before("_marker").From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeFromBeginning()
        {
            string transformed = "TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before("_marker").From(The.Beginning);
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [TestMethod]
        public void InsertTextBeforeFromBeginningCaseSensitive()
        {
            string transformed = "This _marKer will be passed by and TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before("_marker").From(The.Beginning);
            transformed.Should().Be("This _marKer will be passed by and TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [TestMethod]
        public void InsertTextBeforeFromEnd()
        {
            string transformed = "_marker TEST string will be inserted here -->_marker".Insert("TEST").Before("_marker").From(The.End);
            transformed.Should().Be("_marker TEST string will be inserted here -->TEST_marker");
        }

        [TestMethod]
        public void InsertTextBeforeFromEndCaseSensitive()
        {
            string transformed = "_marker TEST string will be inserted here -->_marker, but not here --X_MarkER".Insert("TEST").Before("_marker").From(The.End);
            transformed.Should().Be("_marker TEST string will be inserted here -->TEST_marker, but not here --X_MarkER");
        }

        [TestMethod]
        public void InsertTextBeforeWithMarkerAtBeginningFromBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted before that _marker".Insert("TEST").Before("_marker").From(The.Beginning);
            transformed.Should().Be("TEST_marker<-- TEST string will be inserted before that _marker");
        }

        #endregion

        #region Insert Before Ignoring Case

        [TestMethod]
        public void InsertNullBeforeNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(null).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(null).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).Before(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeNonExistingMarkerIgnoringCase()
        {
            string transformed = "Some long long string".Insert("TEST").Before("marker").IgnoringCase();
            transformed.Should().Be("Some long long string");
        }

        [TestMethod]
        public void InsertTextBeforeIgnoringCase()
        {
            string transformed = "TEST string will be inserted here -->_marker".Insert("TEST").Before("_mArkEr").IgnoringCase();
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker");
        }

        [TestMethod]
        public void InsertTextBeforeIgnoringCaseMultipleTimes()
        {
            string transformed = "TEST string will be inserted here -->_MARKer but NOT here --X_marker".Insert("TEST").Before("_markER").IgnoringCase();
            transformed.Should().Be("TEST string will be inserted here -->TEST_MARKer but NOT here --X_marker");
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
            string transformed = "TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before(1, of: "_marker");
            transformed.Should().Be("TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceCaseSensitive()
        {
            string transformed = "This _Marker will be passed by and TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before(1, of: "_marker");
            transformed.Should().Be("This _Marker will be passed by and TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceInLongerstring()
        {
            string transformed = "_marker Some Another Text _marker _marker And again text _marker TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before(5, of: "_marker");
            transformed.Should().Be("_marker Some Another Text _marker _marker And again text _marker TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceWithMarkerAtBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted before that _marker".Insert("TEST").Before(1, of: "_marker");
            transformed.Should().Be("TEST_marker<-- TEST string will be inserted before that _marker");
        }

        #endregion

        #region Insert Before Occurrence Ignoring Case

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullBeforeOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextBeforeOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(2, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(2, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).Before(2, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeNegativeOccurrenceOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).Before(-1, of: Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void InsertTextBeforeZeroOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = "Some long long string with marker".Insert("TEST").Before(0, of: "marKER").IgnoringCase();
            transformed.Should().Be("Some long long string with marker");
        }

        [TestMethod]
        public void InsertTextBeforeNonExistingOccurrenceIgnoringCase()
        {
            string transformed = Const.SampleString.Insert("TEST").Before(1, of: "_marker").IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceIgnoringCase()
        {
            string transformed = "TEST string will be inserted here -->_MARKER, but not here --X_marker".Insert("TEST").Before(1, of: "_marker").IgnoringCase();
            transformed.Should().Be("TEST string will be inserted here -->TEST_MARKER, but not here --X_marker");
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceIgnoringCaseInLongerstring()
        {
            string transformed = "_MARKER Some Another Text _marker _MARKER And again text _marker TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before(5, of: "_maRKer").IgnoringCase();
            transformed.Should().Be("_MARKER Some Another Text _marker _MARKER And again text _marker TEST string will be inserted here -->TEST_marker, but not here --X_marker");
        }

        [TestMethod]
        public void InsertTextBeforeOccurrenceWithMarkerIgnoringCaseAtBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted before that _marker".Insert("TEST").Before(1, of: "_MARKER").IgnoringCase();
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
            string transformed = "_marker TEST string will be inserted here -->_marker, but not here --X_marker".Insert("TEST").Before(2, of: "_marker").From(The.Beginning);
            transformed.Should().Be("_marker TEST string will be inserted here -->TEST_marker, but not here --X_marker");
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

        [TestMethod]
        public void InsertTextBeforeOccurrenceWithMarkerAtBeginningFromBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted before that _marker".Insert("TEST").Before(1, of: "_marker").From(The.Beginning);
            transformed.Should().Be("TEST_marker<-- TEST string will be inserted before that _marker");
        }

        #endregion

        #region Insert After All

        [TestMethod]
        public void InsertNullAfterAllNullMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).AfterAll(null);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterAllEmptyMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).AfterAll(String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterAllMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).AfterAll(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllNullMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).AfterAll(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllEmptyMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).AfterAll(String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).AfterAll(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterAllNullMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).AfterAll(null);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterAllEmptyMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).AfterAll(String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterAllMarkersIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).AfterAll(Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterAllNullMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).AfterAll(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterAllEmptyMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).AfterAll(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterAllMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).AfterAll(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllNullMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).AfterAll(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllEmptyMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).AfterAll(String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).AfterAll(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterAllNullMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).AfterAll(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterAllEmptyMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).AfterAll(String.Empty);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterAllMarkersIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).AfterAll(Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterAllNullMarkers()
        {
            string transformed = Const.SampleString.Insert(null).AfterAll(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterAllEmptyMarkers()
        {
            string transformed = Const.SampleString.Insert(null).AfterAll(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterAllMarkers()
        {
            string transformed = Const.SampleString.Insert(null).AfterAll(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllNullMarkers()
        {
            string transformed = Const.SampleString.Insert(String.Empty).AfterAll(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllEmptyMarkers()
        {
            string transformed = Const.SampleString.Insert(String.Empty).AfterAll(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllMarkers()
        {
            string transformed = Const.SampleString.Insert(String.Empty).AfterAll(Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterAllNullMarkers()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).AfterAll(null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterAllEmptyMarkers()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).AfterAll(String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterAllNonExistingMarkers()
        {
            string transformed = "Some long long string".Insert("value").AfterAll("marker");
            transformed.Should().Be("Some long long string");
        }

        [TestMethod]
        public void InsertTextAfterAll()
        {
            string transformed = "marker marker marker_<-- TEST string will be inserted here".Insert("TEST").AfterAll("marker_");
            transformed.Should().Be("marker marker marker_TEST<-- TEST string will be inserted here");
        }

        [TestMethod]
        public void InsertTextAfterAllCaseSensitive()
        {
            string transformed = "TEST string will NOT be inserted after _marker".Insert("TEST").AfterAll("_maRKer");
            transformed.Should().Be("TEST string will NOT be inserted after _marker");
        }

        [TestMethod]
        public void InsertTextAfterAllMultipleTimes()
        {
            string transformed = "marker_ marker marker_<-- TEST string will be inserted here".Insert("TEST").AfterAll("marker_");
            transformed.Should().Be("marker_TEST marker marker_TEST<-- TEST string will be inserted here");
        }

        [TestMethod]
        public void InsertTextAfterAllMultipleTimesCaseSensitive()
        {
            string transformed = "Marker_ marker_ marker Marker_ marker_<-- TEST string will be inserted here".Insert("TEST").AfterAll("marker_");
            transformed.Should().Be("Marker_ marker_TEST marker Marker_ marker_TEST<-- TEST string will be inserted here");
        }

        #endregion

        #region Insert After All Ignoring Case

        [TestMethod]
        public void InsertNullAfterAllNullMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).AfterAll(null).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterAllEmptyMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterAllMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllNullMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).AfterAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllEmptyMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterAllNullMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).AfterAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterAllEmptyMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterAllMarkersIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterAllNullMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).AfterAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterAllEmptyMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterAllMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllNullMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).AfterAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllEmptyMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterAllNullMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).AfterAll(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterAllEmptyMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterAllMarkersIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterAllNullMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).AfterAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterAllEmptyMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterAllMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllNullMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).AfterAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllEmptyMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterAllMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).AfterAll(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterAllNullMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).AfterAll(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterAllEmptyMarkersIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).AfterAll(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterAllNonExistingMarkersIgnoringCase()
        {
            string transformed = "Some long long string".Insert("value").AfterAll("MARKER").IgnoringCase();
            transformed.Should().Be("Some long long string");
        }

        [TestMethod]
        public void InsertTextAfterAllIgnoringCase()
        {
            string transformed = "marker marker marker_<-- TEST string will be inserted here".Insert("TEST").AfterAll("MARKER_").IgnoringCase();
            transformed.Should().Be("marker marker marker_TEST<-- TEST string will be inserted here");
        }

        [TestMethod]
        public void InsertTextAfterAllIgnoringCaseMultipleTimes()
        {
            string transformed = "marker_ marker marker_<-- TEST string will be inserted here".Insert("TEST").AfterAll("MARker_").IgnoringCase();
            transformed.Should().Be("marker_TEST marker marker_TEST<-- TEST string will be inserted here");
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
        public void InsertTextAfterNonExistingMarker()
        {
            string transformed = "Some long long string".Insert("value").After("marker");
            transformed.Should().Be("Some long long string");
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

        [TestMethod]
        public void InsertTextAfterMultipleTimes()
        {
            string transformed = "marker_<-- TEST string will be inserted ONLY here despite these marker_ marker".Insert("TEST").After("marker_");
            transformed.Should().Be("marker_TEST<-- TEST string will be inserted ONLY here despite these marker_ marker");
        }

        [TestMethod]
        public void InsertTextAfterMultipleTimesCaseSensitive()
        {
            string transformed = "Marker_ marker_<-- TEST string will be inserted ONLY here despite this MARKER_".Insert("TEST").After("marker_");
            transformed.Should().Be("Marker_ marker_TEST<-- TEST string will be inserted ONLY here despite this MARKER_");
        }

        #endregion

        #region Insert After Ignoring Case

        [TestMethod]
        public void InsertNullAfterNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(null).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(null).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).After(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).After(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterNonExistingMarkerIgnoringCase()
        {
            string transformed = "Some long long string".Insert("value").After("marker").IgnoringCase();
            transformed.Should().Be("Some long long string");
        }

        [TestMethod]
        public void InsertTextAfterIgnoringCase()
        {
            string transformed = "marker marker MARKER_<-- TEST string will be inserted here".Insert("TEST").After("marker_").IgnoringCase();
            transformed.Should().Be("marker marker MARKER_TEST<-- TEST string will be inserted here");
        }

        [TestMethod]
        public void InsertTextAfterIgnoringCaseMultipleTimes()
        {
            string transformed = "mArKer_<-- TEST string will be inserted ONLY here despite these MARKER_ marker".Insert("TEST").After("marker_").IgnoringCase();
            transformed.Should().Be("mArKer_TEST<-- TEST string will be inserted ONLY here despite these MARKER_ marker");
        }

        #endregion

        #region Insert After Occurrence

        [TestMethod]
        public void InsertNullAfterOccurrenceOfNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(3, of: null);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(3, of: String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(3, of: Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(3, of: String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(3, of: Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfNullMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(3, of: null);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(3, of: String.Empty);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfMarkerIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(3, of: Const.SampleMarker);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(3, of: String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(3, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(3, of: String.Empty);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(3, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfNullMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(3, of: null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(3, of: String.Empty);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfMarkerIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(3, of: Const.SampleMarker);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfNullMarker()
        {
            string transformed = Const.SampleString.Insert(null).After(3, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(null).After(3, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfMarker()
        {
            string transformed = Const.SampleString.Insert(null).After(3, of: Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfNullMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(3, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(3, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfMarker()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(3, of: Const.SampleMarker);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfNullMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(3, of: null);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfEmptyMarker()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(3, of: String.Empty);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterNegativeOccurrenceOfMarker()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).After(-1, of: Const.SampleMarker).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void InsertTextAfterZeroOccurrenceOfMarker()
        {
            string transformed = "Some long long string with marker".Insert("TEST").After(0, of: "marker");
            transformed.Should().Be("Some long long string with marker");
        }

        [TestMethod]
        public void InsertTextAfterNonExistingOccurrence()
        {
            string transformed = Const.SampleString.Insert("TEST").Before(1, of: "_marker");
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterOccurrence()
        {
            string transformed = "TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After(1, of: "_marker");
            transformed.Should().Be("TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceCaseSensitive()
        {
            string transformed = "This _Marker will be passed by and TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After(1, of: "_marker");
            transformed.Should().Be("This _Marker will be passed by and TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceInLongerstring()
        {
            string transformed = "_marker Some Another Text _marker _marker And again text _marker TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After(5, of: "_marker");
            transformed.Should().Be("_marker Some Another Text _marker _marker And again text _marker TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceWithMarkerAtBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted after that _marker".Insert("TEST").After(1, of: "_marker");
            transformed.Should().Be("_markerTEST<-- TEST string will be inserted after that _marker");
        }

        #endregion

        #region Insert After Occurrence Ignoring Case

        [TestMethod]
        public void InsertNullAfterOccurrenceOfNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(3, of: null).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(null).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(3, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(3, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfMarkerIgnoringCaseIntoNullString()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(3, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(null).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(3, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(String.Empty).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfNullMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(3, of: null).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfMarkerIgnoringCaseIntoEmptyString()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).After(3, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(null).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(3, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(3, of: Const.SampleMarker).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfNullMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(3, of: null).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIgnoringCase()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(3, of: String.Empty).IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterNegativeOccurrenceOfMarkerIgnoringCase()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).After(-1, of: Const.SampleMarker).IgnoringCase().ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void InsertTextAfterZeroOccurrenceOfMarkerIgnoringCase()
        {
            string transformed = "Some long long string with marker".Insert("TEST").After(0, of: "MARKER").IgnoringCase();
            transformed.Should().Be("Some long long string with marker");
        }

        [TestMethod]
        public void InsertTextAfterNonExistingOccurrenceIgnoringCase()
        {
            string transformed = Const.SampleString.Insert("TEST").Before(1, of: "_marKER").IgnoringCase();
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceIgnoringCase()
        {
            string transformed = "TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After(1, of: "_MARKER").IgnoringCase();
            transformed.Should().Be("TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceIgnoringCaseInLongerstring()
        {
            string transformed = "_MARKER Some Another Text _maRKER _marker And again text _mArKeR TEST string will be inserted after this -->_maRKer, but not after this --X_marker"
                .Insert("TEST").After(5, of: "_marker").IgnoringCase();
            transformed.Should().Be("_MARKER Some Another Text _maRKER _marker And again text _mArKeR TEST string will be inserted after this -->_maRKerTEST, but not after this --X_marker");
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceIgnoringCaseWithMarkerAtBeginning()
        {
            string transformed = "_MARKer<-- TEST string will be inserted after that _marker".Insert("TEST").After(1, of: "_maRKER").IgnoringCase();
            transformed.Should().Be("_MARKerTEST<-- TEST string will be inserted after that _marker");
        }

        #endregion

        #region Insert After Occurrence From

        [TestMethod]
        public void InsertNullAfterOccurrenceOfNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: null).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(null).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(String.Empty).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfNullMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfNullMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: null).From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfMarkerIntoNullStringFromBeginning()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfMarkerIntoNullStringFromEnd()
        {
            string transformed = Const.NullString.Insert(Const.SampleValue).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(null);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).After(2, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(null).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(null).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(String.Empty).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfNullMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfNullMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: null).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfEmptyMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleValue);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfMarkerIntoEmptyStringFromBeginning()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfMarkerIntoEmptyStringFromEnd()
        {
            string transformed = String.Empty.Insert(Const.SampleValue).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertNullAfterOccurrenceOfMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(null).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: Const.SampleMarker).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertEmptyTextAfterOccurrenceOfMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(String.Empty).After(2, of: Const.SampleMarker).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfNullMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(2, of: null).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfNullMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(2, of: null).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfEmptyMarkerFromBeginning()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(2, of: String.Empty).From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceOfEmptyMarkerFromEnd()
        {
            string transformed = Const.SampleString.Insert(Const.SampleValue).After(2, of: String.Empty).From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterNegativeOccurrenceOfMarkerFromBeginning()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).After(-1, of: Const.SampleMarker).From(The.Beginning).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void InsertTextAfterNegativeOccurrenceOfMarkerFromEnd()
        {
            Action action = () => Const.SampleString.Insert(Const.SampleValue).After(-1, of: Const.SampleMarker).From(The.End).ToString();
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void InsertTextAfterZeroOccurrenceOfMarkerFromBeginning()
        {
            string transformed = "Some long long string with marker".Insert("TEST").After(0, of: "marker").From(The.Beginning);
            transformed.Should().Be("Some long long string with marker");
        }

        [TestMethod]
        public void InsertTextAfterZeroOccurrenceOfMarkerFromEnd()
        {
            string transformed = "Some long long string with marker".Insert("TEST").After(0, of: "marker").From(The.End);
            transformed.Should().Be("Some long long string with marker");
        }

        [TestMethod]
        public void InsertTextAfterNonExistingOccurrenceFromBeginning()
        {
            string transformed = Const.SampleString.Insert("TEST").Before(1, of: "_marker").From(The.Beginning);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterNonExistingOccurrenceFromEnd()
        {
            string transformed = Const.SampleString.Insert("TEST").Before(1, of: "_marker").From(The.End);
            transformed.Should().Be(Const.SampleString);
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceFromBeginning()
        {
            string transformed = "TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After(1, of: "_marker").From(The.Beginning);
            transformed.Should().Be("TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceFromEnd()
        {
            string transformed = "TEST string will NOT be inserted after this --X_marker, but after this -->_marker".Insert("TEST").After(1, of: "_marker").From(The.End);
            transformed.Should().Be("TEST string will NOT be inserted after this --X_marker, but after this -->_markerTEST");
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceCaseSensitiveFromBeginning()
        {
            string transformed = "This _Marker will be passed by and TEST string will be inserted after this -->_marker, but not after this --X_marker".Insert("TEST").After(1, of: "_marker").From(The.Beginning);
            transformed.Should().Be("This _Marker will be passed by and TEST string will be inserted after this -->_markerTEST, but not after this --X_marker");
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceCaseSensitiveFromEnd()
        {
            string transformed = "TEST string will NOT be inserted after this --X_marker, but after this -->_marker, but this _Marker will be passed by".Insert("TEST").After(1, of: "_marker").From(The.End);
            transformed.Should().Be("TEST string will NOT be inserted after this --X_marker, but after this -->_markerTEST, but this _Marker will be passed by");
        }

        [TestMethod]
        public void InsertTextAfterOccurrenceWithMarkerAtBeginningFromBeginning()
        {
            string transformed = "_marker<-- TEST string will be inserted after that _marker".Insert("TEST").After(1, of: "_marker").From(The.Beginning);
            transformed.Should().Be("_markerTEST<-- TEST string will be inserted after that _marker");
        }

        #endregion
    }
}
