using System;
using System.Collections.Generic;
using System.Text;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveAllIgnoringCase
    {
        private readonly RemoveAll _removeAll;

        public RemoveAllIgnoringCase(RemoveAll removeAll)
        {
            _removeAll = removeAll;
        }

        public static implicit operator string(RemoveAllIgnoringCase removeAllIgnoringCase)
        {
            return removeAllIgnoringCase.ToString();
        }

        public override string ToString()
        {
            if (_removeAll.Source.IsEmpty() || _removeAll.Extraction.IsEmpty())
                return _removeAll.Source;

            var indexes = new List<int>();
            var index = _removeAll.Source.IndexOf(_removeAll.Extraction, StringComparison.CurrentCultureIgnoreCase);
            while (index >= 0)
            {
                indexes.Add(index);
                index = _removeAll.Source.IndexOf(_removeAll.Extraction, index + 1, StringComparison.CurrentCultureIgnoreCase);
            }

            if (indexes.Count == 0)
                return _removeAll.Source;

            var start = 0;
            var resultStringLength = _removeAll.Source.Length - indexes.Count * _removeAll.Extraction.Length;
            var builder = new StringBuilder(resultStringLength);
            for (int i = 0; i < indexes.Count; i++)
            {
                index = indexes[i];
                builder.Append(_removeAll.Source.Substring(start, index - start));
                start = index + _removeAll.Extraction.Length;
            }
            builder.Append(_removeAll.Source.Substring(start));

            return builder.ToString();
        }
    }
}
