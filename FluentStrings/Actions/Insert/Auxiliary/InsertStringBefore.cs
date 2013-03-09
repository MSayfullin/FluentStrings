using System;
using dokas.FluentStrings.Actions.Utilities;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBefore
    {
        private readonly InsertString _insertString;
        private readonly string _marker;

        internal InsertStringBefore(InsertString insertString, string marker)
        {
            _insertString = insertString;
            _marker = marker;
        }

        public static implicit operator string(InsertStringBefore insertStringBefore)
        {
            return insertStringBefore.ToString();
        }

        public override string ToString()
        {
            switch (_insertString.Source.ToKeyWith(_insertString.Insertion, _marker))
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
                    return _insertString.Insertion;
                case "value-null-null":
                case "value-null-empty":
                case "value-null-value":
                case "value-empty-null":
                case "value-empty-empty":
                case "value-empty-value":
                case "value-value-null":
                case "value-value-empty":
                    return _insertString.Source;
                case "value-value-value":
                    return _insertString.Source.Replace(_marker, (_insertString.Insertion ?? String.Empty) + _marker);
                default:
                    throw new ArgumentOutOfRangeException("Didn't you forget to regenerate case statements for changed key?");
            }
        }
    }
}
