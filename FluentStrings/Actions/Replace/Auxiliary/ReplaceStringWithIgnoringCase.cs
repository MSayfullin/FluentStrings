using System;
using System.Linq;
using System.Text;
using dokas.FluentStrings.Actions.Utilities;

namespace dokas.FluentStrings.Actions.Replace
{
    public class ReplaceStringWithIgnoringCase
    {
        private readonly ReplaceStringWith _replaceStringWith;

        public ReplaceStringWithIgnoringCase(ReplaceStringWith replaceStringWith)
        {
            _replaceStringWith = replaceStringWith;
        }

        public static implicit operator string(ReplaceStringWithIgnoringCase replaceStringWithIgnoringCase)
        {
            return replaceStringWithIgnoringCase.ToString();
        }

        public override string ToString()
        {
            var start = 0;
            var indexes = _replaceStringWith.ReplaceString.Source.IndexesOf(_replaceStringWith.ReplaceString.Value, StringComparison.CurrentCultureIgnoreCase).ToArray();
            var resultStringLength = _replaceStringWith.ReplaceString.Source.Length
                - indexes.Length * (_replaceStringWith.ReplaceString.Value.Length - _replaceStringWith.Replacement.Length);
            var builder = new StringBuilder();
            foreach (var index in indexes)
            {
                builder.Append(_replaceStringWith.ReplaceString.Source.Substring(start, index - start));
                builder.Append(_replaceStringWith.Replacement);
                start = index + _replaceStringWith.ReplaceString.Value.Length;
            }
            builder.Append(_replaceStringWith.ReplaceString.Source.Substring(start));
            return builder.ToString();
        }
    }
}

