using System;
using dokas.FluentStrings.Actions.Common;
using dokas.FluentStrings.Actions.Utilities;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringBeforeAll : ICaseIgnorable
    {
        private readonly InsertString _insertString;
        private readonly string _marker;
        private bool _ignoreCase;

        internal InsertStringBeforeAll(InsertString insertString, string marker)
        {
            _insertString = insertString;
            _marker = marker;
            _ignoreCase = false;
        }

        public static implicit operator string(InsertStringBeforeAll insertStringBeforeAll)
        {
            return insertStringBeforeAll.ToString();
        }

        public override string ToString()
        {
            return _ignoreCase
                ? _insertString.Source.Insert(_insertString.Insertion, _marker, _ignoreCase)
                : _insertString.Source.Insert(_insertString.Insertion, _marker, (s, i, m) => s.Replace(m, i + m));
        }

        #region ICaseIgnorable Members

        void ICaseIgnorable.IgnoreCase()
        {
            _ignoreCase = true;
        }

        #endregion
    }
}
