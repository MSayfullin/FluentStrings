using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Insert
{
    public class InsertStringAfterAll : ICaseIgnorable
    {
        private readonly InsertString _insertString;
        private readonly string _marker;
        private bool _ignoreCase;

        internal InsertStringAfterAll(InsertString insertString, string marker)
        {
            _insertString = insertString;
            _marker = marker;
            _ignoreCase = false;
        }

        public static implicit operator string(InsertStringAfterAll insertStringAfterAll)
        {
            return insertStringAfterAll.ToString();
        }

        public override string ToString()
        {
            return _ignoreCase
                ? _insertString.Source.Insert(_insertString.Insertion, _marker, _ignoreCase, after: true)
                : _insertString.Source.Insert(_insertString.Insertion, _marker, (s, i, m) => s.Replace(m, m + i));
        }

        #region ICaseIgnorable Members

        void ICaseIgnorable.IgnoreCase()
        {
            _ignoreCase = true;
        }

        #endregion
    }
}
