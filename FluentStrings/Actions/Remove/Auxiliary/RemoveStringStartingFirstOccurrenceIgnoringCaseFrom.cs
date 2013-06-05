using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFirstOccurrenceIgnoringCaseFrom
    {
        private readonly RemoveStringStartingFirstOccurrenceIgnoringCase _removeStringStartingFirstOccurrenceIgnoringCase;
        private readonly The _position;

        internal RemoveStringStartingFirstOccurrenceIgnoringCaseFrom(RemoveStringStartingFirstOccurrenceIgnoringCase removeStringStartingFirstOccurrenceIgnoringCase, The position)
        {
            _removeStringStartingFirstOccurrenceIgnoringCase = removeStringStartingFirstOccurrenceIgnoringCase;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingFirstOccurrenceIgnoringCaseFrom removeStringStartingFirstOccurrenceIgnoringCaseFrom)
        {
            return removeStringStartingFirstOccurrenceIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringStartingFirstOccurrenceIgnoringCase.RemoveStringStartingFirstOccurrence.RemoveString.Source.RemoveStartingOrTo(
                _removeStringStartingFirstOccurrenceIgnoringCase.RemoveStringStartingFirstOccurrence.Marker,
                ignoreCase: true, from: _position, isStarting: true);
        }
    }
}
