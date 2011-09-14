using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertTextAfterOccurrence
    {
        private readonly InsertText _insertText;
        private readonly int _occurrenceCount;
        private readonly string _marker;

        internal InsertTextAfterOccurrence(InsertText insertText, int occurrenceCount, string marker)
        {
            _insertText = insertText;
            _occurrenceCount = Math.Max(occurrenceCount, 1);
            _marker = marker;
        }

        internal InsertText InsertText { get { return _insertText; } }
        internal int OccurrenceCount { get { return _occurrenceCount; } }
        internal string Marker { get { return _marker; } }

        public static implicit operator string(InsertTextAfterOccurrence insertTextAfterOccurrence)
        {
            return insertTextAfterOccurrence.ToString();
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(_marker))
                return _insertText.Source;
            else
            {
                int index = -1;
                int passCounter = 0;
                do
                {
                    index = _insertText.Source.IndexOf(_marker, index + 1);
                    passCounter++;
                }
                while (passCounter < _occurrenceCount && index >= 0);

                return index < 0
                    ? _insertText.Source
                    : _insertText.Source.Insert(index + _marker.Length, _insertText.Insertion ?? String.Empty);
            }
        }
    }
}
