using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValueIgnoringCase
    {
        private readonly RemoveValue _removeValue;

        internal RemoveValueIgnoringCase(RemoveValue removeValue)
        {
            _removeValue = removeValue;
        }

        internal RemoveValue RemoveValue { get { return _removeValue; } }

        public static implicit operator string(RemoveValueIgnoringCase removeValueIgnoringCase)
        {
            return removeValueIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return (_removeValue.Source.IsEmpty() || _removeValue.Extraction.IsEmpty())
                ? _removeValue.Source
                : _removeValue.Source.Remove(_removeValue.Source.IndexOf(_removeValue.Extraction, StringComparison.CurrentCultureIgnoreCase), _removeValue.Extraction.Length);
        }
    }
}
