using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringAfter
    {
        private readonly InsertString _insertString;
        private readonly string _marker;

        internal InsertStringAfter(InsertString insertString, string marker)
        {
            this._insertString = insertString;
            this._marker = marker;
        }

        internal InsertString InsertString { get { return _insertString; } }
        internal string Marker { get { return _marker; } }

        public static implicit operator string(InsertStringAfter insertStringAfter)
        {
            return insertStringAfter.ToString();
        }

        public override string ToString()
        {
            return _insertString.Source.Insert(_insertString.Insertion, _marker, occurrenceCount: 1, after: true);
        }
    }
}
