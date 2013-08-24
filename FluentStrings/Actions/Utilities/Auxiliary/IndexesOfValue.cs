using System.Collections;
using System.Collections.Generic;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Utilities
{
    public class IndexesOfValue : IEnumerable<int>, ICaseIgnorable, IPositional
    {
        private readonly string _source;
        private readonly string _marker;
        private bool _ignoreCase;
        private The _position;

        internal IndexesOfValue(string source, string marker)
        {
            _source = source;
            _marker = marker;
            _ignoreCase = false;
            _position = The.Beginning;
        }

        internal string Source { get { return _source; } }
        internal string Marker { get { return _marker; } }

        private IEnumerable<int> AsEnumerable()
        {
            return _source.IndexesOf(_marker, _ignoreCase, _position);
        }

        #region IEnumerable Members

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return AsEnumerable().GetEnumerator();
        }

        #endregion

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
