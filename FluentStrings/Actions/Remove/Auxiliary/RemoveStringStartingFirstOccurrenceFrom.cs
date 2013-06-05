using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFirstOccurrenceFrom
    {
        private RemoveStringStartingFirstOccurrence _removeStringStartingFirstOccurrence;
        private The _position;

        internal RemoveStringStartingFirstOccurrenceFrom(RemoveStringStartingFirstOccurrence removeStringStartingFirstOccurrence, The position)
        {
            _removeStringStartingFirstOccurrence = removeStringStartingFirstOccurrence;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingFirstOccurrenceFrom removeStringStartingFirstOccurrenceFrom)
        {
            return removeStringStartingFirstOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringStartingFirstOccurrence.RemoveString.Source.RemoveStartingOrTo(
                _removeStringStartingFirstOccurrence.Marker,
                ignoreCase: false, from: _position, isStarting: true);
        }
    }
}
