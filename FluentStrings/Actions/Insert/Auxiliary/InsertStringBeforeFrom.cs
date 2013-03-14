using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBeforeFrom
    {
        private readonly InsertStringBefore _insertStringBefore;
        private readonly The _position;

        public InsertStringBeforeFrom(InsertStringBefore insertStringBefore, The position)
        {
            _insertStringBefore = insertStringBefore;
            _position = position;
        }

        public static implicit operator string(InsertStringBeforeFrom insertStringBeforeFrom)
        {
            return insertStringBeforeFrom.ToString();
        }

        public override string ToString()
        {
            return _insertStringBefore.InsertString.Source.Insert(
                _insertStringBefore.InsertString.Insertion, _insertStringBefore.Marker, occurrenceCount: 1, position: _position);
        }
    }
}
