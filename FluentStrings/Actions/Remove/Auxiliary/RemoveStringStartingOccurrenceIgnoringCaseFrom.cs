using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceIgnoringCaseFrom
    {
        private readonly RemoveStringStartingOccurrenceIgnoringCase _removeStringStartingOccurrenceIgnoringCase;
        private readonly The _position;

        internal RemoveStringStartingOccurrenceIgnoringCaseFrom(RemoveStringStartingOccurrenceIgnoringCase removeStringStartingOccurrenceIgnoringCase, The position)
        {
            _removeStringStartingOccurrenceIgnoringCase = removeStringStartingOccurrenceIgnoringCase;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceIgnoringCaseFrom removeStringStartingOccurrenceIgnoringCaseFrom)
        {
            return removeStringStartingOccurrenceIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            return _removeStringStartingOccurrenceIgnoringCase.RemoveStringStartingOccurrence.RemoveString.Source.RemoveStarting(
                _removeStringStartingOccurrenceIgnoringCase.RemoveStringStartingOccurrence.OccurrenceCount,
                _removeStringStartingOccurrenceIgnoringCase.RemoveStringStartingOccurrence.Marker,
                ignoreCase: true, position: _position);
        }
    }
}
