using System;
using System.Linq;
using System.Text;
using dokas.FluentStrings.Actions.Utilities;

namespace dokas.FluentStrings.Actions.Remove
{
    internal static class CommonLogic
    {
        public static string Remove(this string source, string extraction, Func<string, string, string> remove)
        {
            switch (source.ToKeyWith(extraction))
            {
                // source-extraction
                case "null-null":
                case "null-empty":
                case "null-value":
                case "empty-null":
                case "empty-value":
                case "value-null":
                case "value-empty":
                    return source;
                case "empty-empty":
                    return null;
                case "value-value":
                    return remove(source, extraction);
                default:
                    throw new ArgumentOutOfRangeException("Didn't you forget to regenerate case statements for changed key?");
            }
        }

        public static string RemoveValues(this string source, int? quantity, string extraction, StringComparison comparisonRule, The position)
        {
            switch (position)
            {
                case The.Beginning:
                case The.End:
                    return RemoveValuesInternal(source, quantity, extraction, comparisonRule, position);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().From() method");
            }
        }

        public static string RemoveValues(this string source, int? quantity, string extraction, StringComparison comparisonRule)
        {
            return RemoveValuesInternal(source, quantity, extraction, comparisonRule);
        }

        private static string RemoveValuesInternal(string source, int? quantity, string extraction, StringComparison comparisonRule, The position = The.Beginning)
        {
            if (quantity < 0)
                throw new ArgumentOutOfRangeException("quantity", "Negative quantity is not supported");

            if (quantity == 0)
                return source;

            return source.Remove(extraction,
                (s, e) =>
                {
                    var indexes = source.IndexesOf(extraction, comparisonRule, position);
                    if (quantity != null)
                        indexes = indexes.Take(quantity.Value);
                    if (position == The.End)
                        indexes = indexes.Reverse();

                    var indexesArray = indexes.ToArray();

                    if (!indexesArray.Any())
                        return source;

                    var start = 0;
                    var resultStringLength = source.Length - indexesArray.Length * extraction.Length;
                    var builder = new StringBuilder(resultStringLength);
                    foreach (var index in indexes)
                    {
                        builder.Append(source.Substring(start, index - start));
                        start = index + extraction.Length;
                    }
                    builder.Append(source.Substring(start));
                    return builder.ToString();
                });
        }
    }
}
