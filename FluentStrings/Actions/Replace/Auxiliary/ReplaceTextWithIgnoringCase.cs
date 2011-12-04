using System;

namespace dokas.FluentStrings.Actions.Replace
{
    public class ReplaceTextWithIgnoringCase
    {
        private readonly ReplaceTextWith _source;

        public ReplaceTextWithIgnoringCase(ReplaceTextWith source)
        {
            _source = source;
        }

        public static implicit operator string(ReplaceTextWithIgnoringCase replaceTextWithIgnoringCase)
        {
            return replaceTextWithIgnoringCase.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}

