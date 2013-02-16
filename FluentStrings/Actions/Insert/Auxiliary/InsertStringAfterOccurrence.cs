using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringAfterOccurrence
    {
        private readonly InsertString _insertString;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal InsertStringAfterOccurrence(InsertString insertString, int occurrenceCount, string marker)
        {
            _insertString = insertString;
            _occurrenceCount = Math.Max(occurrenceCount, 1);
            _marker = marker;
        }

        internal InsertString InsertString { get { return _insertString; } }
        internal int OccurrenceCount { get { return _occurrenceCount; } }
        internal string Marker { get { return _marker; } }

        public static implicit operator string(InsertStringAfterOccurrence insertStringAfterOccurrence)
        {
            return insertStringAfterOccurrence.ToString();
        }

        public override string ToString()
        {
            if (_marker.IsEmpty())
                return _insertString.Source;
            else
            {
                int index = -1;
                int passCounter = 0;
                do
                {
                    index = _insertString.Source.IndexOf(_marker, index + 1);
                    passCounter++;
                }
                while (passCounter < _occurrenceCount && index >= 0);

                return index < 0
                    ? _insertString.Source
                    : _insertString.Source.Insert(index + _marker.Length, _insertString.Insertion ?? String.Empty);
            }
        }
    }
}
