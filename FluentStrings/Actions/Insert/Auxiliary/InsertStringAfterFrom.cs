using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringAfterFrom
    {
        private readonly InsertStringAfter _insertStringAfter;
        private readonly The _position;

        internal InsertStringAfterFrom(InsertStringAfter insertStringAfter, The position)
        {
            _insertStringAfter = insertStringAfter;
            _position = position;
        }

        public static implicit operator string(InsertStringAfterFrom insertStringAfterFrom)
        {
            return insertStringAfterFrom.ToString();
        }

        public override string ToString()
        {
            return _insertStringAfter.InsertString.Source.Insert(
                _insertStringAfter.InsertString.Insertion, _insertStringAfter.Marker,
                occurrenceCount: 1, position: _position, after: true);
        }
    }
}
