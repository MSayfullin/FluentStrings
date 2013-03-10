using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringAtFrom
    {
        private readonly InsertStringAt _insertStringAt;
        private readonly The _position;

        internal InsertStringAtFrom(InsertStringAt insertStringAt, The position)
        {
            _insertStringAt = insertStringAt;
            _position = position;
        }

        public static implicit operator string(InsertStringAtFrom insertStringAtFrom)
        {
            return insertStringAtFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _insertStringAt;
                case The.End:
                    if (_insertStringAt.InsertString.Source.IsEmpty())
                        return _insertStringAt.InsertString.Source;

                    int positionIndex = _insertStringAt.InsertString.Source.Length - _insertStringAt.PositionIndex;
                    return _insertStringAt.InsertString.Source.Insert(positionIndex, _insertStringAt.InsertString.Insertion ?? String.Empty);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Insert().At().From() method");
            }
        }
    }
}
