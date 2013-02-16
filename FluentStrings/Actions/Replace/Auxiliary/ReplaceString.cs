using System;

namespace dokas.FluentStrings.Actions.Replace
{
    public class ReplaceText
    {
        private readonly string _source;
        private readonly string _value;

        public ReplaceText(string source, string value)
        {
            _source = source;
            _value = value;
        }

        public static implicit operator string(ReplaceText replaceText)
        {
            return replaceText.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
