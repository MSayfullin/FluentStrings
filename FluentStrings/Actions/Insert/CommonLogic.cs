using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dokas.FluentStrings.Actions.Utilities;

namespace dokas.FluentStrings.Actions.Insert
{
    internal static class CommonLogic
    {
        public static string Insert(this string source, string insertion, string marker, Func<string, string, string, string> insert)
        {
            switch (source.ToKeyWith(insertion, marker))
            {
                // source-insertion-marker
                case "null-null-null":
                case "null-null-empty":
                case "null-null-value":
                case "null-empty-empty":
                case "null-empty-value":
                case "null-value-empty":
                case "null-value-value":
                    return null;
                case "null-empty-null":
                case "empty-null-null":
                case "empty-null-empty":
                case "empty-null-value":
                case "empty-empty-null":
                case "empty-empty-empty":
                case "empty-empty-value":
                case "empty-value-null":
                case "empty-value-value":
                    return String.Empty;
                case "null-value-null":
                case "empty-value-empty":
                    return insertion;
                case "value-null-null":
                case "value-null-empty":
                case "value-null-value":
                case "value-empty-null":
                case "value-empty-empty":
                case "value-empty-value":
                case "value-value-null":
                case "value-value-empty":
                    return source;
                case "value-value-value":
                    return insert(source, insertion, marker);
                default:
                    throw new ArgumentOutOfRangeException("Didn't you forget to regenerate case statements for changed key?");
            }
        }

        public static string Insert(
            this string source, string insertion, string marker, StringComparison comparisonRule = StringComparison.CurrentCulture,
            int? occurrenceCount = null, The position = The.Beginning, bool after = false)
        {
            switch (position)
            {
                case The.Beginning:
                case The.End:
                    return occurrenceCount != null
                        ? source.InsertWithChecks(insertion, marker, comparisonRule, occurrenceCount.Value, position, after)
                        : source.InsertWithChecks(insertion, marker, comparisonRule, position, after);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Insert().From() method");
            }
        }

        private static string InsertWithChecks(this string source, string insertion, string marker, StringComparison comparisonRule, int occurrenceCount, The position, bool after)
        {
            if (occurrenceCount < 0)
                throw new ArgumentOutOfRangeException("occurrence", "Negative occurrence count is not supported");

            if (occurrenceCount == 0)
                return source;

            return source.Insert(insertion, marker,
                (s, i, m) =>
                {
                    var shift = after ? marker.Length : 0;
                    var indexes = s.IndexesOf(m, comparisonRule, position).Take(occurrenceCount).ToArray();
                    return indexes.Any() ? s.Insert(indexes.Last() + shift, i) : s;
                });
        }

        private static string InsertWithChecks(this string source, string insertion, string marker, StringComparison comparisonRule, The position, bool after)
        {
            return source.Insert(insertion, marker,
                (s, i, m) =>
                {
                    var indexShift = 0;
                    var afterShift = after ? marker.Length : 0;
                    var indexes = s.IndexesOf(m, comparisonRule, position).ToArray();
                    var builder = new StringBuilder(s, insertion.Length * indexes.Length);
                    foreach (var index in indexes)
                    {
                        builder.Insert(index + indexShift + afterShift, insertion);
                        indexShift += insertion.Length;
                    }
                    return builder.ToString();
                });
        }
    }
}
