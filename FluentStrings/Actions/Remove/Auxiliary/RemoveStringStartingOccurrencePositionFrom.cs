using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrencePositionFrom
    {
        private readonly RemoveStringStartingOccurrencePosition _removeStringStartingOccurrencePosition;
        private readonly The _position;

        internal RemoveStringStartingOccurrencePositionFrom(RemoveStringStartingOccurrencePosition removeStringStartingOccurrencePosition, The position)
        {
            _removeStringStartingOccurrencePosition = removeStringStartingOccurrencePosition;
            _position = position;
        }

        internal RemoveStringStartingOccurrencePosition RemoveStringStartingOccurrencePosition { get { return _removeStringStartingOccurrencePosition; } }
        internal The Position { get { return _position; } }

        public static implicit operator string(RemoveStringStartingOccurrencePositionFrom removeStringStartingOccurrencePositionFrom)
        {
            return removeStringStartingOccurrencePositionFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringStartingOccurrencePosition.RemoveString.Source.RemoveStartingOrToPosition(
                _removeStringStartingOccurrencePosition.Position,
                _removeStringStartingOccurrencePosition.OccurrenceCount, _removeStringStartingOccurrencePosition.Marker,
                ignoreCase: false, from: _position, isStarting: true);
        }
    }
}
