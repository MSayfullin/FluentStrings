using System;

namespace dokas.FluentStrings.Actions.Replace
{
    public class ReplaceStringWithIgnoringCase
    {
        private readonly ReplaceStringWith _replaceStringWith;

        public ReplaceStringWithIgnoringCase(ReplaceStringWith replaceStringWith)
        {
            _replaceStringWith = replaceStringWith;
        }

        public static implicit operator string(ReplaceStringWithIgnoringCase replaceStringWithIgnoringCase)
        {
            return replaceStringWithIgnoringCase.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}

