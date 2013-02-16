using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertTextAtFrom
    {
        private readonly InsertTextAt _insertTextAt;
        private readonly The _position;

        internal InsertTextAtFrom(InsertTextAt insertTextAt, The position)
        {
            _insertTextAt = insertTextAt;
            _position = position;
        }

        public static implicit operator string(InsertTextAtFrom insertTextAtFrom)
        {
            return insertTextAtFrom.ToString();
        }

        public override string ToString()
        {
            if (_position == The.Beginning || _insertTextAt.InsertText.Source == null)
                return _insertTextAt;
            else
            {
                int positionNumber = _insertTextAt.InsertText.Source.Length - _insertTextAt.PositionIndex;
                return _insertTextAt.InsertText.Source.Insert(positionNumber, _insertTextAt.InsertText.Insertion ?? String.Empty);
            }
        }
    }
}
