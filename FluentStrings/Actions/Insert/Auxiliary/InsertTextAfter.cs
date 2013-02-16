using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertTextAfter
    {
        private readonly InsertText _insertText;
        private readonly string _marker;

        internal InsertTextAfter(InsertText insertText, string marker)
        {
            _insertText = insertText;
            _marker = marker;
        }

        public static implicit operator string(InsertTextAfter insertTextAfter)
        {
            return insertTextAfter.ToString();
        }

        public override string ToString()
        {
            if (_insertText.Source != null)
            {
                return _marker.IsEmpty()
                    ? _insertText.Source
                    : _insertText.Source.Replace(_marker, _marker + (_insertText.Insertion ?? String.Empty));
            }
            else
                return _marker == null ? _insertText.Insertion : null;
        }
    }
}
