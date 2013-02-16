using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertTextAfterOccurrenceFrom
    {
        private readonly InsertTextAfterOccurrence _insertTextAfterOccurrence;
        private readonly The _position;

        public InsertTextAfterOccurrenceFrom(InsertTextAfterOccurrence insertTextAfterOccurrence, The position)
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
            switch (_position)
            {
                case The.Beginning:
                    return _insertTextAfterOccurrence;
                case The.End:
                    if (_insertTextAfterOccurrence.Marker.IsEmpty())
                        return _insertTextAfterOccurrence.InsertText.Source;

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
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Insert().After().From() method");
            }
        }
    }
}
