using System.Linq;
using System.Text;
using dokas.FluentStrings.Actions.Common;
using dokas.FluentStrings.Actions.Utilities;

namespace dokas.FluentStrings.Actions.Replace
{
    public class ReplaceAllWith : ICaseIgnorable
    {
        private readonly ReplaceAll _replaceAll;
        private readonly string _replacement;
        private bool _ignoreCase;

        public ReplaceAllWith(ReplaceAll replaceAll, string replacement)
        {
            _replaceAll = replaceAll;
            _replacement = replacement;
            _ignoreCase = false;
        }

        public static implicit operator string(ReplaceAllWith replaceAllWith)
        {
            return replaceAllWith.ToString();
        }

        public override string ToString()
        {
            if (_ignoreCase)
            {
                var indexes = _replaceAll.Source.IndexesOf(_replaceAll.Value, ignoreCase: true).ToArray();
                if (indexes.Any())
                {
                    var start = 0;
                    var resultStringLength =
                        _replaceAll.Source.Length - indexes.Length * (_replaceAll.Value.Length - _replacement.Length);
                    var builder = new StringBuilder(resultStringLength);
                    foreach (var index in indexes)
                    {
                        builder.Append(_replaceAll.Source.Substring(start, index - start));
                        builder.Append(_replacement);
                        start = index + _replaceAll.Value.Length;
                    }
                    builder.Append(_replaceAll.Source.Substring(start));
                    return builder.ToString();
                }
                return _replaceAll.Source;
            }
            return _replaceAll.Source.Replace(_replaceAll.Value, _replacement);
        }

        #region ICaseIgnorable Members

        void ICaseIgnorable.IgnoreCase()
        {
            _ignoreCase = true;
        }

        #endregion
    }
}

