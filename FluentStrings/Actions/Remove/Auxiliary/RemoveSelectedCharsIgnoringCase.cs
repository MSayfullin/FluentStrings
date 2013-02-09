using System;
using System.Linq;
using System.Text;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveSelectedCharsIgnoringCase
    {
        private readonly RemoveSelectedChars _removeSelectedChars;

        internal RemoveSelectedCharsIgnoringCase(RemoveSelectedChars removeSelectedChars)
        {
            _removeSelectedChars = removeSelectedChars;
        }

        public static implicit operator string(RemoveSelectedCharsIgnoringCase removeSelectedCharsIgnoringCase)
        {
            return removeSelectedCharsIgnoringCase.ToString();
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(_removeSelectedChars.Source) || _removeSelectedChars.CharsToRemove.Length == 0)
                return _removeSelectedChars.Source;

            var lowerCaseCharsToRemove = _removeSelectedChars.CharsToRemove.Select(c => Char.ToLower(c)).ToArray();
            var builder = new StringBuilder(_removeSelectedChars.Source.Length - _removeSelectedChars.CharsToRemove.Length, _removeSelectedChars.Source.Length);
            foreach (var ch in _removeSelectedChars.Source)
            {
                var lowerCh = Char.ToLower(ch);
                if (!lowerCaseCharsToRemove.Contains(lowerCh))
                    builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}
