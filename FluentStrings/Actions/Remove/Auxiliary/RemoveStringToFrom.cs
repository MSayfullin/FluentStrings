using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringToFrom
    {
        private readonly RemoveStringTo _removeStringTo;
        private readonly The _position;

        internal RemoveStringToFrom(RemoveStringTo removeStringTo, The position)
        {
            _removeStringTo = removeStringTo;
            _position = position;
        }

        public static implicit operator string(RemoveStringToFrom removeStringToFrom)
        {
            return removeStringToFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _removeStringTo;
                case The.End:
                    if (_removeStringTo.PositionIndex < 0)
                    {
                        throw new ArgumentOutOfRangeException("positionIndex", "Negative index is not supported");
                    }

                    if (_removeStringTo.RemoveString.Source.IsEmpty())
                    {
                        return _removeStringTo.RemoveString.Source;
                    }

                    if (_removeStringTo.PositionIndex >= _removeStringTo.RemoveString.Source.Length)
                    {
                        return String.Empty;
                    }
                    return _removeStringTo.RemoveString.Source.Substring(0, _removeStringTo.RemoveString.Source.Length - _removeStringTo.PositionIndex);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().To().From() method");
            }
        }
    }
}
