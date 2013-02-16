using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertTextBeforeOccurrenceFrom
    {
        private readonly InsertTextBeforeOccurrence _insertTextBeforeOccurrence;
        private readonly The _position;

        public InsertTextBeforeOccurrenceFrom(InsertTextBeforeOccurrence insertTextBeforeOccurrence, The position)
        {
            _insertTextBeforeOccurrence = insertTextBeforeOccurrence;
            _position = position;
        }

        public static implicit operator string(InsertTextBeforeOccurrenceFrom insertTextBeforeOccurrenceFrom)
        {
            return insertTextBeforeOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _insertTextBeforeOccurrence;
                case The.End:
                    if (_insertTextBeforeOccurrence.Marker.IsEmpty())
                        return _insertTextBeforeOccurrence.InsertText.Source;

                    int index = _insertTextBeforeOccurrence.InsertText.Source.Length;
                    int passCounter = 0;
                    do
                    {
                        index = _insertTextBeforeOccurrence.InsertText.Source.LastIndexOf(_insertTextBeforeOccurrence.Marker, index - 1);
                        passCounter++;
                    }
                    while (passCounter < _insertTextBeforeOccurrence.OccurrenceCount && index >= 0);

                    return index < 0
                        ? _insertTextBeforeOccurrence.InsertText.Source
                        : _insertTextBeforeOccurrence.InsertText.Source.Insert(index, _insertTextBeforeOccurrence.InsertText.Insertion ?? String.Empty);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Insert().Before().From() method");
            }
        }
    }
}
