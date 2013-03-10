using System;
using System.Linq;

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
            if (_occurrenceCount < 0)
                throw new ArgumentOutOfRangeException("occurrence", "Negative occurrence count is not supported");

            if (_occurrenceCount == 0)
                return _insertString.Source;

            return _insertString.Source.Insert(_insertString.Insertion, _marker, InsertAction);
        }

        private string InsertAction(string source, string insertion, string marker)
        {
            var indexes = source.IndexesOf(marker).Take(_occurrenceCount).ToArray();
            return indexes.Any() ? source.Insert(indexes.Last(), insertion) : source;
        }
    }
}
