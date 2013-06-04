using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFirstOccurrencePositionIgnoringCaseFrom
    {
        private readonly RemoveStringStartingFirstOccurrencePositionIgnoringCase _removeStringStartingFirstOccurrencePositionIgnoringCase;
        private readonly The _position;

        internal RemoveStringStartingFirstOccurrencePositionIgnoringCaseFrom(RemoveStringStartingFirstOccurrencePositionIgnoringCase removeStringStartingFirstOccurrencePositionIgnoringCase, The position)
        {
            _removeStringStartingFirstOccurrencePositionIgnoringCase = removeStringStartingFirstOccurrencePositionIgnoringCase;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingFirstOccurrencePositionIgnoringCaseFrom removeStringStartingFirstOccurrencePositionIgnoringCaseFrom)
        {
            return removeStringStartingFirstOccurrencePositionIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringStartingFirstOccurrencePositionIgnoringCase.RemoveStringStartingFirstOccurrencePosition.RemoveString.Source.RemoveStartingPosition(
                _removeStringStartingFirstOccurrencePositionIgnoringCase.RemoveStringStartingFirstOccurrencePosition.Position, 1,
                _removeStringStartingFirstOccurrencePositionIgnoringCase.RemoveStringStartingFirstOccurrencePosition.Marker,
                ignoreCase: true, from: _position);
        }
    }
}
