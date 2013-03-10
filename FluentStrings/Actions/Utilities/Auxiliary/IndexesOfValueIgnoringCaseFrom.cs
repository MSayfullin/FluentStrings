using System;
using System.Collections;
using System.Collections.Generic;

namespace dokas.FluentStrings.Actions.Utilities
{
    public class IndexesOfValueIgnoringCaseFrom : IEnumerable<int>
    {
        private readonly IndexesOfValueIgnoringCase _indexesOfValueIgnoringCase;
        private readonly The _position;

        internal IndexesOfValueIgnoringCaseFrom(IndexesOfValueIgnoringCase indexesOfValue, The position)
        {
            _indexesOfValueIgnoringCase = indexesOfValue;
            _position = position;
        }

        private IEnumerable<int> AsEnumerable()
        {
            return _indexesOfValueIgnoringCase.IndexesOfValue.Source.IndexesOf(
                _indexesOfValueIgnoringCase.IndexesOfValue.Marker, StringComparison.CurrentCultureIgnoreCase, _position);
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
