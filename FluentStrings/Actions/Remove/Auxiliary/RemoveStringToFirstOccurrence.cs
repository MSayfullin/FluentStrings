using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToFirstOccurrence
    {
        private readonly RemoveString _removeString;
        private readonly string _marker;

        internal RemoveStringToFirstOccurrence(RemoveString removeString, string marker)
        {
            _removeString = removeString;
            _marker = marker;
        }

        internal RemoveString RemoveString { get { return _removeString; } }
        internal string Marker { get { return _marker; } }

        public static implicit operator string(RemoveStringToFirstOccurrence removeStringToFirstOccurrence)
        {
            return removeStringToFirstOccurrence.ToString();
        }

        public override string ToString()
        {
            return _removeString.Source.Remove(
                _marker,
                (source, marker) =>
                {
                    var index = source.IndexOf(marker);
                    return index >= 0 ? source.Remove(0, index) : source;
                });
        }
    }
}
