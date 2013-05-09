using System.Collections;
using System.Collections.Generic;

namespace dokas.FluentStrings.Actions.Utilities
{
    public class IndexesOfValueIgnoringCase : IEnumerable<int>
    {
        private readonly IndexesOfValue _indexesOfValue;

        internal IndexesOfValueIgnoringCase(IndexesOfValue indexesOfValue)
        {
            _indexesOfValue = indexesOfValue;
        }

        internal IndexesOfValue IndexesOfValue { get { return _indexesOfValue; } }

        private IEnumerable<int> AsEnumerable()
        {
            return _indexesOfValue.Source.IndexesOf(_indexesOfValue.Marker, ignoreCase: true);
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
