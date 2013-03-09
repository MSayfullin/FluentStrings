using System;
using System.Collections.Generic;
using System.Text;

namespace dokas.FluentStrings.Actions.Utilities
{
    internal static class CommonLogic
    {
        public static string ToKeyWith(this string basis, params string[] args)
        {
            // 6 is the maximum length of switch key value among NULL, EMPTY and VALUE
            var builder = new StringBuilder(basis.ToKey(), 6 + 6 * args.Length);
            foreach (var arg in args)
            {
                builder.Append("-");
                builder.Append(arg.ToKey());
            }
            return builder.ToString();
        }

        public static string ToKey(this string value)
        {
            return value == null ? "null" : value.Length == 0 ? "empty" : "value";
        }

        #region Indexes

        public static IEnumerable<int> IndexesOf(this string source, string marker, StringComparison comparisonRule, The position)
        {
            switch (position)
            {
                case The.Beginning:
                    return source.IndexesOf(marker, comparisonRule);
                case The.End:
                    return source.LastIndexesOf(marker, comparisonRule);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by IndexesOf().From() method");
            }
        }

        public static IEnumerable<int> IndexesOf(this string source, string marker, StringComparison comparisonRule)
        {
            if (source.IsEmpty() || marker.IsEmpty())
                yield break;

            var index = source.IndexOf(marker, comparisonRule);
            while (index >= 0)
            {
                yield return index;
                index = source.IndexOf(marker, index + 1, comparisonRule);
            }
        }

        private static IEnumerable<int> LastIndexesOf(this string source, string marker, StringComparison comparisonRule)
        {
            if (source.IsEmpty() || marker.IsEmpty())
                yield break;

            var index = source.LastIndexOf(marker, comparisonRule);
            while (index >= 0)
            {
                yield return index;
                index = source.LastIndexOf(marker, index + 1, comparisonRule);
            }
        }

        #endregion
    }
}
