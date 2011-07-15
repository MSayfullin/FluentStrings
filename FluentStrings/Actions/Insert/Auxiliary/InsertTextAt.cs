using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertTextAt
    {
        private readonly InsertText _insertText;
        private readonly int _positionIndex;

        internal InsertTextAt(InsertText insertText, int positionIndex)
        {
            _insertText = insertText;
            _positionIndex = positionIndex;
        }

        internal InsertText InsertText { get { return _insertText; } }
        internal int PositionIndex { get { return _positionIndex; } }

        public static implicit operator string(InsertTextAt insertTextAt)
        {
            return insertTextAt.ToString();
        }

        public override string ToString()
        {
            return _insertText.Source == null
                ? _insertText
                : _insertText.Source.Insert(_positionIndex, _insertText.Insertion ?? String.Empty);
        }
    }
}
