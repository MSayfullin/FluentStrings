using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBeforeOccurrence : ICaseIgnorable, IPositional
    {
        private readonly InsertString _insertString;
        private readonly int _occurrenceCount;
        private readonly string _marker;
        private bool _ignoreCase;
        private The _position;

        internal InsertStringBeforeOccurrence(InsertString insertString, int occurrenceCount, string marker)
        {
            _insertString = insertString;
            _occurrenceCount = occurrenceCount;
            _marker = marker;
            _ignoreCase = false;
            _position = The.Beginning;
        }

        public static implicit operator string(InsertStringBeforeOccurrence insertStringBeforeOccurrence)
        {
            return insertStringBeforeOccurrence.ToString();
        }

        public override string ToString()
        {
            return _insertString.Source.Insert(_insertString.Insertion, _marker, _ignoreCase, _position, _occurrenceCount);
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
