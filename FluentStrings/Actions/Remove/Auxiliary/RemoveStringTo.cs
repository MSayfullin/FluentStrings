using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringTo : IPositional
    {
        private readonly RemoveString _removeString;
        private readonly int _positionIndex;
        private The _position;

        internal RemoveStringTo(RemoveString removeString, int positionIndex)
        {
            _removeString = removeString;
            _positionIndex = positionIndex;
            _position = The.Beginning;
        }

        public static implicit operator string(RemoveStringTo removeStringTo)
        {
            return removeStringTo.ToString();
        }

        public override string ToString()
        {
            if (_positionIndex < 0)
                throw new ArgumentOutOfRangeException("positionIndex", "Negative index is not supported");

            if (_removeString.Source.IsEmpty())
                return _removeString.Source;

            if (_positionIndex >= _removeString.Source.Length)
                return String.Empty;

            switch (_position)
            {
                case The.Beginning:
                    return _removeString.Source.Substring(_positionIndex, _removeString.Source.Length - _positionIndex);
                case The.End:
                    return _removeString.Source.Substring(0, _removeString.Source.Length - _positionIndex);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().To().From() method");
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
