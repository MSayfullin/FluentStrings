using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceFrom
    {
        private readonly RemoveStringStartingOccurrence _removeStringStartingOccurrence;
        private readonly The _position;

        internal RemoveStringStartingOccurrenceFrom(RemoveStringStartingOccurrence removeStringStartingOccurrence, The position)
        {
            _removeStringStartingOccurrence = removeStringStartingOccurrence;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceFrom removeStringStartingOccurrenceFrom)
        {
            return removeStringStartingOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringStartingOccurrence.RemoveString.Source.RemoveStartingOrTo(
                _removeStringStartingOccurrence.OccurrenceCount,
                _removeStringStartingOccurrence.Marker,
                ignoreCase: false, from: _position, isStarting: true);
        }
    }
}
