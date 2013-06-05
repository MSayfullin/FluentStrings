using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFirstOccurrencePositionFrom
    {
        private readonly RemoveStringStartingFirstOccurrencePosition _removeStringStartingFirstOccurrencePosition;
        private readonly The _position;

        internal RemoveStringStartingFirstOccurrencePositionFrom(RemoveStringStartingFirstOccurrencePosition removeStringStartingFirstOccurrencePosition, The position)
        {
            _removeStringStartingFirstOccurrencePosition = removeStringStartingFirstOccurrencePosition;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingFirstOccurrencePositionFrom removeStringStartingFirstOccurrencePositionFrom)
        {
            return removeStringStartingFirstOccurrencePositionFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringStartingFirstOccurrencePosition.RemoveString.Source.RemoveStartingOrToPosition(
                _removeStringStartingFirstOccurrencePosition.Position,
                1, _removeStringStartingFirstOccurrencePosition.Marker,
                ignoreCase:false, from: _position, isStarting: true);
        }
    }
}
