using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToOccurrence
    {
        private readonly RemoveString _removeString;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveStringToOccurrence(RemoveString removeString, int occurrenceCount, string marker)
        {
            _removeString = removeString;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        internal RemoveString RemoveString { get { return _removeString; } }
        internal int OccurrenceCount { get { return _occurrenceCount; } }
        internal string Marker { get { return _marker; } }

        public static implicit operator string(RemoveStringToOccurrence removeStringToOccurrence)
        {
            return removeStringToOccurrence.ToString();
        }

        public override string ToString()
        {
            return _removeString.Source.RemoveStartingOrTo(
                _occurrenceCount, _marker, ignoreCase: false, from: The.Beginning, isStarting: false);
        }
    }
}
