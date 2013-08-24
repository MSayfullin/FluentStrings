using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValues : ICaseIgnorable, IPositional
    {
        private readonly string _source;
        private readonly int _quantity;
        private readonly string _extraction;
        private bool _ignoreCase;
        private The _position;

        internal RemoveValues(string source, int quantity, string extraction)
        {
            _source = source;
            _quantity = quantity;
            _extraction = extraction;
            _ignoreCase = false;
            _position = The.Beginning;
        }

        public static implicit operator string(RemoveValues removeValues)
        {
            return removeValues.ToString();
        }

        public override string ToString()
        {
            return _source.RemoveValues(_quantity, _extraction, _ignoreCase, _position);
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
