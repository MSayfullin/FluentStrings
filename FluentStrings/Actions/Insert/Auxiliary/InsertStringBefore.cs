using System;
using dokas.FluentStrings.Actions.Utilities;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBefore
    {
        private readonly InsertString _insertString;
        private readonly string _marker;

        internal InsertStringBefore(InsertString insertString, string marker)
        {
            _insertString = insertString;
            _marker = marker;
        }

        public static implicit operator string(InsertStringBefore insertStringBefore)
        {
            return insertStringBefore.ToString();
        }

        public override string ToString()
        {
            return _insertString.Source.Insert(_insertString.Insertion, _marker, (s, i, m) => s.Replace(m, i + m));
        }
    }
}
