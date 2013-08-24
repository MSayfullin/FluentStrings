using System;

namespace dokas.FluentStrings.Actions.Truncate
{
    public class TruncateStringWith
    {
        private readonly TruncateString _truncateString;
        private readonly string _value;

        internal TruncateStringWith(TruncateString truncateString, string value)
        {
            _truncateString = truncateString;
            _value = value;

            if (!_value.IsEmpty())
            {
                _truncateString.TargetLength -= _value.Length;
            }
        }

        public static implicit operator string(TruncateStringWith truncateStringWith)
        {
            return truncateStringWith.ToString();
        }

        public override string ToString()
        {
            if (_truncateString.Source.IsEmpty())
                return _truncateString.Source;

            if (_value.IsEmpty())
                return _truncateString;

            if (_truncateString.Source.Length <= _truncateString.TargetLength)
                return _truncateString.Source;

            string truncated = _truncateString;
            if (!truncated.IsEmpty().OrWhiteSpace())
            {
                truncated = truncated.TrimEnd();
            }
            return truncated + _value;

        }
    }
}
