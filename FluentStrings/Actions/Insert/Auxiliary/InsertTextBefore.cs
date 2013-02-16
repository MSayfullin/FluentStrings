using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertTextBefore
    {
        private readonly InsertText _insertText;
        private readonly string _marker;

        internal InsertTextBefore(InsertText insertText, string marker)
        {
            _insertText = insertText;
            _marker = marker;
        }

        public static implicit operator string(InsertTextBefore insertTextBefore)
        {
            return insertTextBefore.ToString();
        }

        public override string ToString()
        {
            if (_insertText.Source != null)
            {
                return _marker.IsEmpty()
                    ? _insertText.Source
                    : _insertText.Source.Replace(_marker, (_insertText.Insertion ?? String.Empty) + _marker);
            }
            else
                return _marker == null ? _insertText.Insertion : null;
        }
    }
}
