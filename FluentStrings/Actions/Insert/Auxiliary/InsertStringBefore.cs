using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBefore : ICaseIgnorable, IPositional
    {
        private readonly InsertString _insertString;
        private readonly string _marker;
        private bool _ignoreCase;
        private The _position;

        internal InsertStringBefore(InsertString insertString, string marker)
        {
            _insertString = insertString;
            _marker = marker;
            _ignoreCase = false;
            _position = The.Beginning;
        }

        public static implicit operator string(InsertStringBefore insertStringBefore)
        {
            return insertStringBefore.ToString();
        }

        public override string ToString()
        {
            return _insertString.Source.Insert(
                _insertString.Insertion, _marker, _ignoreCase, _position, occurrenceCount: 1);
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
