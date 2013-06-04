using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrencePosition
    {
        private readonly RemoveString _removeString;
        private readonly The _position;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal RemoveStringStartingOccurrencePosition(RemoveString removeString, The position, int occurrenceCount, string marker)
        {
            _removeString = removeString;
            _position = position;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        internal RemoveString RemoveString { get { return _removeString; } }
        internal The Position { get { return _position; } }
        internal int OccurrenceCount { get { return _occurrenceCount; } }
        internal string Marker { get { return _marker; } }

        public static implicit operator string(RemoveStringStartingOccurrencePosition removeStringStartingOccurrencePosition)
        {
            return removeStringStartingOccurrencePosition.ToString();
        }

        public override string ToString()
        {
            return _removeString.Source.RemoveStartingPosition(_position, _occurrenceCount, _marker);
        }
    }
}
