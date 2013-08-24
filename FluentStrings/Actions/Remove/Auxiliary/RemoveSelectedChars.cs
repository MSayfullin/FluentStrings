using System;
using System.Linq;
using System.Text;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveSelectedChars : ICaseIgnorable
    {
        private readonly string _source;
        private readonly char[] _charsToRemove;
        private bool _ignoreCase;

        internal RemoveSelectedChars(string source, char[] charsToRemove)
        {
            _source = source;
            _charsToRemove = charsToRemove;
            _ignoreCase = false;
        }

        public static implicit operator string(RemoveSelectedChars removeSelectedChars)
        {
            return removeSelectedChars.ToString();
        }

        private string Enumerate(Func<char, char> prepare)
        {
            char[] charsToRemove;
            if (prepare != null)
                charsToRemove = _charsToRemove.Select(ch => prepare(ch)).ToArray();
            else
            {
                charsToRemove = _charsToRemove;
                prepare = ch => ch;
            }

            var builder = new StringBuilder(_source.Length);
            foreach (var character in _source)
            {
                var ch = prepare(character);
                if (!charsToRemove.Contains(ch))
                    builder.Append(character);
            }
            return builder.ToString();
        }

        public override string ToString()
        {
            if (_source.IsEmpty() || _charsToRemove.Length == 0)
                return _source;

            return _ignoreCase ? Enumerate(ch => Char.ToLower(ch)) : Enumerate(null);
        }

        #region ICaseIgnorable Members

        void ICaseIgnorable.IgnoreCase()
        {
            _ignoreCase = true;
        }

        #endregion
    }
}
