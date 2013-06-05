using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToOccurrencePositionFrom
    {
        private readonly RemoveStringToOccurrencePosition _removeStringToOccurrencePosition;
        private readonly The _position;

        internal RemoveStringToOccurrencePositionFrom(RemoveStringToOccurrencePosition removeStringToOccurrencePosition, The position)
        {
            _removeStringToOccurrencePosition = removeStringToOccurrencePosition;
            _position = position;
        }

        public static implicit operator string(RemoveStringToOccurrencePositionFrom removeStringToOccurrencePositionFrom)
        {
            return removeStringToOccurrencePositionFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringToOccurrencePosition.RemoveString.Source.RemoveStartingOrToPosition(
                _removeStringToOccurrencePosition.Position,
                _removeStringToOccurrencePosition.OccurrenceCount, _removeStringToOccurrencePosition.Marker,
                ignoreCase: false, from: _position, isStarting: false);
        }
    }
}
