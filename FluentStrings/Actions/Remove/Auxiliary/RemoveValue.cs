using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveValue : ICaseIgnorable, IPositional
    {
        private readonly string _source;
        private readonly string _extraction;
        private bool _ignoreCase;
        private The _position;

        internal RemoveValue(string source, string extraction)
        {
            _source = source;
            _extraction = extraction;
            _ignoreCase = false;
            _position = The.Beginning;
        }

        public static implicit operator string(RemoveValue removeValue)
        {
            return removeValue.ToString();
        }

        public override string ToString()
        {
            var comparison = _ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture;
            switch (_position)
            {
                case The.Beginning:
                    return _source.Remove(_extraction,
                        (s, e) =>
                        {
                            var index = s.IndexOf(e, comparison);
                            return index >= 0 ? s.Remove(index, e.Length) : s;
                        });
                case The.End:
                    return _source.Remove(_extraction,
                        (s, e) =>
                        {
                            var index = s.LastIndexOf(e, comparison);
                            return index >= 0 ? s.Remove(index, e.Length) : s;
                        });
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().From() method");
            }
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
