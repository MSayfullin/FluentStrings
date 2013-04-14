using System;
using System.Linq;
using System.Text;
using dokas.FluentStrings.Actions.Utilities;

namespace dokas.FluentStrings.Actions.Replace
{
    public class ReplaceAllWithIgnoringCase
    {
        private readonly ReplaceAllWith _replaceAllWith;

        public ReplaceAllWithIgnoringCase(ReplaceAllWith replaceAllWith)
        {
            _replaceAllWith = replaceAllWith;
        }

        public static implicit operator string(ReplaceAllWithIgnoringCase replaceAllWithIgnoringCase)
        {
            return replaceAllWithIgnoringCase.ToString();
        }

        public override string ToString()
        {
            var start = 0;
            var indexes = _replaceAllWith.ReplaceAll.Source.IndexesOf(_replaceAllWith.ReplaceAll.Value, StringComparison.CurrentCultureIgnoreCase).ToArray();
            var resultStringLength = _replaceAllWith.ReplaceAll.Source.Length
                - indexes.Length * (_replaceAllWith.ReplaceAll.Value.Length - _replaceAllWith.Replacement.Length);
            var builder = new StringBuilder();
            foreach (var index in indexes)
            {
                builder.Append(_replaceAllWith.ReplaceAll.Source.Substring(start, index - start));
                builder.Append(_replaceAllWith.Replacement);
                start = index + _replaceAllWith.ReplaceAll.Value.Length;
            }
            builder.Append(_replaceAllWith.ReplaceAll.Source.Substring(start));
            return builder.ToString();
        }
    }
}

