using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringAfterOccurrenceFrom
    {
        private readonly InsertStringAfterOccurrence _insertStringAfterOccurrence;
        private readonly The _position;

        public InsertStringAfterOccurrenceFrom(InsertStringAfterOccurrence insertStringAfterOccurrence, The position)
        {
            _insertStringAfterOccurrence = insertStringAfterOccurrence;
            _position = position;
        }

        public static implicit operator string(InsertStringAfterOccurrenceFrom insertStringAfterOccurrenceFrom)
        {
            return insertStringAfterOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            return _insertStringAfterOccurrence.InsertString.Source.Insert(
                _insertStringAfterOccurrence.InsertString.Insertion, _insertStringAfterOccurrence.Marker,
                occurrenceCount: _insertStringAfterOccurrence.OccurrenceCount, position: _position, after: true);
        }
    }
}
