using System;
using System.Collections.Generic;

namespace dokas.FluentStrings.Actions.Utilities
{
    internal static class CommonLogic
    {
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
    }
}
