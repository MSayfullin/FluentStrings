using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveChars
    {
        private readonly string _source;
        private readonly int _charsCount;

        internal RemoveChars(string source, int charsCount)
        {
            _source = source;
            _charsCount = charsCount;
        }

        internal string Source { get { return _source; } }
        internal int CharsCount { get { return _charsCount; } }

        public static implicit operator string(RemoveChars removeChars)
        {
            return removeChars.ToString();
        }

        public override string ToString()
        {
            return _source.IsEmpty()
                ? _source
                : _charsCount <= _source.Length
                    ? _source.Remove(0, _charsCount)
                    : String.Empty;
        }
    }
}
