using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringIgnoringCaseFrom
    {
        private readonly RemoveStringIgnoringCase _removeStringIgnoringCase;
        private readonly The _position;

        internal RemoveStringIgnoringCaseFrom(RemoveStringIgnoringCase removeStringIgnoringCase, The position)
        {
            _removeStringIgnoringCase = removeStringIgnoringCase;
            _position = position;
        }

        public static implicit operator string(RemoveStringIgnoringCaseFrom removeStringIgnoringCaseFrom)
        {
            return removeStringIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _removeStringIgnoringCase;
                case The.End:
                    if (_removeStringIgnoringCase.RemoveText.Source.IsEmpty() || _removeStringIgnoringCase.RemoveText.Extraction.IsEmpty())
                        return _removeStringIgnoringCase.RemoveText.Source;

                    var indexOfExtraction = _removeStringIgnoringCase.RemoveText.Source.LastIndexOf(_removeStringIgnoringCase.RemoveText.Extraction, StringComparison.CurrentCultureIgnoreCase);
                    return _removeStringIgnoringCase.RemoveText.Source.Remove(indexOfExtraction, _removeStringIgnoringCase.RemoveText.Extraction.Length);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().IgnoringCase().From() method");
            }
        }
    }
}
