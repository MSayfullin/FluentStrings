using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertTextAtFrom
    {
        private readonly InsertTextAt _insertTextAt;
        private readonly Position _position;

        internal InsertTextAtFrom(InsertTextAt insertTextAt, Position position)
        {
            if (position == Position.Anywhere)
                throw new ArgumentException();

            _insertTextAt = insertTextAt;
            _position = position;
        }

        public static implicit operator string(InsertTextAtFrom insertTextAtFrom)
        {
            return insertTextAtFrom.ToString();
        }

        public override string ToString()
        {
            if (_position == Position.Beginning || _insertTextAt.InsertText.Source == null)
                return _insertTextAt;
            else
            {
                int positionNumber = _insertTextAt.InsertText.Source.Length - _insertTextAt.PositionIndex;
                return _insertTextAt.InsertText.Source.Insert(positionNumber, _insertTextAt.InsertText.Insertion ?? String.Empty);
            }
        }
    }
}
