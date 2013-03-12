using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringAfterAll
    {
        private readonly InsertString _insertString;
        private readonly string _marker;

        internal InsertStringAfterAll(InsertString insertString, string marker)
        {
            _insertString = insertString;
            _marker = marker;
        }

        public static implicit operator string(InsertStringAfterAll insertStringAfterAll)
        {
            return insertStringAfterAll.ToString();
        }

        public override string ToString()
        {
            return _insertString.Source.Insert(_insertString.Insertion, _marker, (s, i, m) => s.Replace(m, m + i));
        }
    }
}
