using System.Collections;
using System.Collections.Generic;

namespace dokas.FluentStrings.Actions.Utilities
{
    public class IndexesOfValue : IEnumerable<int>
    {
        private readonly string _source;
        private readonly string _marker;

        internal IndexesOfValue(string source, string marker)
        {
            _source = source;
            _marker = marker;
        }

        internal string Source { get { return _source; } }
        internal string Marker { get { return _marker; } }

        private IEnumerable<int> AsEnumerable()
        {
            return _source.IndexesOf(_marker, ignoreCase: false);
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
    }
}
