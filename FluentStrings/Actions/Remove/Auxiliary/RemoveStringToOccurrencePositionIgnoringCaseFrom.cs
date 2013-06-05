using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToOccurrencePositionIgnoringCaseFrom
    {
        private readonly RemoveStringToOccurrencePositionIgnoringCase _removeStringToOccurrencePositionIgnoringCase;
        private readonly The _position;

        internal RemoveStringToOccurrencePositionIgnoringCaseFrom(RemoveStringToOccurrencePositionIgnoringCase removeStringToOccurrencePositionIgnoringCase, The position)
        {
            _removeStringToOccurrencePositionIgnoringCase = removeStringToOccurrencePositionIgnoringCase;
            _position = position;
        }

        public static implicit operator string(RemoveStringToOccurrencePositionIgnoringCaseFrom removeStringToOccurrencePositionIgnoringCaseFrom)
        {
            return removeStringToOccurrencePositionIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringToOccurrencePositionIgnoringCase.RemoveStringToOccurrencePosition.RemoveString.Source.RemoveStartingOrToPosition(
                _removeStringToOccurrencePositionIgnoringCase.RemoveStringToOccurrencePosition.Position,
                _removeStringToOccurrencePositionIgnoringCase.RemoveStringToOccurrencePosition.OccurrenceCount, _removeStringToOccurrencePositionIgnoringCase.RemoveStringToOccurrencePosition.Marker,
                ignoreCase: true, from: _position, isStarting: false);
        }
    }
}
