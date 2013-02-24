using System;
using System.Collections.Generic;
using System.Text;

namespace dokas.FluentStrings.Actions.Remove
{
    internal static class CommonLogic
    {
        public static string RemoveValues(string source, int? quantity, string extraction, StringComparison comparisonRule)
        {
            if (source.IsEmpty() || extraction.IsEmpty() || quantity == 0)
                return source;

            var indexes = new List<int>();
            var index = source.IndexOf(extraction, comparisonRule);
            while (index >= 0 && (quantity == null || indexes.Count < quantity))
            {
                indexes.Add(index);
                index = source.IndexOf(extraction, index + 1, comparisonRule);
            }

            if (indexes.Count == 0)
                return source;

            var start = 0;
            var resultStringLength = source.Length - indexes.Count * extraction.Length;
            var builder = new StringBuilder(resultStringLength);
            for (int i = 0; i < indexes.Count; i++)
            {
                index = indexes[i];
                builder.Append(source.Substring(start, index - start));
                start = index + extraction.Length;
            }
            builder.Append(source.Substring(start));

            return builder.ToString();
        }
    }
}
