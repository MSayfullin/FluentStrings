using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringAt
    {
        private readonly InsertString _insertString;
        private readonly int _positionIndex;

        internal InsertStringAt(InsertString insertString, int positionIndex)
        {
            _insertString = insertString;
            _positionIndex = positionIndex;
        }

        internal InsertString InsertString { get { return _insertString; } }
        internal int PositionIndex { get { return _positionIndex; } }

        public static implicit operator string(InsertStringAt insertStringAt)
        {
            return insertStringAt.ToString();
        }

        public override string ToString()
        {
            if (_positionIndex < 0)
            {
                throw new ArgumentOutOfRangeException("positionIndex", "Negative index is not supported");
            }

            return _insertString.Source.IsEmpty()
                ? _insertString.Source
                : _insertString.Source.Insert(_positionIndex, _insertString.Insertion ?? String.Empty);
        }
    }
}
