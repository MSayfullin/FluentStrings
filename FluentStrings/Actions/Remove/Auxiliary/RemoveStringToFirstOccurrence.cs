using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToFirstOccurrence : ICaseIgnorable, IPositional
    {
        private readonly RemoveString _removeString;
        private readonly string _marker;
        private bool _ignoreCase;
        private The _position;

        internal RemoveStringToFirstOccurrence(RemoveString removeString, string marker)
        {
            _removeString = removeString;
            _marker = marker;
            _ignoreCase = false;
            _position = The.Beginning;
        }

        public static implicit operator string(RemoveStringToFirstOccurrence removeStringToFirstOccurrence)
        {
            return removeStringToFirstOccurrence.ToString();
        }

        public override string ToString()
        {
            return _removeString.Source.RemoveStartingOrTo(_marker, _ignoreCase, _position, isStarting: false);
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
            _position = position;
        }

        #endregion
    }
}
