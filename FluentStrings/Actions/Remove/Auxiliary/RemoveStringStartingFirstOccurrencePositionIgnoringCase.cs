using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFirstOccurrencePositionIgnoringCase
    {
        private readonly RemoveStringStartingFirstOccurrencePosition _removeStringStartingFirstOccurrencePosition;

        internal RemoveStringStartingFirstOccurrencePositionIgnoringCase(RemoveStringStartingFirstOccurrencePosition removeStringStartingFirstOccurrencePosition)
        {
            _removeStringStartingFirstOccurrencePosition = removeStringStartingFirstOccurrencePosition;
        }

        internal RemoveStringStartingFirstOccurrencePosition RemoveStringStartingFirstOccurrencePosition { get { return _removeStringStartingFirstOccurrencePosition; } }

        public static implicit operator string(RemoveStringStartingFirstOccurrencePositionIgnoringCase removeStringStartingFirstOccurrencePositionIgnoringCase)
        {
            return removeStringStartingFirstOccurrencePositionIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _removeStringStartingFirstOccurrencePosition.RemoveString.Source.RemoveStartingPosition(
                _removeStringStartingFirstOccurrencePosition.Position, 1, _removeStringStartingFirstOccurrencePosition.Marker,
                ignoreCase: true);
        }
    }
}
