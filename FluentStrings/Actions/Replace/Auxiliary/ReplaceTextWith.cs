using System;

namespace dokas.FluentStrings.Actions.Replace
{
    public class ReplaceTextWith
    {
        private readonly ReplaceText _source;
        private readonly string _replacement;

        public ReplaceTextWith(ReplaceText source, string replacement)
        {
            _source = source;
            _replacement = replacement;
        }

        public static implicit operator string(ReplaceTextWith replaceTextWith)
        {
            return replaceTextWith.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}

