using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToOccurrenceIgnoringCaseFrom
    {
        private readonly RemoveStringToOccurrenceIgnoringCase _removeStringToOccurrenceIgnoringCase;
        private readonly The _position;

        internal RemoveStringToOccurrenceIgnoringCaseFrom(RemoveStringToOccurrenceIgnoringCase removeStringToOccurrenceIgnoringCase, The position)
        {
            _removeStringToOccurrenceIgnoringCase = removeStringToOccurrenceIgnoringCase;
            _position = position;
        }

        public static implicit operator string(RemoveStringToOccurrenceIgnoringCaseFrom removeStringToOccurrenceIgnoringCaseFrom)
        {
            return removeStringToOccurrenceIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringToOccurrenceIgnoringCase.RemoveStringToOccurrence.RemoveString.Source.RemoveStartingOrTo(
                _removeStringToOccurrenceIgnoringCase.RemoveStringToOccurrence.OccurrenceCount, _removeStringToOccurrenceIgnoringCase.RemoveStringToOccurrence.Marker,
                ignoreCase: true, from: _position, isStarting: false);
        }
    }
}
