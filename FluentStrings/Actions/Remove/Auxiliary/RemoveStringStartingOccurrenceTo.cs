using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingOccurrenceTo : IPositional
    {
        private readonly RemoveStringStartingOccurrence _removeStringStartingOccurrence;
        private readonly int _positionIndex;
        private The _position;

        internal RemoveStringStartingOccurrenceTo(RemoveStringStartingOccurrence removeStringStartingOccurrence, int positionIndex)
        {
            _removeStringStartingOccurrence = removeStringStartingOccurrence;
            _positionIndex = positionIndex;
            _position = The.Beginning;
        }

        public static implicit operator string(RemoveStringStartingOccurrenceTo removeStringStartingOccurrenceTo)
        {
            return removeStringStartingOccurrenceTo.ToString();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        #region IPositional Members

        void IPositional.Set(The position)
        {
            _position = position;
        }

        #endregion
    }
}
