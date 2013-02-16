using System;

namespace dokas.FluentStrings.Actions.Utilities
{
    public class IsEmptyString
    {
        private readonly string _source;

        internal IsEmptyString(string source)
        {
            _source = source;
        }

        internal string Source { get { return _source; } }

        public static implicit operator bool(IsEmptyString isEmptyString)
        {
            return String.IsNullOrEmpty(isEmptyString.Source);
        }
    }
}
