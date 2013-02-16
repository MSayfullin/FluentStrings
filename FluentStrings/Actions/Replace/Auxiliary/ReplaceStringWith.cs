using System;

namespace dokas.FluentStrings.Actions.Replace
{
    public class ReplaceStringWith
    {
        private readonly ReplaceString _replaceString;
        private readonly string _replacement;

        public ReplaceStringWith(ReplaceString replaceString, string replacement)
        {
            _replaceString = replaceString;
            _replacement = replacement;
        }

        public static implicit operator string(ReplaceStringWith replaceStringWith)
        {
            return replaceStringWith.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}

