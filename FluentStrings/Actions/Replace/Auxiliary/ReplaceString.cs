using System;

namespace dokas.FluentStrings.Actions.Replace
{
    public class ReplaceString
    {
        private readonly string _source;
        private readonly string _value;

        public ReplaceString(string source, string value)
        {
            _source = source;
            _value = value;
        }

        public static implicit operator string(ReplaceString replaceString)
        {
            return replaceString.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
