using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringAfterOccurrenceFrom
    {
        private readonly InsertStringAfterOccurrence _insertStringAfterOccurrence;
        private readonly The _position;

        public InsertStringAfterOccurrenceFrom(InsertStringAfterOccurrence insertStringAfterOccurrence, The position)
        {
            _insertStringAfterOccurrence = insertStringAfterOccurrence;
            _position = position;
        }

        public static implicit operator string(InsertStringAfterOccurrenceFrom insertStringAfterOccurrenceFrom)
        {
            return insertStringAfterOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _insertStringAfterOccurrence;
                case The.End:
                    if (_insertStringAfterOccurrence.Marker.IsEmpty())
                        return _insertStringAfterOccurrence.InsertString.Source;

                    int index = _insertStringAfterOccurrence.InsertString.Source.Length;
                    int passCounter = 0;
                    do
                    {
                        index = _insertStringAfterOccurrence.InsertString.Source.LastIndexOf(_insertStringAfterOccurrence.Marker, index - 1);
                        passCounter++;
                    }
                    while (passCounter < _insertStringAfterOccurrence.OccurrenceCount && index >= 0);

                    return index < 0
                        ? _insertStringAfterOccurrence.InsertString.Source
                        : _insertStringAfterOccurrence.InsertString.Source.Insert(index + _insertStringAfterOccurrence.Marker.Length, _insertStringAfterOccurrence.InsertString.Insertion ?? String.Empty);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Insert().After().From() method");
            }
        }
    }
}
