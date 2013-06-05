using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToOccurrenceIgnoringCase
    {
        private readonly RemoveStringToOccurrence _removeStringToOccurrence;

        internal RemoveStringToOccurrenceIgnoringCase(RemoveStringToOccurrence removeStringToOccurrence)
        {
            _removeStringToOccurrence = removeStringToOccurrence;
        }

        internal RemoveStringToOccurrence RemoveStringToOccurrence { get { return _removeStringToOccurrence; } }

        public static implicit operator string(RemoveStringToOccurrenceIgnoringCase removeStringToOccurrenceIgnoringCase)
        {
            return removeStringToOccurrenceIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _removeStringToOccurrence.RemoveString.Source.RemoveStartingOrTo(
                _removeStringToOccurrence.OccurrenceCount, _removeStringToOccurrence.Marker,
                ignoreCase: true, from: The.Beginning, isStarting: false);
        }
    }
}
