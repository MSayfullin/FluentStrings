using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertTextBeforeOccurrenceFrom
    {
        private readonly InsertTextBeforeOccurrence _insertTextBeforeOccurrence;
        private readonly Position _position;

        public InsertTextBeforeOccurrenceFrom(InsertTextBeforeOccurrence insertTextBeforeOccurrence, Position position)
        {
            if (position == Position.Anywhere)
                throw new ArgumentException();

            _insertTextBeforeOccurrence = insertTextBeforeOccurrence;
            _position = position;
        }

        public static implicit operator string(InsertTextBeforeOccurrenceFrom insertTextBeforeOccurrenceFrom)
        {
            return insertTextBeforeOccurrenceFrom.ToString();
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(_insertTextBeforeOccurrence.Marker))
                return _insertTextBeforeOccurrence.InsertText.Source;
            else
            {
                if (_position == Position.Beginning)
                    return _insertTextBeforeOccurrence;
                else
                {
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
                }
            }
        }
    }
}
