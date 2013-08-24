using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringAt : IPositional
    {
        private readonly InsertString _insertString;
        private readonly int _positionIndex;
        private The _position;

        internal InsertStringAt(InsertString insertString, int positionIndex)
        {
            _insertString = insertString;
            _positionIndex = positionIndex;
            _position = The.Beginning;
        }

        public static implicit operator string(InsertStringAt insertStringAt)
        {
            return insertStringAt.ToString();
        }

        public override string ToString()
        {
            if (_positionIndex < 0)
                throw new ArgumentOutOfRangeException("positionIndex", "Negative index is not supported");

            if (_insertString.Source.IsEmpty())
                return _insertString.Source;

            int positionIndex;
            switch (_position)
            {
                case The.Beginning:
                    positionIndex = _positionIndex;
                    break;
                case The.End:
                    positionIndex = _insertString.Source.Length - _positionIndex;
                    break;
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Insert().At().From() method");
            }
            return _insertString.Source.Insert(positionIndex, _insertString.Insertion ?? String.Empty);
        }

        #region IPositional Members

        void IPositional.Set(The position)
        {
            _position = position;
        }

        #endregion
    }
}
