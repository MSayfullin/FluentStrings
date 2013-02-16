using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBeforeOccurrenceFrom
    {
        private readonly InsertStringBeforeOccurrence _insertStringBeforeOccurrence;
        private readonly The _position;

        public InsertStringBeforeOccurrenceFrom(InsertStringBeforeOccurrence insertStringBeforeOccurrence, The position)
        {
            _insertStringBeforeOccurrence = insertStringBeforeOccurrence;
            _position = position;
        }

        public static implicit operator string(InsertStringBeforeOccurrenceFrom insertStringBeforeOccurrenceFrom)
        {
            return insertStringBeforeOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _insertStringBeforeOccurrence;
                case The.End:
                    if (_insertStringBeforeOccurrence.Marker.IsEmpty())
                        return _insertStringBeforeOccurrence.InsertString.Source;

                    int index = _insertStringBeforeOccurrence.InsertString.Source.Length;
                    int passCounter = 0;
                    do
                    {
                        index = _insertStringBeforeOccurrence.InsertString.Source.LastIndexOf(_insertStringBeforeOccurrence.Marker, index - 1);
                        passCounter++;
                    }
                    while (passCounter < _insertStringBeforeOccurrence.OccurrenceCount && index >= 0);

                    return index < 0
                        ? _insertStringBeforeOccurrence.InsertString.Source
                        : _insertStringBeforeOccurrence.InsertString.Source.Insert(index, _insertStringBeforeOccurrence.InsertString.Insertion ?? String.Empty);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Insert().Before().From() method");
            }
        }
    }
}
