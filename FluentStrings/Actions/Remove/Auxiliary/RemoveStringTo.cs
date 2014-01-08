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
            return _removeString.Source.RemoveTo(_positionIndex, _position);
        }

        #region IPositional Members

        void IPositional.Set(The position)
        {
            _position = position;
        }

        #endregion
    }
}
