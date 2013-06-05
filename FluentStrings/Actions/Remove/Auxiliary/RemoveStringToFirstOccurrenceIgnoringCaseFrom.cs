using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToFirstOccurrenceIgnoringCaseFrom
    {
        private readonly RemoveStringToFirstOccurrenceIgnoringCase _removeStringToFirstOccurrenceIgnoringCase;
        private readonly The _position;

        internal RemoveStringToFirstOccurrenceIgnoringCaseFrom(RemoveStringToFirstOccurrenceIgnoringCase removeStringToFirstOccurrenceIgnoringCase, The position)
        {
            _removeStringToFirstOccurrenceIgnoringCase = removeStringToFirstOccurrenceIgnoringCase;
            _position = position;
        }

        public static implicit operator string(RemoveStringToFirstOccurrenceIgnoringCaseFrom removeStringToFirstOccurrenceIgnoringCaseFrom)
        {
            return removeStringToFirstOccurrenceIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _removeStringToFirstOccurrenceIgnoringCase;
                case The.End:
                    return _removeStringToFirstOccurrenceIgnoringCase.RemoveStringToFirstOccurrence.RemoveString.Source.Remove(
                        _removeStringToFirstOccurrenceIgnoringCase.RemoveStringToFirstOccurrence.Marker,
                        (source, marker) =>
                        {
                            var index = source.LastIndexOf(marker, StringComparison.CurrentCultureIgnoreCase);
                            return index >= 0 ? source.Remove(0, index) : source;
                        });
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().To().IgnoreCase().From() method");
            }
        }
    }
}
