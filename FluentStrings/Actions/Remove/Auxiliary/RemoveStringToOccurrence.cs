using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToOccurrence : ICaseIgnorable, IPositional
    {
        private readonly RemoveString _removeString;
        private readonly int _occurrenceCount;
        private readonly string _marker;
        private bool _ignoreCase;
        private The _position;

        internal RemoveStringToOccurrence(RemoveString removeString, int occurrenceCount, string marker)
        {
            _removeString = removeString;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
            _ignoreCase = false;
            _position = The.Beginning;
        }

        public static implicit operator string(RemoveStringToOccurrence removeStringToOccurrence)
        {
            return removeStringToOccurrence.ToString();
        }

        public override string ToString()
        {
            return _removeString.Source.RemoveStartingOrTo(
                _occurrenceCount, _marker, _ignoreCase, _position, isStarting: false);
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
