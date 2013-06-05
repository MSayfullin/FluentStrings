using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToFirstOccurrenceIgnoringCaseFrom
    {
        private readonly RemoveStringToFirstOccurrenceIgnoringCase _removeStringToFirstOccurrenceIgnoringCase;
        private readonly The _position;

        internal RemoveStringToFirstOccurrenceIgnoringCaseFrom(RemoveStringToFirstOccurrenceIgnoringCase removeStringToFirstOccurrenceIgnoringCase, The position)
        {
            _removeStringToFirstOccurrenceIgnoringCase = removeStringToFirstOccurrenceIgnoringCase;
            _position = position;
        }

        public static implicit operator string(RemoveStringToFirstOccurrenceIgnoringCaseFrom removeStringToFirstOccurrenceIgnoringCaseFrom)
        {
            return removeStringToFirstOccurrenceIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringToFirstOccurrenceIgnoringCase.RemoveStringToFirstOccurrence.RemoveString.Source.RemoveStartingOrTo(
                _removeStringToFirstOccurrenceIgnoringCase.RemoveStringToFirstOccurrence.Marker,
                ignoreCase: true, from: _position, isStarting: false);
        }
    }
}
