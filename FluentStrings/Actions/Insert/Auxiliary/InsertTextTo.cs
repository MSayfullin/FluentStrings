using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertTextTo
    {
        private readonly InsertText _insertText;
        private readonly Position _position;

        internal InsertTextTo(InsertText insertText, Position position)
        {
            if (position == Position.Anywhere)
                throw new ArgumentException();

            _insertText = insertText;
            _position = position;
        }

        public static implicit operator string(InsertTextTo insertTextTo)
        {
            return insertTextTo.ToString();
        }

        public override string ToString()
        {
            return _position == Position.Beginning
                ? _insertText
                : (_insertText.Source == null && _insertText.Insertion == null)
                    ? null
                    : _insertText.Source + _insertText.Insertion;
        }
    }
}
