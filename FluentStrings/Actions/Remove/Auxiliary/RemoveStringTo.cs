using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringTo
    {
        private readonly RemoveString _removeString;
        private readonly int _positionIndex;

        internal RemoveStringTo(RemoveString removeString, int positionIndex)
        {
            _removeString = removeString;
            _positionIndex = positionIndex;
        }

        internal RemoveString RemoveString { get { return _removeString; } }
        internal int PositionIndex { get { return _positionIndex; } }

        public static implicit operator string(RemoveStringTo removeStringTo)
        {
            return removeStringTo.ToString();
        }

        public override string ToString()
        {
            if (_positionIndex < 0)
            {
                throw new ArgumentOutOfRangeException("positionIndex", "Negative index is not supported");
            }

            if (_removeString.Source.IsEmpty())
            {
                return _removeString.Source;
            }

            if (_positionIndex >= _removeString.Source.Length)
            {
                return String.Empty;
            }
            return _removeString.Source.Substring(_positionIndex, _removeString.Source.Length - _positionIndex);
        }
    }
}
