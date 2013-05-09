using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBeforeAllIgnoringCase
    {
        private InsertStringBeforeAll _insertStringBeforeAll;

        internal InsertStringBeforeAllIgnoringCase(InsertStringBeforeAll insertStringBeforeAll)
        {
            _insertStringBeforeAll = insertStringBeforeAll;
        }

        public static implicit operator string(InsertStringBeforeAllIgnoringCase insertStringBeforeAllIgnoringCase)
        {
            return insertStringBeforeAllIgnoringCase.ToString();
        }

        public override string ToString()
        {
            return _insertStringBeforeAll.InsertString.Source.Insert(
                _insertStringBeforeAll.InsertString.Insertion, _insertStringBeforeAll.Marker,
                ignoreCase: true);
        }
    }
}
