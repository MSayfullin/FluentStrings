using System;
using dokas.FluentStrings.Actions.Common;

namespace dokas.FluentStrings.Actions.Truncate
{
    public class TruncateString : IPositional
    {
        private readonly string _source;
        private The _position;

        internal TruncateString(string source, int targetLength)
        {
            _source = source;
            TargetLength = targetLength;
        }

        internal string Source { get { return _source; } }
        internal int TargetLength { get; set; }

        public static implicit operator string(TruncateString truncateString)
        {
            return truncateString.ToString();
        }

        public override string ToString()
        {
            if (_source == null)
                return null;

            if (_source.Length <= TargetLength)
                return _source;

            switch (_position)
            {
                case The.Beginning:
                    return _source.Substring(0, TargetLength);
                case The.End:
                    int startingPoint = _source.Length - TargetLength;
                    return _source.Substring(startingPoint);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by TruncateTo().From() method");
            }
        }

        #region IPositional Members

        void IPositional.Set(The position)
        {
            _position = position;
        }

        #endregion
    }
}
