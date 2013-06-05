using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToFirstOccurrenceIgnoringCase
    {
        private readonly RemoveStringToFirstOccurrence _removeStringToFirstOccurrence;

        internal RemoveStringToFirstOccurrenceIgnoringCase(RemoveStringToFirstOccurrence removeStringToFirstOccurrence)
        {
            _removeStringToFirstOccurrence = removeStringToFirstOccurrence;
        }

        internal RemoveStringToFirstOccurrence RemoveStringToFirstOccurrence { get { return _removeStringToFirstOccurrence; } }

        public static implicit operator string(RemoveStringToFirstOccurrenceIgnoringCase removeStringToFirstOccurrenceIgnoringCase)
        {
            return removeStringToFirstOccurrenceIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _removeStringToFirstOccurrence.RemoveString.Source.RemoveStartingOrTo(
                _removeStringToFirstOccurrence.Marker, ignoreCase: true, isStarting: false);
        }
    }
}
