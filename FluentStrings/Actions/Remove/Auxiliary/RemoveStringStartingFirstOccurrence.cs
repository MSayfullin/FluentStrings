using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFirstOccurrence
    {
        private readonly RemoveString _removeString;
        private readonly string _marker;

        internal RemoveStringStartingFirstOccurrence(RemoveString removeString, string marker)
        {
            _removeString = removeString;
            _marker = marker;
        }

        internal RemoveString RemoveString { get { return _removeString; } }
        internal string Marker { get { return _marker; } }

        public static implicit operator string(RemoveStringStartingFirstOccurrence removeStringStartingFirstOccurrence)
        {
            return removeStringStartingFirstOccurrence.ToString();
        }

        public override string ToString()
        {
            return _removeString.Source.RemoveStartingOrTo(_marker, ignoreCase: false, isStarting: true);
        }
    }
}
