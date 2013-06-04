using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrencePositionIgnoringCaseFrom
    {
        private readonly RemoveStringStartingOccurrencePositionIgnoringCase _removeStringStartingOccurrencePositionIgnoringCase;
        private readonly The _position;

        internal RemoveStringStartingOccurrencePositionIgnoringCaseFrom(RemoveStringStartingOccurrencePositionIgnoringCase removeStringStartingOccurrencePositionIgnoringCase, The position)
        {
            _removeStringStartingOccurrencePositionIgnoringCase = removeStringStartingOccurrencePositionIgnoringCase;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingOccurrencePositionIgnoringCaseFrom removeStringStartingOccurrencePositionIgnoringCaseFrom)
        {
            return removeStringStartingOccurrencePositionIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringStartingOccurrencePositionIgnoringCase.RemoveStringStartingOccurrencePosition.RemoveString.Source.RemoveStartingPosition(
                _removeStringStartingOccurrencePositionIgnoringCase.RemoveStringStartingOccurrencePosition.Position,
                _removeStringStartingOccurrencePositionIgnoringCase.RemoveStringStartingOccurrencePosition.OccurrenceCount,
                _removeStringStartingOccurrencePositionIgnoringCase.RemoveStringStartingOccurrencePosition.Marker,
                ignoreCase: true, from: _position);
        }
    }
}
