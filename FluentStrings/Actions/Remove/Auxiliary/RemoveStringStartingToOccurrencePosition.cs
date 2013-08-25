using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingToOccurrencePosition : ICaseIgnorable, IPositional
    {
        private readonly RemoveStringStarting _source;
        private readonly The _position;
        private readonly int _occurrenceCount;
        private readonly string _marker;
        private bool _ignoreCase;
        private The _from;

        internal RemoveStringStartingToOccurrencePosition(RemoveStringStarting source, The position, int occurrenceCount, string marker)
        {
            _source = source;
            _position = position;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
            _ignoreCase = false;
            _from = The.Beginning;
        }

        public static implicit operator string(RemoveStringStartingToOccurrencePosition removeStringStartingToOccurrencePosition)
        {
            return removeStringStartingToOccurrencePosition.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
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
