using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToFirstOccurrencePositionIgnoringCaseFrom
    {
        private readonly RemoveStringToFirstOccurrencePositionIgnoringCase _removeStringToFirstOccurrencePositionIgnoringCase;
        private readonly The _position;

        internal RemoveStringToFirstOccurrencePositionIgnoringCaseFrom(RemoveStringToFirstOccurrencePositionIgnoringCase removeStringToFirstOccurrencePositionIgnoringCase, The position)
        {
            _removeStringToFirstOccurrencePositionIgnoringCase = removeStringToFirstOccurrencePositionIgnoringCase;
            _position = position;
        }

        public static implicit operator string(RemoveStringToFirstOccurrencePositionIgnoringCaseFrom removeStringToFirstOccurrencePositionIgnoringCaseFrom)
        {
            return removeStringToFirstOccurrencePositionIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringToFirstOccurrencePositionIgnoringCase.RemoveStringToFirstOccurrencePosition.RemoveString.Source.RemoveStartingOrToPosition(
                _removeStringToFirstOccurrencePositionIgnoringCase.RemoveStringToFirstOccurrencePosition.Position,
                1, _removeStringToFirstOccurrencePositionIgnoringCase.RemoveStringToFirstOccurrencePosition.Marker,
                ignoreCase: true, from: _position, isStarting: false);
        }
    }
}
