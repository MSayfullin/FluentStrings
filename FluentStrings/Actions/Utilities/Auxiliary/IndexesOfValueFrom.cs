using System;
using System.Collections;
using System.Collections.Generic;

namespace dokas.FluentStrings.Actions.Utilities
{
    public class IndexesOfValueFrom : IEnumerable<int>
    {
        private readonly IndexesOfValue _indexesOfValue;
        private readonly The _position;

        internal IndexesOfValueFrom(IndexesOfValue indexesOfValue, The position)
        {
            _indexesOfValue = indexesOfValue;
            _position = position;
        }

        private IEnumerable<int> AsEnumerable()
        {
            return _indexesOfValue.Source.IndexesOf(_indexesOfValue.Marker, ignoreCase: false, position: _position);
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
