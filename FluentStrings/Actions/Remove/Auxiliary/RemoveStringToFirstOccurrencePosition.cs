using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToFirstOccurrencePosition : ICaseIgnorable, IPositional
    {
        private readonly RemoveString _removeString;
        private readonly The _position;
        private readonly string _marker;
        private bool _ignoreCase;
        private The _from;

        internal RemoveStringToFirstOccurrencePosition(RemoveString removeString, The position, string marker)
        {
            _removeString = removeString;
            _position = position;
            _marker = marker;
            _ignoreCase = false;
            _from = The.Beginning;
        }

        public static implicit operator string(RemoveStringToFirstOccurrencePosition removeStringToFirstOccurrencePosition)
        {
            return removeStringToFirstOccurrencePosition.ToString();
        }

        public override string ToString()
        {
            return _removeString.Source.RemoveStartingOrToPosition(
                _position, 1, _marker,
                _ignoreCase, _from, isStarting: false);
        }

        #region ICaseIgnorable Members

        void ICaseIgnorable.IgnoreCase()
        {
            _ignoreCase = true;
        }

        #endregion

        #region IPositional Members

        void IPositional.Set(The position)
        {
            _from = position;
        }

        #endregion
    }
}
