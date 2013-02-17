using System;

namespace dokas.FluentStrings.Actions.Truncate
{
    public class TruncateStringFrom
    {
        private readonly TruncateString _truncateString;
        private readonly The _position;

        internal TruncateStringFrom(TruncateString truncateString, The position)
        {
            _truncateString = truncateString;
            _position = position;
        }

        public static implicit operator string(TruncateStringFrom truncateStringFrom)
        {
            return truncateStringFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _truncateString;
                case The.End:
                    if (_truncateString.Source != null)
                    {
                        if (_truncateString.Source.Length <= _truncateString.Length)
                            return _truncateString.Source;
                        else
                        {
                            int startingPoint = _truncateString.Source.Length - _truncateString.Length;
                            return _truncateString.Source.Substring(startingPoint);
                        }
                    }
                    return null;
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by TruncateTo().From() method");
            }
        }
    }
}
