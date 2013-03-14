using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringAfterAllIgnoringCase
    {
        private readonly InsertStringAfterAll _insertStringAfterAll;

        internal InsertStringAfterAllIgnoringCase(InsertStringAfterAll insertStringAfterAll)
        {
            this._insertStringAfterAll = insertStringAfterAll;
        }

        public static implicit operator string(InsertStringAfterAllIgnoringCase insertStringAfterAllIgnoringCase)
        {
            return insertStringAfterAllIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _insertStringAfterAll.InsertString.Source.Insert(
                _insertStringAfterAll.InsertString.Insertion, _insertStringAfterAll.Marker,
                comparisonRule: StringComparison.CurrentCultureIgnoreCase, after: true);
        }
    }
}
