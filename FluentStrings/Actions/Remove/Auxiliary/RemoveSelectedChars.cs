using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveSelectedChars
    {
        private readonly string _source;
        private readonly char[] _charsToRemove;

        internal RemoveSelectedChars(string source, char[] charsToRemove)
        {
            _source = source;
            _charsToRemove = charsToRemove;
        }

        public static implicit operator string(RemoveSelectedChars removeSelectedChars)
        {
            return removeSelectedChars.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
