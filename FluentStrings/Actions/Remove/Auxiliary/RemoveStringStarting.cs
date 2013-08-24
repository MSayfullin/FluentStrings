using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStarting : IPositional
    {
        private readonly RemoveString _removeString;
        private readonly int _positionIndex;
        private The _position;

        internal RemoveStringStarting(RemoveString removeString, int positionIndex)
        {
            _removeString = removeString;
            _positionIndex = positionIndex;
            _position = The.Beginning;
        }

        internal RemoveString RemoveString { get { return _removeString; } }
        internal int PositionIndex { get { return _positionIndex; } }
        internal The Position { get { return _position; } }

        public static implicit operator string(RemoveStringStarting removeStringStarting)
        {
            return removeStringStarting.ToString();
        }

        public override string ToString()
        {
            if (_positionIndex < 0)
                throw new ArgumentOutOfRangeException("positionIndex", "Negative index is not supported");

            if (_removeString.Source.IsEmpty() || _positionIndex >= _removeString.Source.Length)
                return _removeString.Source;

            switch (_position)
            {
                case The.Beginning:
                    return _removeString.Source.Substring(0, _positionIndex);
                case The.End:
                    return _removeString.Source.Substring(_removeString.Source.Length - _positionIndex, _positionIndex);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().Starting().From() method");
            }
        }

        #region IPositional Members

        void IPositional.Set(The position)
        {
            _position = position;
        }

        #endregion
    }
}
