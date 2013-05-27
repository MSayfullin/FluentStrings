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
            return _removeStringStartingFirstOccurrence.RemoveString.Source.Remove(
                _removeStringStartingFirstOccurrence.Marker,
                (source, marker) =>
                {
                    var index = source.IndexOf(marker, StringComparison.CurrentCultureIgnoreCase);
                    return index >= 0 ? source.Substring(0, index) : source;
                });
        }
    }
}
