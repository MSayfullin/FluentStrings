using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToFirstOccurrencePositionFrom
    {
        private readonly RemoveStringToFirstOccurrencePosition _removeStringToFirstOccurrencePositionsource;
        private readonly The _position;

        internal RemoveStringToFirstOccurrencePositionFrom(RemoveStringToFirstOccurrencePosition removeStringToFirstOccurrencePosition, The position)
        {
            _removeStringToFirstOccurrencePositionsource = removeStringToFirstOccurrencePosition;
            _position = position;
        }

        public static implicit operator string(RemoveStringToFirstOccurrencePositionFrom removeStringToFirstOccurrencePositionFrom)
        {
            return removeStringToFirstOccurrencePositionFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringToFirstOccurrencePositionsource.RemoveString.Source.RemoveStartingOrToPosition(
                _removeStringToFirstOccurrencePositionsource.Position,
                1, _removeStringToFirstOccurrencePositionsource.Marker,
                ignoreCase: false, from: _position, isStarting: false);
        }
    }
}
