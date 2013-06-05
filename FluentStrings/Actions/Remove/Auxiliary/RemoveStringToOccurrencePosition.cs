using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToOccurrencePosition
    {
        private readonly RemoveString _removeString;
        private readonly The _position;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveStringToOccurrencePosition(RemoveString removeString, The position, int occurrence, string marker)
        {
            _removeString = removeString;
            _position = position;
            _occurrenceCount = occurrence;
            _marker = marker;
        }

        internal RemoveString RemoveString { get { return _removeString; } }
        internal The Position { get { return _position; } }
        internal int OccurrenceCount { get { return _occurrenceCount; } }
        internal string Marker { get { return _marker; } }

        public static implicit operator string(RemoveStringToOccurrencePosition removeStringToOccurrencePosition)
        {
            return removeStringToOccurrencePosition.ToString();
        }

        public override string ToString()
        {
            return _removeString.Source.RemoveStartingOrToPosition(
                _position, _occurrenceCount, _marker,
                ignoreCase: false, from: The.Beginning, isStarting: false);
        }
    }
}
