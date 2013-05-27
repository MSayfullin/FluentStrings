using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFirstOccurrenceIgnoringCaseFrom
    {
        private readonly RemoveStringStartingFirstOccurrenceIgnoringCase _removeStringStartingFirstOccurrenceIgnoringCase;
        private readonly The _position;

        internal RemoveStringStartingFirstOccurrenceIgnoringCaseFrom(RemoveStringStartingFirstOccurrenceIgnoringCase removeStringStartingFirstOccurrenceIgnoringCase, The position)
        {
            _removeStringStartingFirstOccurrenceIgnoringCase = removeStringStartingFirstOccurrenceIgnoringCase;
            _position = position;
        }

        public static implicit operator string(RemoveStringStartingFirstOccurrenceIgnoringCaseFrom removeStringStartingFirstOccurrenceIgnoringCaseFrom)
        {
            return removeStringStartingFirstOccurrenceIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _removeStringStartingFirstOccurrenceIgnoringCase;
                case The.End:
                    return _removeStringStartingFirstOccurrenceIgnoringCase.RemoveStringStartingFirstOccurrence.RemoveString.Source.Remove(
                        _removeStringStartingFirstOccurrenceIgnoringCase.RemoveStringStartingFirstOccurrence.Marker,
                        (source, marker) =>
                        {
                            var index = source.LastIndexOf(marker, StringComparison.CurrentCultureIgnoreCase);
                            return index >= 0 ? source.Substring(0, index) : source;
                        });
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().Starting().IgnoringCase().From() method");
            }
        }
    }
}
