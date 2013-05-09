using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBeforeOccurrenceIgnoringCase
    {
        private InsertStringBeforeOccurrence _insertStringBeforeOccurrence;

        internal InsertStringBeforeOccurrenceIgnoringCase(InsertStringBeforeOccurrence insertStringBeforeOccurrence)
        {
            this._insertStringBeforeOccurrence = insertStringBeforeOccurrence;
        }

        internal InsertStringBeforeOccurrence InsertStringBeforeOccurrence { get { return _insertStringBeforeOccurrence; } }

        public static implicit operator string(InsertStringBeforeOccurrenceIgnoringCase insertStringBeforeOccurrenceIgnoringCase)
        {
            return insertStringBeforeOccurrenceIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _insertStringBeforeOccurrence.InsertString.Source.Insert(
                _insertStringBeforeOccurrence.InsertString.Insertion, _insertStringBeforeOccurrence.Marker,
                ignoreCase: true, occurrenceCount: _insertStringBeforeOccurrence.OccurrenceCount);
        }
    }
}
