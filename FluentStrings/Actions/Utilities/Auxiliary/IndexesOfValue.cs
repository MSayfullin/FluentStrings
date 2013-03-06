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

        private IEnumerable<int> AsEnumerable()
        {
            if (_source.IsEmpty() || _marker.IsEmpty())
                yield break;

            var index = _source.IndexOf(_marker);
            while (index >= 0)
            {
                yield return index;
                index = _source.IndexOf(_marker, index + 1);
            }
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
