using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBeforeOccurrenceFrom
    {
        private readonly InsertStringBeforeOccurrence _insertStringBeforeOccurrence;
        private readonly The _position;

        public InsertStringBeforeOccurrenceFrom(InsertStringBeforeOccurrence insertStringBeforeOccurrence, The position)
        {
            _insertStringBeforeOccurrence = insertStringBeforeOccurrence;
            _position = position;
        }

        public static implicit operator string(InsertStringBeforeOccurrenceFrom insertStringBeforeOccurrenceFrom)
        {
            return insertStringBeforeOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            return _insertStringBeforeOccurrence.InsertString.Source
                .Insert(_insertStringBeforeOccurrence.InsertString.Insertion, _insertStringBeforeOccurrence.Marker, _insertStringBeforeOccurrence.OccurrenceCount, _position);
        }
    }
}
