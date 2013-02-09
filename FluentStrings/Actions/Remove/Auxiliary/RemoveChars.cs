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

        public static implicit operator string(RemoveChars removeChars)
        {
            return removeChars.ToString();
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(_source))
                return _source;

            return _charsCount <= _source.Length
                ? _source.Remove(0, _charsCount)
                : String.Empty;
        }
    }
}
