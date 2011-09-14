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
            throw new NotImplementedException();
        }
    }
}
