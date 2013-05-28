using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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

        public static IEnumerable<int> IndexesOf(this string source, string marker, bool ignoreCase, The position)
        {
            switch (position)
            {
                case The.Beginning:
                    return source.IndexesOf(marker, ignoreCase);
                case The.End:
                    return source.IndexesOf(marker, ignoreCase).Reverse();
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by IndexesOf().From() method");
            }
        }

        public static IEnumerable<int> IndexesOf(this string source, string marker, bool ignoreCase)
        {
            if (source.IsEmpty() || marker.IsEmpty())
                return Enumerable.Empty<int>();

            return Regex.Matches(source, marker, ignoreCase ? RegexOptions.IgnoreCase : RegexOptions.None).OfType<Match>().Select(m => m.Index);
        }

        #endregion
    }
}
