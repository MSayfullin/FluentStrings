using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveAll : ICaseIgnorable
    {
        private readonly string _source;
        private readonly string _extraction;
        private bool _ignoreCase;

        internal RemoveAll(string source, string extraction)
        {
            _source = source;
            _extraction = extraction;
            _ignoreCase = false;
        }

        public static implicit operator string(RemoveAll removeAll)
        {
            return removeAll.ToString();
        }

        public override string ToString()
        {
            return _ignoreCase
                ? _source.RemoveValues(null, _extraction, ignoreCase: true)
                : _source.Remove(_extraction, (s, e) => s.Replace(e, String.Empty));
        }

        #region ICaseIgnorable Members

        void ICaseIgnorable.IgnoreCase()
        {
            _ignoreCase = true;
        }

        #endregion
    }
}
