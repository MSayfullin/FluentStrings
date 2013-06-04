using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrencePositionIgnoringCase
    {
        private readonly RemoveStringStartingOccurrencePosition _removeStringStartingOccurrencePosition;

        internal RemoveStringStartingOccurrencePositionIgnoringCase(RemoveStringStartingOccurrencePosition removeStringStartingOccurrencePosition)
        {
            _removeStringStartingOccurrencePosition = removeStringStartingOccurrencePosition;
        }

        internal RemoveStringStartingOccurrencePosition RemoveStringStartingOccurrencePosition { get { return _removeStringStartingOccurrencePosition; } }

        public static implicit operator string(RemoveStringStartingOccurrencePositionIgnoringCase removeStringStartingOccurrencePositionIgnoringCase)
        {
            return removeStringStartingOccurrencePositionIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _removeStringStartingOccurrencePosition.RemoveString.Source.RemoveStartingPosition(
                _removeStringStartingOccurrencePosition.Position,
                _removeStringStartingOccurrencePosition.OccurrenceCount, _removeStringStartingOccurrencePosition.Marker,
                ignoreCase: true);
        }
    }
}
