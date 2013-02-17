using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringIgnoringCase
    {
        private readonly RemoveValue _removeValue;

        public RemoveStringIgnoringCase(RemoveValue removeValue)
        {
            _removeValue = removeValue;
        }

        internal RemoveValue RemoveValue { get { return _removeValue; } }

        public static implicit operator string(RemoveStringIgnoringCase removeStringIgnoringCase)
        {
            return removeStringIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return (_removeValue.Source.IsEmpty() || _removeValue.Extraction.IsEmpty())
                ? _removeValue.Source
                : _removeValue.Source.Remove(_removeValue.Source.IndexOf(_removeValue.Extraction, StringComparison.CurrentCultureIgnoreCase), _removeValue.Extraction.Length);
        }
    }
}
