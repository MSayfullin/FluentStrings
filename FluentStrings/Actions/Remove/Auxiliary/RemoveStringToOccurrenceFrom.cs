using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToOccurrenceFrom
    {
        private readonly RemoveStringToOccurrence _removeStringToOccurrence;
        private readonly The _position;

        internal RemoveStringToOccurrenceFrom(RemoveStringToOccurrence removeStringToOccurrence, The position)
        {
            _removeStringToOccurrence = removeStringToOccurrence;
            _position = position;
        }

        public static implicit operator string(RemoveStringToOccurrenceFrom removeStringToOccurrenceFrom)
        {
            return removeStringToOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringToOccurrence.RemoveString.Source.RemoveStartingOrTo(
                _removeStringToOccurrence.OccurrenceCount, _removeStringToOccurrence.Marker,
                ignoreCase: false, from: _position, isStarting: false);
        }
    }
}
