using System;

namespace dokas.FluentStrings.Actions.Truncate
{
    public class TruncateText
    {
        private readonly string _source;
        private readonly int _charsCount;

        internal TruncateText(string source, int charsCount)
        {
            _source = source;
            _charsCount = charsCount;
        }

        public static implicit operator string(TruncateText truncateText)
        {
            return truncateText.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
