using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringAfterIgnoringCaseFrom
    {
        private readonly InsertStringAfterIgnoringCase _insertStringAfterIgnoringCase;
        private readonly The _position;

        internal InsertStringAfterIgnoringCaseFrom(InsertStringAfterIgnoringCase insertStringAfterIgnoringCase, The position)
        {
            _insertStringAfterIgnoringCase = insertStringAfterIgnoringCase;
            _position = position;
        }

        public static implicit operator string(InsertStringAfterIgnoringCaseFrom insertStringAfterIgnoringCaseFrom)
        {
            return insertStringAfterIgnoringCaseFrom.ToString();
        }

        public override string ToString()
        {
            return _insertStringAfterIgnoringCase.InsertStringAfter.InsertString.Source.Insert(
                _insertStringAfterIgnoringCase.InsertStringAfter.InsertString.Insertion, _insertStringAfterIgnoringCase.InsertStringAfter.Marker,
                ignoreCase: true, occurrenceCount: 1, position: _position, after: true);
        }
    }
}
