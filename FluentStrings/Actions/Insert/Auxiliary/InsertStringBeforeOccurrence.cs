using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBeforeOccurrence
    {
        private readonly InsertString _insertString;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal InsertStringBeforeOccurrence(InsertString insertString, int occurrenceCount, string marker)
        {
            _insertString = insertString;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
        }

        internal InsertString InsertString { get { return _insertString; } }
        internal int OccurrenceCount { get { return _occurrenceCount; } }
        internal string Marker { get { return _marker; } }

        public static implicit operator string(InsertStringBeforeOccurrence insertStringBeforeOccurrence)
        {
            return insertStringBeforeOccurrence.ToString();
        }

        public override string ToString()
        {
            return _insertString.Source.Insert(_insertString.Insertion, _marker, occurrenceCount: _occurrenceCount);
        }
    }
}
