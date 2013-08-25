using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingToOccurrence : ICaseIgnorable, IPositional
    {
        private readonly RemoveStringStarting _source;
        private readonly int _occurrenceCount;
        private readonly string _marker;
        private bool _ignoreCase;
        private The _position;

        internal RemoveStringStartingToOccurrence(RemoveStringStarting source, int occurrenceCount, string marker)
        {
            _source = source;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
            _ignoreCase = false;
            _position = The.Beginning;
        }

        public static implicit operator string(RemoveStringStartingToOccurrence removeStringStartingToOccurrence)
        {
            return removeStringStartingToOccurrence.ToString();
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
            _position = position;
        }

        #endregion
    }
}
