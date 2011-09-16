using System;

namespace dokas.FluentStrings.Actions.Truncate
{
    public class TruncateTextFrom
    {
        private readonly TruncateText _source;
        private readonly The _position;

        internal TruncateTextFrom(TruncateText source, The position)
        {
            _source = source;
            _position = position;
        }

        public static implicit operator string(TruncateTextFrom truncateTextFrom)
        {
            return truncateTextFrom.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
