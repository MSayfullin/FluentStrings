using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceIgnoringCase
    {
        private readonly RemoveStringStartingOccurrence _removeStringStartingOccurrence;

        internal RemoveStringStartingOccurrenceIgnoringCase(RemoveStringStartingOccurrence removeStringStartingOccurrence)
        {
            _removeStringStartingOccurrence = removeStringStartingOccurrence;
        }

        internal RemoveStringStartingOccurrence RemoveStringStartingOccurrence { get { return _removeStringStartingOccurrence; } }

        public static implicit operator string(RemoveStringStartingOccurrenceIgnoringCase removeStringStartingOccurrenceIgnoringCase)
        {
            return removeStringStartingOccurrenceIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _removeStringStartingOccurrence.RemoveString.Source.RemoveStartingOrTo(
                _removeStringStartingOccurrence.OccurrenceCount,
                _removeStringStartingOccurrence.Marker,
                ignoreCase: true, from: The.Beginning, isStarting: true);
        }
    }
}
