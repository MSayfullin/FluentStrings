using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToFirstOccurrencePosition
    {
        private readonly RemoveString _removeString;
        private readonly The _position;
        private readonly string _marker;

        internal RemoveStringToFirstOccurrencePosition(RemoveString removeString, The position, string marker)
        {
            _removeString = removeString;
            _position = position;
            _marker = marker;
        }

        internal RemoveString RemoveString { get { return _removeString; } }
        internal The Position { get { return _position; } }
        internal string Marker { get { return _marker; } }

        public static implicit operator string(RemoveStringToFirstOccurrencePosition removeStringToFirstOccurrencePosition)
        {
            return removeStringToFirstOccurrencePosition.ToString();
        }

        public override string ToString()
        {
            return _removeString.Source.RemoveStartingOrToPosition(
                _position, 1, _marker,
                ignoreCase: false, from: The.Beginning, isStarting: false);
        }
    }
}
