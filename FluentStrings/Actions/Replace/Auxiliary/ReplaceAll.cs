using System;

namespace dokas.FluentStrings.Actions.Replace
{
    public class ReplaceAll
    {
        private readonly string _source;
        private readonly string _value;

        public ReplaceAll(string source, string value)
        {
            _source = source;
            _value = value;
        }

        internal string Source { get { return _source; } }
        internal string Value { get { return _value; } }

        public static implicit operator string(ReplaceAll replaceAll)
        {
            return replaceAll.ToString();
        }

        public override string ToString()
        {
            return _source.Replace(_value, String.Empty);
        }
    }
}
