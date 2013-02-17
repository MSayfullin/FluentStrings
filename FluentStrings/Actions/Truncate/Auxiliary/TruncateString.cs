using System;

namespace dokas.FluentStrings.Actions.Truncate
{
    public class TruncateString
    {
        private readonly string _source;
        private readonly int _length;

        internal TruncateString(string source, int length)
        {
            _source = source;
            _length = length;
        }

        internal string Source { get { return _source; } }
        internal int Length { get { return _length; } }

        public static implicit operator string(TruncateString truncateString)
        {
            return truncateString.ToString();
        }

        public override string ToString()
        {
            return _source != null
                ? _source.Length <= _length ? _source : _source.Substring(0, _length)
                : null;
        }
    }
}
