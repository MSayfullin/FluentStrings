using System;

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

        internal InsertString InsertString { get { return _insertString; } }
        internal string Marker { get { return _marker; } }

        public static implicit operator string(InsertStringBefore insertStringBefore)
        {
            return insertStringBefore.ToString();
        }

        public override string ToString()
        {
            return _insertString.Source.Insert(_insertString.Insertion, _marker, occurrenceCount: 1);
        }
    }
}
