using System;
using System.Linq;
using System.Text;

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

        internal string Source { get { return _source; } }
        internal char[] CharsToRemove { get { return _charsToRemove; } }

        public static implicit operator string(RemoveSelectedChars removeSelectedChars)
        {
            return removeSelectedChars.ToString();
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(_source) || _charsToRemove.Length == 0)
                return _source;

            var builder = new StringBuilder(_source.Length - _charsToRemove.Length, _source.Length);
            foreach (var ch in _source)
            {
                if (!_charsToRemove.Contains(ch))
                    builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}
