using System;

namespace dokas.FluentStrings.Actions.Truncate
{
    public class TruncateString
    {
        private readonly string _source;

        internal TruncateString(string source, int length)
        {
            _source = source;
            Length = length;
        }

        internal string Source { get { return _source; } }
        internal int Length { get; set; }

        public static implicit operator string(TruncateString truncateString)
        {
            return truncateString.ToString();
        }

        public override string ToString()
        {
            return _source != null
                ? _source.Length <= Length ? _source : _source.Substring(0, Length)
                : null;
        }
    }
}
