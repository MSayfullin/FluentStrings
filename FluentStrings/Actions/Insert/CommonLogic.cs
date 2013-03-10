using System;
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
    }
}
