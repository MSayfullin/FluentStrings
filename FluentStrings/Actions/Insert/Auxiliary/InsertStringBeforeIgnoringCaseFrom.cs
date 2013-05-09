using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBeforeIgnoringCaseFrom
    {
        private readonly InsertStringBeforeIgnoringCase _insertStringBeforeIgnoringCase;
        private readonly The _position;

        internal InsertStringBeforeIgnoringCaseFrom(InsertStringBeforeIgnoringCase insertStringBeforeIgnoringCase, The position)
        {
            _insertStringBeforeIgnoringCase = insertStringBeforeIgnoringCase;
            _position = position;
        }

        public static implicit operator string(InsertStringBeforeIgnoringCaseFrom insertStringBeforeIgnoringCaseFrom)
        {
            return insertStringBeforeIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            return _insertStringBeforeIgnoringCase.InsertStringBefore.InsertString.Source.Insert(
                _insertStringBeforeIgnoringCase.InsertStringBefore.InsertString.Insertion, _insertStringBeforeIgnoringCase.InsertStringBefore.Marker,
                ignoreCase: true, occurrenceCount: 1, position: _position);
        }
    }
}
