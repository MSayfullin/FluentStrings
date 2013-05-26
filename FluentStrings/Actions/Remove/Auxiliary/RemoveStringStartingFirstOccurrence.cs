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

        public static implicit operator string(RemoveStringStartingFirstOccurrence removeStringStartingFirstOccurrence)
        {
            return removeStringStartingFirstOccurrence.ToString();
        }

        public override string ToString()
        {
            return _removeString.Source.Remove(
                _marker,
                (source, marker) =>
                {
                    var index = source.IndexOf(marker);
                    return index >= 0 ? source.Substring(0, index) : source;
                });
        }
    }
}
