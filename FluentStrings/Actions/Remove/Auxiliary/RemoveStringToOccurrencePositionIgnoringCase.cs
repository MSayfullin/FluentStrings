using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToOccurrencePositionIgnoringCase
    {
        private readonly RemoveStringToOccurrencePosition _removeStringToOccurrencePosition;

        internal RemoveStringToOccurrencePositionIgnoringCase(RemoveStringToOccurrencePosition removeStringToOccurrencePosition)
        {
            _removeStringToOccurrencePosition = removeStringToOccurrencePosition;
        }

        internal RemoveStringToOccurrencePosition RemoveStringToOccurrencePosition { get { return _removeStringToOccurrencePosition; } }

        public static implicit operator string(RemoveStringToOccurrencePositionIgnoringCase removeStringToOccurrencePositionIgnoringCase)
        {
            return removeStringToOccurrencePositionIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _removeStringToOccurrencePosition.RemoveString.Source.RemoveStartingOrToPosition(
                _removeStringToOccurrencePosition.Position,
                _removeStringToOccurrencePosition.OccurrenceCount, _removeStringToOccurrencePosition.Marker,
                ignoreCase: true, from: The.Beginning, isStarting: false);
        }
    }
}
