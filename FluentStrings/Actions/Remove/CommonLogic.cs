using System;
using System.Collections.Generic;
using System.Text;

namespace dokas.FluentStrings.Actions.Remove
{
    internal static class CommonLogic
    {
        public static string RemoveValues(string source, int? quantity, string extraction, StringComparison comparisonRule, The position)
        {
            switch (position)
            {
                case The.Beginning:
                    return RemoveValuesInternal(source, quantity, extraction, comparisonRule);
                case The.End:
                    return RemoveValuesInternal(source, quantity, extraction, comparisonRule, true);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().From() method");
            }
        }

        public static string RemoveValues(string source, int? quantity, string extraction, StringComparison comparisonRule)
        {
            return RemoveValuesInternal(source, quantity, extraction, comparisonRule);
        }

        private static string RemoveValuesInternal(string source, int? quantity, string extraction, StringComparison comparisonRule, bool reverse = false)
        {
            if (quantity < 0)
                throw new ArgumentOutOfRangeException("quantity", "Negative quantity is not supported");

            if (source.IsEmpty() || extraction.IsEmpty() || quantity == 0)
                return source;

            var indexes = reverse
                ? GetReverseIndexes(source, quantity, extraction, comparisonRule)
                : GetForwardIndexes(source, quantity, extraction, comparisonRule);

            if (indexes.Count == 0)
                return source;

            var start = 0;
            var resultStringLength = source.Length - indexes.Count * extraction.Length;
            var builder = new StringBuilder(resultStringLength);
            foreach (var index in indexes)
            {
                builder.Append(source.Substring(start, index - start));
                start = index + extraction.Length;
            }
            builder.Append(source.Substring(start));
            return builder.ToString();
        }

        private static List<int> GetForwardIndexes(string source, int? quantity, string extraction, StringComparison comparisonRule)
        {
            var indexes = new List<int>();
            var index = source.IndexOf(extraction, comparisonRule);
            while (index >= 0 && (quantity == null || indexes.Count < quantity))
            {
                indexes.Add(index);
                index = source.IndexOf(extraction, index + 1, comparisonRule);
            }
            return indexes;
        }

        private static List<int> GetReverseIndexes(string source, int? quantity, string extraction, StringComparison comparisonRule)
        {
            var indexes = new List<int>();
            var index = source.LastIndexOf(extraction, comparisonRule);
            while (index >= 0 && (quantity == null || indexes.Count < quantity))
            {
                indexes.Add(index);
                index = source.LastIndexOf(extraction, index + 1, comparisonRule);
            }
            indexes.Reverse();
            return indexes;
        }
    }
}
