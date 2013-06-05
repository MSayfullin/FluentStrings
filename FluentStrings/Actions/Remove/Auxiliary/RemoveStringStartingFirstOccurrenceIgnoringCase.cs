using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFirstOccurrenceIgnoringCase
    {
        private readonly RemoveStringStartingFirstOccurrence _removeStringStartingFirstOccurrence;

        internal RemoveStringStartingFirstOccurrenceIgnoringCase(RemoveStringStartingFirstOccurrence removeStringStartingFirstOccurrence)
        {
            _removeStringStartingFirstOccurrence = removeStringStartingFirstOccurrence;
        }

        internal RemoveStringStartingFirstOccurrence RemoveStringStartingFirstOccurrence { get { return _removeStringStartingFirstOccurrence; } }

        public static implicit operator string(RemoveStringStartingFirstOccurrenceIgnoringCase removeStringStartingFirstOccurrenceIgnoringCase)
        {
            return removeStringStartingFirstOccurrenceIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _removeStringStartingFirstOccurrence.RemoveString.Source.RemoveStartingOrTo(
                _removeStringStartingFirstOccurrence.Marker, ignoreCase: true, isStarting: true);
        }
    }
}
