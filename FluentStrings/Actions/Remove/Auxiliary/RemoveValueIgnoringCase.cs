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
            return _removeValue.Source.Remove(_removeValue.Extraction,
                (s, e) =>
                {
                    var index = s.IndexOf(e, StringComparison.CurrentCultureIgnoreCase);
                    return index >= 0 ? s.Remove(index, e.Length) : s;
                });
        }
    }
}
