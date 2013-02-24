using System;
using System.Collections.Generic;
using System.Text;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValues
    {
        private readonly string _source;
        private readonly int _quantity;
        private readonly string _extraction;

        public RemoveValues(string source, int quantity, string extraction)
        {
            _source = source;
            _quantity = quantity;
            _extraction = extraction;
        }

        public static implicit operator string(RemoveValues removeValues)
        {
            return removeValues.ToString();
        }

        public override string ToString()
        {
            if (_source.IsEmpty() || _extraction.IsEmpty() || _quantity == 0)
                return _source;

            var indexes = new List<int>();
            var index = _source.IndexOf(_extraction);
            while (index >= 0 && indexes.Count < _quantity)
            {
                indexes.Add(index);
                index = _source.IndexOf(_extraction, index + 1);
            }

            if (indexes.Count == 0)
                return _source;

            var start = 0;
            var resultStringLength = _source.Length - indexes.Count * _extraction.Length;
            var builder = new StringBuilder(resultStringLength);
            for (int i = 0; i < indexes.Count; i++)
            {
                index = indexes[i];
                builder.Append(_source.Substring(start, index - start));
                start = index + _extraction.Length;
            }
            builder.Append(_source.Substring(start));

            return builder.ToString();
        }
    }
}
