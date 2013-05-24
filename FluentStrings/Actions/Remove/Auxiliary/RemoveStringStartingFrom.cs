using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStartingFrom
    {
        private readonly RemoveStringStarting _removeStringStarting;
        private readonly The _position;

        internal RemoveStringStartingFrom(RemoveStringStarting removeStringStarting, The position)
        {
            _removeStringStarting = removeStringStarting;
            _position = position;
        }

        internal RemoveStringStarting RemoveStringStarting { get { return _removeStringStarting; } }
        internal The Position { get { return _position; } }

        public static implicit operator string(RemoveStringStartingFrom removeStringStartingFrom)
        {
            return removeStringStartingFrom.ToString();
        }

        public override string ToString()
        {
            switch (_position)
            {
                case The.Beginning:
                    return _removeStringStarting;
                case The.End:
                    if (_removeStringStarting.PositionIndex < 0)
                    {
                        throw new ArgumentOutOfRangeException("positionIndex", "Negative index is not supported");
                    }

                    if (_removeStringStarting.RemoveString.Source.IsEmpty() || _removeStringStarting.PositionIndex >= _removeStringStarting.RemoveString.Source.Length)
                    {
                        return _removeStringStarting.RemoveString.Source;
                    }
                    return _removeStringStarting.RemoveString.Source.Substring(_removeStringStarting.RemoveString.Source.Length - _removeStringStarting.PositionIndex, _removeStringStarting.PositionIndex);
                case The.StartOf:
                case The.EndOf:
                default:
                    throw new ArgumentOutOfRangeException("position", "Only Beginning and End positions are supported by Remove().Starting().From() method");
            }
        }
    }
}
