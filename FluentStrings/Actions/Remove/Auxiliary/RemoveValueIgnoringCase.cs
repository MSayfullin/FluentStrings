using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValueIgnoringCase
    {
        private readonly RemoveValue _removeValue;

        public RemoveValueIgnoringCase(RemoveValue removeValue)
        {
            _removeValue = removeValue;
        }

        internal RemoveValue RemoveValue { get { return _removeValue; } }

        public static implicit operator string(RemoveValueIgnoringCase removeStringIgnoringCase)
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
