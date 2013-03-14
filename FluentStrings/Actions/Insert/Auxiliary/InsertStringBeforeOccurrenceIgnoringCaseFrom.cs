using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBeforeOccurrenceIgnoringCaseFrom
    {
        private InsertStringBeforeOccurrenceIgnoringCase _insertStringBeforeOccurrenceIgnoringCase;
        private The _position;

        internal InsertStringBeforeOccurrenceIgnoringCaseFrom(InsertStringBeforeOccurrenceIgnoringCase insertStringBeforeOccurrenceIgnoringCase, The position)
        {
            _insertStringBeforeOccurrenceIgnoringCase = insertStringBeforeOccurrenceIgnoringCase;
            _position = position;
        }

        public static implicit operator string(InsertStringBeforeOccurrenceIgnoringCaseFrom insertStringBeforeOccurrenceIgnoringCaseFrom)
        {
            return insertStringBeforeOccurrenceIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            return _insertStringBeforeOccurrenceIgnoringCase.InsertStringBeforeOccurrence.InsertString.Source.Insert(
                _insertStringBeforeOccurrenceIgnoringCase.InsertStringBeforeOccurrence.InsertString.Insertion, _insertStringBeforeOccurrenceIgnoringCase.InsertStringBeforeOccurrence.Marker,
                comparisonRule: StringComparison.CurrentCultureIgnoreCase, occurrenceCount: _insertStringBeforeOccurrenceIgnoringCase.InsertStringBeforeOccurrence.OccurrenceCount, position: _position);
        }
    }
}
