using System;
using dokas.FluentStrings.Actions.Utilities;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBeforeAll
    {
        private readonly InsertString _insertString;
        private readonly string _marker;

        internal InsertStringBeforeAll(InsertString insertString, string marker)
        {
            _insertString = insertString;
            _marker = marker;
        }

        internal InsertString InsertString { get { return _insertString; } }
        internal string Marker { get { return _marker; } }

        public static implicit operator string(InsertStringBeforeAll insertStringBeforeAll)
        {
            return insertStringBeforeAll.ToString();
        }

        public override string ToString()
        {
            return _insertString.Source.Insert(_insertString.Insertion, _marker, (s, i, m) => s.Replace(m, i + m));
        }
    }
}
