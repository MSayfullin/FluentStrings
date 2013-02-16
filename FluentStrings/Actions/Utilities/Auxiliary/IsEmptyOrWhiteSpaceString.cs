using System;

namespace dokas.FluentStrings.Actions.Utilities
{
    public class IsEmptyOrWhiteSpaceString
    {
        private readonly IsEmptyString _isEmptyString;

        internal IsEmptyOrWhiteSpaceString(IsEmptyString isEmptyString)
        {
            _isEmptyString = isEmptyString;
        }

        internal IsEmptyString IsEmptyString { get { return _isEmptyString; } }

        public static implicit operator bool(IsEmptyOrWhiteSpaceString isEmptyOrWhiteSpaceString)
        {
            if (!String.IsNullOrEmpty(isEmptyOrWhiteSpaceString.IsEmptyString.Source))
            {
                foreach (var ch in isEmptyOrWhiteSpaceString.IsEmptyString.Source)
                {
                    if (!Char.IsWhiteSpace(ch))
                        return false;
                }
            }
            return true;
        }
    }
}
