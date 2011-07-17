using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertTextAfterOccurrenceFrom
    {
        private readonly InsertTextAfterOccurrence _insertTextAfterOccurrence;
        private readonly Position _position;

        public InsertTextAfterOccurrenceFrom(InsertTextAfterOccurrence insertTextAfterOccurrence, Position position)
        {
            _insertTextAfterOccurrence = insertTextAfterOccurrence;
            _position = position;
        }

        public static implicit operator string(InsertTextAfterOccurrenceFrom insertTextAfterOccurrenceFrom)
        {
            return insertTextAfterOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(_insertTextAfterOccurrence.Marker))
                return _insertTextAfterOccurrence.InsertText.Source;
            else
            {
                if (_position == Position.Beginning)
                    return _insertTextAfterOccurrence;
                else
                {
                    int index = _insertTextAfterOccurrence.InsertText.Source.Length;
                    int passCounter = 0;
                    do
                    {
                        index = _insertTextAfterOccurrence.InsertText.Source.LastIndexOf(_insertTextAfterOccurrence.Marker, index - 1);
                        passCounter++;
                    }
                    while (passCounter < _insertTextAfterOccurrence.OccurrenceCount && index >= 0);

                    return index < 0
                        ? _insertTextAfterOccurrence.InsertText.Source
                        : _insertTextAfterOccurrence.InsertText.Source.Insert(index + _insertTextAfterOccurrence.Marker.Length, _insertTextAfterOccurrence.InsertText.Insertion ?? String.Empty);
                }
            }
        }
    }
}
