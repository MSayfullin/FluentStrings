using System;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertTextAtFrom
    {
        private readonly InsertTextAt _insertTextAt;
        private readonly The _position;

        internal InsertTextAtFrom(InsertTextAt insertTextAt, The position)
        {
            _insertTextAt = insertTextAt;
            _position = position;
        }

        public static implicit operator string(InsertTextAtFrom insertTextAtFrom)
        {
            return insertTextAtFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _insertTextAt;
                case The.End:
                    if (_insertTextAt.InsertText.Source == null)
                        return _insertTextAt;

                    int positionIndex = _insertTextAt.InsertText.Source.Length - _insertTextAt.PositionIndex;
                    return _insertTextAt.InsertText.Source.Insert(positionIndex, _insertTextAt.InsertText.Insertion ?? String.Empty);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Insert().At().From() method");
            }
        }
    }
}
