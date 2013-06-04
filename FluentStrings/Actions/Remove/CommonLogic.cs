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

        public static string RemoveValues(this string source, int? quantity, string extraction, bool ignoreCase, The position)
        {
            switch (position)
            {
                case The.Beginning:
                case The.End:
                    return RemoveValuesInternal(source, quantity, extraction, ignoreCase, position);
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

        private static string RemoveValuesInternal(string source, int? quantity, string extraction, bool ignoreCase, The position = The.Beginning)
        {
            if (quantity < 0)
                throw new ArgumentOutOfRangeException("quantity", "Negative quantity is not supported");

            if (quantity == 0)
                return source;

            return source.Remove(extraction,
                (s, e) =>
                {
                    var indexes = s.IndexesOf(e, ignoreCase, position);
                    if (quantity != null)
                        indexes = indexes.Take(quantity.Value);
                    if (position == The.End)
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

        public static string RemoveStartingTo(this string source, int startingPositionIndex, The startingFrom, int toPositionIndex, The toFrom)
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
                var tmp = start;
                start = finish + 1;
                finish = Math.Min(tmp + 1, source.Length);
            }

            if (start >= source.Length)
                return source;

            start = Math.Max(start, 0);
            return source.Remove(start, finish - start);
        }

        public static string RemoveStarting(this string source, int occurrenceCount, string marker, bool ignoreCase = false, The from = The.Beginning)
        {
            if (occurrenceCount < 0)
                throw new ArgumentOutOfRangeException("occurrenceCount", "Negative occurrence count is not supported");

            if (occurrenceCount == 0)
                return source;

            return source.Remove(marker,
                (s, m) =>
                {
                    var indexes = source.IndexesOf(marker, ignoreCase, from).Skip(occurrenceCount - 1);

                    if (!indexes.Any())
                        return source;

                    return source.Remove(indexes.First());
                });
        }

        public static string RemoveStartingPosition(this string source, The position, int occurrenceCount, string marker, bool ignoreCase = false, The from = The.Beginning)
        {
            if (occurrenceCount < 0)
                throw new ArgumentOutOfRangeException("occurrenceCount", "Negative occurrence count is not supported");

            if (occurrenceCount == 0)
                return source;

            return source.Remove(marker,
                (s, m) =>
                {
                    int shift;
                    switch (position)
                    {
                        case The.StartOf:
                            shift = 0;
                            break;
                        case The.EndOf:
                            shift = marker.Length;
                            break;
                        case The.Beginning:
                        case The.End:
                        default:
                            throw new ArgumentOutOfRangeException("exactPosition", "Only StartOf and EndOf positions are supported by Remove().Starting() method");
                    }

                    var indexes = source.IndexesOf(marker, ignoreCase, from).Skip(occurrenceCount - 1);

                    if (!indexes.Any())
                        return source;

                    var index = indexes.First() + shift;

                    if (index >= source.Length)
                        return source;

                    return source.Remove(index);
                });
        }
    }
}
