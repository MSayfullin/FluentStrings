using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToFirstOccurrenceFrom
    {
        private readonly RemoveStringToFirstOccurrence _removeStringToFirstOccurrence;
        private readonly The _position;

        internal RemoveStringToFirstOccurrenceFrom(RemoveStringToFirstOccurrence removeStringToFirstOccurrence, The position)
        {
            _removeStringToFirstOccurrence = removeStringToFirstOccurrence;
            _position = position;
        }

        public static implicit operator string(RemoveStringToFirstOccurrenceFrom removeStringToFirstOccurrenceFrom)
        {
            return removeStringToFirstOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringToFirstOccurrence.RemoveString.Source.RemoveStartingOrTo(
                _removeStringToFirstOccurrence.Marker,
                ignoreCase: false, from: _position, isStarting: false);
        }
    }
}
