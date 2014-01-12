using System;
using System.Linq;
using System.Text;
using dokas.FluentStrings.Actions.Utilities;

namespace dokas.FluentStrings.Actions.Remove
{
    internal static class CommonLogic
    {
        public static string Remove(this string source, string extraction, Func<string, string, string> remove, Func<string, string, string> emptyEmptyCase = null)
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
                    return emptyEmptyCase != null ? emptyEmptyCase(source, extraction) : null;
                case "value-value":
                    return remove(source, extraction);
                default:
                    throw new ArgumentOutOfRangeException("key", "Have you regenerated case statements for changed key?");
            }
        }

        #region Remove Values

        public static string RemoveValues(this string source, int? quantity, string extraction, bool ignoreCase, The from)
        {
            switch (from)
            {
                case The.Beginning:
                case The.End:
                    return RemoveValuesInternal(source, quantity, extraction, ignoreCase, from);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().From() method");
            }
        }

        public static string RemoveValues(this string source, int? quantity, string extraction, bool ignoreCase)
        {
            return RemoveValuesInternal(source, quantity, extraction, ignoreCase);
        }

        private static string RemoveValuesInternal(string source, int? quantity, string extraction, bool ignoreCase, The from = The.Beginning)
        {
            if (quantity < 0)
                throw new ArgumentOutOfRangeException("quantity", "Negative quantity is not supported");

            if (quantity == 0)
                return source;

            return source.Remove(extraction,
                (s, e) =>
                {
                    var indexes = s.IndexesOf(e, ignoreCase, from);
                    if (quantity != null)
                        indexes = indexes.Take(quantity.Value);
                    if (from == The.End)
                        indexes = indexes.Reverse();

                    var indexesArray = indexes.ToArray();

                    if (!indexesArray.Any())
                        return s;

                    var start = 0;
                    var resultStringLength = s.Length - indexesArray.Length * e.Length;
                    var builder = new StringBuilder(resultStringLength);
                    foreach (var index in indexes)
                    {
                        builder.Append(s.Substring(start, index - start));
                        start = index + e.Length;
                    }
                    builder.Append(s.Substring(start));
                    return builder.ToString();
                });
        }

        #endregion

        #region Remove Starting To Indexes

        public static string RemoveStartingTo(this string source,
            int startingPositionIndex, The startingFrom, int toPositionIndex, The toFrom,
            bool applyStartCorrection = true, bool applyFinishCorrection = true)
        {
            if (startingPositionIndex < 0 || toPositionIndex < 0)
                throw new ArgumentOutOfRangeException("positionIndex", "Negative index is not supported");

            if (source.IsEmpty())
                return source;

            int start = 0;
            switch (startingFrom)
            {
                case The.Beginning:
                    start = Math.Min(startingPositionIndex, source.Length);
                    break;
                case The.End:
                    start = Math.Max(source.Length - startingPositionIndex - 1, -1);
                    break;
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().Starting().From().To().From() methods");
            }

            int finish = 0;
            switch (toFrom)
            {
                case The.Beginning:
                    finish = Math.Min(toPositionIndex, source.Length);
                    break;
                case The.End:
                    finish = Math.Max(source.Length - toPositionIndex - 1, -1);
                    break;
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().Starting().From().To().From() methods");
            }

            if (start == finish)
                return source;

            if (finish < start)
            {
                var oldStart = applyStartCorrection ? start + 1 : start;
                start = applyFinishCorrection ? finish + 1 : finish;
                finish = Math.Min(oldStart, source.Length);
            }

            if (start >= source.Length)
                return source;

            start = Math.Max(start, 0);
            return source.Remove(start, finish - start);
        }

        #endregion

        #region Remove Starting Or To First Occurence

        public static string RemoveStartingOrTo(this string source, string marker, bool ignoreCase, The from, bool isStarting)
        {
            switch (from)
            {
                case The.Beginning:
                    return source.RemoveStartingOrTo(marker, ignoreCase, isStarting, fromBeginning: true);
                case The.End:
                    return source.RemoveStartingOrTo(marker, ignoreCase, isStarting, fromBeginning: false);
                case The.StartOf:
                case The.EndOf:
                default:
                    var methodName = isStarting ? "Starting" : "To";
                    throw new ArgumentOutOfRangeException(
                        "position", "Only Beginning and End positions are supported by Remove().{0}().From() method".f(methodName));
            }
        }

        private static string RemoveStartingOrTo(this string source, string marker, bool ignoreCase, bool isStarting, bool fromBeginning)
        {
            return source.Remove(
                marker,
                (s, m) =>
                {
                    var comparison = ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture;
                    var index = fromBeginning ? s.IndexOf(m, comparison) : s.LastIndexOf(m, comparison);
                    return index >= 0
                        ? isStarting
                            ? s.Substring(0, index)
                            : s.Remove(0, index)
                        : s;
                },
                (s, m) => isStarting ? null : String.Empty);
        }

        #endregion

        #region Remove Starting Or To Occurrence

        public static int? IndexOf(this string source, int occurrenceCount, string marker, bool ignoreCase, The from)
        {
            if (occurrenceCount == 0)
                return null;

            var indexes = source.IndexesOf(marker, ignoreCase, from).Skip(occurrenceCount - 1);

            if (!indexes.Any())
                return null;

            return indexes.First();
        }

        public static int? IndexOf(this string source, The position, int occurrenceCount, string marker, bool ignoreCase, The from)
        {
            var index = source.IndexOf(occurrenceCount, marker, ignoreCase, from);

            if (index == null)
                return null;

            int shift = position == The.StartOf ? 0 : marker.Length;
            return index.Value + shift;
        }

        public static string RemoveStartingOrTo(this string source, int occurrenceCount, string marker, bool ignoreCase, The from, bool isStarting)
        {
            if (occurrenceCount < 0)
                throw new ArgumentOutOfRangeException("occurrenceCount", "Negative occurrence count is not supported");

            if (occurrenceCount == 0)
                return source;

            return source.Remove(marker,
                (s, m) =>
                {
                    var index = source.IndexOf(occurrenceCount, marker, ignoreCase, from);

                    if (index == null)
                        return source;

                    return isStarting ? source.Substring(0, index.Value) : source.Remove(0, index.Value);
                },
                (s, m) => isStarting ? null : String.Empty);
        }

        public static string RemoveStartingOrToPosition(this string source, The position, int occurrenceCount, string marker, bool ignoreCase, The from, bool isStarting)
        {
            if (occurrenceCount < 0)
                throw new ArgumentOutOfRangeException("occurrenceCount", "Negative occurrence count is not supported");

            if (occurrenceCount == 0)
                return source;

            switch (position)
            {
                case The.StartOf:
                case The.EndOf:
                    break;
                case The.Beginning:
                case The.End:
                default:
                    var methodName = isStarting ? "Starting" : "To";
                    throw new ArgumentOutOfRangeException(
                        "position", "Only StartOf and EndOf positions are supported by Remove().{0}() method".f(methodName));
            }

            return source.Remove(marker,
                (s, m) =>
                {
                    var index = source.IndexOf(position, occurrenceCount, marker, ignoreCase, from);

                    if (index == null)
                        return source;

                    if (index >= source.Length)
                        return isStarting ? source : String.Empty;

                    return isStarting ? source.Substring(0, index.Value) : source.Remove(0, index.Value);
                },
                (s, m) => isStarting || position == The.EndOf ? null : String.Empty);
        }

        #endregion
    }
}
