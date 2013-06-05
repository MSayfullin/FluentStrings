using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToFirstOccurrenceFrom
    {
        private readonly RemoveStringToFirstOccurrence _removeStringToFirstOccurrence;
        private readonly The _position;

        internal RemoveStringToFirstOccurrenceFrom(RemoveStringToFirstOccurrence removeStringToFirstOccurrence, The position)
        {
            _removeStringToFirstOccurrence = removeStringToFirstOccurrence;
            _position = position;
        }

        public static implicit operator string(RemoveStringToFirstOccurrenceFrom removeStringToFirstOccurrenceFrom)
        {
            return removeStringToFirstOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _removeStringToFirstOccurrence;
                case The.End:
                    return _removeStringToFirstOccurrence.RemoveString.Source.Remove(
                        _removeStringToFirstOccurrence.Marker,
                        (source, marker) =>
                        {
                            var index = source.LastIndexOf(marker);
                            return index >= 0 ? source.Remove(0, index) : source;
                        });
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().To().From() method");
            }
        }
    }
}
