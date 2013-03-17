using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValueIgnoringCaseFrom
    {
        private readonly RemoveValueIgnoringCase _removeStringIgnoringCase;
        private readonly The _position;

        internal RemoveValueIgnoringCaseFrom(RemoveValueIgnoringCase removeStringIgnoringCase, The position)
        {
            _removeStringIgnoringCase = removeStringIgnoringCase;
            _position = position;
        }

        public static implicit operator string(RemoveValueIgnoringCaseFrom removeValueIgnoringCaseFrom)
        {
            return removeValueIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _removeStringIgnoringCase;
                case The.End:
                    return _removeStringIgnoringCase.RemoveValue.Source.Remove(_removeStringIgnoringCase.RemoveValue.Extraction,
                        (s, e) =>
                        {
                            var index = s.LastIndexOf(e, StringComparison.CurrentCultureIgnoreCase);
                            return index >= 0 ? s.Remove(index, e.Length) : s;
                        });
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().IgnoringCase().From() method");
            }
        }
    }
}
