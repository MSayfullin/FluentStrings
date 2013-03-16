using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringAfterOccurrenceIgnoringCaseFrom
    {
        private readonly InsertStringAfterOccurrenceIgnoringCase _insertStringAfterOccurrenceIgnoringCase;
        private readonly The _position;

        internal InsertStringAfterOccurrenceIgnoringCaseFrom(InsertStringAfterOccurrenceIgnoringCase insertStringAfterOccurrenceIgnoringCase, The position)
        {
            _insertStringAfterOccurrenceIgnoringCase = insertStringAfterOccurrenceIgnoringCase;
            _position = position;
        }

        public static implicit operator string(InsertStringAfterOccurrenceIgnoringCaseFrom insertStringAfterOccurrenceIgnoringCaseFrom)
        {
            return insertStringAfterOccurrenceIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            return _insertStringAfterOccurrenceIgnoringCase.InsertStringAfterOccurrence.InsertString.Source.Insert(
                _insertStringAfterOccurrenceIgnoringCase.InsertStringAfterOccurrence.InsertString.Insertion, _insertStringAfterOccurrenceIgnoringCase.InsertStringAfterOccurrence.Marker,
                comparisonRule: StringComparison.CurrentCultureIgnoreCase, occurrenceCount: _insertStringAfterOccurrenceIgnoringCase.InsertStringAfterOccurrence.OccurrenceCount, position: _position, after: true);
        }
    }
}
