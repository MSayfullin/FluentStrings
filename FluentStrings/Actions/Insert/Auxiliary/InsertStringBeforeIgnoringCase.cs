using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBeforeIgnoringCase
    {
        private readonly InsertStringBefore _insertStringBefore;

        internal InsertStringBeforeIgnoringCase(InsertStringBefore insertStringBefore)
        {
            this._insertStringBefore = insertStringBefore;
        }

        public static implicit operator string(InsertStringBeforeIgnoringCase insertStringBeforeIgnoringCase)
        {
            return insertStringBeforeIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _insertStringBefore.InsertString.Source.Insert(
                _insertStringBefore.InsertString.Insertion, _insertStringBefore.Marker,
                comparisonRule: StringComparison.CurrentCultureIgnoreCase, occurrenceCount: 1);
        }
    }
}
