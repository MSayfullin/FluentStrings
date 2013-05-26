using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFirstOccurrenceFrom
    {
        private RemoveStringStartingFirstOccurrence _removeStringStartingFirstOccurrence;
        private The _position;

        internal RemoveStringStartingFirstOccurrenceFrom(RemoveStringStartingFirstOccurrence removeStringStartingFirstOccurrence, The position)
        {
            _removeStringStartingFirstOccurrence = removeStringStartingFirstOccurrence;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingFirstOccurrenceFrom removeStringStartingFirstOccurrenceFrom)
        {
            return removeStringStartingFirstOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _removeStringStartingFirstOccurrence;
                case The.End:
                    return _removeStringStartingFirstOccurrence.RemoveString.Source.Remove(
                        _removeStringStartingFirstOccurrence.Marker,
                        (source, marker) =>
                        {
                            var index = source.LastIndexOf(marker);
                            return index >= 0 ? source.Substring(0, index) : source;
                        });
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().Starting().From() method");
            }
        }
    }
}
